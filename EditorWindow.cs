using Pixel_Editor_Test_2.Controls;
using Pixel_Editor_Test_2.Controls.PixelEditor;
using Pixel_Editor_Test_2.Systems;
using Pixel_Editor_Test_2.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pixel_Editor_Test_2
{
    public partial class EditorWindow : Form
    {
        private Color _primaryColor, _secondaryColor;
        private Color[] _palette = new Color[64];

        private AnimatedBitmap _animation;

        public EditorWindow()
        {
            InitializeComponent();

            Frame emptyFrame = new Frame(Canvas.CreateNewCanvas(32, 32), Global.STANDARD_FRAMERATE);

            _animation = new AnimatedBitmap(new List<Frame>() { emptyFrame });
            _animation.FrameUpdated += (_o, e) => UpdateFrame(e);

            _animation.GotoFrame(0);

            canvasPanel.Coordinates = coordinatesLabel;
            canvasPanel.Selection = selectionLabel;

            canvasPanel.Zoom = 8;
            canvasPanel.PixelEditor_AddToViewport(new Size(-32, -4));

            canvasPanel.PrimaryColor = SetColor(ref _primaryColor, buttonPrimaryColor, Color.Black);
            canvasPanel.SecondaryColor = SetColor(ref _secondaryColor, buttonSecondaryColor, Color.White);
            canvasPanel.PixelEditor_SetTool(PixelEditor.Tool.PENCIL);
            canvasPanel.OnEyedropperChange += (_o, e) => SetEyedropperColor(e);

            ToggleGrid(checkboxToggleGrid.Checked);
            TogglePreview(checkboxTogglePreview.Checked);
        }

        private void UpdateFrame(Bitmap bmp)
        {
            srcImage.Image = bmp;
            canvasPanel.APBox = srcImage;

            ToggleOnionSkin();

            if (numericFrame.InvokeRequired)
            {
                numericFrame.Invoke(new MethodInvoker(delegate { numericFrame.Value = _animation.CurrentFrame; }));
            }

            canvasPanel.Invalidate();
        }

        private void ExitApplication()
        {
            Close();
        }

        private void ToggleGrid(bool status)
        {
            canvasPanel.GridColor = status ? Color.DimGray : Color.Transparent;
        }

        private void TogglePreview(bool status)
        {
            if (status)
                previewContainer.Show();
            else
                previewContainer.Hide();
        }

        private void SelectSelectTool()
        {
            canvasPanel.PixelEditor_SetTool(PixelEditor.Tool.SELECT);
        }

        private void SelectMagicTool()
        {
            canvasPanel.PixelEditor_SetTool(PixelEditor.Tool.MAGICWAND);
        }

        private void SelectPencilTool()
        {
            canvasPanel.PixelEditor_SetTool(PixelEditor.Tool.PENCIL);
        }

        private void SelectEraserTool()
        {
            canvasPanel.PixelEditor_SetTool(PixelEditor.Tool.ERASER);
        }

        private void SelectFillTool()
        {
            canvasPanel.PixelEditor_SetTool(PixelEditor.Tool.FILL);
        }

        private void SelectHandTool()
        {
            canvasPanel.PixelEditor_SetTool(PixelEditor.Tool.HAND);
        }

        private void SelectEyedropperTool()
        {
            canvasPanel.PixelEditor_SetTool(PixelEditor.Tool.EYEDROPPER);
        }

        private void SelectLineTool()
        {
            canvasPanel.PixelEditor_SetTool(PixelEditor.Tool.LINE);
        }

        private void SelectRectangleTool()
        {
            canvasPanel.PixelEditor_SetTool(PixelEditor.Tool.RECTANGLE);
        }

        private void SelectOvalTool()
        {
            canvasPanel.PixelEditor_SetTool(PixelEditor.Tool.OVAL);
        }

        Label[] lbl;

        int n = 4;
        int space = 20;

        private void button1_Click(object sender, EventArgs e)
        {
            lbl = new Label[n];

            for (int i = 0; i < n; i++)
            {
                lbl[i] = new Label();
                lbl[i].Name = "n" + i;
                lbl[i].Text = "n" + i;
            }

            for (int i = 0; i < n; i++)
            {
                lbl[i].Visible = true;
                lbl[i].Location = new Point(456 + space, 45);
                lbl[i].ForeColor = Color.White;
                lbl[i].BringToFront();
                this.Controls.Add(lbl[i]);
                space += 50;
            }
        }

        private void ToggleOnionSkin()
        {
            if (_leftOnionSkinEnabled)
            {
                if (_animation.CurrentFrame > 0)
                {
                    canvasPanel.OnionSkin = _animation.GetFrameByIndex(_animation.CurrentFrame - 1).Image;
                }
            } else if (_rightOnionSkinEnabled)
            {
                if (_animation.CurrentFrame < _animation.TotalFrames - 1)
                {
                    canvasPanel.OnionSkin = _animation.GetFrameByIndex(_animation.CurrentFrame + 1).Image;
                }
            } else
            {
                canvasPanel.OnionSkin = null;
            }
        }
    }
}
