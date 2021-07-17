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

namespace Pixel_Editor_Test_2.Controls
{
    public partial class KeyframeContainer : UserControl
    {
        public KeyframeContainer()
        {
            InitializeComponent();
        }

        private void KeyframeContainer_Load(object sender, EventArgs e)
        {
            Session.Instance.OnAddKeyframe += (_o, f) => AddKeyframe(f);
        }

        public void AddKeyframe(KeyframeAddedEventArgs e)
        {
            Keyframe newKeyframe = new Keyframe(e.FrameIndex);

            newKeyframe.Click += new EventHandler(ClickKeyframe);
            layoutKeyframe.Controls.Add(newKeyframe);
        }

        private void ClickKeyframe(object sender, EventArgs e)
        {
            Keyframe keyframe = (Keyframe)sender;
            Session.Instance.Animation.GotoFrame(keyframe.FrameIndex);
        }

        private void buttonAddFrame_Click(object sender, EventArgs e)
        {
            Session.Instance.AddKeyframe(new Frame(Canvas.CreateNewCanvas(32, 32), Global.STANDARD_FRAMERATE));
        }

        private void ButtomAddEmptyFrame_Click(object sender, EventArgs e)
        {
            Session.Instance.AddKeyframe(new Frame(new Bitmap(Session.Instance.Animation.GetLastFrame().Image), Global.STANDARD_FRAMERATE));
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            Session.Instance.Animation.PlayAnimation();
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            Session.Instance.Animation.PauseAnimation();
        }
    }
}
