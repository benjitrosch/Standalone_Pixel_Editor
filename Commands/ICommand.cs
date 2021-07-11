using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pixel_Editor_Test_2.Commands
{
    public interface ICommand
    {
        PictureBox _destinationRef { get; set; }

        Dictionary<Point, Color> _previousColors { get; set; }
        Dictionary<Point, Color> _finalColors { get; set; }

        void Execute(Bitmap bmp, Point startPos, Point endPos, Color color);

        void Undo(Bitmap bmp);

        void Redo(Bitmap bmp);
    }
}
