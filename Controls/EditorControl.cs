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
        public EditorControl()
        {
            InitializeComponent();
        }

        protected virtual void OnLoad()
        {
            Session.Instance.OnChangeTheme += UpdateTheme;
        }

        protected virtual void UpdateTheme(object sender, EventArgs e)
        {}
    }
}
