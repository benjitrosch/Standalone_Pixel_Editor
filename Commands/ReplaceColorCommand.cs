using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pixel_Editor_Test_2.Commands
{
    public class ReplaceColorCommand : ICommand
    {
        public PictureBox _destinationRef { get; set; }

        public Dictionary<Point, Color> _previousColors { get; set; }
        public Dictionary<Point, Color> _finalColors { get; set; }

        public ReplaceColorCommand(PictureBox destination)
        {
            _destinationRef = destination;

            _previousColors = new Dictionary<Point, Color>();
            _finalColors = new Dictionary<Point, Color>();
        }

        public void Execute(Bitmap bmp, Color oldColor, Color newColor)
        {
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    if (bmp.GetPixel(x, y).ToArgb() == oldColor.ToArgb())
                    {
                        _previousColors.Add(new Point(x, y), oldColor);
                        _finalColors.Add(new Point(x, y), newColor);
                        bmp.SetPixel(x, y, newColor);
                    }
                }
            }

            _destinationRef.Image = bmp;
        }

        public void Execute(Bitmap bmp, Point startPos, Point endPos, Color color)
        {}

        public void Undo(Bitmap bmp)
        {
            if (_previousColors.Count < 1)
                return;

            foreach (KeyValuePair<Point, Color> pixel in _previousColors)
                bmp.SetPixel(pixel.Key.X, pixel.Key.Y, pixel.Value);

            _destinationRef.Image = bmp;
        }

        public void Redo(Bitmap bmp)
        {
            if (_finalColors.Count < 1)
                return;

            foreach (KeyValuePair<Point, Color> pixel in _finalColors)
                bmp.SetPixel(pixel.Key.X, pixel.Key.Y, pixel.Value);

            _destinationRef.Image = bmp;
        }
    }
}
