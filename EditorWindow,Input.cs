using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pixel_Editor_Test_2
{
    public partial class EditorWindow
    {
        private void EditorWindow_KeyDown(object sender, KeyEventArgs e)
        {
            canvasPanel.PixelEditor_KeyDown(e);

            switch (e.KeyCode)
            {
                case Keys.W:
                    if (e.Control)
                        ExitApplication();
                    break;

                case Keys.S:
                    /*if (e.Control)
                    {
                        SaveFileDialog sfd = new SaveFileDialog();
                        sfd.Filter = "Sprite Sheet (.png)|*.png";

                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            Bitmap bmp = new Bitmap(32 * _animation.TotalFrames, 32);
                            using (Graphics g = Graphics.FromImage(bmp))
                            {
                                for (int i = 0; i < _animation.TotalFrames; i++)
                                {
                                    g.DrawImage(_animation.Frames[i], 32 * i, 0);
                                }
                            }

                            bmp.Save(sfd.FileName, ImageFormat.Png);
                        }
                    }*/
                    break;

                case Keys.Q:
                    SelectSelectTool();
                    break;

                case Keys.M:
                    SelectMagicTool();
                    break;

                case Keys.P:
                case Keys.B:
                    SelectPencilTool();
                    break;

                case Keys.E:
                    SelectEraserTool();
                    break;

                case Keys.F:
                case Keys.G:
                    SelectFillTool();
                    break;

                case Keys.H:
                    SelectHandTool();
                    break;

                case Keys.I:
                    SelectEyedropperTool();
                    break;

                case Keys.L:
                    SelectLineTool();
                    break;

                case Keys.R:
                    SelectRectangleTool();
                    break;

                case Keys.U:
                case Keys.O:
                    SelectOvalTool();
                    break;
            }
        }

        private void EditorWindow_KeyUp(object sender, KeyEventArgs e)
        {
            canvasPanel.PixelEditor_KeyUp(e);
        }
    }
}
