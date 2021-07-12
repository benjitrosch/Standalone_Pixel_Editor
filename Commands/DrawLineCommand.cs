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
    public class DrawLineCommand : Command
    {
        public DrawLineCommand(PictureBox destination)
                    : base(destination)
        {}

        public override void Execute(Bitmap bmp, Point startPos, Point endPos, Color color)
        {
            List<Point> pixels = BresenhamLine.Line(startPos, endPos);

            if (pixels.Count < 1)
                return;

            foreach (Point pixel in pixels)
            {
                _previousColors.Add(pixel, bmp.GetPixel(pixel.X, pixel.Y));
                _finalColors.Add(pixel, color);
                bmp.SetPixel(pixel.X, pixel.Y, color);
            }

            _destinationRef.Image = bmp;
        }
    }
}
