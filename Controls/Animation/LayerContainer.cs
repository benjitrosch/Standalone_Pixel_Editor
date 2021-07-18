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
        public Layer Layer { get; set; }

        public LayerContainer(Layer layer = null)
        {
            InitializeComponent();
            textLayerName.AutoSize = false;
            textLayerName.Size = new Size(64, 32);

            Layer = layer;
        }

        private void LayerContainer_Load(object sender, EventArgs e)
        {
            base.OnLoad();
            Session.Instance.Animation.OnAddKeyframe += (_o, f) => AddKeyframe(f);

            RefreshKeyframes();
        }

        protected override void UpdateTheme(object sender, EventArgs e)
        {}

        private void RefreshKeyframes()
        {
            frameLayout.Controls.Clear();

            int i = 0;
            foreach(Image frame in Layer.Frames)
            {
                Keyframe newKeyframe = new Keyframe(i);

                newKeyframe.Click += new EventHandler(ClickKeyframe);
                frameLayout.Controls.Add(newKeyframe);
                i++;
            }
        }

        public void AddKeyframe(KeyframeAddedEventArgs e)
        {
            Keyframe newKeyframe = new Keyframe(e.FrameIndex);

            newKeyframe.Click += new EventHandler(ClickKeyframe);
            frameLayout.Controls.Add(newKeyframe);
        }

        private void ClickKeyframe(object sender, EventArgs e)
        {
            Keyframe keyframe = (Keyframe)sender;
            Session.Instance.Animation.GotoFrame(keyframe.FrameIndex);
        }
    }
}
