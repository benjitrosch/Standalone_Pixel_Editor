using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pixel_Editor_Test_2.Systems
{
    public class Themes
    {
        public static Color MAIN_BG_COLOR { get; private set; }
        public static Color OUTLINE_COLOR { get; private set; }
        public static Color TRIM_COLOR { get; private set; }
        public static Color SHADOW_COLOR { get; private set; }

        public static Color BUTTON_BG_COLOR { get; private set; }
        public static Color BUTTON_HOVER_COLOR { get; private set; }
        public static Color BUTTON_HIGHLIGHT_COLOR { get; private set; }

        public static Color MENUSTRIP_COLOR { get; private set; }
        public static Color TOOLBAR_COLOR { get; private set; }
        public static Color PALETTE_COLOR { get; private set; }
        public static Color ANIMATOR_COLOR { get; private set; }

        public static void DEFAULT_THEME()
        {
            MAIN_BG_COLOR = Color.White;
            OUTLINE_COLOR = Color.Black;
            TRIM_COLOR = Color.White;
            SHADOW_COLOR = Color.Black;

            BUTTON_BG_COLOR = Color.White;
            BUTTON_HOVER_COLOR = Color.FromArgb(229, 229, 229);
            BUTTON_HIGHLIGHT_COLOR = Color.FromArgb(250, 203, 254);

            MENUSTRIP_COLOR = Color.White;
            TOOLBAR_COLOR = Color.FromArgb(203, 254, 221);
            PALETTE_COLOR = Color.FromArgb(203, 249, 254);
            ANIMATOR_COLOR = Color.FromArgb(254, 204, 203);
        }

        public static void FLORALSHOPPE_THEME()
        {
            MAIN_BG_COLOR = Color.FromArgb(214, 193, 212);
            OUTLINE_COLOR = Color.FromArgb(73, 49, 178);
            TRIM_COLOR = Color.FromArgb(107, 212, 209);
            SHADOW_COLOR = Color.FromArgb(73, 49, 178);

            BUTTON_BG_COLOR = Color.FromArgb(214, 193, 212);
            BUTTON_HOVER_COLOR = Color.FromArgb(229, 229, 229);
            BUTTON_HIGHLIGHT_COLOR = Color.FromArgb(107, 212, 209);

            MENUSTRIP_COLOR = Color.FromArgb(207, 156, 203);
            TOOLBAR_COLOR = Color.FromArgb(207, 156, 203);
            PALETTE_COLOR = Color.FromArgb(121, 124, 221);
            ANIMATOR_COLOR = Color.FromArgb(203, 108, 147);
        }
    }
}
