using Pixel_Editor_Test_2.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pixel_Editor_Test_2
{
    public partial class PixelEditor : Panel
    {
        public enum Tool
        {
            PENCIL,
            FILL,
            ERASER,
            SELECT,
            HAND,
            EYEDROPPER,
        }

        public Tool ActiveTool { get; private set; }

        public List<ICommand> UndoHistory = new List<ICommand>();
        public List<ICommand> RedoHistory = new List<ICommand>();

        public event EventHandler<Color> OnEyedropperChange;

        public Color PrimaryColor { get; set; }
        public Color SecondaryColor { get; set; }
        public Color GridColor { get; set; }

        int _zoom = 8;

        public int Zoom
        {
            get { return _zoom; }
            set
            {
                _zoom = value;
                Invalidate();
            }
        }

        private Point _viewport = new Point(0, 0);
        public Point Viewport
        {
            get { return _viewport; }
            set
            {
                _viewport = value;
                Invalidate();
            }
        }

        public Bitmap TgtBitmap { get; set; }
        public Point TgtMousePos { get; set; }
        public Point SelectionStartPos { get; set; }
        public Point SelectionEndPos { get; set; }

        Point lastPoint = Point.Empty;

        PictureBox aPBox = null;
        public PictureBox APBox
        {
            get { return aPBox; }
            set
            {
                if (value == null) return;
                aPBox = value;
                aPBox.MouseClick -= APBox_MouseClick;
                aPBox.MouseClick += APBox_MouseClick;
            }
        }

        Label coordinates = null, selection = null;

        public Label Coordinates
        {
            get { return coordinates; }
            set
            {
                if (value == null) return;
                coordinates = value;
            }
        }
        public Label Selection
        {
            get { return selection; }
            set
            {
                if (value == null) return;
                selection = value;
            }
        }

        private void APBox_MouseClick(object sender, MouseEventArgs e)
        {
            TgtMousePos = e.Location;
            Invalidate();
        }

        public PixelEditor()
        {
            DoubleBuffered = true;
            BackColor = Color.White;
            GridColor = Color.Transparent;
            PrimaryColor = Color.Black;
            SecondaryColor = Color.White;
            Zoom = 8;
            TgtMousePos = Point.Empty;

            if (APBox != null && APBox.Image != null)
                TgtBitmap = (Bitmap)APBox.Image;

            MouseDown += PixelEditor_MouseDown;
            MouseMove += PixelEditor_MouseMove;
            MouseUp += PixelEditor_MouseUp;
            Paint += PixelEditor_Paint;
        }

        private void PixelEditor_Paint(object sender, PaintEventArgs e)
        {
            if (DesignMode) return;

            Graphics g = e.Graphics;

            int cols = ClientSize.Width / Zoom;
            int rows = ClientSize.Height / Zoom;

            if (TgtMousePos.X < 0 || TgtMousePos.Y < 0) return;

            for (int x = 0; x < cols; x++)
                for (int y = 0; y < rows; y++)
                {
                    int sx = TgtMousePos.X + Viewport.X + x;
                    int sy = TgtMousePos.Y + Viewport.Y + y;

                    if (sx < 0 || sx > TgtBitmap.Width - 1 ||
                        sy < 0 || sy > TgtBitmap.Height - 1) continue;

                    Color col = TgtBitmap.GetPixel(sx, sy);

                    using (SolidBrush b = new SolidBrush(col))
                    using (Pen p = new Pen(GridColor))
                    {
                        Rectangle rect = new Rectangle(x * Zoom, y * Zoom,
                                                           Zoom, Zoom);
                        g.FillRectangle(b, rect);
                        g.DrawRectangle(p, rect);
                    }
                }

            int width = Math.Abs(SelectionStartPos.X - SelectionEndPos.X);
            int height = Math.Abs(SelectionStartPos.Y - SelectionEndPos.Y);

            if (width > 0 && height > 0)
            {
                using (Pen pen = new Pen(Color.DimGray, 1F))
                {
                    e.Graphics.DrawRectangle(pen, new Rectangle(
                        (int)Math.Round((double)SelectionStartPos.X),
                        (int)Math.Round((double)SelectionStartPos.Y),
                        (int)Math.Round((double)width),
                        (int)Math.Round((double)height)
                    ));
                }
                using (Pen pen = new Pen(Color.White, 1F))
                {
                    pen.DashPattern = new float[] { 5, 5 };
                    e.Graphics.DrawRectangle(pen, new Rectangle(
                        (int)Math.Round((double)SelectionStartPos.X),
                        (int)Math.Round((double)SelectionStartPos.Y),
                        (int)Math.Round((double)width),
                        (int)Math.Round((double)height)
                    ));
                }
            }
        }

        private void PixelEditor_MouseDown(object sender, MouseEventArgs e)
        {
            switch (ActiveTool)
            {
                case Tool.PENCIL:
                case Tool.ERASER:
                    PixelEditor_Draw(e);
                    break;

                case Tool.HAND:
                case Tool.SELECT:
                    SelectionStartPos = e.Location;
                    break;

                case Tool.FILL:
                    PixelEditor_Fill(e);
                    break;

                case Tool.EYEDROPPER:
                    int eyeX = TgtMousePos.X + Viewport.X + e.X / Zoom;
                    int eyeY = TgtMousePos.Y + Viewport.Y + e.Y / Zoom;

                    GetColorAt(eyeX, eyeY);
                    break;
            }

            Cursor.Current = Cursors.Cross;
        }

        private void PixelEditor_MouseMove(object sender, MouseEventArgs e)
        {
            int x = TgtMousePos.X + Viewport.X + e.X / Zoom;
            int y = TgtMousePos.Y + Viewport.Y + e.Y / Zoom;

            int width = Math.Abs(SelectionStartPos.X - SelectionEndPos.X);
            int height = Math.Abs(SelectionStartPos.Y - SelectionEndPos.Y);

            if (Coordinates != null && Selection != null)
            {
                Coordinates.Text = $"X: {x} Y: {y}";
                Selection.Text = $"W: {width} H: {Math.Abs(height)}";
            }

            if (e.Button != MouseButtons.Left && e.Button != MouseButtons.Right) return;

            switch (ActiveTool)
            {
                case Tool.PENCIL:
                case Tool.ERASER:
                    if (new Point(x, y) == lastPoint) return;
                    PixelEditor_Draw(e);
                    lastPoint = new Point(x, y);
                    break;

                case Tool.SELECT:
                    SelectionEndPos = e.Location;
                    Invalidate();
                    break;

                case Tool.HAND:
                    SelectionEndPos = e.Location;

                    int diffX = SelectionStartPos.X - SelectionEndPos.X;
                    int diffY = SelectionStartPos.Y - SelectionEndPos.Y;

                    Viewport = Point.Add(Viewport, new Size(diffX / 4, diffY / 4));
                    SelectionStartPos = SelectionEndPos;
                    break;

                case Tool.EYEDROPPER:
                    GetColorAt(x, y);
                    break;
            }
        }

        private void PixelEditor_MouseUp(object sender, MouseEventArgs e)
        {
            switch (ActiveTool)
            {
                case Tool.PENCIL:
                case Tool.ERASER:
                    break;

                case Tool.SELECT:
                    SelectionEndPos = e.Location;
                    Invalidate();
                    break;
            }

            Cursor.Current = Cursors.Default;
        }

        public void PixelEditor_KeyDown(KeyEventArgs e)
        {
            PixelEditor_ViewportControl(e);

            switch (e.KeyCode)
            {
                case Keys.Z:
                    if (e.Control && UndoHistory.Count > 0)
                    {
                        ICommand lastCommand = UndoHistory[UndoHistory.Count - 1];

                        lastCommand.Undo((Bitmap)APBox.Image);
                        UndoHistory.Remove(lastCommand);
                        RedoHistory.Add(lastCommand);

                        Invalidate();
                    }
                    break;

                case Keys.Y:
                    if (e.Control && RedoHistory.Count > 0)
                    {
                        ICommand lastCommand = RedoHistory[RedoHistory.Count - 1];

                        lastCommand.Redo((Bitmap)APBox.Image);
                        RedoHistory.Remove(lastCommand);
                        UndoHistory.Add(lastCommand);

                        Invalidate();
                    }
                    break;

                case Keys.R:
                    if (e.Control)
                        PixelEditor_ReplaceColor(PrimaryColor, SecondaryColor);
                    break;

                case Keys.Escape:
                    SelectionStartPos = Point.Empty;
                    SelectionEndPos = Point.Empty;
                    break;

                case Keys.Delete:
                case Keys.Back:
                    int width = Math.Abs(SelectionStartPos.X - SelectionEndPos.X);
                    int height = Math.Abs(SelectionStartPos.Y - SelectionEndPos.Y);

                    if ((width < 1) || (height < 1)) return;

                    int startX = SelectionStartPos.X / Zoom;
                    int startY = SelectionStartPos.Y / Zoom;

                    int endX = SelectionEndPos.X / Zoom;
                    int endY = SelectionEndPos.Y / Zoom;

                    SelectAreaCommand deleteArea = new SelectAreaCommand(APBox);
                    deleteArea.Execute(
                        (Bitmap)APBox.Image,
                        new Point(startX, startY),
                        new Point(endX, endY),
                        Color.Transparent
                    );
                    UndoHistory.Add(deleteArea);
                    RedoHistory.Clear();

                    Invalidate();
                    break;
            }
        }

        private void PixelEditor_Draw(MouseEventArgs e)
        {
            Color drawColor = Color.Magenta;

            switch(ActiveTool)
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
                    throw new InvalidEnumArgumentException("No tool selected... what are you drawing with???");
            }

            int x = TgtMousePos.X + Viewport.X + e.X / Zoom;
            int y = TgtMousePos.Y + Viewport.Y + e.Y / Zoom;

            DrawPixelCommand drawPixel = new DrawPixelCommand(APBox);
            drawPixel.Execute(
                (Bitmap)APBox.Image,
                new Point(x, y),
                drawColor
            );
            UndoHistory.Add(drawPixel);
            RedoHistory.Clear();

            Invalidate();
        }

        private void PixelEditor_Fill(MouseEventArgs e)
        {
            // TODO: Refactor this into a Command so we can UNDO / REDO
            Color drawColor = Color.Magenta;

            if (e.Button == MouseButtons.Left)
                drawColor = PrimaryColor;

            if (e.Button == MouseButtons.Right)
                drawColor = SecondaryColor;

            int x = TgtMousePos.X + e.X / Zoom;
            int y = TgtMousePos.Y + e.Y / Zoom;

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

        protected virtual void GetColorAt(int x, int y)
        {
            Bitmap bmp = (Bitmap)APBox.Image;

            EventHandler<Color> handler = OnEyedropperChange;
            handler?.Invoke(this, bmp.GetPixel(x,y));
        }

        private void PixelEditor_ViewportControl(KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Left:
                    Viewport = Point.Add(Viewport, new Size(-1, 0));
                    break;

                case Keys.Right:
                    Viewport = Point.Add(Viewport, new Size(1, 0));
                    break;

                case Keys.Up:
                    Viewport = Point.Add(Viewport, new Size(0, 1));
                    break;

                case Keys.Down:
                    Viewport = Point.Add(Viewport, new Size(0, -1));
                    break;
            }
        }

        public void PixelEditor_SetTool(Tool tool)
        {
            if (ActiveTool == tool)
                return;

            ActiveTool = tool;
        }
    }
}
