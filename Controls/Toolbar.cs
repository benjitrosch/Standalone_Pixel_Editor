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
        private List<ToolButton> _buttons = new List<ToolButton>();

        public Toolbar()
        {
            InitializeComponent();
        }

        protected override void OnLoad()
        {
            base.OnLoad();

            _buttons.Add(buttonSelect);
            _buttons.Add(buttonMagic);
            _buttons.Add(buttonEraser);
            _buttons.Add(buttonPencil);
            _buttons.Add(buttonFill);
            _buttons.Add(buttonHand);
            _buttons.Add(buttonLine);
            _buttons.Add(buttonDropper);
            _buttons.Add(buttonRectangle);
            _buttons.Add(buttonEllipse);

            foreach (ToolButton button in _buttons)
                button.Initialize();
        }

        protected override void UpdateTheme()
        {
            toolContainer.BackColor = Themes.TOOLBAR_COLOR;
            boxOutline.BackColor = Themes.OUTLINE_COLOR;
        }

        private void buttonSelect_Load(object sender, EventArgs e)
        {
            PixelEditor.PixelEditor.Tool tool = PixelEditor.PixelEditor.Tool.SELECT;

            buttonSelect.ButtonTool = tool;
            buttonSelect.Callback = () => Session.Instance.SetEditorTool(tool);
        }

        private void buttonMagic_Load(object sender, EventArgs e)
        {
            PixelEditor.PixelEditor.Tool tool = PixelEditor.PixelEditor.Tool.MAGICWAND;

            buttonMagic.ButtonTool = tool;
            buttonMagic.Callback = () => Session.Instance.SetEditorTool(tool);
        }

        private void buttonEraser_Load(object sender, EventArgs e)
        {
            PixelEditor.PixelEditor.Tool tool = PixelEditor.PixelEditor.Tool.ERASER;

            buttonEraser.ButtonTool = PixelEditor.PixelEditor.Tool.ERASER;
            buttonEraser.Callback = () => Session.Instance.SetEditorTool(tool);
        }

        private void buttonPencil_Load(object sender, EventArgs e)
        {
            PixelEditor.PixelEditor.Tool tool = PixelEditor.PixelEditor.Tool.PENCIL;

            buttonPencil.ButtonTool = tool;
            buttonPencil.Callback = () => Session.Instance.SetEditorTool(tool);
        }

        private void buttonFill_Load(object sender, EventArgs e)
        {
            PixelEditor.PixelEditor.Tool tool = PixelEditor.PixelEditor.Tool.FILL;

            buttonFill.ButtonTool = tool;
            buttonFill.Callback = () => Session.Instance.SetEditorTool(tool);
        }

        private void buttonHand_Load(object sender, EventArgs e)
        {
            PixelEditor.PixelEditor.Tool tool = PixelEditor.PixelEditor.Tool.HAND;

            buttonHand.ButtonTool = tool;
            buttonHand.Callback = () => Session.Instance.SetEditorTool(tool);
        }

        private void buttonLine_Load(object sender, EventArgs e)
        {
            PixelEditor.PixelEditor.Tool tool = PixelEditor.PixelEditor.Tool.LINE;

            buttonLine.ButtonTool = tool;
            buttonLine.Callback = () => Session.Instance.SetEditorTool(tool);
        }

        private void buttonDropper_Load(object sender, EventArgs e)
        {
            PixelEditor.PixelEditor.Tool tool = PixelEditor.PixelEditor.Tool.EYEDROPPER;

            buttonDropper.ButtonTool = tool;
            buttonDropper.Callback = () => Session.Instance.SetEditorTool(tool);
        }

        private void buttonRectangle_Load(object sender, EventArgs e)
        {
            PixelEditor.PixelEditor.Tool tool = PixelEditor.PixelEditor.Tool.RECTANGLE;

            buttonRectangle.ButtonTool = tool;
            buttonRectangle.Callback = () => Session.Instance.SetEditorTool(tool);
        }

        private void buttonEllipse_Load(object sender, EventArgs e)
        {
            PixelEditor.PixelEditor.Tool tool = PixelEditor.PixelEditor.Tool.OVAL;

            buttonEllipse.ButtonTool = tool;
            buttonEllipse.Callback = () => Session.Instance.SetEditorTool(tool);
        }
    }
}
