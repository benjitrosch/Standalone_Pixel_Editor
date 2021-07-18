
namespace Pixel_Editor_Test_2.Controls
{
    partial class Keyframe
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
            this.SuspendLayout();
            // 
            // Keyframe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Keyframe";
            this.Size = new System.Drawing.Size(16, 32);
            this.Load += new System.EventHandler(this.Keyframe_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Keyframe_Paint);
            this.MouseEnter += new System.EventHandler(this.Keyframe_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Keyframe_MouseLeave);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
