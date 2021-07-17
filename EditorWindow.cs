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
        public EditorWindow()
        {
            InitializeComponent();
        }

        private void EditorWindow_Load(object sender, EventArgs e)
        {

            Session.Instance.SetEditor(this);
            Session.Instance.OnChangeTheme += UpdateTheme;
            Session.Instance.SetEditorTheme(Themes.DEFAULT_THEME);
            Session.Instance.SetEditorTool(PixelEditor.Tool.PENCIL);
            Session.Instance.SetPrimaryColor(Color.Black);
            Session.Instance.SetSecondaryColor(Color.White);
            Session.Instance.BrushSize = 1;

            AnimatedBitmap animation = Session.Instance.CreateNewAnimation();
            animation.FrameUpdated += (_o, f) => UpdateFrame(f);
            Frame emptyFrame = new Frame(Canvas.CreateNewCanvas(32, 32), Global.STANDARD_FRAMERATE);
            Session.Instance.AddKeyframe(emptyFrame);

            canvasPanel.Zoom = 8;
            canvasPanel.PixelEditor_AddToViewport(new Size(-32, -4));
            canvasPanel.OnEyedropperChange += (_o, i) => SetEyedropperColor(i);
        }

        private void UpdateTheme(object sender, EventArgs e)
        {
            BackColor = Themes.OUTLINE_COLOR;
            canvasContainer.BackColor = colorContainer.BackColor = Themes.MAIN_BG_COLOR;
            canvasOutline.BackColor = colorOutline.BackColor = Themes.OUTLINE_COLOR;
        }

        private void UpdateFrame(Bitmap bmp)
        {
            srcImage.Image = bmp;
            canvasPanel.APBox = srcImage;

            //ToggleOnionSkin();

            canvasPanel.Invalidate();
        }

        private void canvasPanel_MouseHover(object sender, EventArgs e)
        {
            canvasPanel.Focus();
        }

        private void SetEyedropperColor(EyeDropperEventArgs e)
        {
            if (e.MouseButton == MouseButtons.Left)
                Session.Instance.SetPrimaryColor(e.SelectedColor);
            else if (e.MouseButton == MouseButtons.Right)
                Session.Instance.SetSecondaryColor(e.SelectedColor);
        }
    }
}
