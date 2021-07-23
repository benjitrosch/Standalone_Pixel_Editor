using Pixel_Editor_Test_2.Commands;
using Pixel_Editor_Test_2.Systems;
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

            switch (Session.Instance.ActiveTool)
            {
                case Tool.PENCIL:
                    if (e.Button == MouseButtons.Left)
                        drawColor = Session.Instance.PrimaryColor;

                    if (e.Button == MouseButtons.Right)
                        drawColor = Session.Instance.SecondaryColor;
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
                new Point(x - Session.Instance.BrushSize, y - Session.Instance.BrushSize),
                new Point(x, y),
                drawColor,
                true
            );
            UndoHistory.Add(drawPixel);
            RedoHistory.Clear();

            Invalidate();
        }

        private void PixelEditor_DrawShape<T>(Point startPos, Point endPos, T command, MouseEventArgs e) where T : Command
        {
            command.Execute(
                (Bitmap)APBox.Image,
                startPos,
                endPos,
                e.Button == MouseButtons.Left ? Session.Instance.PrimaryColor : Session.Instance.SecondaryColor
            );
            UndoHistory.Add(command);
            RedoHistory.Clear();

            ShapeStartPos = Point.Empty;
            ShapeEndPos = Point.Empty;

            Invalidate();
        }

        private void PixelEditor_Fill(int x, int y, MouseEventArgs e)
        {
            FillCommand fill = new FillCommand(APBox);
            fill.Execute(
                (Bitmap)APBox.Image,
                new Point(x, y),
                Point.Empty,
                e.Button == MouseButtons.Left ? Session.Instance.PrimaryColor : Session.Instance.SecondaryColor
            );
            UndoHistory.Add(fill);
            RedoHistory.Clear();

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