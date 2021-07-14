using Pixel_Editor_Test_2.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pixel_Editor_Test_2.Controls.PixelEditor
{
    public partial class PixelEditor
    {
        private void PixelEditor_Draw(int x, int y, MouseEventArgs e)
        {
            Color drawColor = Color.Magenta;

            if (e.Button == MouseButtons.Middle)
                return;

            switch (ActiveTool)
            {
                case Tool.PENCIL:
                    if (e.Button == MouseButtons.Left)
                        drawColor = PrimaryColor;

                    if (e.Button == MouseButtons.Right)
                        drawColor = SecondaryColor;
                    break;

                case Tool.ERASER:
                    drawColor = Color.Transparent;
                    break;

                default:
                    throw new InvalidEnumArgumentException("No tool selected.");
            }

            DrawCircleCommand drawPixel = new DrawCircleCommand(APBox);
            drawPixel.Execute(
                (Bitmap)APBox.Image,
                new Point(x - BrushSize, y - BrushSize),
                new Point(x, y),
                drawColor
            );

            Invalidate();
        }

        private void PixelEditor_DrawShape<T>(Point startPos, Point endPos, T command, MouseEventArgs e) where T : Command
        {
            command.Execute(
                (Bitmap)APBox.Image,
                startPos,
                endPos,
                e.Button == MouseButtons.Left ? PrimaryColor : SecondaryColor
            );
            UndoHistory.Add(command);
            RedoHistory.Clear();

            ShapeStartPos = Point.Empty;
            ShapeEndPos = Point.Empty;

            Invalidate();
        }

        private void PixelEditor_Fill(int x, int y, MouseEventArgs e)
        {
            // TODO: Refactor this into a Command so we can UNDO / REDO
            Color drawColor = Color.Magenta;

            if (e.Button == MouseButtons.Left)
                drawColor = PrimaryColor;

            if (e.Button == MouseButtons.Right)
                drawColor = SecondaryColor;

            Bitmap bmp = (Bitmap)APBox.Image;
            BitmapData data = bmp.LockBits(
            new Rectangle(0, 0, bmp.Width, bmp.Height),
            ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            int[] bits = new int[data.Stride / 4 * data.Height];
            Marshal.Copy(data.Scan0, bits, 0, bits.Length);

            LinkedList<Point> check = new LinkedList<Point>();
            int floodTo = drawColor.ToArgb();
            int floodFrom = bits[x + y * data.Stride / 4];
            bits[x + y * data.Stride / 4] = floodTo;

            if (floodFrom != floodTo)
            {
                check.AddLast(new Point(x, y));
                while (check.Count > 0)
                {
                    Point cur = check.First.Value;
                    check.RemoveFirst();

                    foreach (Point off in new Point[] {
                new Point(0, -1), new Point(0, 1),
                new Point(-1, 0), new Point(1, 0)})
                    {
                        Point next = new Point(cur.X + off.X, cur.Y + off.Y);
                        if (next.X >= 0 && next.Y >= 0 &&
                            next.X < data.Width &&
                            next.Y < data.Height)
                        {
                            if (bits[next.X + next.Y * data.Stride / 4] == floodFrom)
                            {
                                check.AddLast(next);
                                bits[next.X + next.Y * data.Stride / 4] = floodTo;
                            }
                        }
                    }
                }
            }

            Marshal.Copy(bits, 0, data.Scan0, bits.Length);
            bmp.UnlockBits(data);

            Invalidate();
        }

        private void PixelEditor_ReplaceColor(Color oldColor, Color newColor)
        {
            ReplaceColorCommand replaceColor = new ReplaceColorCommand(APBox);
            replaceColor.Execute(
                (Bitmap)APBox.Image,
                oldColor,
                newColor
            );
            UndoHistory.Add(replaceColor);
            RedoHistory.Clear();

            Invalidate();
        }
    }
}
