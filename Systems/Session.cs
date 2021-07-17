using Pixel_Editor_Test_2.Controls.Events;
using Pixel_Editor_Test_2.Controls.PixelEditor;
using Pixel_Editor_Test_2.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pixel_Editor_Test_2.Systems
{
    public class Session
    {
        private static readonly Session _instance = new Session();

        public EditorWindow Editor { get; private set; }
        public AnimatedBitmap Animation { get; private set; }
        public event EventHandler<KeyframeAddedEventArgs> OnAddKeyframe;

        public Action CurrentTheme { get; private set; }
        public event EventHandler OnChangeTheme;

        public Color PrimaryColor { get; set; }
        public Color SecondaryColor { get; set; }
        public event EventHandler<Color> OnPrimaryColorChange;
        public event EventHandler<Color> OnSecondaryColorChange;

        private List<Color> Palette = new List<Color>();
        public event EventHandler<Color> OnPaletteUpdate;

        private int _brushSize;
        public int BrushSize
        {
            get
            {
                return (int)Math.Round((double)_brushSize / 2);
            }
            set
            {
                _brushSize = value;
            }
        }

        public PixelEditor.Tool ActiveTool { get; set; }
        public event EventHandler<PixelEditor.Tool> OnActiveToolChange;

        static Session()
        {}

        public static Session Instance
        {
            get
            {
                return _instance;
            }
        }

        public void SetEditor(EditorWindow editor)
        {
            if (Editor != null)
                return;

            Editor = editor;
        }

        public void SetEditorTheme(Action theme)
        {
            theme();
            CurrentTheme = theme;
            OnChangeTheme?.Invoke(this, null);
        }

        public AnimatedBitmap CreateNewAnimation()
        {
            Animation = new AnimatedBitmap();
            return Animation;
        }

        public void SetEditorTool(PixelEditor.Tool tool)
        {
            if (ActiveTool == tool)
                return;

            ActiveTool = tool;
            OnActiveToolChange?.Invoke(this, tool);
        }

        public void SetPrimaryColor(Color color)
        {
            if (PrimaryColor == color)
                return;

            PrimaryColor = color;
            OnPrimaryColorChange?.Invoke(this, color);
        }

        public void SetSecondaryColor(Color color)
        {
            if (SecondaryColor == color)
                return;

            SecondaryColor = color;
            OnSecondaryColorChange?.Invoke(this, color);
        }

        public void SaveColorToPalette(Color color)
        {
            if (Palette.Contains(color))
                return;

            Palette.Add(color);
            OnPaletteUpdate?.Invoke(this, color);
        }

        public void AddKeyframe(Frame frame)
        {
            int frameIndex = Animation.TotalFrames;

            Animation.PauseAnimation();
            Animation.AddFrame(frame);
            Animation.GotoFrame(frameIndex);
            OnAddKeyframe?.Invoke(this, new KeyframeAddedEventArgs(frame, frameIndex));
        }
    }
}
