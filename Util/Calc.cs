using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pixel_Editor_Test_2.Util
{
    public class Calc
    {
        public static double Distance(Point startPos, Point endPos)
        {
            int distX = endPos.X - startPos.X;
            int distY = endPos.Y - startPos.Y;

            return Math.Sqrt(distX * distX + distY * distY);
        }
    }
}
