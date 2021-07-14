using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pixel_Editor_Test_2.Util
{
    public class Canvas
    {
        public static Bitmap CreateNewCanvas(int width, int height, Brush color = null)
        {
            Bitmap bmp = new Bitmap(width, height);
            using (Graphics graph = Graphics.FromImage(bmp))
            {
                Rectangle ImageSize = new Rectangle(0, 0, width, height);
                graph.FillRectangle(color ?? Brushes.Transparent, ImageSize);
            }
            return bmp;
        }
        public static Bitmap CreateNewCanvas(Rectangle size, Brush color = null)
        {
            return CreateNewCanvas(size.X, size.Y, color);
        }

        public static Bitmap CropCanvas(Bitmap src, Rectangle section)
        {
            Bitmap bmp = new Bitmap(section.Width, section.Height);
            using (var g = Graphics.FromImage(bmp))
            {
                g.DrawImage(src, 0, 0, section, GraphicsUnit.Pixel);
                return bmp;
            }
        }
    }
}
