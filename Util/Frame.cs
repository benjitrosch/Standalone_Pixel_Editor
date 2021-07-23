using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pixel_Editor_Test_2.Util
{
    public class Frame
    {
        public Bitmap Image { get; set; }
        public int Delay { get; set; }

        public Frame(Bitmap image, int delay)
        {
            Image = image;
            Delay = delay;
        }
    }
}
