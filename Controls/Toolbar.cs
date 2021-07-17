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
    public partial class Toolbar : EditorControl
    {
        public Toolbar()
        {
            InitializeComponent();
        }

        private void Toolbar_Load(object sender, EventArgs e)
        {
            base.OnLoad();
        }

        protected override void UpdateTheme(object sender, EventArgs e)
        {
            toolContainer.BackColor = Themes.TOOLBAR_COLOR;
            boxOutline.BackColor = Themes.OUTLINE_COLOR;
        }

        private void buttonSelect_Load(object sender, EventArgs e)
        {
            PixelEditor.PixelEditor.Tool tool = PixelEditor.PixelEditor.Tool.SELECT;

            buttonSelect.ButtonTool = tool;
            buttonSelect.ToolCallback = () => Session.Instance.SetEditorTool(tool);
        }

        private void buttonMagic_Load(object sender, EventArgs e)
        {
            PixelEditor.PixelEditor.Tool tool = PixelEditor.PixelEditor.Tool.MAGICWAND;

            buttonMagic.ButtonTool = tool;
            buttonMagic.ToolCallback = () => Session.Instance.SetEditorTool(tool);
        }

        private void buttonEraser_Load(object sender, EventArgs e)
        {
            PixelEditor.PixelEditor.Tool tool = PixelEditor.PixelEditor.Tool.ERASER;

            buttonEraser.ButtonTool = PixelEditor.PixelEditor.Tool.ERASER;
            buttonEraser.ToolCallback = () => Session.Instance.SetEditorTool(tool);
        }

        private void buttonPencil_Load(object sender, EventArgs e)
        {
            PixelEditor.PixelEditor.Tool tool = PixelEditor.PixelEditor.Tool.PENCIL;

            buttonPencil.ButtonTool = tool;
            buttonPencil.ToolCallback = () => Session.Instance.SetEditorTool(tool);
        }

        private void buttonFill_Load(object sender, EventArgs e)
        {
            PixelEditor.PixelEditor.Tool tool = PixelEditor.PixelEditor.Tool.FILL;

            buttonFill.ButtonTool = tool;
            buttonFill.ToolCallback = () => Session.Instance.SetEditorTool(tool);
        }

        private void buttonHand_Load(object sender, EventArgs e)
        {
            PixelEditor.PixelEditor.Tool tool = PixelEditor.PixelEditor.Tool.HAND;

            buttonHand.ButtonTool = tool;
            buttonHand.ToolCallback = () => Session.Instance.SetEditorTool(tool);
        }

        private void buttonLine_Load(object sender, EventArgs e)
        {
            PixelEditor.PixelEditor.Tool tool = PixelEditor.PixelEditor.Tool.LINE;

            buttonLine.ButtonTool = tool;
            buttonLine.ToolCallback = () => Session.Instance.SetEditorTool(tool);
        }

        private void buttonDropper_Load(object sender, EventArgs e)
        {
            PixelEditor.PixelEditor.Tool tool = PixelEditor.PixelEditor.Tool.EYEDROPPER;

            buttonDropper.ButtonTool = tool;
            buttonDropper.ToolCallback = () => Session.Instance.SetEditorTool(tool);
        }

        private void buttonRectangle_Load(object sender, EventArgs e)
        {
            PixelEditor.PixelEditor.Tool tool = PixelEditor.PixelEditor.Tool.RECTANGLE;

            buttonRectangle.ButtonTool = tool;
            buttonRectangle.ToolCallback = () => Session.Instance.SetEditorTool(tool);
        }

        private void buttonEllipse_Load(object sender, EventArgs e)
        {
            PixelEditor.PixelEditor.Tool tool = PixelEditor.PixelEditor.Tool.OVAL;

            buttonEllipse.ButtonTool = tool;
            buttonEllipse.ToolCallback = () => Session.Instance.SetEditorTool(tool);
        }
    }
}
