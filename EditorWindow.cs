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
        private List<EditorControl> _controls = new List<EditorControl>();

        public EditorWindow()
        {
            InitializeComponent();
        }

        private void EditorWindow_Load(object sender, EventArgs e)
        {
            Session.Instance.OnChangeTheme += UpdateTheme;

            Session.Instance.InitializeSession(this, new AnimatedBitmap());

            Session.Instance.SetEditorTheme(Themes.DEFAULT_THEME);
            Session.Instance.SetEditorTool(PixelEditor.Tool.PENCIL);
            Session.Instance.SetPrimaryColor(Color.Black);
            Session.Instance.SetSecondaryColor(Color.White);
            Session.Instance.BrushSize = 1;

            Session.Instance.Animation.OnFrameChanged += (_o, f) => UpdateFrame(f);
            Session.Instance.Animation.AddFrame(new Frame(Canvas.CreateNewCanvas(32, 32), Global.STANDARD_FRAMERATE));

            canvasPanel.Zoom = 8;
            canvasPanel.PixelEditor_AddToViewport(new Size(-32, -4));
            canvasPanel.OnEyedropperChange += (_o, i) => SetEyedropperColor(i);

            InitializeControls();
        }

        private void InitializeControls()
        {
            _controls.Add(titlebar);
            _controls.Add(keyframeContainer);
            _controls.Add(palette);
            _controls.Add(colorPicker);
            _controls.Add(activeColors);
            _controls.Add(toolbar);

            foreach (EditorControl control in _controls)
                control.Initialize();
        }

        private void UpdateTheme(object sender, EventArgs e)
        {
            BackColor = Themes.OUTLINE_COLOR;
            canvasContainer.BackColor = Themes.MAIN_BG_COLOR;
            colorContainer.BackColor = Themes.SECONDARY_BG_COLOR;
            canvasOutline.BackColor = colorOutline.BackColor = Themes.OUTLINE_COLOR;
        }

        private void UpdateFrame(List<Bitmap> bitmaps)
        {
            srcImage.Image = bitmaps[Session.Instance.ActiveLayer];
            canvasPanel.APBox = srcImage;

            //canvasPanel.ActiveLayer = bitmaps[Session.Instance.ActiveLayer];
            canvasPanel.Layers = bitmaps;

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
