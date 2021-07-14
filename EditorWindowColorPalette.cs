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

            colorBox2D.ColorHSL = new HslColor(color);

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

            UpdatePalette();
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
            HslColor colorHSL = colorSlider.ColorHSL;
            colorBox2D.ColorHSL = colorHSL;
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
