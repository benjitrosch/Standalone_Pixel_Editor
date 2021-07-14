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
            _animation.PauseAnimation();
            _animation.GotoFrame(0);
        }

        private void buttonAddEmptyFrame_Click(object sender, EventArgs e)
        {
            _animation.AddFrame(new Frame(Canvas.CreateNewCanvas(32, 32), Global.STANDARD_FRAMERATE));
            _animation.GotoFrame(_animation.TotalFrames - 1);
        }

        private void buttonAddCopyFrame_Click(object sender, EventArgs e)
        {
            _animation.AddFrame(new Frame(new Bitmap(_animation.GetLastFrame().Image), Global.STANDARD_FRAMERATE));
            _animation.GotoFrame(_animation.TotalFrames - 1);
        }
    }
}
