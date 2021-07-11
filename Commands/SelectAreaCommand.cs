using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pixel_Editor_Test_2.Commands
{
    public class SelectAreaCommand : ICommand
    {
        public PictureBox _destinationRef { get; set; }

        public Dictionary<Point, Color> _previousColors { get; set; }
        public Dictionary<Point, Color> _finalColors { get; set; }

        public SelectAreaCommand(PictureBox destination)
        {
            _destinationRef = destination;

            _previousColors = new Dictionary<Point, Color>();
            _finalColors = new Dictionary<Point, Color>();
        }

        public void Execute(Bitmap bmp, Point startPos, Point endPos, Color color)
        {
            for (int x = Math.Min(startPos.X, endPos.X); x < Math.Max(startPos.X, endPos.X); x++)
            {
                for (int y = Math.Min(startPos.Y, endPos.Y); y < Math.Max(startPos.Y, endPos.Y); y++)
                {
                    if (x < 0 || x >= bmp.Width ||
                        y < 0 || y >= bmp.Height)
                        continue;

                    _previousColors.Add(new Point(x, y), bmp.GetPixel(x, y));
                    _finalColors.Add(new Point(x, y), color);
                    bmp.SetPixel(x, y, color);
                }
            }

            _destinationRef.Image = bmp;
        }

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
