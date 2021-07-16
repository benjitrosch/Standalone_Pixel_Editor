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
    public partial class Titlebar : UserControl
    {
        public Titlebar()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            EditorWindow editor = (EditorWindow)Application.OpenForms["EditorWindow"];
            editor.Close();
        }
    }
}
