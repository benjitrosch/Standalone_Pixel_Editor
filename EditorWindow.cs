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

            Session.Instance.SetEditor(this);
            Session.Instance.SetEditorTool(PixelEditor.Tool.PENCIL);
            Session.Instance.OnActiveToolChange += (_o, t) => canvasPanel.PixelEditor_SetTool(t);

            _animation = new AnimatedBitmap(new List<Frame>());
            _animation.FrameUpdated += (_o, e) => UpdateFrame(e);

            //canvasPanel.OnEyedropperChange += (_o, e) => SetEyedropperColor(e);
        }

        private void EditorWindow_Load(object sender, EventArgs e)
        {
            Frame emptyFrame = new Frame(Canvas.CreateNewCanvas(32, 32), Global.STANDARD_FRAMERATE);
            AddKeyframe(emptyFrame);

            //canvasPanel.PrimaryColor = SetColor(ref _primaryColor, buttonPrimaryColor, Color.Black);
            //canvasPanel.SecondaryColor = SetColor(ref _secondaryColor, buttonSecondaryColor, Color.White);
            canvasPanel.Zoom = 8;
            canvasPanel.PixelEditor_AddToViewport(new Size(-32, -4));
            canvasPanel.PixelEditor_SetTool(PixelEditor.Tool.PENCIL);
        }

        private void UpdateFrame(Bitmap bmp)
        {
            srcImage.Image = bmp;
            canvasPanel.APBox = srcImage;

            ToggleOnionSkin();

            canvasPanel.Invalidate();
        }

        private void canvasPanel_MouseHover(object sender, EventArgs e)
        {
            canvasPanel.Focus();
        }
    }
}
