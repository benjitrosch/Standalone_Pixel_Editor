using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pixel_Editor_Test_2.Controls
{
    internal static class MathExtensions
    {
        public static int Round(double val)
        {
            int num = (int)val;
            int num2 = (int)(val * 100.0);
            if ((num2 % 100) >= 50)
            {
                num++;
            }
            return num;
        }

        public static int LimitToRange(int value, int inclusiveMinimum, int inclusiveMaximum)
        {
            if (value < inclusiveMinimum) { return inclusiveMinimum; }
            if (value > inclusiveMaximum) { return inclusiveMaximum; }
            return value;
        }
    }
}
