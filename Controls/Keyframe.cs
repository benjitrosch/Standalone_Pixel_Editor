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
    public partial class Keyframe : UserControl
    {
        public int FrameIndex { get; private set; }

        public Keyframe(int index)
        {
            InitializeComponent();
            FrameIndex = index;
        }

        private void Keyframe_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(158, 161, 176);
        }

        private void Keyframe_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(74, 79, 99);
        }
    }
}
