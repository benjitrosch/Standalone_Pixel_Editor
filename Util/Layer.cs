using Pixel_Editor_Test_2.Controls;
using Pixel_Editor_Test_2.Systems;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pixel_Editor_Test_2.Util
{
    public class Layer
    {
        public string Name { get; set; }
        public bool Visible { get; private set; }

        private List<Frame> _frames;
        public List<Bitmap> Frames
        {
            get
            {
                return _frames.Select(frame => frame.Image).ToList();
            }
        }

        public Layer(int emptyFrames = 0)
        {
            _frames = Enumerable.Repeat(new Frame(Canvas.CreateNewCanvas(32, 32), Global.STANDARD_FRAMERATE), emptyFrames).ToList();
            Name = "New Layer";
        }

        public void ToggleVisibility()
        {
            Visible = !Visible;
        }

        public void AddFrame(Frame frame)
        {
            _frames.Add(frame);
        }

        public void RemoveFrame(Frame frame)
        {
            _frames.Remove(frame);
        }

        public Frame GetFrameByIndex(int i)
        {
            if (i < 0 || i >= _frames.Count)
                throw new ArgumentOutOfRangeException(nameof(i), "Index must be greater than 0 and less than the total number of frames.");

            return _frames[i];
        }
    }
}
