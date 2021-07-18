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
    public partial class KeyframeContainer :EditorControl
    {
        public KeyframeContainer()
        {
            InitializeComponent();
        }

        private void KeyframeContainer_Load(object sender, EventArgs e)
        {
            base.OnLoad();
            Session.Instance.OnAddKeyframe += (_o, f) => AddKeyframe(f);
        }

        protected override void UpdateTheme(object sender, EventArgs e)
        {
            BackColor = Themes.MAIN_BG_COLOR;
            layoutKeyframe.BackColor = Themes.ANIMATOR_COLOR;
            boxOutline.BackColor = boxOutlineInner.BackColor = Themes.OUTLINE_COLOR;
            boxOutlineWhite.BackColor = Themes.TRIM_COLOR;
            boxShadow.BackColor = playShadow.BackColor = pauseShadow.BackColor = addShadow.BackColor = Themes.SHADOW_COLOR;
            buttonPlay.BackColor = buttonPause.BackColor = buttonAddFrame.BackColor = Themes.BUTTON_BG_COLOR;
            buttonPlay.FlatAppearance.BorderColor = buttonPause.FlatAppearance.BorderColor = buttonAddFrame.FlatAppearance.BorderColor = Themes.OUTLINE_COLOR;
            buttonPlay.FlatAppearance.MouseOverBackColor = buttonPause.FlatAppearance.MouseOverBackColor = buttonAddFrame.FlatAppearance.MouseOverBackColor = Themes.BUTTON_HOVER_COLOR;
            buttonPlay.FlatAppearance.MouseDownBackColor = buttonPause.FlatAppearance.MouseDownBackColor = buttonAddFrame.FlatAppearance.MouseDownBackColor = Themes.BUTTON_HIGHLIGHT_COLOR;
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
