using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pixel_Editor_Test_2.Controls
{
    public class ColorChangedEventArgs : EventArgs
    {
        private Color selectedColor;
        private HslColor selectedHslColor;

        public ColorChangedEventArgs(Color selectedColor)
        {
            this.selectedColor = selectedColor;
            this.selectedHslColor = HslColor.FromColor(selectedColor);
        }

        public ColorChangedEventArgs(HslColor selectedHslColor)
        {
            this.selectedColor = selectedHslColor.RgbValue;
            this.selectedHslColor = selectedHslColor;
        }

        public Color SelectedColor
        {
            get
            {
                return this.selectedColor;
            }
        }

        public HslColor SelectedHslColor
        {
            get
            {
                return this.selectedHslColor;
            }
        }
    }
}
