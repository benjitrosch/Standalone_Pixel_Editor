using Pixel_Editor_Test_2.Commands;
using Pixel_Editor_Test_2.Util;
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
            LINE,
            RECTANGLE,
        }

        public Tool ActiveTool { get; private set; }

        public List<Command> UndoHistory = new List<Command>();
        public List<Command> RedoHistory = new List<Command>();

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
        public Point LineStartPos { get; set; }
        public Point LineEndPos { get; set; }
        public Point HandStartPos { get; set; }
        public Point HandEndPos { get; set; }
        public Point SelectionStartPos { get; set; }
        public Point SelectionEndPos { get; set; }
        public Point RectangleStartPos { get; set; }
        public Point RectangleEndPos { get; set; }

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

        private Point _coordinates;

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

            int cols = (int)Math.Floor((double)ClientSize.Width / Zoom);
            int rows = (int)Math.Floor((double)ClientSize.Height / Zoom);

            if (TgtMousePos.X < 0 || TgtMousePos.Y < 0) return;

            for (int x = 0; x < cols; x++)
                for (int y = 0; y < rows; y++)
                {
                    int sx = TgtMousePos.X + Viewport.X + x;
                    int sy = TgtMousePos.Y + Viewport.Y + y;

                    if (sx < 0 || sx > TgtBitmap.Width - 1 ||
                        sy < 0 || sy > TgtBitmap.Height - 1) continue;

                    Point pC = new Point(sx, sy);
                    Color col = TgtBitmap.GetPixel(sx, sy);
                    Color drawColor = GridColor;

                    if (col.ToArgb() == 0 || col.ToArgb() == 16777215)
                    {
                        if (x % 2 == 1)
                            col = y % 2 == 1 ? Color.FromArgb(127, 127, 127) : Color.FromArgb(190, 190, 190);
                        else
                            col = y % 2 == 1 ? Color.FromArgb(190, 190, 190) : Color.FromArgb(127, 127, 127);
                    }

                    if (pC == _coordinates || pC == SelectionStartPos)
                        drawColor = Color.White;

                    using (SolidBrush b = new SolidBrush(col))
                    using (Pen p = new Pen(drawColor))
                    {
                        Rectangle rect = new Rectangle(x * Zoom,
                                                       y * Zoom,
                                                       Zoom,
                                                       Zoom);
                        g.FillRectangle(b, rect);
                        g.DrawRectangle(p, rect);
                    }
                }

            using (Pen s = new Pen(Color.Black, 2))
            using (Pen p = new Pen(Color.FromArgb(0, 126, 249), 2))
            {
                Rectangle rect = new Rectangle(0 - (Viewport.X * Zoom),
                                               0 - (Viewport.Y * Zoom),
                                               APBox.Image.Width * Zoom,
                                               APBox.Image.Height * Zoom);

                s.Alignment = PenAlignment.Outset;
                p.Alignment = PenAlignment.Inset;

                g.DrawRectangle(s, rect);
                //g.DrawRectangle(p, rect);
            }

            PixelEditor_RenderSelectionPreview(e);
            PixelEditor_RenderLinePreview(e);
        }

        private void PixelEditor_MouseDown(object sender, MouseEventArgs e)
        {
            int x = TgtMousePos.X + Viewport.X + e.X / Zoom;
            int y = TgtMousePos.Y + Viewport.Y + e.Y / Zoom;

            Point p = new Point(x, y);

            switch (ActiveTool)
            {
                case Tool.PENCIL:
                case Tool.ERASER:
                    PixelEditor_Draw(x, y, e);
                    break;

                case Tool.LINE:
                    LineStartPos = p;
                    break;

                case Tool.RECTANGLE:
                    RectangleStartPos = p;
                    break;

                case Tool.HAND:
                    HandStartPos = e.Location;
                    break;

                case Tool.SELECT:
                    SelectionStartPos = p;
                    break;

                case Tool.FILL:
                    PixelEditor_Fill(x, y, e);
                    break;

                case Tool.EYEDROPPER:
                    GetColorAt(x, y);
                    break;
            }

            Cursor.Current = Cursors.Cross;
        }

        private void PixelEditor_MouseMove(object sender, MouseEventArgs e)
        {
            int x = TgtMousePos.X + Viewport.X + e.X / Zoom;
            int y = TgtMousePos.Y + Viewport.Y + e.Y / Zoom;

            Point p = new Point(x, y);

            _coordinates = p;
            Invalidate();

            int width = Math.Abs(SelectionStartPos.X - SelectionEndPos.X);
            int height = Math.Abs(SelectionStartPos.Y - SelectionEndPos.Y);

            if (Coordinates != null && Selection != null)
            {
                Coordinates.Text = $"X: {_coordinates.X} Y: {_coordinates.Y}";
                Selection.Text = $"W: {width} H: {Math.Abs(height)}";
            }

            if (e.Button != MouseButtons.Left && e.Button != MouseButtons.Right) return;

            switch (ActiveTool)
            {
                case Tool.PENCIL:
                case Tool.ERASER:
                    if (p == lastPoint) return;
                    PixelEditor_Draw(x, y, e);
                    lastPoint = p;
                    break;

                case Tool.LINE:
                    LineEndPos = p;
                    break;

                case Tool.RECTANGLE:
                    RectangleEndPos = p;
                    break;

                case Tool.SELECT:
                    SelectionEndPos = p;
                    break;

                case Tool.HAND:
                    HandEndPos = e.Location;

                    int diffX = HandStartPos.X - HandEndPos.X;
                    int diffY = HandStartPos.Y - HandEndPos.Y;

                    Viewport = Point.Add(Viewport, new Size(diffX / 4, diffY / 4));
                    HandStartPos = HandEndPos;
                    break;

                case Tool.EYEDROPPER:
                    GetColorAt(x, y);
                    break;
            }

            Invalidate();
        }

        private void PixelEditor_MouseUp(object sender, MouseEventArgs e)
        {
            int x = TgtMousePos.X + Viewport.X + e.X / Zoom;
            int y = TgtMousePos.Y + Viewport.Y + e.Y / Zoom;

            Point p = new Point(x, y);

            switch (ActiveTool)
            {
                case Tool.PENCIL:
                case Tool.ERASER:
                    break;

                case Tool.LINE:
                    LineEndPos = p;

                    DrawLineCommand drawLine = new DrawLineCommand(APBox);
                    drawLine.Execute(
                        (Bitmap)APBox.Image,
                        LineStartPos,
                        LineEndPos,
                        e.Button == MouseButtons.Left ? PrimaryColor : SecondaryColor
                    );
                    UndoHistory.Add(drawLine);
                    RedoHistory.Clear();

                    LineStartPos = Point.Empty;
                    LineEndPos = Point.Empty;

                    Invalidate();
                    break;

                case Tool.RECTANGLE:
                    RectangleEndPos = p;

                    DrawRectangleCommand drawRect = new DrawRectangleCommand(APBox);
                    drawRect.Execute(
                        (Bitmap)APBox.Image,
                        RectangleStartPos,
                        RectangleEndPos,
                        e.Button == MouseButtons.Left ? PrimaryColor : SecondaryColor,
                        false
                    );
                    UndoHistory.Add(drawRect);
                    RedoHistory.Clear();

                    RectangleStartPos = Point.Empty;
                    RectangleEndPos = Point.Empty;

                    Invalidate();
                    break;

                case Tool.SELECT:
                    SelectionEndPos = p;
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
                        Command lastCommand = UndoHistory[UndoHistory.Count - 1];

                        lastCommand.Undo((Bitmap)APBox.Image);
                        UndoHistory.Remove(lastCommand);
                        RedoHistory.Add(lastCommand);

                        Invalidate();
                    }
                    break;

                case Keys.Y:
                    if (e.Control && RedoHistory.Count > 0)
                    {
                        Command lastCommand = RedoHistory[RedoHistory.Count - 1];

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

                    int startX = SelectionStartPos.X;
                    int startY = SelectionStartPos.Y;

                    int endX = SelectionEndPos.X;
                    int endY = SelectionEndPos.Y;

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

        private void PixelEditor_Draw(int x, int y, MouseEventArgs e)
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

            DrawPixelCommand drawPixel = new DrawPixelCommand(APBox);
            drawPixel.Execute(
                (Bitmap)APBox.Image,
                new Point(x, y),
                Point.Empty,
                drawColor
            );
            UndoHistory.Add(drawPixel);
            RedoHistory.Clear();

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

        private void PixelEditor_RenderSelectionPreview(PaintEventArgs e)
        {
            int width = Math.Abs(SelectionStartPos.X - SelectionEndPos.X);
            int height = Math.Abs(SelectionStartPos.Y - SelectionEndPos.Y);

            if (width > 0 && height > 0)
            {
                using (Pen pen = new Pen(Color.DimGray, 1F))
                {
                    e.Graphics.DrawRectangle(pen, new Rectangle(
                        (int)Math.Round((double)Math.Min(SelectionStartPos.X, SelectionEndPos.X) * Zoom - (Viewport.X * Zoom)),
                        (int)Math.Round((double)Math.Min(SelectionStartPos.Y, SelectionEndPos.Y) * Zoom - (Viewport.Y * Zoom)),
                        (int)Math.Round((double)width * Zoom),
                        (int)Math.Round((double)height * Zoom)
                    ));
                }
                using (Pen pen = new Pen(Color.White, 1F))
                {
                    pen.DashPattern = new float[] { 5, 5 };
                    e.Graphics.DrawRectangle(pen, new Rectangle(
                        (int)Math.Round((double)Math.Min(SelectionStartPos.X, SelectionEndPos.X) * Zoom - (Viewport.X * Zoom)),
                        (int)Math.Round((double)Math.Min(SelectionStartPos.Y, SelectionEndPos.Y) * Zoom - (Viewport.Y * Zoom)),
                        (int)Math.Round((double)width * Zoom),
                        (int)Math.Round((double)height * Zoom)
                    ));
                }
            }
        }

        private void PixelEditor_RenderLinePreview(PaintEventArgs e)
        {
            if (LineStartPos == Point.Empty || LineEndPos == Point.Empty)
                return;

            List<Point> pixels = BresenhamLine.Line(LineStartPos, LineEndPos);

            foreach (Point pixel in pixels)
            {
                using (Pen pen = new Pen(Color.White, 1F))
                {
                    e.Graphics.DrawRectangle(pen,
                                             new Rectangle(pixel.X * Zoom - (Viewport.X * Zoom),
                                                           pixel.Y * Zoom - (Viewport.Y * Zoom),
                                                           Zoom,
                                                           Zoom));
                }
            }
        }
    }
}
