using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pixel_Editor_Test_2
{
    public partial class EditorWindow : Form
    {
        private Color _primaryColor, _secondaryColor;
        private List<Color> _palette = new List<Color>();

        public EditorWindow()
        {
            InitializeComponent();

            srcImage.Image = Image.FromFile(@"C:\Users\benji\Downloads\Monkey_jump.png");
            srcImage.Width = srcImage.Image.Width * (248 / srcImage.Image.Height);
            srcImage.Height = srcImage.Image.Height * (248 / srcImage.Image.Width);
            previewContainer.Height = srcImage.Height + 32;

            canvasPanel.APBox = srcImage;
            canvasPanel.TgtBitmap = (Bitmap)canvasPanel.APBox.Image;
            canvasPanel.Coordinates = coordinatesLabel;
            canvasPanel.Selection = selectionLabel;

            canvasPanel.Zoom = 16;

            canvasPanel.PrimaryColor = SetColor(ref _primaryColor, buttonPrimaryColor, Color.Black);
            canvasPanel.SecondaryColor = SetColor(ref _secondaryColor, buttonSecondaryColor, Color.White);

            canvasPanel.PixelEditor_SetTool(PixelEditor.Tool.PENCIL);

            canvasPanel.OnEyedropperChange += (_o, e) => SetEyedropperColor(e);

            ToggleGrid(checkboxToggleGrid.Checked);
            TogglePreview(checkboxTogglePreview.Checked);
        }

        private void ExitApplication()
        {
            Close();
        }

        private void zoomBar_ValueChanged(object sender, EventArgs e)
        {
            switch(zoomCanvas.Value)
            {
                // 8 x 8
                case 0:
                    canvasPanel.Zoom = 32;
                    break;

                // 16 x 16
                case 1:
                    canvasPanel.Zoom = 16;
                    break;

                // 32 x 32
                case 2:
                    canvasPanel.Zoom = 8;
                    break;
            }
        }

        private void buttonPrimaryColor_Click(object sender, EventArgs e)
        {
            canvasPanel.PrimaryColor = ChooseColor(ref _primaryColor, buttonPrimaryColor, e);
        }

        private void buttonSecondaryColor_Click(object sender, EventArgs e)
        {
            canvasPanel.SecondaryColor = ChooseColor(ref _secondaryColor, buttonSecondaryColor, e);
        }

        private Color ChooseColor(ref Color colorRef, Button button, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color newColor = colorDialog.Color;

                return SetColor(ref colorRef, button, newColor);
            }

            return Color.Transparent;
        }

        private Color SetColor(ref Color colorRef, Button button, Color color)
        {
            colorRef = color;

            button.BackColor = color;
            button.Text = color.R + ", " + color.G + ", " + color.B;

            return color;
        }

        private void buttonSavePrimaryColor_Click(object sender, EventArgs e)
        {
            SaveColor(_primaryColor);
        }

        private void buttonSaveSeconaryColor_Click(object sender, EventArgs e)
        {
            SaveColor(_secondaryColor);
        }

        private void SaveColor(Color color)
        {
            if (_palette.Contains(color))
                return;

            _palette.Add(color);
        }

        private void buttonSwitchColors_Click(object sender, EventArgs e)
        {
            Color prevPrimary = _primaryColor;
            Color prevSecondary = _secondaryColor;

            canvasPanel.PrimaryColor = SetColor(ref _primaryColor, buttonPrimaryColor, prevSecondary);
            canvasPanel.SecondaryColor = SetColor(ref _secondaryColor, buttonSecondaryColor, prevPrimary);
        }

        private void checkboxToggleGrid_CheckStateChanged(object sender, EventArgs e)
        {
            ToggleGrid(checkboxToggleGrid.Checked);
            canvasPanel.Invalidate();
        }

        private void ToggleGrid(bool status)
        {
            canvasPanel.GridColor = status ? Color.DimGray : Color.Transparent;
        }

        private void checkboxTogglePreview_CheckStateChanged(object sender, EventArgs e)
        {
            TogglePreview(checkboxTogglePreview.Checked);
        }

        private void TogglePreview(bool status)
        {
            if (status)
                previewContainer.Show();
            else
                previewContainer.Hide();
        }

        private void buttonSelectTool_Click(object sender, EventArgs e)
        {
            SelectSelectTool();
        }

        private void SelectSelectTool()
        {
            canvasPanel.PixelEditor_SetTool(PixelEditor.Tool.SELECT);
        }

        private void buttonPencilTool_Click(object sender, EventArgs e)
        {
            SelectPencilTool();
        }

        private void SelectPencilTool()
        {
            canvasPanel.PixelEditor_SetTool(PixelEditor.Tool.PENCIL);
        }

        private void buttonEraserTool_Click(object sender, EventArgs e)
        {
            SelectEraserTool();
        }

        private void SelectEraserTool()
        {
            canvasPanel.PixelEditor_SetTool(PixelEditor.Tool.ERASER);
        }

        private void buttonFillTool_Click(object sender, EventArgs e)
        {
            SelectFillTool();
        }

        private void SelectFillTool()
        {
            canvasPanel.PixelEditor_SetTool(PixelEditor.Tool.FILL);
        }

        private void buttonHandTool_Click(object sender, EventArgs e)
        {
            SelectHandTool();
        }

        private void SelectHandTool()
        {
            canvasPanel.PixelEditor_SetTool(PixelEditor.Tool.HAND);
        }

        private void buttonEyedropper_Click(object sender, EventArgs e)
        {
            SelectEyedropperTool();
        }

        private void SelectEyedropperTool()
        {
            canvasPanel.PixelEditor_SetTool(PixelEditor.Tool.EYEDROPPER);
        }

        private void SetEyedropperColor(Color color)
        {
            buttonEyedropper.BackColor = color;
        }

        private bool mouseDown;
        private Point lastLocation;

        private void menuStrip_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void menuStrip_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point(
                    (Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);

                Update();
            }
        }

        private void menuStrip_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            ExitApplication();
        }

        private void EditorWindow_KeyDown(object sender, KeyEventArgs e)
        {
            canvasPanel.PixelEditor_KeyDown(e);

            switch(e.KeyCode)
            {
                case Keys.Escape:
                    ExitApplication();
                    break;

                case Keys.Q:
                case Keys.M:
                    SelectSelectTool();
                    break;

                case Keys.B:
                    SelectPencilTool();
                    break;

                case Keys.E:
                    SelectEraserTool();
                    break;

                case Keys.G:
                    SelectFillTool();
                    break;

                case Keys.H:
                    SelectHandTool();
                    break;

                case Keys.I:
                    SelectEyedropperTool();
                    break;
            }
        }
    }
}
