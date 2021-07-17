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
    public partial class PaletteColor : UserControl
    {
        public PaletteColor(Color color)
        {
            InitializeComponent();
            buttonColor.BackColor = color;
        }

        private void color_MouseDown(object sender, MouseEventArgs e)
        {
            Panel paletteBtn = (Panel)sender;
            Color color = paletteBtn.BackColor;

            if (e.Button == MouseButtons.Left)
                Session.Instance.SetPrimaryColor(color);
            else if (e.Button == MouseButtons.Right)
                Session.Instance.SetSecondaryColor(color);
        }
    }
}
