using Pixel_Editor_Test_2.Controls.PixelEditor;
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

        public Color PrimaryColor { get; set; }
        public Color SecondaryColor { get; set; }
        private Color[] Palette = new Color[64];

        public int BrushSize { get; set; }

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

        public void SetEditorTool(PixelEditor.Tool tool)
        {
            if (ActiveTool == tool)
                return;

            EventHandler<PixelEditor.Tool> handler = OnActiveToolChange;
            handler?.Invoke(this, tool);

            ActiveTool = tool;
        }
    }
}
