
namespace Pixel_Editor_Test_2.Controls
{
    partial class PaletteColor
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
            this.color = new System.Windows.Forms.Panel();
            this.boxOutline.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxOutline
            // 
            this.boxOutline.BackColor = System.Drawing.Color.Black;
            this.boxOutline.Controls.Add(this.color);
            this.boxOutline.Location = new System.Drawing.Point(0, 0);
            this.boxOutline.Margin = new System.Windows.Forms.Padding(0);
            this.boxOutline.Name = "boxOutline";
            this.boxOutline.Padding = new System.Windows.Forms.Padding(1);
            this.boxOutline.Size = new System.Drawing.Size(32, 32);
            this.boxOutline.TabIndex = 0;
            // 
            // color
            // 
            this.color.BackColor = System.Drawing.Color.Magenta;
            this.color.Dock = System.Windows.Forms.DockStyle.Fill;
            this.color.Location = new System.Drawing.Point(1, 1);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(30, 30);
            this.color.TabIndex = 0;
            // 
            // PaletteColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.boxOutline);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PaletteColor";
            this.Size = new System.Drawing.Size(32, 32);
            this.boxOutline.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel boxOutline;
        private System.Windows.Forms.Panel color;
    }
}
