using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pixel_Editor_Test_2.Commands
{
    public class ReplaceColorCommand : Command
    {
        public ReplaceColorCommand(PictureBox destination)
            :base(destination)
        {}

        public void Execute(Bitmap bmp, Color oldColor, Color newColor)
        {
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    if (bmp.GetPixel(x, y).ToArgb() == oldColor.ToArgb())
                    {
                        _previousColors.Add(new Point(x, y), oldColor);
                        _finalColors.Add(new Point(x, y), newColor);
                        bmp.SetPixel(x, y, newColor);
                    }
                }
            }

            _destinationRef.Image = bmp;
        }

        public override void Execute(Bitmap bmp, Point startPos, Point endPos, Color color)
        {}
    }
}
