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
    public partial class ToolButton : EditorControl
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
            base.OnLoad();
            if (Icon != null)
                button.BackgroundImage = Icon;

            Session.Instance.OnActiveToolChange += (_o, t) => CheckToolSelection(t);
        }

        protected override void UpdateTheme(object sender, EventArgs e)
        {
            BackColor = Themes.TOOLBAR_COLOR;
            boxShadow.BackColor = Themes.SHADOW_COLOR;
            button.BackColor = Themes.BUTTON_BG_COLOR;
            button.FlatAppearance.BorderColor = Themes.OUTLINE_COLOR;
            button.FlatAppearance.MouseOverBackColor = Themes.BUTTON_HOVER_COLOR;
            button.FlatAppearance.MouseDownBackColor = Themes.BUTTON_HOVER_COLOR;
        }

        private void CheckToolSelection(PixelEditor.PixelEditor.Tool tool)
        {
            if (ButtonTool == tool)
                button.BackColor = Themes.BUTTON_HIGHLIGHT_COLOR;
            else
                button.BackColor = Themes.BUTTON_BG_COLOR;
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (ToolCallback != null)
                ToolCallback();
        }
    }
}
