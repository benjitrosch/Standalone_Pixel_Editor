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
    public partial class EditorControl : UserControl
    {
        private bool _hasLoaded;

        public EditorControl()
        {
            InitializeComponent();
            Visible = false;
        }

        public void Initialize()
        {
            if (_hasLoaded)
                return;

            OnLoad();
        }

        protected virtual void OnLoad()
        {
            Session.Instance.OnChangeTheme += (_o, _e) => UpdateTheme();
            _hasLoaded = true;
            Visible = true;
        }

        protected virtual void UpdateTheme()
        {}
    }
}
