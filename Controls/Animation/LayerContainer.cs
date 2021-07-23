using Pixel_Editor_Test_2.Controls.Events;
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

namespace Pixel_Editor_Test_2.Controls.Animation
{
    public partial class LayerContainer : EditorControl
    {
        public Layer Layer { get; private set; }
        public int LayerIndex { get; private set; }

        public LayerContainer(Layer layer, int layerIndex)
        {
            InitializeComponent();

            textLayerName.AutoSize = false;
            textLayerName.Size = new Size(64, 32);

            Layer = layer;
            LayerIndex = layerIndex;
        }

        protected override void OnLoad()
        {
            base.OnLoad();
            Session.Instance.Animation.OnAddKeyframe += (_o, f) => AddKeyframe(f.FrameIndex);
            Session.Instance.OnActiveLayerChange += (_o, l) => CheckLayerSelection(l);

            RefreshKeyframes();
            UpdateTheme();
        }

        protected override void UpdateTheme()
        {
            frameLayout.BackColor = buttonVisibility.BackColor = Themes.ANIMATOR_COLOR;
            BackColor = divider.BackColor = Themes.TEXT_COLOR;

            CheckLayerSelection(Session.Instance.ActiveLayer);
        }

        private void RefreshKeyframes()
        {
            frameLayout.Controls.Clear();

            int i = 0;
            foreach (Image frame in Layer.Frames)
            {
                AddKeyframe(i);
                i++;
            }
        }

        public void AddKeyframe(int index)
        {
            Keyframe newKeyframe = new Keyframe(index, LayerIndex);

            newKeyframe.Click += new EventHandler(ClickKeyframe);
            frameLayout.Controls.Add(newKeyframe);
            newKeyframe.Initialize();
        }

        private void ClickKeyframe(object sender, EventArgs e)
        {
            Keyframe keyframe = (Keyframe)sender;
            Session.Instance.Animation.GotoFrame(keyframe.FrameIndex);
            Session.Instance.SetActiveLayer(LayerIndex);
        }

        private void CheckLayerSelection(int layerIndex)
        {
            if (LayerIndex == layerIndex)
                textLayerName.BackColor = buttonVisibility.BackColor = Themes.BUTTON_HIGHLIGHT_COLOR;
            else
                textLayerName.BackColor = buttonVisibility.BackColor = Themes.ANIMATOR_COLOR;
        }

        private void buttonVisibility_Click(object sender, EventArgs e)
        {
            Layer.ToggleVisibility();
            buttonVisibility.BackgroundImage = Layer.Visible ? Properties.Resources.eye_icon : Properties.Resources.hidden_icon;
        }
    }
}
