using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pixel_Editor_Test_2.Commands
{
    public class DrawPixelCommand : Command
    {
        public DrawPixelCommand(ref Bitmap image)
            :base(ref image)
        {}

        public override void Execute(Bitmap bmp, Point startPos, Point endPos, Color color)
        {
            if (startPos.X < 0 || startPos.X >= bmp.Width ||
                startPos.Y < 0 || startPos.Y >= bmp.Height)
                            return;

            _previousColors.Add(startPos, bmp.GetPixel(startPos.X, startPos.Y));
            _finalColors.Add(startPos, color);
            bmp.SetPixel(startPos.X, startPos.Y, color);

            _image = bmp;
        }
    }
}
