using Pixel_Editor_Test_2.Systems;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pixel_Editor_Test_2.Controls
{
    public partial class EditorButton : EditorControl
    {
        public Image Icon { get; set; }
        public Action Callback { get; set; }

        public EditorButton()
        {
            InitializeComponent();
        }

        protected virtual void EditorButton_Load(object sender, EventArgs e)
        {
            base.OnLoad();
            if (Icon != null)
                button.BackgroundImage = Icon;
        }

        protected override void UpdateTheme(object sender, EventArgs e)
        {
            BackColor = Themes.TOOLBAR_COLOR;
            boxShadow.BackColor = Themes.SHADOW_COLOR;
            button.BackColor = Themes.BUTTON_BG_COLOR;
            button.FlatAppearance.BorderColor = Themes.OUTLINE_COLOR;
            button.FlatAppearance.MouseOverBackColor = Themes.BUTTON_HOVER_COLOR;
            button.FlatAppearance.MouseDownBackColor = Themes.BUTTON_HOVER_COLOR;

            if (button.ForeColor != Themes.ICON_COLOR)
            {
                Bitmap bmp = new Bitmap(Icon);

                for (int x = 0; x < bmp.Width; x++)
                {
                    for (int y = 0; y < bmp.Height; y++)
                    {
                        if (bmp.GetPixel(x, y).ToArgb() == button.ForeColor.ToArgb())
                        {
                            bmp.SetPixel(x, y, Themes.ICON_COLOR);
                        }
                    }
                }

                button.ForeColor = Themes.ICON_COLOR;
                button.BackgroundImage = bmp;
            }
        }

        protected virtual void button_Click(object sender, EventArgs e)
        {
            if (Callback != null)
                Callback();
        }
    }
}
