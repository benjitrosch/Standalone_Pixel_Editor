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

namespace Pixel_Editor_Test_2.Util
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

        public List<Bitmap> Frames
        {
            get
            {
                return _frames.Select(frame => frame.Image).ToList();
            }
        }

        public int TotalFrames
        {
            get
            {
                return _frames.Count;
            }
        }
        public int CurrentFrame { get; set; }

        private bool _isPlaying;
        private CancellationTokenSource _cancelToken;

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
            if (_isPlaying)
                _addQueue.Add(frame);
            else
                _frames.Add(frame);
        }

        public void RemoveFrame(Frame frame)
        {
            if (_isPlaying)
                _removeQueue.Add(frame);
            else
                _frames.Remove(frame);
        }

        public void GotoFrame(int i)
        {
            if (i < 0 || i >= _frames.Count)
                throw new ArgumentOutOfRangeException(nameof(i), "Index must be greater than 0 and less than the total number of frames.");

            PauseAnimation();
            CurrentFrame = i;
            OnFrameUpdated(_frames[i].Image);
        }

        public Frame GetFrameByIndex(int i)
        {
            if (i < 0 || i >= _frames.Count)
                throw new ArgumentOutOfRangeException(nameof(i), "Index must be greater than 0 and less than the total number of frames.");

            return _frames[i];
        }

        public Frame GetLastFrame()
        {
            return _frames[_frames.Count - 1];
        }

        private void Animate(object obj)
        {
            while (!_cancelToken.IsCancellationRequested)
            {
                int i = 0;
                foreach (Frame frame in _frames)
                {
                    if (_cancelToken.IsCancellationRequested)
                        break;

                    CurrentFrame = i;
                    i++;

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
            if (_isPlaying)
                return;

            _isPlaying = true;

            _cancelToken = new CancellationTokenSource();
            Task.Factory.StartNew(Animate,
                                    TaskCreationOptions.LongRunning,
                                    _cancelToken.Token);
        }

        public void PauseAnimation()
        {
            _isPlaying = false;

            _cancelToken.Cancel();
        }

        public void Dispose()
        {
            _cancelToken.Cancel();
        }
    }
}
