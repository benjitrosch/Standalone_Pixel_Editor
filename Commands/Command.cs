using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pixel_Editor_Test_2.Commands
{
    public abstract class Command
    {
        protected PictureBox _destinationRef;

        protected Dictionary<Point, Color> _previousColors = new Dictionary<Point, Color>();
        protected Dictionary<Point, Color> _finalColors = new Dictionary<Point, Color>();

        protected Command(PictureBox destination)
        {
            _destinationRef = destination;
        }

        public abstract void Execute(Bitmap bmp, Point startPos, Point endPos, Color color);

        public abstract List<Point> GetAreaOfExecute(Bitmap bmp, Point startPos, Point endPos);

        public virtual void Undo(Bitmap bmp)
        {
            if (_previousColors.Count < 1)
                return;

            foreach (KeyValuePair<Point, Color> pixel in _previousColors)
                bmp.SetPixel(pixel.Key.X, pixel.Key.Y, pixel.Value);

            _destinationRef.Image = bmp;
        }

        public virtual void Redo(Bitmap bmp)
        {
            if (_finalColors.Count < 1)
                return;

            foreach (KeyValuePair<Point, Color> pixel in _finalColors)
                bmp.SetPixel(pixel.Key.X, pixel.Key.Y, pixel.Value);

            _destinationRef.Image = bmp;
        }
    }
}
