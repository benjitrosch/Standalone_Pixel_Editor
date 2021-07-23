using Pixel_Editor_Test_2.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pixel_Editor_Test_2.Systems
{
    public class Global
    {
        public const int STANDARD_FRAMERATE = 83; // 12FPS
        public readonly Point STANDARD_CANVAS_SIZE = new Point(32, 32);

        public const string PIXEL_FILETYPE = "UNNAMED FILETYPE (.pxl)|*.pxl";
        public const string SPRITESHEET_FILETYPE = "Sprite Sheet (.png)|*.png";
        public const string PALETTE_FILETYPE = "Palette (.pclr)|*.pclr";
    }
}
