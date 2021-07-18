﻿using Pixel_Editor_Test_2.Util;
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
        public DrawCircleCommand(ref Bitmap image)
            : base(ref image)
        {}

        public void Execute(Bitmap bmp, Point startPos, Point endPos, Color color, bool fill)
        {
            List<Point> pixels = Shapes.Ellipse(startPos, endPos, fill);

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
        public override void Execute(Bitmap bmp, Point startPos, Point endPos, Color color)
        {
            Execute(bmp, startPos, endPos, color, false);
        }
    }
}
