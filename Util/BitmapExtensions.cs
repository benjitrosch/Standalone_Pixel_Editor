using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
    }
}
