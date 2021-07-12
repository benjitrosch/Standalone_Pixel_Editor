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
    class DrawRectangleCommand : Command
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
                List<Point> line1 = BresenhamLine.Line(startPos, new Point(endPos.X, startPos.Y));
                List<Point> line2 = BresenhamLine.Line(new Point(endPos.X, startPos.Y), endPos);
                List<Point> line3 = BresenhamLine.Line(endPos, new Point(startPos.X, endPos.Y));
                List<Point> line4 = BresenhamLine.Line(new Point(startPos.X, endPos.Y), startPos);

                List<Point> pixels = new List<Point>(line1.Count + line2.Count + line3.Count + line4.Count);
                pixels.AddRange(line1);
                pixels.AddRange(line2);
                pixels.AddRange(line3);
                pixels.AddRange(line4);

                pixels = pixels.Distinct().ToList();

                if (pixels.Count < 1)
                    return;

                foreach (Point pixel in pixels)
                {
                    _previousColors.Add(pixel, bmp.GetPixel(pixel.X, pixel.Y));
                    _finalColors.Add(pixel, color);
                    bmp.SetPixel(pixel.X, pixel.Y, color);
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
