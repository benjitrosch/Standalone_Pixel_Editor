
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
            this.boxOutline = new System.Windows.Forms.Panel();
            this.colorContainer = new System.Windows.Forms.Panel();
            this.colorSlider = new Pixel_Editor_Test_2.Controls.ColorSliderVertical();
            this.colorBox2D = new Pixel_Editor_Test_2.ColorBox2D();
            this.boxShadow = new System.Windows.Forms.Panel();
            this.boxOutline.SuspendLayout();
            this.colorContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxOutline
            // 
            this.boxOutline.BackColor = System.Drawing.Color.Black;
            this.boxOutline.Controls.Add(this.colorContainer);
            this.boxOutline.Location = new System.Drawing.Point(0, 0);
            this.boxOutline.Margin = new System.Windows.Forms.Padding(0);
            this.boxOutline.Name = "boxOutline";
            this.boxOutline.Padding = new System.Windows.Forms.Padding(1);
            this.boxOutline.Size = new System.Drawing.Size(224, 128);
            this.boxOutline.TabIndex = 0;
            // 
            // colorContainer
            // 
            this.colorContainer.BackColor = System.Drawing.Color.White;
            this.colorContainer.Controls.Add(this.colorSlider);
            this.colorContainer.Controls.Add(this.colorBox2D);
            this.colorContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorContainer.Location = new System.Drawing.Point(1, 1);
            this.colorContainer.Name = "colorContainer";
            this.colorContainer.Padding = new System.Windows.Forms.Padding(8);
            this.colorContainer.Size = new System.Drawing.Size(222, 126);
            this.colorContainer.TabIndex = 0;
            // 
            // colorSlider
            // 
            this.colorSlider.ColorMode = Pixel_Editor_Test_2.Controls.ColorModes.Hue;
            this.colorSlider.ColorRGB = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorSlider.Dock = System.Windows.Forms.DockStyle.Right;
            this.colorSlider.Location = new System.Drawing.Point(166, 8);
            this.colorSlider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.colorSlider.Name = "colorSlider";
            this.colorSlider.NubColor = System.Drawing.Color.Empty;
            this.colorSlider.Position = 0;
            this.colorSlider.Size = new System.Drawing.Size(48, 110);
            this.colorSlider.TabIndex = 4;
            this.colorSlider.ColorChanged += new Pixel_Editor_Test_2.Controls.ColorSliderVertical.ColorChangedEventHandler(this.colorSlider_ColorChanged);
            // 
            // colorBox2D
            // 
            this.colorBox2D.ColorMode = Pixel_Editor_Test_2.Controls.ColorModes.Hue;
            this.colorBox2D.ColorRGB = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorBox2D.Dock = System.Windows.Forms.DockStyle.Left;
            this.colorBox2D.Location = new System.Drawing.Point(8, 8);
            this.colorBox2D.Name = "colorBox2D";
            this.colorBox2D.Size = new System.Drawing.Size(151, 110);
            this.colorBox2D.TabIndex = 3;
            this.colorBox2D.MouseDown += new System.Windows.Forms.MouseEventHandler(this.colorBox2D_MouseDown);
            this.colorBox2D.MouseMove += new System.Windows.Forms.MouseEventHandler(this.colorBox2D_MouseMove);
            // 
            // boxShadow
            // 
            this.boxShadow.BackColor = System.Drawing.Color.Black;
            this.boxShadow.Location = new System.Drawing.Point(8, 8);
            this.boxShadow.Margin = new System.Windows.Forms.Padding(0);
            this.boxShadow.Name = "boxShadow";
            this.boxShadow.Size = new System.Drawing.Size(224, 128);
            this.boxShadow.TabIndex = 1;
            // 
            // ColorPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.boxOutline);
            this.Controls.Add(this.boxShadow);
            this.Name = "ColorPicker";
            this.Size = new System.Drawing.Size(232, 136);
            this.Load += new System.EventHandler(this.ColorPicker_Load);
            this.boxOutline.ResumeLayout(false);
            this.colorContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel boxOutline;
        private System.Windows.Forms.Panel colorContainer;
        private System.Windows.Forms.Panel boxShadow;
        private ColorSliderVertical colorSlider;
        private ColorBox2D colorBox2D;
    }
}
