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
    public partial class Titlebar : EditorControl
    {
        private bool _mouseDown;
        private Point _lastLocation;

        public Titlebar()
        {
            InitializeComponent();
        }

        private void Titlebar_Load(object sender, EventArgs e)
        {
            base.OnLoad();
        }

        protected override void UpdateTheme(object sender, EventArgs e)
        {
            menuStrip.BackColor = buttonExit.BackColor =  Themes.MENUSTRIP_COLOR;
            menuOutline.BackColor = Themes.OUTLINE_COLOR;
            menuStrip.ForeColor = buttonExit.ForeColor = Themes.TEXT_COLOR;
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
                Session.Instance.Editor.Location = new Point(
                    (Session.Instance.Editor.Location.X - _lastLocation.X) + e.X, (Session.Instance.Editor.Location.Y - _lastLocation.Y) + e.Y);

                Session.Instance.Editor.Update();
            }
        }

        private void menuStrip_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDown = false;
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Session.Instance.SetEditorTheme(Themes.DEFAULT_THEME);
        }

        private void floraleShoppeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Session.Instance.SetEditorTheme(Themes.FLORALSHOPPE_THEME);
        }

        private void windows98ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Session.Instance.SetEditorTheme(Themes.WINDOWS98_THEME);
        }

        private void modenrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Session.Instance.SetEditorTheme(Themes.MODERN_THEME);
        }
    }
}
