using Pixel_Editor_Test_2.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pixel_Editor_Test_2.Commands
{
    public class FillCommand : Command
    {
        public FillCommand(ref Bitmap image)
            : base(ref image)
        {}

        public override void Execute(Bitmap bmp, Point startPos, Point endPos, Color color)
        {
            int x = startPos.X;
            int y = startPos.Y;

            List<Point> pixels = BitmapExtensions.SelectBitmapArea(bmp, x, y);

            foreach (Point pixel in pixels)
            {
                if (pixel.X >= 0 && pixel.X < bmp.Width && pixel.Y >= 0 && pixel.Y < bmp.Height)
                {
                    _previousColors.Add(pixel, bmp.GetPixel(pixel.X, pixel.Y));
                    _finalColors.Add(pixel, color);
                    bmp.SetPixel(pixel.X, pixel.Y, color);
                }
            }

            _image = bmp;
        }
    }
}
