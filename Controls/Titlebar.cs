using Pixel_Editor_Test_2.Systems;
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
    public partial class Titlebar : UserControl
    {
        private bool _mouseDown;
        private Point _lastLocation;

        public Titlebar()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Session.Instance.Editor.ExitApplication();
        }

        private void menuStrip_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true;
            _lastLocation = e.Location;
        }

        private void menuStrip_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown)
            {
                Location = new Point(
                    (Location.X - _lastLocation.X) + e.X, (Location.Y - _lastLocation.Y) + e.Y);

                Update();
            }
        }

        private void menuStrip_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDown = false;
        }
    }
}
