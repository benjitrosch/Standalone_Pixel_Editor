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
        private Color _selectedColor;
        private MouseButtons _mouseButton;

        public EyeDropperEventArgs(Color selectedColor, MouseButtons mouseButton)
        {
            this._selectedColor = selectedColor;
            this._mouseButton = mouseButton;
        }

        public Color SelectedColor
        {
            get
            {
                return this._selectedColor;
            }
        }

        public MouseButtons MouseButton
        {
            get
            {
                return this._mouseButton;
            }
        }
    }
}
