using Pixel_Editor_Test_2.Commands;
using Pixel_Editor_Test_2.Controls;
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
            OVAL
        }

        public Tool ActiveTool { get; private set; }

        public List<Command> UndoHistory = new List<Command>();
        public List<Command> RedoHistory = new List<Command>();

        public event EventHandler<EyeDropperEventArgs> OnEyedropperChange;

        private int _activeMouseButton = -1;
        public bool KeyShiftDown { get; set; }

        public Color PrimaryColor { get; set; }
        public Color SecondaryColor { get; set; }
        public Color GridColor { get; set; }

        int _zoom = 8;

        public int Zoom
        {
            get { return _zoom; }
            set
            {
                _zoom = Math.Max(Math.Min(value, 32), 2);
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

        public Point TgtMousePos { get; set; }
        public Point HandStartPos { get; set; }
        public Point HandEndPos { get; set; }
        public Point SelectionStartPos { get; set; }
        public Point SelectionEndPos { get; set; }
        public Point ShapeStartPos { get; set; }
        public Point ShapeEndPos { get; set; }

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

        public Bitmap OnionSkin { get; set; } = null;

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

            MouseDown += PixelEditor_MouseDown;
            MouseMove += PixelEditor_MouseMove;
            MouseUp += PixelEditor_MouseUp;
            MouseWheel += PixelEditor_MouseWheel;
            Paint += PixelEditor_Paint;
        }

        private void PixelEditor_Paint(object sender, PaintEventArgs e)
        {
            if (DesignMode) return;

            Graphics g = e.Graphics;
            Bitmap bmp = (Bitmap)APBox.Image;

            int cols = (int)Math.Round((double)ClientSize.Width / Zoom);
            int rows = (int)Math.Round((double)ClientSize.Height / Zoom);

            if (TgtMousePos.X < 0 || TgtMousePos.Y < 0) return;

            for (int x = 0; x < cols; x++)
                for (int y = 0; y < rows; y++)
                {
                    int sx = TgtMousePos.X + Viewport.X + x;
                    int sy = TgtMousePos.Y + Viewport.Y + y;

                    if (sx < 0 || sx > bmp.Width - 1 ||
                        sy < 0 || sy > bmp.Height - 1) continue;

                    Point pC = new Point(sx, sy);

                    Color onion = OnionSkin != null ? OnionSkin.GetPixel(sx, sy) : Color.Transparent;
                    onion = onion.A != 0 ? Color.FromArgb(100, onion.R, onion.G, onion.B) : onion;
                    Color col = bmp.GetPixel(sx, sy);

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
                    using (SolidBrush o = new SolidBrush(onion))
                    using (Pen p = new Pen(drawColor))
                    {
                        Rectangle rect = new Rectangle(x * Zoom,
                                                       y * Zoom,
                                                       Zoom,
                                                       Zoom);
                        g.FillRectangle(b, rect);
                        g.FillRectangle(o, rect);
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

                Rectangle window = new Rectangle(0, 0, Width, Height);

                s.Alignment = PenAlignment.Outset;
                p.Alignment = PenAlignment.Inset;

                g.DrawRectangle(s, rect);
                //g.DrawRectangle(p, window);
                //g.DrawRectangle(p, rect);
            }

            ControlPaint.DrawBorder(g,
                                    ClientRectangle,
                                    Color.Black,
                                    2,
                                    ButtonBorderStyle.Solid,
                                    Color.Black,
                                    2,
                                    ButtonBorderStyle.Solid,
                                    Color.Black,
                                    2,
                                    ButtonBorderStyle.Solid,
                                    Color.Black,
                                    2,
                                    ButtonBorderStyle.Solid);

            PixelEditor_RenderSelectionPreview(e);
            PixelEditor_RenderShapePreview(e);
        }

        private void PixelEditor_MouseDown(object sender, MouseEventArgs e)
        {
            int x = TgtMousePos.X + Viewport.X + e.X / Zoom;
            int y = TgtMousePos.Y + Viewport.Y + e.Y / Zoom;

            Point p = new Point(x, y);

            if (e.Button == MouseButtons.Middle)
                HandStartPos = e.Location;

            if (e.Button == MouseButtons.Left)
                _activeMouseButton = 0;
            else if (e.Button == MouseButtons.Right)
                _activeMouseButton = 1;
            else _activeMouseButton = -1;

            switch (ActiveTool)
            {
                case Tool.PENCIL:
                case Tool.ERASER:
                    PixelEditor_Draw(x, y, e);
                    break;

                case Tool.LINE:
                    ShapeStartPos = p;
                    break;

                case Tool.RECTANGLE:
                case Tool.OVAL:
                    ShapeStartPos = p;
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

            if (e.Button == MouseButtons.Middle)
            {
                HandEndPos = e.Location;

                int diffX = HandStartPos.X - HandEndPos.X;
                int diffY = HandStartPos.Y - HandEndPos.Y;

                Viewport = Point.Add(Viewport, new Size(diffX / 4, diffY / 4));
                HandStartPos = HandEndPos;
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
                case Tool.RECTANGLE:
                case Tool.OVAL:
                    ShapeEndPos = p;
                    if (KeyShiftDown)
                    {
                        float distance = (float)Calc.Distance(ShapeStartPos, p);
                        float distanceX = ShapeStartPos.X > p.X ? -distance : distance;
                        float distanceY = ShapeStartPos.Y > p.Y ? -distance : distance;
                        ShapeEndPos = new Point((int)Math.Round(ShapeStartPos.X + distanceX),
                                                    (int)Math.Round(ShapeStartPos.Y + distanceY));
                    }
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

            _activeMouseButton = -1;

            if (e.Button == MouseButtons.Middle)
                return;

            switch (ActiveTool)
            {
                case Tool.PENCIL:
                case Tool.ERASER:
                    break;

                case Tool.LINE:
                    ShapeEndPos = p;
                    if (KeyShiftDown)
                    {
                        float distance = (float)Calc.Distance(ShapeStartPos, p);
                        float distanceX = ShapeStartPos.X > p.X ? -distance : distance;
                        float distanceY = ShapeStartPos.Y > p.Y ? -distance : distance;
                        ShapeEndPos = new Point((int)Math.Round(ShapeStartPos.X + distanceX),
                                                    (int)Math.Round(ShapeStartPos.Y + distanceY));
                    }

                    DrawLineCommand drawLine = new DrawLineCommand(APBox);
                    drawLine.Execute(
                        (Bitmap)APBox.Image,
                        ShapeStartPos,
                        ShapeEndPos,
                        e.Button == MouseButtons.Left ? PrimaryColor : SecondaryColor
                    );
                    UndoHistory.Add(drawLine);
                    RedoHistory.Clear();

                    ShapeStartPos = Point.Empty;
                    ShapeEndPos = Point.Empty;

                    Invalidate();
                    break;

                case Tool.RECTANGLE:
                    ShapeEndPos = p;
                    if (KeyShiftDown)
                    {
                        float distance = (float)Calc.Distance(ShapeStartPos, p);
                        float distanceX = ShapeStartPos.X > p.X ? -distance : distance;
                        float distanceY = ShapeStartPos.Y > p.Y ? -distance : distance;
                        ShapeEndPos = new Point((int)Math.Round(ShapeStartPos.X + distanceX),
                                                    (int)Math.Round(ShapeStartPos.Y + distanceY));
                    }

                    DrawRectangleCommand drawRect = new DrawRectangleCommand(APBox);
                    drawRect.Execute(
                        (Bitmap)APBox.Image,
                        ShapeStartPos,
                        ShapeEndPos,
                        e.Button == MouseButtons.Left ? PrimaryColor : SecondaryColor,
                        false
                    );
                    UndoHistory.Add(drawRect);
                    RedoHistory.Clear();

                    ShapeStartPos = Point.Empty;
                    ShapeEndPos = Point.Empty;

                    Invalidate();
                    break;

                case Tool.OVAL:
                    ShapeEndPos = p;
                    if (KeyShiftDown)
                    {
                        float distance = (float)Calc.Distance(ShapeStartPos, p);
                        float distanceX = ShapeStartPos.X > p.X ? -distance : distance;
                        float distanceY = ShapeStartPos.Y > p.Y ? -distance : distance;
                        ShapeEndPos = new Point((int)Math.Round(ShapeStartPos.X + distanceX),
                                                    (int)Math.Round(ShapeStartPos.Y + distanceY));
                    }

                    DrawCircleCommand drawCircle = new DrawCircleCommand(APBox);
                    drawCircle.Execute(
                        (Bitmap)APBox.Image,
                        ShapeStartPos,
                        ShapeEndPos,
                        e.Button == MouseButtons.Left ? PrimaryColor : SecondaryColor
                    );
                    UndoHistory.Add(drawCircle);
                    RedoHistory.Clear();

                    ShapeStartPos = Point.Empty;
                    ShapeEndPos = Point.Empty;

                    Invalidate();
                    break;

                case Tool.SELECT:
                    SelectionEndPos = p;
                    Invalidate();
                    break;
            }

            Cursor.Current = Cursors.Default;
        }

        private void PixelEditor_MouseWheel(object sender, MouseEventArgs e)
        {
            /*if (e.Delta > 0)
                PixelEditor_AddToViewport(new Size(0, -1));
            else
                PixelEditor_AddToViewport(new Size(0, 1));*/

            if (e.Delta > 0)
                Zoom++;
            else
                Zoom--;
        }

        public void PixelEditor_KeyDown(KeyEventArgs e)
        {
            PixelEditor_ViewportControl(e);
    
            switch (e.KeyCode)
            {
                case Keys.ShiftKey:
                    KeyShiftDown = true;
                    break;

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

                case Keys.OemMinus:
                    Zoom--;
                    break;

                case Keys.Oemplus:
                    Zoom++;
                    break;
            }
        }

        public void PixelEditor_KeyUp(KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.ShiftKey:
                    KeyShiftDown = false;
                    break;
            }
        }

        private void PixelEditor_Draw(int x, int y, MouseEventArgs e)
        {
            Color drawColor = Color.Magenta;

            if (e.Button == MouseButtons.Middle)
                return;

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

            /*DrawPixelCommand drawPixel = new DrawPixelCommand(APBox);
            drawPixel.Execute(
                (Bitmap)APBox.Image,
                new Point(x, y),
                Point.Empty,
                drawColor
            );
            UndoHistory.Add(drawPixel);
            RedoHistory.Clear();*/

            int _brushSize = 2;

            DrawCircleCommand drawPixel = new DrawCircleCommand(APBox);
            drawPixel.Execute(
                (Bitmap)APBox.Image,
                new Point(x - _brushSize, y - _brushSize),
                new Point(x, y),
                drawColor
            );

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
            MouseButtons mouseButton = _activeMouseButton == 0 ? MouseButtons.Left : MouseButtons.Right;

            EventHandler<EyeDropperEventArgs> handler = OnEyedropperChange;
            handler?.Invoke(this, new EyeDropperEventArgs(bmp.GetPixel(x,y), mouseButton));
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
                    Viewport = Point.Add(Viewport, new Size(0, -1));
                    break;

                case Keys.Down:
                    Viewport = Point.Add(Viewport, new Size(0, 1));
                    break;
            }
        }

        public void PixelEditor_AddToViewport(Size direction)
        {
            Viewport = Point.Add(Viewport, direction);
        }

        public void PixelEditor_SetTool(Tool tool)
        {
            if (ActiveTool == tool)
                return;

            ActiveTool = tool;
        }

        private void PixelEditor_RenderSelectionPreview(PaintEventArgs e)
        {
            Point startPos = SelectionStartPos;
            Point endPos = SelectionEndPos;

            int width = Math.Abs(startPos.X - endPos.X);
            int height = Math.Abs(startPos.Y - endPos.Y);

            if (width > 0 && height > 0)
            {
                Rectangle rect = new Rectangle((int)Math.Round((double)Math.Min(startPos.X, endPos.X) * Zoom - (Viewport.X * Zoom)),
                                               (int)Math.Round((double)Math.Min(startPos.Y, endPos.Y) * Zoom - (Viewport.Y * Zoom)),
                                               (int)Math.Round((double)width * Zoom),
                                               (int)Math.Round((double)height * Zoom));

                using (Pen pen = new Pen(Color.DimGray, 1F))
                {
                    e.Graphics.DrawRectangle(pen, rect);
                }
                using (Pen pen = new Pen(Color.White, 1F))
                {
                    pen.DashPattern = new float[] { 5, 5 };
                    e.Graphics.DrawRectangle(pen, rect);
                }
            }
        }

        private void PixelEditor_RenderShapePreview(PaintEventArgs e)
        {
            List<Point> pixels = new List<Point>();

            switch (ActiveTool)
            {
                case Tool.LINE:
                    pixels.AddRange(Bresenham.Line(ShapeStartPos, ShapeEndPos));
                    break;

                case Tool.RECTANGLE:
                    pixels.AddRange(Bresenham.Rectangle(ShapeStartPos, ShapeEndPos));
                    break;

                case Tool.OVAL:
                    pixels.AddRange(Bresenham.Ellipse(ShapeStartPos, ShapeEndPos));
                    break;

                default:
                    break;
            }

            Color drawColor = Color.Transparent;

            if (_activeMouseButton == 0)
                drawColor = PrimaryColor;
            else if (_activeMouseButton == 1)
                drawColor = SecondaryColor;

            foreach (Point pixel in pixels)
            {
                using (SolidBrush b = new SolidBrush(drawColor))
                {
                    Rectangle rect = new Rectangle(pixel.X * Zoom - (Viewport.X * Zoom),
                                                   pixel.Y * Zoom - (Viewport.Y * Zoom),
                                                   Zoom,
                                                   Zoom);
                    e.Graphics.FillRectangle(b, rect);
                }
            }
        }

        private void ResetAllPoints()
        {
            ShapeStartPos = ShapeEndPos = Point.Empty;
            ShapeStartPos = ShapeEndPos = Point.Empty;
            SelectionStartPos = SelectionEndPos = Point.Empty;
        }
    }
}
