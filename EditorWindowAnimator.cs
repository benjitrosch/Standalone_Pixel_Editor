using Pixel_Editor_Test_2.Controls;
using Pixel_Editor_Test_2.Systems;
using Pixel_Editor_Test_2.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pixel_Editor_Test_2
{
    public partial class EditorWindow
    {
        private List<Keyframe> _keyframes = new List<Keyframe>();

        private void AddKeyframe(Frame frame)
        {
            _animation.PauseAnimation();

            int frameIndex = _animation.TotalFrames;
            _animation.AddFrame(frame);

            Keyframe newKeyframe = new Keyframe(frameIndex);
            _keyframes.Add(newKeyframe);

            keyframeContainer.Controls.Clear();

            foreach(Keyframe keyframe in _keyframes)
            {
                keyframe.Click += new EventHandler(ClickEvent);
                keyframeContainer.Controls.Add(keyframe);
            }

            _animation.GotoFrame(frameIndex);
        }

        private void ClickEvent(object sender, EventArgs e)
        {
            Keyframe keyframe = (Keyframe)sender;
            _animation.GotoFrame(keyframe.FrameIndex);
        }

        private void buttonPlayAnimation_Click(object sender, EventArgs e)
        {
            _animation.PlayAnimation();
        }

        private void buttonPauseAnimation_Click(object sender, EventArgs e)
        {
            _animation.PauseAnimation();
        }

        private void buttonRewindAnimation_Click(object sender, EventArgs e)
        {
            _animation.GotoFrame(0);
        }

        private void buttonAddEmptyFrame_Click(object sender, EventArgs e)
        {
            AddKeyframe(new Frame(Canvas.CreateNewCanvas(32, 32), Global.STANDARD_FRAMERATE));
        }

        private void buttonAddCopyFrame_Click(object sender, EventArgs e)
        {
            AddKeyframe(new Frame(new Bitmap(_animation.GetLastFrame().Image), Global.STANDARD_FRAMERATE));
        }
    }
}
