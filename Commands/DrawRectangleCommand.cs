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
    public class DrawRectangleCommand : Command
    {
        public DrawRectangleCommand(PictureBox destination)
            : base(destination)
        {}

        public void Execute(Bitmap bmp, Point startPos, Point endPos, Color color, bool filled)
        {
            if (filled)
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
            } else if (!filled)
            {
                List<Point> pixels = Shapes.Rectangle(startPos, endPos);

                foreach (Point pixel in pixels)
                {
                    if (pixel.X >= 0 && pixel.X < bmp.Width && pixel.Y >= 0 && pixel.Y < bmp.Height)
                    {
                        _previousColors.Add(pixel, bmp.GetPixel(pixel.X, pixel.Y));
                        _finalColors.Add(pixel, color);
                        bmp.SetPixel(pixel.X, pixel.Y, color);
                    }
                }
            }

            _destinationRef.Image = bmp;
        }

        public override void Execute(Bitmap bmp, Point startPos, Point endPos, Color color)
        {
            Execute(bmp, startPos, endPos, color, false);
        }
    }
}
