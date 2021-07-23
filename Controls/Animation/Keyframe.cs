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
        private int _layerIndex;
        public int FrameIndex { get; private set; }
        private Color _drawColor = Themes.OUTLINE_COLOR;

        public Keyframe(int index, int layer)
        {
            InitializeComponent();

            FrameIndex = index;
            _layerIndex = layer;
        }

        protected override void OnLoad()
        {
            base.OnLoad();
            UpdateTheme();

            Session.Instance.Editor.canvasPanel.OnCanvasMouseUp += (_o, _e) => CheckUpdate();
            Session.Instance.Editor.canvasPanel.OnHistoryChange += (_o, _e) => CheckUpdate();
            Session.Instance.OnActiveLayerChange += (_o, l) => CheckLayerSelection(l);

            CheckLayerSelection(Session.Instance.ActiveLayer);
        }

        protected override void UpdateTheme()
        {
            _drawColor = Themes.TEXT_COLOR;
            BackColor = Themes.ANIMATOR_COLOR;

            CheckLayerSelection(Session.Instance.ActiveLayer);
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
                if (!BitmapExtensions.IsEmpty(Session.Instance.Animation.Layers[_layerIndex].GetFrameByIndex(FrameIndex).Image))
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
            BackColor = Session.Instance.ActiveLayer == _layerIndex ? Themes.BUTTON_HIGHLIGHT_COLOR : Themes.ANIMATOR_COLOR;
        }

        private bool LayerSelected()
        {
            return _layerIndex == Session.Instance.ActiveLayer;
        }

        private bool KeyframeSelected()
        {
            return FrameIndex == Session.Instance.Animation.CurrentFrame && LayerSelected();
        }

        private void CheckLayerSelection(int layerIndex)
        {
            if (layerIndex == _layerIndex)
                BackColor = Themes.BUTTON_HIGHLIGHT_COLOR;
            else
                BackColor = Themes.ANIMATOR_COLOR;
        }
    }
}
