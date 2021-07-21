using Pixel_Editor_Test_2.Controls.Animation;
using Pixel_Editor_Test_2.Controls.Events;
using Pixel_Editor_Test_2.Systems;
using Pixel_Editor_Test_2.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pixel_Editor_Test_2.Controls
{
    public partial class KeyframeContainer : EditorControl
    {
        private List<EditorButton> _buttons = new List<EditorButton>();

        public KeyframeContainer()
        {
            InitializeComponent();
        }

        protected override void OnLoad()
        {
            base.OnLoad();
            Session.Instance.Animation.OnAddLayer += (_o, _l) => RefreshLayers();

            buttonPlay.Callback = () => Session.Instance.Animation.PlayAnimation();
            buttonPause.Callback = () => Session.Instance.Animation.PauseAnimation();
            buttonAddFrame.Callback = () => Session.Instance.Animation.AddFrame(new Frame(Canvas.CreateNewCanvas(32, 32), Global.STANDARD_FRAMERATE));
            buttonAddLayer.Callback = () => Session.Instance.Animation.AddLayer();

            _buttons.Add(buttonPlay);
            _buttons.Add(buttonPause);
            _buttons.Add(buttonAddFrame);
            _buttons.Add(buttonAddLayer);

            foreach (EditorButton button in _buttons)
                button.Initialize();
        }

        protected override void UpdateTheme()
        {
            BackColor = Themes.MAIN_BG_COLOR;
            layoutKeyframe.BackColor = Themes.ANIMATOR_COLOR;
            boxOutline.BackColor = boxOutlineInner.BackColor = Themes.OUTLINE_COLOR;
            boxOutlineWhite.BackColor = Themes.TRIM_COLOR;
            boxShadow.BackColor = Themes.SHADOW_COLOR;
        }

        public void RefreshLayers()
        {
            layoutKeyframe.Controls.Clear();

            int i = 0;
            foreach(Layer layer in Session.Instance.Animation.Layers)
            {
                LayerContainer layerContainer = new LayerContainer(layer, i);
                layoutKeyframe.Controls.Add(layerContainer);
                layerContainer.Initialize();
                i++;
            }
        }

        private void buttonAddFrame_Click(object sender, EventArgs e)
        {
            buttonAddFrame.button_Click(sender, e);
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            buttonPlay.button_Click(sender, e);
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            buttonPause.button_Click(sender, e);
        }

        private void buttonAddLayer_Click(object sender, EventArgs e)
        {
            buttonAddLayer.button_Click(sender, e);
        }
    }
}
