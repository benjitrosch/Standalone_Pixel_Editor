using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pixel_Editor_Test_2.Util
{
    public class Bresenham
    {
        public static List<Point> Line(Point startPos, Point endPos)
        {
            List<Point> pixels = new List<Point>();

            int x = startPos.X;
            int x2 = endPos.X;
            int y = startPos.Y;
            int y2 = endPos.Y;

            int w = x2 - x;
            int h = y2 - y;

            int dx1 = 0, dy1 = 0, dx2 = 0, dy2 = 0;

            if (w < 0) dx1 = -1; else if (w > 0) dx1 = 1;
            if (h < 0) dy1 = -1; else if (h > 0) dy1 = 1;
            if (w < 0) dx2 = -1; else if (w > 0) dx2 = 1;

            int longest = Math.Abs(w);
            int shortest = Math.Abs(h);

            if (!(longest > shortest))
            {
                longest = Math.Abs(h);
                shortest = Math.Abs(w);
                if (h < 0) dy2 = -1; else if (h > 0) dy2 = 1;
                dx2 = 0;
            }
            int numerator = longest >> 1;
            for (int i = 0; i <= longest; i++)
            {
                pixels.Add(new Point(x, y));

                numerator += shortest;
                if (!(numerator < longest))
                {
                    numerator -= longest;
                    x += dx1;
                    y += dy1;
                }
                else
                {
                    x += dx2;
                    y += dy2;
                }
            }

            return pixels;
        }

        public static List<Point> Rectangle(Point startPos, Point endPos)
        {
            // ...it's a rectangle MADE out of Bresenham lines, that has to count, right?

            List<Point> line1 = Bresenham.Line(startPos, new Point(endPos.X, startPos.Y));
            List<Point> line2 = Bresenham.Line(new Point(endPos.X, startPos.Y), endPos);
            List<Point> line3 = Bresenham.Line(endPos, new Point(startPos.X, endPos.Y));
            List<Point> line4 = Bresenham.Line(new Point(startPos.X, endPos.Y), startPos);

            List<Point> pixels = new List<Point>(line1.Count + line2.Count + line3.Count + line4.Count);
            pixels.AddRange(line1);
            pixels.AddRange(line2);
            pixels.AddRange(line3);
            pixels.AddRange(line4);

            return pixels.Distinct().ToList();
        }

        public static List<Point> Ellipse(Point startPos, Point endPos, bool fill = false)
        {
            // Not technically Bresenham... this is McIlroy!

            List<Point> pixels = new List<Point>();
            int xb, yb, xc, yc;

            // Calculate height
            yb = yc = (startPos.Y + endPos.Y) / 2;
            int qb = (startPos.Y < endPos.Y) ? (endPos.Y - startPos.Y) : (startPos.Y - endPos.Y);
            int qy = qb;
            int dy = qb / 2;
            if (qb % 2 != 0)
                // Bounding box has even pixel height
                yc++;

            // Calculate width
            xb = xc = (startPos.X + endPos.X) / 2;
            int qa = (startPos.X < endPos.X) ? (endPos.X - startPos.X) : (startPos.X - endPos.X);
            int qx = qa % 2;
            int dx = 0;
            long qt = (long)qa * qa + (long)qb * qb - 2L * qa * qa * qb;
            if (qx != 0)
            {
                // Bounding box has even pixel width
                xc++;
                qt += 3L * qb * qb;
            }

            // Start at (dx, dy) = (0, b) and iterate until (a, 0) is reached
            while (qy >= 0 && qx <= qa)
            {
                // Draw the new points
                if (!fill)
                {
                    pixels.Add(new Point(xb - dx, yb - dy));
                    if (dx != 0 || xb != xc)
                    {
                        pixels.Add(new Point(xc + dx, yb - dy));
                        if (dy != 0 || yb != yc)
                            pixels.Add(new Point(xc + dx, yc + dy));
                    }
                    if (dy != 0 || yb != yc)
                        pixels.Add(new Point(xb - dx, yc + dy));
                }

                // If a (+1, 0) step stays inside the ellipse, do it
                if (qt + 2L * qb * qb * qx + 3L * qb * qb <= 0L ||
                    qt + 2L * qa * qa * qy - (long)qa * qa <= 0L)
                {
                    qt += 8L * qb * qb + 4L * qb * qb * qx;
                    dx++;
                    qx += 2;
                    // If a (0, -1) step stays outside the ellipse, do it
                }
                else if (qt - 2L * qa * qa * qy + 3L * qa * qa > 0L)
                {
                    if (fill)
                    {
                        //drawRow(xb - dx, xc + dx, yc + dy);
                        //if (dy != 0 || yb != yc)
                            //drawRow(xb - dx, xc + dx, yb - dy);
                    }
                    qt += 8L * qa * qa - 4L * qa * qa * qy;
                    dy--;
                    qy -= 2;
                    // Else step (+1, -1)
                }
                else
                {
                    if (fill)
                    {
                        //drawRow(xb - dx, xc + dx, yc + dy);
                        //if (dy != 0 || yb != yc)
                            //drawRow(xb - dx, xc + dx, yb - dy);
                    }
                    qt += 8L * qb * qb + 4L * qb * qb * qx + 8L * qa * qa - 4L * qa * qa * qy;
                    dx++;
                    qx += 2;
                    dy--;
                    qy -= 2;
                }
            }   // End of while loop
            return pixels;
        }
    }
}
