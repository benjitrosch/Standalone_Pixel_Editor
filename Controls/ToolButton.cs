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
    public partial class ToolButton : EditorButton
    {
        public PixelEditor.PixelEditor.Tool ButtonTool { get; set; }

        public ToolButton()
        {
            InitializeComponent();
        }

        protected override void OnLoad()
        {
            base.OnLoad();
            Session.Instance.OnActiveToolChange += (_o, t) => CheckToolSelection(t);
        }

        private void CheckToolSelection(PixelEditor.PixelEditor.Tool tool)
        {
            if (ButtonTool == tool)
                button.BackColor = Themes.BUTTON_HIGHLIGHT_COLOR;
            else
                button.BackColor = Themes.BUTTON_BG_COLOR;
        }
    }
}
