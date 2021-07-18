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
        public static Color SECONDARY_BG_COLOR { get; private set; }
        public static Color OUTLINE_COLOR { get; private set; }
        public static Color TRIM_COLOR { get; private set; }
        public static Color SHADOW_COLOR { get; private set; }

        public static Color BUTTON_BG_COLOR { get; private set; }
        public static Color BUTTON_HOVER_COLOR { get; private set; }
        public static Color BUTTON_HIGHLIGHT_COLOR { get; private set; }

        public static Color TEXT_COLOR { get; private set; }
        public static Color ICON_COLOR { get; private set; }

        public static Color MENUSTRIP_COLOR { get; private set; }
        public static Color TOOLBAR_COLOR { get; private set; }
        public static Color PALETTE_COLOR { get; private set; }
        public static Color ANIMATOR_COLOR { get; private set; }

        public static void DEFAULT_THEME()
        {
            MAIN_BG_COLOR = Color.White;
            SECONDARY_BG_COLOR = Color.White;
            OUTLINE_COLOR = Color.Black;
            TRIM_COLOR = Color.White;
            SHADOW_COLOR = Color.Black;

            BUTTON_BG_COLOR = Color.White;
            BUTTON_HOVER_COLOR = Color.FromArgb(229, 229, 229);
            BUTTON_HIGHLIGHT_COLOR = Color.FromArgb(250, 203, 254);

            TEXT_COLOR = Color.Black;
            ICON_COLOR = Color.Black;

            MENUSTRIP_COLOR = Color.White;
            TOOLBAR_COLOR = Color.FromArgb(203, 254, 221);
            PALETTE_COLOR = Color.FromArgb(203, 249, 254);
            ANIMATOR_COLOR = Color.FromArgb(254, 204, 203);
        }

        public static void FLORALSHOPPE_THEME()
        {
            MAIN_BG_COLOR = Color.FromArgb(207, 156, 203);
            SECONDARY_BG_COLOR = Color.FromArgb(207, 156, 203);
            OUTLINE_COLOR = Color.FromArgb(73, 49, 178);
            TRIM_COLOR = Color.FromArgb(107, 212, 209);
            SHADOW_COLOR = Color.FromArgb(73, 49, 178);

            BUTTON_BG_COLOR = Color.FromArgb(214, 193, 212);
            BUTTON_HOVER_COLOR = Color.FromArgb(229, 229, 229);
            BUTTON_HIGHLIGHT_COLOR = Color.FromArgb(107, 212, 209);

            TEXT_COLOR = Color.FromArgb(73, 49, 178);
            ICON_COLOR = Color.FromArgb(73, 49, 178);

            MENUSTRIP_COLOR = Color.FromArgb(121, 124, 221);
            TOOLBAR_COLOR = Color.FromArgb(121, 124, 221);
            PALETTE_COLOR = Color.FromArgb(203, 108, 147);
            ANIMATOR_COLOR = Color.FromArgb(203, 108, 147);
        }

        public static void WINDOWS98_THEME()
        {
            MAIN_BG_COLOR = Color.FromArgb(0, 128, 128);
            SECONDARY_BG_COLOR = Color.FromArgb(0, 128, 128);
            OUTLINE_COLOR = Color.FromArgb(184, 184, 184);
            TRIM_COLOR = Color.White;
            SHADOW_COLOR = Color.Black;

            BUTTON_BG_COLOR = Color.White;
            BUTTON_HOVER_COLOR = Color.FromArgb(229, 229, 229);
            BUTTON_HIGHLIGHT_COLOR = Color.FromArgb(120, 120, 120);

            TEXT_COLOR = Color.White;
            ICON_COLOR = Color.Black;

            MENUSTRIP_COLOR = Color.FromArgb(0, 0, 120);
            TOOLBAR_COLOR = Color.FromArgb(184, 184, 184);
            PALETTE_COLOR = Color.FromArgb(184, 184, 184);
            ANIMATOR_COLOR = Color.FromArgb(184, 184, 184);
        }

        public static void MODERN_THEME()
        {
            MAIN_BG_COLOR = Color.FromArgb(46, 51, 73);
            SECONDARY_BG_COLOR = Color.FromArgb(37, 42, 64);
            OUTLINE_COLOR = Color.FromArgb(5, 12, 41);
            TRIM_COLOR = Color.FromArgb(0, 126, 249);
            SHADOW_COLOR = Color.FromArgb(24, 30, 54);

            BUTTON_BG_COLOR = Color.FromArgb(74, 79, 99);
            BUTTON_HOVER_COLOR = Color.FromArgb(74, 79, 99);
            BUTTON_HIGHLIGHT_COLOR = Color.FromArgb(0, 126, 249);

            TEXT_COLOR = Color.FromArgb(158, 161, 176);
            ICON_COLOR = Color.FromArgb(158, 161, 176);

            MENUSTRIP_COLOR = Color.FromArgb(24, 30, 54);
            TOOLBAR_COLOR = Color.FromArgb(24, 30, 54);
            PALETTE_COLOR = Color.FromArgb(74, 79, 99);
            ANIMATOR_COLOR = Color.FromArgb(74, 79, 99);
        }

        public static void SPOTIFY_THEME()
        {
            MAIN_BG_COLOR = Color.FromArgb(33, 33, 33);
            SECONDARY_BG_COLOR = Color.FromArgb(33, 33, 33);
            OUTLINE_COLOR = Color.FromArgb(83, 83, 83);
            TRIM_COLOR = Color.FromArgb(29, 185, 84);
            SHADOW_COLOR = Color.Black;

            BUTTON_BG_COLOR = Color.FromArgb(33, 33, 33);
            BUTTON_HOVER_COLOR = Color.FromArgb(83, 83, 83);
            BUTTON_HIGHLIGHT_COLOR = Color.FromArgb(29, 185, 84);

            TEXT_COLOR = Color.FromArgb(179, 179, 179);
            ICON_COLOR = Color.FromArgb(179, 179, 179);

            MENUSTRIP_COLOR = Color.Black;
            TOOLBAR_COLOR = Color.Black;
            PALETTE_COLOR = Color.FromArgb(83, 83, 83);
            ANIMATOR_COLOR = Color.FromArgb(83, 83, 83);
        }
    }
}
