
namespace Pixel_Editor_Test_2.Controls
{
    partial class BrushSize
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
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.boxOutline = new System.Windows.Forms.Panel();
            this.boxContainer = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.boxOutline.SuspendLayout();
            this.boxContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBar
            // 
            this.trackBar.AutoSize = false;
            this.trackBar.BackColor = System.Drawing.Color.White;
            this.trackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar.Location = new System.Drawing.Point(8, 8);
            this.trackBar.Maximum = 32;
            this.trackBar.Minimum = 1;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(142, 30);
            this.trackBar.TabIndex = 2;
            this.trackBar.TickFrequency = 8;
            this.trackBar.Value = 1;
            // 
            // boxOutline
            // 
            this.boxOutline.BackColor = System.Drawing.Color.Black;
            this.boxOutline.Controls.Add(this.boxContainer);
            this.boxOutline.Location = new System.Drawing.Point(0, 0);
            this.boxOutline.Name = "boxOutline";
            this.boxOutline.Padding = new System.Windows.Forms.Padding(1);
            this.boxOutline.Size = new System.Drawing.Size(160, 48);
            this.boxOutline.TabIndex = 3;
            // 
            // boxContainer
            // 
            this.boxContainer.BackColor = System.Drawing.Color.White;
            this.boxContainer.Controls.Add(this.trackBar);
            this.boxContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxContainer.Location = new System.Drawing.Point(1, 1);
            this.boxContainer.Margin = new System.Windows.Forms.Padding(0);
            this.boxContainer.Name = "boxContainer";
            this.boxContainer.Padding = new System.Windows.Forms.Padding(8);
            this.boxContainer.Size = new System.Drawing.Size(158, 46);
            this.boxContainer.TabIndex = 0;
            // 
            // BrushSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.boxOutline);
            this.Name = "BrushSize";
            this.Size = new System.Drawing.Size(160, 48);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.boxOutline.ResumeLayout(false);
            this.boxContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Panel boxOutline;
        private System.Windows.Forms.Panel boxContainer;
    }
}
