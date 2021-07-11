using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pixel_Editor_Test_2.Commands
{
    public class DrawPixelCommand : ICommand
    {
        public PictureBox _destinationRef { get; set; }

        public Dictionary<Point, Color> _previousColors { get; set; }
        public Dictionary<Point, Color> _finalColors { get; set; }

        public DrawPixelCommand(PictureBox destination)
        {
            _destinationRef = destination;

            _previousColors = new Dictionary<Point, Color>();
            _finalColors = new Dictionary<Point, Color>();
        }

        public void Execute(Bitmap bmp, Point position, Color color)
        {
            if (position.X < 0 || position.X >= bmp.Width ||
                position.Y < 0 || position.Y >= bmp.Height)
                return;

            _previousColors.Add(position, bmp.GetPixel(position.X, position.Y));
            _finalColors.Add(position, color);
            bmp.SetPixel(position.X, position.Y, color);

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
