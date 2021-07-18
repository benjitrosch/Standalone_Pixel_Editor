using Pixel_Editor_Test_2.Commands;
using Pixel_Editor_Test_2.Controls;
using Pixel_Editor_Test_2.Systems;
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

namespace Pixel_Editor_Test_2.Controls.PixelEditor
{
    public partial class PixelEditor : Panel
    {
        public enum Tool
        {
            PENCIL,
            FILL,
            ERASER,
            SELECT,
            MAGICWAND,
            HAND,
            EYEDROPPER,
            LINE,
            RECTANGLE,
            OVAL
        }

        public List<Command> UndoHistory = new List<Command>();
        public List<Command> RedoHistory = new List<Command>();
        public event EventHandler OnHistoryChange;

        public event EventHandler<EyeDropperEventArgs> OnEyedropperChange;

        private int _activeMouseButton = -1;
        public bool KeyShiftDown { get; set; }

        private int _zoom = 8;
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

        private Bitmap _activeLayer;
        public Bitmap ActiveLayer
        {
            get
            {
                return _activeLayer;
            }
            set
            {
                _activeLayer = value;
            }
        }
        public List<Bitmap> Layers { get; set; }
        public Bitmap OnionSkin { get; set; } = null;

        public PixelEditor()
        {
            DoubleBuffered = true;

            Zoom = 8;
            TgtMousePos = Point.Empty;

            MouseClick += PixelEditor_MouseClick;
            MouseDown += PixelEditor_MouseDown;
            MouseMove += PixelEditor_MouseMove;
            MouseUp += PixelEditor_MouseUp;
            MouseWheel += PixelEditor_MouseWheel;
            Paint += PixelEditor_Paint;

            Session.Instance.OnActiveLayerChange += (_o, l) => _activeLayer = Layers[l];
        }

        private void PixelEditor_Paint(object sender, PaintEventArgs e)
        {
            if (DesignMode) return;

            Graphics g = e.Graphics;
            Bitmap bmp = _activeLayer;

            int cols = (int)Math.Round((double)ClientSize.Width / Zoom);
            int rows = (int)Math.Round((double)ClientSize.Height / Zoom);

            if (_activeLayer == null || TgtMousePos.X < 0 || TgtMousePos.Y < 0) return;

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

                    if (col.ToArgb() == 0 || col.ToArgb() == 16777215)
                    {
                        if (x % 2 == 1)
                            col = y % 2 == 1 ? Color.FromArgb(127, 127, 127) : Color.FromArgb(190, 190, 190);
                        else
                            col = y % 2 == 1 ? Color.FromArgb(190, 190, 190) : Color.FromArgb(127, 127, 127);
                    }

                    using (SolidBrush b = new SolidBrush(col))
                    using (SolidBrush o = new SolidBrush(onion))
                    {
                        Rectangle rect = new Rectangle(x * Zoom,
                                                       y * Zoom,
                                                       Zoom,
                                                       Zoom);
                        g.FillRectangle(b, rect);
                        g.FillRectangle(o, rect);
                    }
                }

            using (Pen s = new Pen(Color.Black, 2))
            {
                Rectangle rect = new Rectangle(0 - (Viewport.X * Zoom),
                                               0 - (Viewport.Y * Zoom),
                                               _activeLayer.Width * Zoom,
                                               _activeLayer.Height * Zoom);


                s.Alignment = PenAlignment.Outset;
                g.DrawRectangle(s, rect);
            }

            ControlPaint.DrawBorder(g,
                                    ClientRectangle,
                                    Color.Black,
                                    1,
                                    ButtonBorderStyle.Solid,
                                    Color.Black,
                                    1,
                                    ButtonBorderStyle.Solid,
                                    Color.Black,
                                    1,
                                    ButtonBorderStyle.Solid,
                                    Color.Black,
                                    1,
                                    ButtonBorderStyle.Solid);

            PixelEditor_RenderSelectionPreview(e);
            PixelEditor_RenderShapePreview(e);
        }

        protected virtual void GetColorAt(int x, int y)
        {
            Bitmap bmp = _activeLayer;
            MouseButtons mouseButton = _activeMouseButton == 0 ? MouseButtons.Left : MouseButtons.Right;

            EventHandler<EyeDropperEventArgs> handler = OnEyedropperChange;
            handler?.Invoke(this, new EyeDropperEventArgs(bmp.GetPixel(x,y), mouseButton));
        }

        private void PixelEditor_Undo()
        {
            if (UndoHistory.Count < 1)
                return;
            
            Command lastCommand = UndoHistory[UndoHistory.Count - 1];

            lastCommand.Undo(_activeLayer);
            UndoHistory.Remove(lastCommand);
            RedoHistory.Add(lastCommand);

            OnHistoryChange?.Invoke(this, null);
            Invalidate();
        }

        private void PixelEditor_Redo()
        {
            if (RedoHistory.Count < 1)
                return;

            Command lastCommand = RedoHistory[RedoHistory.Count - 1];

            lastCommand.Redo(_activeLayer);
            RedoHistory.Remove(lastCommand);
            UndoHistory.Add(lastCommand);

            OnHistoryChange?.Invoke(this, null);
            Invalidate();
        }

        public void PixelEditor_AddToViewport(Size direction)
        {
            Viewport = Point.Add(Viewport, direction);
        }

        private void PixelEditor_ViewportControl(KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Left:
                    PixelEditor_AddToViewport(new Size(-1, 0));
                    break;

                case Keys.Right:
                    PixelEditor_AddToViewport(new Size(1, 0));
                    break;

                case Keys.Up:
                    PixelEditor_AddToViewport(new Size(0, -1));
                    break;

                case Keys.Down:
                    PixelEditor_AddToViewport(new Size(0, 1));
                    break;
            }
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

            switch (Session.Instance.ActiveTool)
            {
                case Tool.LINE:
                    pixels.AddRange(Shapes.Line(ShapeStartPos, ShapeEndPos));
                    break;

                case Tool.RECTANGLE:
                    pixels.AddRange(Shapes.Rectangle(ShapeStartPos, ShapeEndPos));
                    break;

                case Tool.OVAL:
                    pixels.AddRange(Shapes.Ellipse(ShapeStartPos, ShapeEndPos));
                    break;

                default:
                    break;
            }

            Color drawColor = Color.Transparent;

            if (_activeMouseButton == 0)
                drawColor = Session.Instance.PrimaryColor;
            else if (_activeMouseButton == 1)
                drawColor = Session.Instance.SecondaryColor;

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
            SelectionStartPos = SelectionEndPos = Point.Empty;
            ShapeStartPos = ShapeEndPos = Point.Empty;
        }
    }
}
