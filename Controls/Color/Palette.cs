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
    public partial class Palette : UserControl
    {
        public Palette()
        {
            InitializeComponent();
        }

        private void Palette_Load(object sender, EventArgs e)
        {
            Session.Instance.OnPaletteUpdate += PaletteUpdate;
        }

        private void PaletteUpdate(object sender, Color color)
        {
            PaletteColor item = new PaletteColor(color);
            layoutPalette.Controls.Add(item);
        }
    }
}
