using Pixel_Editor_Test_2.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pixel_Editor_Test_2.Controls.Events
{
    public class KeyframeAddedEventArgs : EventArgs
    {
        private Frame _frame;
        private int _frameIndex;

        public KeyframeAddedEventArgs(Frame frame, int frameIndex)
        {
            this._frame = frame;
            this._frameIndex = frameIndex;
        }

        public Frame Frame
        {
            get
            {
                return this._frame;
            }
        }

        public int FrameIndex
        {
            get
            {
                return this._frameIndex;
            }
        }
    }
}
