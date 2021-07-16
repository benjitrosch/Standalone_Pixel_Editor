using Pixel_Editor_Test_2.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pixel_Editor_Test_2
{
    public partial class EditorWindow
    {   
        private Color SetColor(ref Color colorRef, Button button, Color color)
        {
            colorRef = color;

            button.BackColor = color;
            button.Text = color.R + ", " + color.G + ", " + color.B;

            //colorBox2D.ColorHSL = new HslColor(color);

            return color;
        }

        private void SaveColor(Color color)
        {
            if (_palette.Contains(color))
                return;

            int openSlot = Array.FindIndex(_palette, c => c.IsEmpty);
            if (openSlot == -1)
                return;

            _palette[openSlot] = color;

            //UpdatePalette();
        }

        private void buttonPrimaryColor_Click(object sender, EventArgs e)
        {}

        private void buttonSecondaryColor_Click(object sender, EventArgs e)
        {}

        private void buttonSavePrimaryColor_Click(object sender, EventArgs e)
        {
            SaveColor(_primaryColor);
        }

        private void buttonSaveSeconaryColor_Click(object sender, EventArgs e)
        {
            SaveColor(_secondaryColor);
        }

        private void buttonSwitchColors_Click(object sender, EventArgs e)
        {
            Color prevPrimary = _primaryColor;
            Color prevSecondary = _secondaryColor;

            canvasPanel.PrimaryColor = SetColor(ref _primaryColor, buttonPrimaryColor, prevSecondary);
            canvasPanel.SecondaryColor = SetColor(ref _secondaryColor, buttonSecondaryColor, prevPrimary);
        }

        private void colorSlider_ColorChanged(object sender, ColorChangedEventArgs args)
        {
            //HslColor colorHSL = colorSlider.ColorHSL;
            //colorBox2D.ColorHSL = colorHSL;
        }

        private void colorBox2D_MouseDown(object sender, MouseEventArgs e)
        {
            //PickColor(colorBox2D.ColorHSL.RgbValue, e);
        }

        private void colorBox2D_MouseMove(object sender, MouseEventArgs e)
        {
            //PickColor(colorBox2D.ColorHSL.RgbValue, e);
        }

        private void PickColor(Color color, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                canvasPanel.PrimaryColor = SetColor(ref _primaryColor, buttonPrimaryColor, color);
            if (e.Button == MouseButtons.Right)
                canvasPanel.SecondaryColor = SetColor(ref _secondaryColor, buttonSecondaryColor, color);
        }

        private void SetEyedropperColor(EyeDropperEventArgs e)
        {
            if (e.MouseButton == MouseButtons.Left)
                canvasPanel.PrimaryColor = SetColor(ref _primaryColor, buttonPrimaryColor, e.SelectedColor);
            else if (e.MouseButton == MouseButtons.Right)
                canvasPanel.SecondaryColor = SetColor(ref _secondaryColor, buttonSecondaryColor, e.SelectedColor);
        }

        private void paletteButton_Click(object sender, MouseEventArgs e)
        {
            Panel paletteBtn = sender as Panel;

            if (e.Button == MouseButtons.Left)
                canvasPanel.PrimaryColor = SetColor(ref _primaryColor, buttonPrimaryColor, paletteBtn.BackColor);
            else if (e.Button == MouseButtons.Right)
                canvasPanel.SecondaryColor = SetColor(ref _secondaryColor, buttonSecondaryColor, paletteBtn.BackColor);
        }
    }
}
