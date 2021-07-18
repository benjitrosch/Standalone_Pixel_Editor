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
    public partial class ColorPicker : EditorControl
    {
        public ColorPicker()
        {
            InitializeComponent();
        }

        private void ColorPicker_Load(object sender, EventArgs e)
        {
            base.OnLoad();
        }

        protected override void UpdateTheme(object sender, EventArgs e)
        {
            colorContainer.BackColor = Themes.BUTTON_BG_COLOR;
            boxOutline.BackColor = Themes.OUTLINE_COLOR;
            boxShadow.BackColor = Themes.SHADOW_COLOR;
        }

        private void colorSlider_ColorChanged(object sender, ColorChangedEventArgs args)
        {
            HslColor colorHSL = colorSlider.ColorHSL;
            colorBox2D.ColorHSL = colorHSL;
        }

        private void colorBox2D_MouseDown(object sender, MouseEventArgs e)
        {
            PickColor(colorBox2D.ColorHSL.RgbValue, e);
        }

        private void colorBox2D_MouseMove(object sender, MouseEventArgs e)
        {
            PickColor(colorBox2D.ColorHSL.RgbValue, e);
        }

        private void PickColor(Color color, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Session.Instance.SetPrimaryColor(color);
            else if (e.Button == MouseButtons.Right)
                Session.Instance.SetSecondaryColor(color);
        }
    }
}
