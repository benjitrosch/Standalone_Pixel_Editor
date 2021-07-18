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
            buttonOpenPalette.BackColor = buttonNewPalette.BackColor = Themes.BUTTON_BG_COLOR;
            buttonOpenPalette.FlatAppearance.MouseOverBackColor = buttonNewPalette.FlatAppearance.MouseOverBackColor = Themes.BUTTON_HOVER_COLOR;
            buttonOpenPalette.FlatAppearance.MouseDownBackColor = buttonNewPalette.FlatAppearance.MouseDownBackColor = Themes.BUTTON_HIGHLIGHT_COLOR;
            boxShadow.BackColor = folderShadow.BackColor = fileShadow.BackColor = Themes.SHADOW_COLOR;
            boxOutline.BackColor = boxOutlineInner.BackColor = buttonOpenPalette.FlatAppearance.BorderColor = buttonNewPalette.FlatAppearance.BorderColor = Themes.OUTLINE_COLOR;
            boxOutlineWhite.BackColor = Themes.TRIM_COLOR;
        }

        private void PaletteUpdate(object sender, Color color)
        {
            PaletteColor item = new PaletteColor(color);
            layoutPalette.Controls.Add(item);
        }

        private void buttonOpenPalette_Click(object sender, EventArgs e)
        {}

        private void buttonNewPalette_Click(object sender, EventArgs e)
        {}
    }
}
