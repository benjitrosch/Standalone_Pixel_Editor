﻿using Pixel_Editor_Test_2.Systems;
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
    public partial class ActiveColors : EditorControl
    {
        public ActiveColors()
        {
            InitializeComponent();
        }

        protected override void OnLoad()
        {
            base.OnLoad();
            Session.Instance.OnPrimaryColorChange += PrimaryColorChange;
            Session.Instance.OnSecondaryColorChange += SecondaryColorChange;

            PrimaryColorChange(null, Session.Instance.PrimaryColor);
            SecondaryColorChange(null, Session.Instance.SecondaryColor);
        }

        protected override void UpdateTheme()
        {
            boxContainer.BackColor = primaryContainer.BackColor = secondaryContainer.BackColor = Themes.BUTTON_BG_COLOR;
            boxOutline.BackColor = Themes.OUTLINE_COLOR;
            boxShadow.BackColor = Themes.SHADOW_COLOR;
        }

        private void PrimaryColorChange(object sender, Color color)
        {
            buttonPrimaryColor.BackColor = color;
            buttonPrimaryColor.Text = color.R + ", " + color.G + ", " + color.B;
            buttonPrimaryColor.ForeColor = color.GetBrightness() >= .5f ? Color.Black : Color.White;
        }

        private void SecondaryColorChange(object sender, Color color)
        {
            buttonSecondaryColor.BackColor = color;
            buttonSecondaryColor.Text = color.R + ", " + color.G + ", " + color.B;
            buttonSecondaryColor.ForeColor = color.GetBrightness() >= .5f ? Color.Black : Color.White;
        }

        private void buttonSavePrimaryColor_Click(object sender, EventArgs e)
        {
            Session.Instance.SaveColorToPalette(buttonPrimaryColor.BackColor);
        }

        private void buttonSaveSecondaryColor_Click(object sender, EventArgs e)
        {
            Session.Instance.SaveColorToPalette(buttonSecondaryColor.BackColor);
        }
    }
}
