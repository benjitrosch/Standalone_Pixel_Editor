using Pixel_Editor_Test_2.Controls;
using Pixel_Editor_Test_2.Controls.PixelEditor;
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
        private bool _leftOnionSkinEnabled = false;
        private bool _rightOnionSkinEnabled = false;

        private void buttonOnionLeft_Click(object sender, EventArgs e)
        {
            _leftOnionSkinEnabled = !_leftOnionSkinEnabled;
            //ToggleOnionSkin();
            canvasPanel.Invalidate();
        }

        private void buttonOnionRight_Click(object sender, EventArgs e)
        {
            _rightOnionSkinEnabled = !_rightOnionSkinEnabled;
            //ToggleOnionSkin();
            canvasPanel.Invalidate();
        }

        public void ExitApplication()
        {
            Close();
        }

        public void SelectSelectTool()
        {
            Session.Instance.SetEditorTool(PixelEditor.Tool.SELECT);
        }

        public void SelectMagicTool()
        {
            Session.Instance.SetEditorTool(PixelEditor.Tool.MAGICWAND);
        }

        public void SelectPencilTool()
        {
            Session.Instance.SetEditorTool(PixelEditor.Tool.PENCIL);
        }

        public void SelectEraserTool()
        {
            Session.Instance.SetEditorTool(PixelEditor.Tool.ERASER);
        }

        public void SelectFillTool()
        {
            Session.Instance.SetEditorTool(PixelEditor.Tool.FILL);
        }

        public void SelectHandTool()
        {
            Session.Instance.SetEditorTool(PixelEditor.Tool.HAND);
        }

        public void SelectEyedropperTool()
        {
            Session.Instance.SetEditorTool(PixelEditor.Tool.EYEDROPPER);
        }

        public void SelectLineTool()
        {
            Session.Instance.SetEditorTool(PixelEditor.Tool.LINE);
        }

        public void SelectRectangleTool()
        {
            Session.Instance.SetEditorTool(PixelEditor.Tool.RECTANGLE);
        }

        public void SelectOvalTool()
        {
            Session.Instance.SetEditorTool(PixelEditor.Tool.OVAL);
        }

        /*private void ToggleOnionSkin()
        {
            if (_leftOnionSkinEnabled)
            {
                if (_animation.CurrentFrame > 0)
                {
                    canvasPanel.OnionSkin = _animation.GetFrameByIndex(_animation.CurrentFrame - 1).Image;
                }
            }
            else if (_rightOnionSkinEnabled)
            {
                if (_animation.CurrentFrame < _animation.TotalFrames - 1)
                {
                    canvasPanel.OnionSkin = _animation.GetFrameByIndex(_animation.CurrentFrame + 1).Image;
                }
            }
            else
            {
                canvasPanel.OnionSkin = null;
            }
        }*/
    }
}
