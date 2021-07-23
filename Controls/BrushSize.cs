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
    public partial class BrushSize : EditorControl
    {
        public BrushSize()
        {
            InitializeComponent();
        }

        protected override void UpdateTheme()
        {
            boxContainer.BackColor = trackBar.BackColor = Themes.BUTTON_BG_COLOR;
            boxOutline.BackColor = Themes.OUTLINE_COLOR;
        }

        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            Session.Instance.BrushSize = trackBar.Value;
        }
    }
}
