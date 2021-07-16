
namespace Pixel_Editor_Test_2.Controls
{
    partial class ToolButton
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
            this.button = new System.Windows.Forms.Button();
            this.boxShadow = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.White;
            this.button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button.Location = new System.Drawing.Point(0, 0);
            this.button.Margin = new System.Windows.Forms.Padding(0);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(32, 32);
            this.button.TabIndex = 0;
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // boxShadow
            // 
            this.boxShadow.BackColor = System.Drawing.Color.Black;
            this.boxShadow.Location = new System.Drawing.Point(4, 4);
            this.boxShadow.Name = "boxShadow";
            this.boxShadow.Size = new System.Drawing.Size(32, 32);
            this.boxShadow.TabIndex = 1;
            // 
            // ToolButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            this.Controls.Add(this.button);
            this.Controls.Add(this.boxShadow);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ToolButton";
            this.Size = new System.Drawing.Size(36, 36);
            this.Load += new System.EventHandler(this.ToolButton_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Panel boxShadow;
    }
}
