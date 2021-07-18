using Pixel_Editor_Test_2.Controls.Events;
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
    public class AnimatedBitmap : IDisposable
    {
        public event EventHandler<List<Bitmap>> OnFrameChanged;
        public event EventHandler<Layer> OnAddLayer;
        public event EventHandler<KeyframeAddedEventArgs> OnAddKeyframe;

        public List<Layer> Layers;

        public int TotalFrames { get; private set; }
        public int CurrentFrame { get; set; }

        private bool _isPlaying;
        private CancellationTokenSource _cancelToken;

        protected void FrameChanged(int currentFrame)
        {
            List<Bitmap> layerBitmaps = new List<Bitmap>();
            foreach (Layer layer in Layers)
                layerBitmaps.Add(layer.GetFrameByIndex(currentFrame).Image);

            CurrentFrame = currentFrame;
            OnFrameChanged?.Invoke(this, layerBitmaps);
        }

        public AnimatedBitmap()
        {
            Layers = new List<Layer>() { new Layer() };
            _cancelToken = new CancellationTokenSource();
        }

        private void Animate(object obj)
        {
            while (!_cancelToken.IsCancellationRequested)
            {
                for (int i = 0; i < TotalFrames; i++)
                {
                    if (_cancelToken.IsCancellationRequested)
                        break;

                    FrameChanged(i);
                    Thread.Sleep(83); // REFACTOR TO USE DELAY FROM FRAMES (LATER)
                }
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

        public void GotoFrame(int i)
        {
            if (i < 0 || (i >= TotalFrames && TotalFrames > 0))
                throw new ArgumentOutOfRangeException(i.ToString(), "Index must be greater than 0 and less than the total number of frames.");

            PauseAnimation();
            FrameChanged(i);
        }

        public void AddLayer()
        {
            Layer layer = new Layer(TotalFrames);
            Console.WriteLine(layer.Frames.Count);

            Layers.Add(layer);
            OnAddLayer?.Invoke(this, layer);
        }

        public void AddFrame(Frame frame)
        {
            TotalFrames++;

            foreach(Layer layer in Layers)
                layer.AddFrame(frame);

            GotoFrame(TotalFrames - 1);
            OnAddKeyframe?.Invoke(this, new KeyframeAddedEventArgs(frame, TotalFrames));
        }

        public void Dispose()
        {
            _cancelToken.Cancel();
        }
    }
}
