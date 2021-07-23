using Pixel_Editor_Test_2.Systems;
using Pixel_Editor_Test_2.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pixel_Editor_Test_2.Controls
{
    public partial class PaletteContainer : EditorControl
    {
        private List<Color> _colors = new List<Color>();

        public PaletteContainer()
        {
            InitializeComponent();
        }

        private void Palette_Load(object sender, EventArgs e)
        {
            base.OnLoad();
            Session.Instance.OnPaletteUpdate += PaletteUpdate;

            buttonOpenPalette.Callback = buttonOpenPalette_Click;
            buttonNewPalette.Callback = buttonNewPalette_Click;
        }

        protected override void UpdateTheme()
        {
            layoutPalette.BackColor = Themes.PALETTE_COLOR;
            boxShadow.BackColor = Themes.SHADOW_COLOR;
            boxOutline.BackColor = boxOutlineInner.BackColor = Themes.OUTLINE_COLOR;
            boxOutlineWhite.BackColor = Themes.TRIM_COLOR;
        }

        private void PaletteUpdate(object sender, Color color)
        {
            _colors.Add(color);
            PaletteColor item = new PaletteColor(color);
            layoutPalette.Controls.Add(item);
        }

        private void buttonOpenPalette_Click()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = Global.PALETTE_FILETYPE;

            // TODO: CAn totally make a genertic method for both opening and saving files... Do that next time I create a save dialog somewhere?
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Stream stream = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);

                IFormatter format = new BinaryFormatter();
                Palette palette = (Palette)format.Deserialize(stream);

                foreach (int color in palette.ColorsAsArgb)
                    Session.Instance.SaveColorToPalette(Color.FromArgb(color));
            }
        }

        private void buttonNewPalette_Click()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = Global.PALETTE_FILETYPE;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Palette palette = new Palette(_colors);
                
                Stream stream = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write);

                IFormatter format = new BinaryFormatter();
                format.Serialize(stream, palette);

                stream.Close();
            }
        }
    }
}
