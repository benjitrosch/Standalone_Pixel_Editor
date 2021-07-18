using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Pixel_Editor_Test_2.Util
{
    public class BitmapExtensions
    {
        public static Bitmap ResizeImage(Bitmap src, Rectangle newSize)
        {
            var brush = new SolidBrush(Color.Black);
            float scale = Math.Min(newSize.Width / src.Width, newSize.Height / src.Height);

            Bitmap bmp = new Bitmap(newSize.Width, newSize.Height);
            Graphics g = Graphics.FromImage(bmp);

            float scaleWidth = (int)(src.Width * scale);
            float scaleHeight = (int)(src.Height * scale);

            g.FillRectangle(brush, new RectangleF(0, 0, newSize.Width, newSize.Height));
            g.DrawImage(src, ((int)newSize.Width - scaleWidth) / 2, ((int)newSize.Height - scaleHeight) / 2, scaleWidth, scaleHeight);

            return bmp;
        }

        public static bool IsEmpty(Bitmap src)
        {
            BitmapData data = src.LockBits(new Rectangle(0, 0, src.Width, src.Height),
                                           ImageLockMode.ReadOnly,
                                           PixelFormat.Format32bppArgb);
            var bytes = new byte[data.Height * data.Stride];
            Marshal.Copy(data.Scan0, bytes, 0, bytes.Length);
            src.UnlockBits(data);

            for (int p = 3; p < bytes.Length; p += 4)
            {
                if (bytes[p] > 0)
                    return false;
            }

            return true;
        }

        public static List<Point> SelectBitmapArea(Bitmap src, int x, int y)
        {
            List<Point> pixels = new List<Point>();

            Bitmap bmp = new Bitmap(src);
            BitmapData data = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height),
                                           ImageLockMode.ReadWrite,
                                           PixelFormat.Format32bppArgb);
            int[] bits = new int[data.Stride / 4 * data.Height];
            Marshal.Copy(data.Scan0, bits, 0, bits.Length);

            LinkedList<Point> check = new LinkedList<Point>();
            int floodTo = Color.Magenta.ToArgb();
            int floodFrom = bits[x + y * data.Stride / 4];

            pixels.Add(new Point(x,y));
            bits[x + y * data.Stride / 4] = floodTo;

            check.AddLast(new Point(x, y));
            while (check.Count > 0)
            {
                Point cur = check.First.Value;
                check.RemoveFirst();

                foreach (Point off in new Point[] {
                new Point(0, -1), new Point(0, 1),
                new Point(-1, 0), new Point(1, 0)})
                {
                    Point next = new Point(cur.X + off.X, cur.Y + off.Y);
                    if (next.X >= 0 && next.Y >= 0 &&
                        next.X < data.Width &&
                        next.Y < data.Height)
                    {
                        if (bits[next.X + next.Y * data.Stride / 4] == floodFrom)
                        {
                            check.AddLast(next);
                            pixels.Add(next);

                            bits[next.X + next.Y * data.Stride / 4] = floodTo;
                        }
                    }
                }
            }

            return pixels;
        }
    }
}
