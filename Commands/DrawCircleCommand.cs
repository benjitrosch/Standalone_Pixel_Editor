using Pixel_Editor_Test_2.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pixel_Editor_Test_2.Commands
{
    public class DrawCircleCommand : Command
    {
        public DrawCircleCommand(PictureBox destination)
            : base(destination)
        {}

        public override void Execute(Bitmap bmp, Point startPos, Point endPos, Color color)
        {
            List<Point> pixels = Bresenham.Ellipse(startPos, endPos);

            foreach (Point pixel in pixels)
            {
                if (pixel.X >= 0 && pixel.X < bmp.Width && pixel.Y >= 0 && pixel.Y < bmp.Height)
                {
                    _previousColors.Add(pixel, bmp.GetPixel(pixel.X, pixel.Y));
                    _finalColors.Add(pixel, color);
                    bmp.SetPixel(pixel.X, pixel.Y, color);
                }
            }

            _destinationRef.Image = bmp;
        }
    }
}
