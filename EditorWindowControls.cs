using Pixel_Editor_Test_2.Controls;
using Pixel_Editor_Test_2.Systems;
using Pixel_Editor_Test_2.Util;
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
        private bool _mouseDown;
        private Point _lastLocation;

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

        private void zoomBar_ValueChanged(object sender, EventArgs e)
        {
            canvasPanel.Zoom = zoomCanvas.Value;
        }

        private void checkboxToggleGrid_CheckStateChanged(object sender, EventArgs e)
        {
            ToggleGrid(checkboxToggleGrid.Checked);
            canvasPanel.Invalidate();
        }

        private void checkboxTogglePreview_CheckStateChanged(object sender, EventArgs e)
        {
            TogglePreview(checkboxTogglePreview.Checked);
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            ExitApplication();
        }

        private void buttonSelectTool_Click(object sender, EventArgs e)
        {
            SelectSelectTool();
        }

        private void buttonPencilTool_Click(object sender, EventArgs e)
        {
            SelectPencilTool();
        }

        private void buttonEraserTool_Click(object sender, EventArgs e)
        {
            SelectEraserTool();
        }

        private void buttonFillTool_Click(object sender, EventArgs e)
        {
            SelectFillTool();
        }

        private void buttonHandTool_Click(object sender, EventArgs e)
        {
            SelectHandTool();
        }

        private void buttonEyedropperTool_Click(object sender, EventArgs e)
        {
            SelectEyedropperTool();
        }

        private void buttonLineTool_Click(object sender, EventArgs e)
        {
            SelectLineTool();
        }

        private void buttonRectangleTool_Click(object sender, EventArgs e)
        {
            SelectRectangleTool();
        }

        private void buttonOvalTool_Click(object sender, EventArgs e)
        {
            SelectOvalTool();
        }

        private void canvasPanel_MouseHover(object sender, EventArgs e)
        {
            canvasPanel.Focus();
        }

        private bool _leftOnionSkinEnabled = false;
        private bool _rightOnionSkinEnabled = false;

        private void buttonOnionLeft_Click(object sender, EventArgs e)
        {
            _leftOnionSkinEnabled = !_leftOnionSkinEnabled;
            ToggleOnionSkin();
            canvasPanel.Invalidate();
        }

        private void buttonOnionRight_Click(object sender, EventArgs e)
        {
            _rightOnionSkinEnabled = !_rightOnionSkinEnabled;
            ToggleOnionSkin();
            canvasPanel.Invalidate();
        }
    }
}
