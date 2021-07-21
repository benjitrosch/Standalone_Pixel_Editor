
namespace Pixel_Editor_Test_2.Controls
{
    partial class KeyframeContainer
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
            this.layoutKeyframe = new System.Windows.Forms.FlowLayoutPanel();
            this.boxShadow = new System.Windows.Forms.Panel();
            this.buttonPlay = new Pixel_Editor_Test_2.Controls.EditorButton();
            this.buttonPause = new Pixel_Editor_Test_2.Controls.EditorButton();
            this.buttonAddFrame = new Pixel_Editor_Test_2.Controls.EditorButton();
            this.buttonAddLayer = new Pixel_Editor_Test_2.Controls.EditorButton();
            this.boxOutline.SuspendLayout();
            this.boxOutlineWhite.SuspendLayout();
            this.boxOutlineInner.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxOutline
            // 
            this.boxOutline.BackColor = System.Drawing.Color.Black;
            this.boxOutline.Controls.Add(this.boxOutlineWhite);
            this.boxOutline.Location = new System.Drawing.Point(0, 16);
            this.boxOutline.Margin = new System.Windows.Forms.Padding(0);
            this.boxOutline.Name = "boxOutline";
            this.boxOutline.Padding = new System.Windows.Forms.Padding(1);
            this.boxOutline.Size = new System.Drawing.Size(947, 200);
            this.boxOutline.TabIndex = 0;
            // 
            // boxOutlineWhite
            // 
            this.boxOutlineWhite.BackColor = System.Drawing.Color.White;
            this.boxOutlineWhite.Controls.Add(this.boxOutlineInner);
            this.boxOutlineWhite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxOutlineWhite.Location = new System.Drawing.Point(1, 1);
            this.boxOutlineWhite.Margin = new System.Windows.Forms.Padding(0);
            this.boxOutlineWhite.Name = "boxOutlineWhite";
            this.boxOutlineWhite.Padding = new System.Windows.Forms.Padding(2);
            this.boxOutlineWhite.Size = new System.Drawing.Size(945, 198);
            this.boxOutlineWhite.TabIndex = 0;
            // 
            // boxOutlineInner
            // 
            this.boxOutlineInner.BackColor = System.Drawing.Color.Black;
            this.boxOutlineInner.Controls.Add(this.layoutKeyframe);
            this.boxOutlineInner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxOutlineInner.Location = new System.Drawing.Point(2, 2);
            this.boxOutlineInner.Margin = new System.Windows.Forms.Padding(0);
            this.boxOutlineInner.Name = "boxOutlineInner";
            this.boxOutlineInner.Padding = new System.Windows.Forms.Padding(1);
            this.boxOutlineInner.Size = new System.Drawing.Size(941, 194);
            this.boxOutlineInner.TabIndex = 0;
            // 
            // layoutKeyframe
            // 
            this.layoutKeyframe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(204)))), ((int)(((byte)(203)))));
            this.layoutKeyframe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutKeyframe.Location = new System.Drawing.Point(1, 1);
            this.layoutKeyframe.Name = "layoutKeyframe";
            this.layoutKeyframe.Size = new System.Drawing.Size(939, 192);
            this.layoutKeyframe.TabIndex = 0;
            // 
            // boxShadow
            // 
            this.boxShadow.BackColor = System.Drawing.Color.Black;
            this.boxShadow.Location = new System.Drawing.Point(8, 24);
            this.boxShadow.Name = "boxShadow";
            this.boxShadow.Size = new System.Drawing.Size(947, 200);
            this.boxShadow.TabIndex = 1;
            // 
            // buttonPlay
            // 
            this.buttonPlay.Callback = null;
            this.buttonPlay.Icon = global::Pixel_Editor_Test_2.Properties.Resources.play_icon;
            this.buttonPlay.Location = new System.Drawing.Point(24, 208);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(36, 36);
            this.buttonPlay.TabIndex = 11;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.Callback = null;
            this.buttonPause.Icon = global::Pixel_Editor_Test_2.Properties.Resources.pause_icon;
            this.buttonPause.Location = new System.Drawing.Point(80, 208);
            this.buttonPause.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(36, 36);
            this.buttonPause.TabIndex = 10;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonAddFrame
            // 
            this.buttonAddFrame.Callback = null;
            this.buttonAddFrame.Icon = global::Pixel_Editor_Test_2.Properties.Resources.addframe_icon;
            this.buttonAddFrame.Location = new System.Drawing.Point(896, 208);
            this.buttonAddFrame.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddFrame.Name = "buttonAddFrame";
            this.buttonAddFrame.Size = new System.Drawing.Size(36, 36);
            this.buttonAddFrame.TabIndex = 9;
            this.buttonAddFrame.Click += new System.EventHandler(this.buttonAddFrame_Click);
            // 
            // buttonAddLayer
            // 
            this.buttonAddLayer.Callback = null;
            this.buttonAddLayer.Icon = global::Pixel_Editor_Test_2.Properties.Resources.file_icon;
            this.buttonAddLayer.Location = new System.Drawing.Point(840, 208);
            this.buttonAddLayer.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddLayer.Name = "buttonAddLayer";
            this.buttonAddLayer.Size = new System.Drawing.Size(36, 36);
            this.buttonAddLayer.TabIndex = 13;
            this.buttonAddLayer.Click += new System.EventHandler(this.buttonAddLayer_Click);
            // 
            // KeyframeContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.buttonAddLayer);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.buttonAddFrame);
            this.Controls.Add(this.boxOutline);
            this.Controls.Add(this.boxShadow);
            this.Name = "KeyframeContainer";
            this.Size = new System.Drawing.Size(955, 244);
            this.boxOutline.ResumeLayout(false);
            this.boxOutlineWhite.ResumeLayout(false);
            this.boxOutlineInner.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel boxOutline;
        private System.Windows.Forms.Panel boxShadow;
        private System.Windows.Forms.Panel boxOutlineWhite;
        private System.Windows.Forms.Panel boxOutlineInner;
        private System.Windows.Forms.FlowLayoutPanel layoutKeyframe;
        private EditorButton buttonAddFrame;
        private EditorButton buttonPause;
        private EditorButton buttonPlay;
        private EditorButton buttonAddLayer;
    }
}
