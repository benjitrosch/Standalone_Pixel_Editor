
namespace Pixel_Editor_Test_2.Controls
{
    partial class ColorPicker
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.colorSliderVertical1 = new Pixel_Editor_Test_2.Controls.ColorSliderVertical();
            this.colorBox2D1 = new Pixel_Editor_Test_2.ColorBox2D();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1);
            this.panel1.Size = new System.Drawing.Size(224, 128);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.colorSliderVertical1);
            this.panel2.Controls.Add(this.colorBox2D1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(8);
            this.panel2.Size = new System.Drawing.Size(222, 126);
            this.panel2.TabIndex = 0;
            // 
            // colorSliderVertical1
            // 
            this.colorSliderVertical1.ColorMode = Pixel_Editor_Test_2.Controls.ColorModes.Hue;
            this.colorSliderVertical1.ColorRGB = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorSliderVertical1.Dock = System.Windows.Forms.DockStyle.Right;
            this.colorSliderVertical1.Location = new System.Drawing.Point(166, 8);
            this.colorSliderVertical1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.colorSliderVertical1.Name = "colorSliderVertical1";
            this.colorSliderVertical1.NubColor = System.Drawing.Color.Empty;
            this.colorSliderVertical1.Position = 0;
            this.colorSliderVertical1.Size = new System.Drawing.Size(48, 110);
            this.colorSliderVertical1.TabIndex = 4;
            // 
            // colorBox2D1
            // 
            this.colorBox2D1.ColorMode = Pixel_Editor_Test_2.Controls.ColorModes.Hue;
            this.colorBox2D1.ColorRGB = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorBox2D1.Dock = System.Windows.Forms.DockStyle.Left;
            this.colorBox2D1.Location = new System.Drawing.Point(8, 8);
            this.colorBox2D1.Name = "colorBox2D1";
            this.colorBox2D1.Size = new System.Drawing.Size(151, 110);
            this.colorBox2D1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(8, 8);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(224, 128);
            this.panel3.TabIndex = 1;
            // 
            // ColorPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "ColorPicker";
            this.Size = new System.Drawing.Size(232, 136);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private ColorSliderVertical colorSliderVertical1;
        private ColorBox2D colorBox2D1;
    }
}
