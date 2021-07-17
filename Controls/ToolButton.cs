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
    public partial class ToolButton : UserControl
    {
        public Image Icon { get; set; }
        public PixelEditor.PixelEditor.Tool ButtonTool { get; set; }
        public Action ToolCallback { get; set; }

        public ToolButton()
        {
            InitializeComponent();
        }

        private void ToolButton_Load(object sender, EventArgs e)
        {
            if (Icon != null)
                button.BackgroundImage = Icon;

            Session.Instance.OnActiveToolChange += (_o, t) => CheckToolSelection(t);
        }

        private void CheckToolSelection(PixelEditor.PixelEditor.Tool tool)
        {
            if (ButtonTool == tool)
                button.BackColor = Color.FromArgb(250, 203, 254);
            else
                button.BackColor = Color.White;
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (ToolCallback != null)
                ToolCallback();
        }
    }
}
