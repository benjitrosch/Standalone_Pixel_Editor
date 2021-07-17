
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
            this.addShadow = new System.Windows.Forms.Panel();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.playShadow = new System.Windows.Forms.Panel();
            this.buttonPause = new System.Windows.Forms.Button();
            this.pauseShadow = new System.Windows.Forms.Panel();
            this.buttonAddFrame = new System.Windows.Forms.Button();
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
            this.boxOutline.Size = new System.Drawing.Size(947, 192);
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
            this.boxOutlineWhite.Size = new System.Drawing.Size(945, 190);
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
            this.boxOutlineInner.Size = new System.Drawing.Size(941, 186);
            this.boxOutlineInner.TabIndex = 0;
            // 
            // layoutKeyframe
            // 
            this.layoutKeyframe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(204)))), ((int)(((byte)(203)))));
            this.layoutKeyframe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutKeyframe.Location = new System.Drawing.Point(1, 1);
            this.layoutKeyframe.Name = "layoutKeyframe";
            this.layoutKeyframe.Size = new System.Drawing.Size(939, 184);
            this.layoutKeyframe.TabIndex = 0;
            // 
            // boxShadow
            // 
            this.boxShadow.BackColor = System.Drawing.Color.Black;
            this.boxShadow.Location = new System.Drawing.Point(8, 24);
            this.boxShadow.Name = "boxShadow";
            this.boxShadow.Size = new System.Drawing.Size(947, 192);
            this.boxShadow.TabIndex = 1;
            // 
            // addShadow
            // 
            this.addShadow.BackColor = System.Drawing.Color.Black;
            this.addShadow.Location = new System.Drawing.Point(900, 196);
            this.addShadow.Margin = new System.Windows.Forms.Padding(0);
            this.addShadow.Name = "addShadow";
            this.addShadow.Size = new System.Drawing.Size(32, 32);
            this.addShadow.TabIndex = 4;
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.White;
            this.buttonPlay.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay.Font = new System.Drawing.Font("Minecraftia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay.Location = new System.Drawing.Point(24, 192);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(32, 32);
            this.buttonPlay.TabIndex = 5;
            this.buttonPlay.Text = ">";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // playShadow
            // 
            this.playShadow.BackColor = System.Drawing.Color.Black;
            this.playShadow.Location = new System.Drawing.Point(28, 196);
            this.playShadow.Margin = new System.Windows.Forms.Padding(0);
            this.playShadow.Name = "playShadow";
            this.playShadow.Size = new System.Drawing.Size(32, 32);
            this.playShadow.TabIndex = 6;
            // 
            // buttonPause
            // 
            this.buttonPause.BackColor = System.Drawing.Color.White;
            this.buttonPause.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPause.Font = new System.Drawing.Font("Minecraftia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPause.Location = new System.Drawing.Point(80, 192);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(32, 32);
            this.buttonPause.TabIndex = 7;
            this.buttonPause.Text = "| |";
            this.buttonPause.UseVisualStyleBackColor = false;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // pauseShadow
            // 
            this.pauseShadow.BackColor = System.Drawing.Color.Black;
            this.pauseShadow.Location = new System.Drawing.Point(84, 196);
            this.pauseShadow.Margin = new System.Windows.Forms.Padding(0);
            this.pauseShadow.Name = "pauseShadow";
            this.pauseShadow.Size = new System.Drawing.Size(32, 32);
            this.pauseShadow.TabIndex = 8;
            // 
            // buttonAddFrame
            // 
            this.buttonAddFrame.BackColor = System.Drawing.Color.White;
            this.buttonAddFrame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAddFrame.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonAddFrame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddFrame.Font = new System.Drawing.Font("Minecraftia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddFrame.Location = new System.Drawing.Point(896, 192);
            this.buttonAddFrame.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddFrame.Name = "buttonAddFrame";
            this.buttonAddFrame.Size = new System.Drawing.Size(32, 32);
            this.buttonAddFrame.TabIndex = 3;
            this.buttonAddFrame.Text = "+";
            this.buttonAddFrame.UseVisualStyleBackColor = false;
            this.buttonAddFrame.Click += new System.EventHandler(this.buttonAddFrame_Click);
            // 
            // KeyframeContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.pauseShadow);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.playShadow);
            this.Controls.Add(this.buttonAddFrame);
            this.Controls.Add(this.addShadow);
            this.Controls.Add(this.boxOutline);
            this.Controls.Add(this.boxShadow);
            this.Name = "KeyframeContainer";
            this.Size = new System.Drawing.Size(955, 232);
            this.Load += new System.EventHandler(this.KeyframeContainer_Load);
            this.boxOutline.ResumeLayout(false);
            this.boxOutlineWhite.ResumeLayout(false);
            this.boxOutlineInner.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel boxOutline;
        private System.Windows.Forms.Panel boxShadow;
        private System.Windows.Forms.Button buttonAddFrame;
        private System.Windows.Forms.Panel addShadow;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Panel playShadow;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Panel pauseShadow;
        private System.Windows.Forms.Panel boxOutlineWhite;
        private System.Windows.Forms.Panel boxOutlineInner;
        private System.Windows.Forms.FlowLayoutPanel layoutKeyframe;
    }
}
