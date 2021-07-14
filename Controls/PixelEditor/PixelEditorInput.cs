using Pixel_Editor_Test_2.Commands;
using Pixel_Editor_Test_2.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pixel_Editor_Test_2.Controls.PixelEditor
{
    public partial class PixelEditor
    {
        private void APBox_MouseClick(object sender, MouseEventArgs e)
        {
            TgtMousePos = e.Location;
            Invalidate();
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

                    PixelEditor_DrawShape(ShapeStartPos, ShapeEndPos, new DrawLineCommand(APBox), e);
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

                    PixelEditor_DrawShape(ShapeStartPos, ShapeEndPos, new DrawRectangleCommand(APBox), e);
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

                    PixelEditor_DrawShape(ShapeStartPos, ShapeEndPos, new DrawCircleCommand(APBox), e);
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
                    if (e.Control)
                        PixelEditor_Undo();
                    break;

                case Keys.Y:
                    if (e.Control)
                        PixelEditor_Redo();
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
    }
}
