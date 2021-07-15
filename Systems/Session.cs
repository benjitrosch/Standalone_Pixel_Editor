using Pixel_Editor_Test_2.Controls.PixelEditor;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pixel_Editor_Test_2.Systems
{
    public class Session
    {
        private static readonly Session _instance = new Session();

        public Color PrimaryColor { get; set; }
        public Color SecondaryColor { get; set; }
        private Color[] Palette = new Color[64];

        public int BrushSize { get; set; }

        static Session()
        {}

        public static Session Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
