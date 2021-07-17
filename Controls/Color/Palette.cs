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
    public partial class Palette : EditorControl
    {
        public Palette()
        {
            InitializeComponent();
        }

        private void Palette_Load(object sender, EventArgs e)
        {
            base.OnLoad();
            Session.Instance.OnPaletteUpdate += PaletteUpdate;
        }

        protected override void UpdateTheme(object sender, EventArgs e)
        {
            layoutPalette.BackColor = Themes.PALETTE_COLOR;
            boxShadow.BackColor = Themes.SHADOW_COLOR;
            boxOutline.BackColor = boxOutlineInner.BackColor = Themes.OUTLINE_COLOR;
            boxOutlineWhite.BackColor = Themes.TRIM_COLOR;
        }

        private void PaletteUpdate(object sender, Color color)
        {
            PaletteColor item = new PaletteColor(color);
            layoutPalette.Controls.Add(item);
        }
    }
}
