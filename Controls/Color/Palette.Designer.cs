
namespace Pixel_Editor_Test_2.Controls
{
    partial class Palette
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
            this.boxOutlineWhite = new System.Windows.Forms.Panel();
            this.boxOutlineInner = new System.Windows.Forms.Panel();
            this.layoutPalette = new System.Windows.Forms.FlowLayoutPanel();
            this.boxShadow = new System.Windows.Forms.Panel();
            this.buttonNewPalette = new Pixel_Editor_Test_2.Controls.EditorButton();
            this.buttonOpenPalette = new Pixel_Editor_Test_2.Controls.EditorButton();
            this.boxOutline.SuspendLayout();
            this.boxOutlineWhite.SuspendLayout();
            this.boxOutlineInner.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxOutline
            // 
            this.boxOutline.BackColor = System.Drawing.Color.Black;
            this.boxOutline.Controls.Add(this.boxOutlineWhite);
            this.boxOutline.Location = new System.Drawing.Point(0, 0);
            this.boxOutline.Margin = new System.Windows.Forms.Padding(0);
            this.boxOutline.Name = "boxOutline";
            this.boxOutline.Padding = new System.Windows.Forms.Padding(1);
            this.boxOutline.Size = new System.Drawing.Size(202, 360);
            this.boxOutline.TabIndex = 0;
            // 
            // boxOutlineWhite
            // 
            this.boxOutlineWhite.BackColor = System.Drawing.Color.White;
            this.boxOutlineWhite.Controls.Add(this.boxOutlineInner);
            this.boxOutlineWhite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxOutlineWhite.Location = new System.Drawing.Point(1, 1);
            this.boxOutlineWhite.Name = "boxOutlineWhite";
            this.boxOutlineWhite.Padding = new System.Windows.Forms.Padding(2);
            this.boxOutlineWhite.Size = new System.Drawing.Size(200, 358);
            this.boxOutlineWhite.TabIndex = 0;
            // 
            // boxOutlineInner
            // 
            this.boxOutlineInner.BackColor = System.Drawing.Color.Black;
            this.boxOutlineInner.Controls.Add(this.layoutPalette);
            this.boxOutlineInner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxOutlineInner.Location = new System.Drawing.Point(2, 2);
            this.boxOutlineInner.Name = "boxOutlineInner";
            this.boxOutlineInner.Padding = new System.Windows.Forms.Padding(1);
            this.boxOutlineInner.Size = new System.Drawing.Size(196, 354);
            this.boxOutlineInner.TabIndex = 0;
            // 
            // layoutPalette
            // 
            this.layoutPalette.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.layoutPalette.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPalette.Location = new System.Drawing.Point(1, 1);
            this.layoutPalette.Name = "layoutPalette";
            this.layoutPalette.Size = new System.Drawing.Size(194, 352);
            this.layoutPalette.TabIndex = 0;
            // 
            // boxShadow
            // 
            this.boxShadow.BackColor = System.Drawing.Color.Black;
            this.boxShadow.Location = new System.Drawing.Point(8, 8);
            this.boxShadow.Name = "boxShadow";
            this.boxShadow.Size = new System.Drawing.Size(202, 360);
            this.boxShadow.TabIndex = 1;
            // 
            // buttonNewPalette
            // 
            this.buttonNewPalette.Callback = null;
            this.buttonNewPalette.Icon = global::Pixel_Editor_Test_2.Properties.Resources.file_icon;
            this.buttonNewPalette.Location = new System.Drawing.Point(160, 350);
            this.buttonNewPalette.Margin = new System.Windows.Forms.Padding(0);
            this.buttonNewPalette.Name = "buttonNewPalette";
            this.buttonNewPalette.Size = new System.Drawing.Size(36, 36);
            this.buttonNewPalette.TabIndex = 9;
            this.buttonNewPalette.Click += new System.EventHandler(this.buttonNewPalette_Click);
            // 
            // buttonOpenPalette
            // 
            this.buttonOpenPalette.Callback = null;
            this.buttonOpenPalette.Icon = global::Pixel_Editor_Test_2.Properties.Resources.folder_icon;
            this.buttonOpenPalette.Location = new System.Drawing.Point(120, 350);
            this.buttonOpenPalette.Margin = new System.Windows.Forms.Padding(0);
            this.buttonOpenPalette.Name = "buttonOpenPalette";
            this.buttonOpenPalette.Size = new System.Drawing.Size(36, 36);
            this.buttonOpenPalette.TabIndex = 11;
            this.buttonOpenPalette.Click += new System.EventHandler(this.buttonOpenPalette_Click);
            // 
            // Palette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.buttonOpenPalette);
            this.Controls.Add(this.buttonNewPalette);
            this.Controls.Add(this.boxOutline);
            this.Controls.Add(this.boxShadow);
            this.Name = "Palette";
            this.Size = new System.Drawing.Size(210, 384);
            this.Load += new System.EventHandler(this.Palette_Load);
            this.boxOutline.ResumeLayout(false);
            this.boxOutlineWhite.ResumeLayout(false);
            this.boxOutlineInner.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel boxOutline;
        private System.Windows.Forms.FlowLayoutPanel layoutPalette;
        private System.Windows.Forms.Panel boxShadow;
        private System.Windows.Forms.Panel boxOutlineWhite;
        private System.Windows.Forms.Panel boxOutlineInner;
        private EditorButton buttonNewPalette;
        private EditorButton buttonOpenPalette;
    }
}
