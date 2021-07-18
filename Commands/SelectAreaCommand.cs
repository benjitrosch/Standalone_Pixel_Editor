using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pixel_Editor_Test_2.Commands
{
    public class SelectAreaCommand : Command
    {
        public SelectAreaCommand(ref Bitmap image)
            :base(ref image)
        {}

        public override void Execute(Bitmap bmp, Point startPos, Point endPos, Color color)
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

            _image = bmp;
        }
    }
}
