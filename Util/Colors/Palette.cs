using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pixel_Editor_Test_2.Util
{
    [Serializable]
    class Palette
    {
        public List<int> ColorsAsArgb { get; private set; }

        public Palette(List<Color> colors)
        {
            ColorsAsArgb = new List<int>();

            foreach (Color color in colors)
                ColorsAsArgb.Add(color.ToArgb());
        }
        public Palette(List<int> colors)
        {
            ColorsAsArgb = new List<int>(colors);
        }
    }
}
