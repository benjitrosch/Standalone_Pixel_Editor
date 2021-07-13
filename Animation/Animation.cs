using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pixel_Editor_Test_2.Animation
{
    public class Frame
    {
        public Bitmap Image { get; set; }
        public int Delay { get; set; }

        public Frame(Bitmap image, int delay)
        {
            Image = image;
            Delay = delay;
        }
    }

    public class AnimatedBitmap : IDisposable
    {
        public event EventHandler<Bitmap> FrameUpdated;

        private List<Frame> _addQueue;
        private List<Frame> _removeQueue;
        private List<Frame> _frames;

        private CancellationTokenSource _cancelToken;

        public Frame CurrentFrame { get; set; }

        protected void OnFrameUpdated(Bitmap bmp)
        {
            FrameUpdated?.Invoke(this, bmp);
        }

        public AnimatedBitmap(List<Frame> frames)
        {
            _addQueue = new List<Frame>();
            _removeQueue = new List<Frame>();
            _frames = frames;

            _cancelToken = new CancellationTokenSource();
        }

        public void AddFrame(Frame frame)
        {
            _addQueue.Add(frame);
        }

        public void RemoveFrame(Frame frame)
        {
            _removeQueue.Add(frame);
        }

        private void Animate(object obj)
        {
            while (!_cancelToken.IsCancellationRequested)
            {
                foreach (Frame frame in _frames)
                {
                    if (_cancelToken.IsCancellationRequested)
                        break;

                    OnFrameUpdated(frame.Image);
                    Thread.Sleep(frame.Delay);
                }

                _frames.AddRange(_addQueue);

                foreach (Frame frame in _removeQueue)
                    _frames.Remove(frame);

                _addQueue.Clear();
                _removeQueue.Clear();
            }
        }

        public void PlayAnimation()
        {
            if (_cancelToken.IsCancellationRequested)
            {
                _cancelToken = new CancellationTokenSource();
                Task.Factory.StartNew(Animate,
                                      TaskCreationOptions.LongRunning,
                                      _cancelToken.Token);
            }
        }

        public void PauseAnimation()
        {
            _cancelToken.Cancel();
        }

        public void Dispose()
        {
            _cancelToken.Cancel();
        }
    }
}
