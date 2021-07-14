using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pixel_Editor_Test_2.Controls
{
    public class EyeDropperEventArgs : EventArgs
    {
        private Color selectedColor;
        private MouseButtons mouseButton;

        public EyeDropperEventArgs(Color selectedColor, MouseButtons mouseButton)
        {
            this.selectedColor = selectedColor;
            this.mouseButton = mouseButton;
        }

        public Color SelectedColor
        {
            get
            {
                return this.selectedColor;
            }
        }

        public MouseButtons MouseButton
        {
            get
            {
                return this.mouseButton;
            }
        }
    }
}
