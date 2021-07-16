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
            ToggleOnionSkin();
            canvasPanel.Invalidate();
        }

        private void buttonOnionRight_Click(object sender, EventArgs e)
        {
            _rightOnionSkinEnabled = !_rightOnionSkinEnabled;
            ToggleOnionSkin();
            canvasPanel.Invalidate();
        }

        public void ExitApplication()
        {
            Close();
        }

        public void SelectSelectTool()
        {
            canvasPanel.PixelEditor_SetTool(PixelEditor.Tool.SELECT);
        }

        public void SelectMagicTool()
        {
            canvasPanel.PixelEditor_SetTool(PixelEditor.Tool.MAGICWAND);
        }

        public void SelectPencilTool()
        {
            canvasPanel.PixelEditor_SetTool(PixelEditor.Tool.PENCIL);
        }

        public void SelectEraserTool()
        {
            canvasPanel.PixelEditor_SetTool(PixelEditor.Tool.ERASER);
        }

        public void SelectFillTool()
        {
            canvasPanel.PixelEditor_SetTool(PixelEditor.Tool.FILL);
        }

        public void SelectHandTool()
        {
            canvasPanel.PixelEditor_SetTool(PixelEditor.Tool.HAND);
        }

        public void SelectEyedropperTool()
        {
            canvasPanel.PixelEditor_SetTool(PixelEditor.Tool.EYEDROPPER);
        }

        public void SelectLineTool()
        {
            canvasPanel.PixelEditor_SetTool(PixelEditor.Tool.LINE);
        }

        public void SelectRectangleTool()
        {
            canvasPanel.PixelEditor_SetTool(PixelEditor.Tool.RECTANGLE);
        }

        public void SelectOvalTool()
        {
            canvasPanel.PixelEditor_SetTool(PixelEditor.Tool.OVAL);
        }

        private void ToggleOnionSkin()
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
        }
    }
}
