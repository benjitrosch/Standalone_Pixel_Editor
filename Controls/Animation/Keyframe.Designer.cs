
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
            this.divider = new System.Windows.Forms.Panel();
            this.labelIndex = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // divider
            // 
            this.divider.BackColor = System.Drawing.Color.White;
            this.divider.ForeColor = System.Drawing.Color.White;
            this.divider.Location = new System.Drawing.Point(0, 16);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(24, 1);
            this.divider.TabIndex = 0;
            // 
            // labelIndex
            // 
            this.labelIndex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelIndex.BackColor = System.Drawing.Color.Transparent;
            this.labelIndex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelIndex.ForeColor = System.Drawing.Color.White;
            this.labelIndex.Location = new System.Drawing.Point(-2, 0);
            this.labelIndex.Margin = new System.Windows.Forms.Padding(0);
            this.labelIndex.Name = "labelIndex";
            this.labelIndex.Size = new System.Drawing.Size(28, 16);
            this.labelIndex.TabIndex = 1;
            this.labelIndex.Text = "00";
            this.labelIndex.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Keyframe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.Controls.Add(this.labelIndex);
            this.Controls.Add(this.divider);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Keyframe";
            this.Size = new System.Drawing.Size(24, 48);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Keyframe_Paint);
            this.MouseEnter += new System.EventHandler(this.Keyframe_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Keyframe_MouseLeave);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel divider;
        private System.Windows.Forms.Label labelIndex;
    }
}
