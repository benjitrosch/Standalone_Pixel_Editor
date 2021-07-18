using Pixel_Editor_Test_2.Systems;
using Pixel_Editor_Test_2.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pixel_Editor_Test_2.Controls
{
    public partial class Keyframe : EditorControl
    {
        public int FrameIndex { get; private set; }
        private Color _drawColor = Themes.OUTLINE_COLOR;

        public Keyframe(int index)
        {
            InitializeComponent();
            FrameIndex = index;
        }

        private void Keyframe_Load(object sender, EventArgs e)
        {
            base.OnLoad();
            UpdateTheme(sender, e);

            Session.Instance.Editor.canvasPanel.OnCanvasMouseUp += (_o, _e) => CheckUpdate();
            Session.Instance.Editor.canvasPanel.OnHistoryChange += (_o, _e) => CheckUpdate();
        }

        protected override void UpdateTheme(object sender, EventArgs e)
        {
            _drawColor = Themes.TEXT_COLOR;
            BackColor = Themes.MAIN_BG_COLOR;
        }

        private void CheckUpdate()
        {
            if (Session.Instance.Animation.CurrentFrame == FrameIndex)
                Invalidate();
        }

        private void Keyframe_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            using (Pen p = new Pen(_drawColor, 1))
            using (Brush b = new SolidBrush(_drawColor))
            {
                Rectangle rect = new Rectangle(new Point(2, 10), new Size(6, 6));
                g.DrawEllipse(p, rect);
                if (!BitmapExtensions.IsEmpty(Session.Instance.Animation.Layers[Session.Instance.ActiveLayer].GetFrameByIndex(FrameIndex).Image))
                    g.FillEllipse(b, rect);
            }

            ControlPaint.DrawBorder(g,
                                    ClientRectangle,
                                    _drawColor,
                                    0,
                                    ButtonBorderStyle.Solid,
                                    _drawColor,
                                    0,
                                    ButtonBorderStyle.Solid,
                                    _drawColor,
                                    1,
                                    ButtonBorderStyle.Solid,
                                    _drawColor,
                                    0,
                                    ButtonBorderStyle.Solid);
        }

        private void Keyframe_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Themes.BUTTON_HIGHLIGHT_COLOR;
        }

        private void Keyframe_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Themes.MAIN_BG_COLOR;
        }
    }
}
