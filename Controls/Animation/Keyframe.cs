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
            labelIndex.Text = FrameIndex.ToString();
        }

        private void Keyframe_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Color color = Color.Black;

            using (Pen p = new Pen(color, 1))
            using (Brush b = new SolidBrush(color))
            {
                Rectangle rect = new Rectangle(new Point(4, 21), new Size(8, 8));
                g.DrawEllipse(p, rect);
                g.FillEllipse(b, rect);
            }

            ControlPaint.DrawBorder(g,
                                    ClientRectangle,
                                    color,
                                    1,
                                    ButtonBorderStyle.Solid,
                                    color,
                                    1,
                                    ButtonBorderStyle.Solid,
                                    color,
                                    1,
                                    ButtonBorderStyle.Solid,
                                    color,
                                    1,
                                    ButtonBorderStyle.Solid);
        }

        private void Keyframe_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(250, 203, 254);
        }

        private void Keyframe_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}
