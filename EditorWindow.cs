using Pixel_Editor_Test_2.Animation;
using Pixel_Editor_Test_2.Controls;
using Pixel_Editor_Test_2.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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
        private Color[] _palette = new Color[64];

        private AnimatedBitmap _animation;

        public EditorWindow()
        {
            InitializeComponent();

            Frame emptyFrame = new Frame(Canvas.CreateNewCanvas(32, 32), 83);

            _animation = new AnimatedBitmap(new List<Frame>() { emptyFrame });
            _animation.FrameUpdated += (_o, e) => UpdateFrame(e);

            UpdateFrame(_animation.GetFrameByIndex(0).Image);

            canvasPanel.Coordinates = coordinatesLabel;
            canvasPanel.Selection = selectionLabel;

            canvasPanel.Zoom = 8;
            canvasPanel.PixelEditor_AddToViewport(new Size(-32, -4));

            canvasPanel.PrimaryColor = SetColor(ref _primaryColor, buttonPrimaryColor, Color.Black);
            canvasPanel.SecondaryColor = SetColor(ref _secondaryColor, buttonSecondaryColor, Color.White);

            canvasPanel.PixelEditor_SetTool(PixelEditor.Tool.PENCIL);

            canvasPanel.OnEyedropperChange += (_o, e) => SetEyedropperColor(e);

            ToggleGrid(checkboxToggleGrid.Checked);
            TogglePreview(checkboxTogglePreview.Checked);
        }

        private void UpdateFrame(Bitmap bmp)
        {
            srcImage.Image = bmp;
            canvasPanel.APBox = srcImage;
            canvasPanel.TgtBitmap = (Bitmap)canvasPanel.APBox.Image;
            canvasPanel.Invalidate();
        }

        private void ExitApplication()
        {
            Close();
        }

        private void zoomBar_ValueChanged(object sender, EventArgs e)
        {
            canvasPanel.Zoom = zoomCanvas.Value;
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

            int openSlot = Array.FindIndex(_palette, c => c.IsEmpty);
            if (openSlot == -1)
                return;

            _palette[openSlot] = color;

            UpdatePalette();
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

        private void buttonEyedropperTool_Click(object sender, EventArgs e)
        {
            SelectEyedropperTool();
        }

        private void SelectEyedropperTool()
        {
            canvasPanel.PixelEditor_SetTool(PixelEditor.Tool.EYEDROPPER);
        }

        private void SetEyedropperColor(EyeDropperEventArgs e)
        {
            if (e.MouseButton == MouseButtons.Left)
                canvasPanel.PrimaryColor = SetColor(ref _primaryColor, buttonPrimaryColor, e.SelectedColor);
            else if (e.MouseButton == MouseButtons.Right)
                canvasPanel.SecondaryColor = SetColor(ref _secondaryColor, buttonSecondaryColor, e.SelectedColor);
        }

        private void buttonLineTool_Click(object sender, EventArgs e)
        {
            SelectLineTool();
        }

        private void SelectLineTool()
        {
            canvasPanel.PixelEditor_SetTool(PixelEditor.Tool.LINE);
        }

        private void buttonRectangleTool_Click(object sender, EventArgs e)
        {
            SelectRectangleTool();
        }

        private void SelectRectangleTool()
        {
            canvasPanel.PixelEditor_SetTool(PixelEditor.Tool.RECTANGLE);
        }

        private void buttonOvalTool_Click(object sender, EventArgs e)
        {
            SelectOvalTool();
        }

        private void SelectOvalTool()
        {
            canvasPanel.PixelEditor_SetTool(PixelEditor.Tool.OVAL);
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
                    //ExitApplication();
                    break;

                case Keys.S:
                    if (e.Control)
                    {
                        SaveFileDialog sfd = new SaveFileDialog();
                        sfd.Filter = "Sprite|*.png";

                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            Bitmap bmp = (Bitmap)canvasPanel.APBox.Image;
                            bmp.Save(sfd.FileName, ImageFormat.Png);
                        }
                    }
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

                case Keys.F:
                case Keys.G:
                    SelectFillTool();
                    break;

                case Keys.H:
                    SelectHandTool();
                    break;

                case Keys.I:
                    SelectEyedropperTool();
                    break;

                case Keys.L:
                    SelectLineTool();
                    break;

                case Keys.R:
                    SelectRectangleTool();
                    break;

                case Keys.O:
                    SelectOvalTool();
                    break;
            }
        }

        private void EditorWindow_KeyUp(object sender, KeyEventArgs e)
        {
            canvasPanel.PixelEditor_KeyUp(e);
        }

        private void colorBox2D_MouseDown(object sender, MouseEventArgs e)
        {
            PickColor(colorBox2D.ColorHSL.RgbValue, e);
        }

        private void colorBox2D_MouseMove(object sender, MouseEventArgs e)
        {
            PickColor(colorBox2D.ColorHSL.RgbValue, e);
        }

        private void PickColor(Color color, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                canvasPanel.PrimaryColor = SetColor(ref _primaryColor, buttonPrimaryColor, color);
            if (e.Button == MouseButtons.Right)
                canvasPanel.SecondaryColor = SetColor(ref _secondaryColor, buttonSecondaryColor, color);
        }

        private void colorSlider_ColorChanged(object sender, ColorChangedEventArgs args)
        {
            HslColor colorHSL = colorSlider.ColorHSL;
            colorBox2D.ColorHSL = colorHSL;
        }

        private void canvasPanel_MouseHover(object sender, EventArgs e)
        {
            canvasPanel.Focus();
        }

        private void paletteButton_Click(object sender, MouseEventArgs e)
        {
            Panel paletteBtn = sender as Panel;

            if (e.Button == MouseButtons.Left)
                canvasPanel.PrimaryColor = SetColor(ref _primaryColor, buttonPrimaryColor, paletteBtn.BackColor);
            else if (e.Button == MouseButtons.Right)
                canvasPanel.SecondaryColor = SetColor(ref _secondaryColor, buttonSecondaryColor, paletteBtn.BackColor);
        }

        private void buttonPlayAnimation_Click(object sender, EventArgs e)
        {
            _animation.PlayAnimation();
        }

        private void buttonPauseAnimation_Click(object sender, EventArgs e)
        {
            _animation.PauseAnimation();
        }

        private void buttonAddEmptyFrame_Click(object sender, EventArgs e)
        {
            _animation.AddFrame(new Frame(Canvas.CreateNewCanvas(32, 32), 83));
            UpdateFrame(_animation.GetLastFrame().Image);
        }

        private void buttonAddCopyFrame_Click(object sender, EventArgs e)
        {
            _animation.AddFrame(new Frame(new Bitmap(_animation.GetLastFrame().Image), 83));
            UpdateFrame(_animation.GetLastFrame().Image);
        }

        private void UpdatePalette()
        {
            // sorry :-)
            palette00.BackColor = _palette[0];
            palette01.BackColor = _palette[1];
            palette02.BackColor = _palette[2];
            palette03.BackColor = _palette[3];
            palette04.BackColor = _palette[4];
            palette05.BackColor = _palette[5];
            palette06.BackColor = _palette[6];
            palette07.BackColor = _palette[7];
            palette08.BackColor = _palette[8];
            palette09.BackColor = _palette[9];
            palette10.BackColor = _palette[10];
            palette11.BackColor = _palette[11];
            palette12.BackColor = _palette[12];
            palette13.BackColor = _palette[13];
            palette14.BackColor = _palette[14];
            palette15.BackColor = _palette[15];
            palette16.BackColor = _palette[16];
            palette17.BackColor = _palette[17];
            palette18.BackColor = _palette[18];
            palette19.BackColor = _palette[19];
            palette20.BackColor = _palette[20];
            palette21.BackColor = _palette[21];
            palette22.BackColor = _palette[22];
            palette23.BackColor = _palette[23];
            palette24.BackColor = _palette[24];
            palette25.BackColor = _palette[25];
            palette26.BackColor = _palette[26];
            palette27.BackColor = _palette[27];
            palette28.BackColor = _palette[28];
            palette29.BackColor = _palette[29];
            palette30.BackColor = _palette[30];
            palette31.BackColor = _palette[31];
            palette32.BackColor = _palette[32];
            palette33.BackColor = _palette[33];
            palette34.BackColor = _palette[34];
            palette35.BackColor = _palette[35];
            palette36.BackColor = _palette[36];
            palette37.BackColor = _palette[37];
            palette38.BackColor = _palette[38];
            palette39.BackColor = _palette[39];
            palette40.BackColor = _palette[40];
            palette41.BackColor = _palette[41];
            palette42.BackColor = _palette[42];
            palette43.BackColor = _palette[43];
            palette44.BackColor = _palette[44];
            palette45.BackColor = _palette[45];
            palette46.BackColor = _palette[46];
            palette47.BackColor = _palette[47];
            palette48.BackColor = _palette[48];
            palette49.BackColor = _palette[49];
            palette50.BackColor = _palette[50];
            palette51.BackColor = _palette[51];
            palette52.BackColor = _palette[52];
            palette53.BackColor = _palette[53];
            palette54.BackColor = _palette[54];
            palette55.BackColor = _palette[55];
            palette56.BackColor = _palette[56];
            palette57.BackColor = _palette[57];
            palette58.BackColor = _palette[58];
            palette59.BackColor = _palette[59];
            palette60.BackColor = _palette[60];
            palette61.BackColor = _palette[61];
            palette62.BackColor = _palette[62];
            palette63.BackColor = _palette[63];
        }
    }
}
