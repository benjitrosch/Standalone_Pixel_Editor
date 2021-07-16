
using Pixel_Editor_Test_2.Controls.PixelEditor;

namespace Pixel_Editor_Test_2
{
    partial class EditorWindow
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.canvasPanel = new Pixel_Editor_Test_2.Controls.PixelEditor.PixelEditor();
            this.srcImage = new System.Windows.Forms.PictureBox();
            this.keyframeContainer1 = new Pixel_Editor_Test_2.Controls.KeyframeContainer();
            this.colorPicker1 = new Pixel_Editor_Test_2.Controls.ColorPicker();
            this.activeColors = new Pixel_Editor_Test_2.Controls.ActiveColors();
            this.toolbar = new Pixel_Editor_Test_2.Controls.Toolbar();
            this.titlebar = new Pixel_Editor_Test_2.Controls.Titlebar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.canvasPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.srcImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(1, 33);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(1);
            this.panel4.Size = new System.Drawing.Size(248, 686);
            this.panel4.TabIndex = 33;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.panel1);
            this.panel7.Controls.Add(this.colorPicker1);
            this.panel7.Controls.Add(this.activeColors);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(1, 1);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(16);
            this.panel7.Size = new System.Drawing.Size(246, 684);
            this.panel7.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(249, 33);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(1);
            this.panel8.Size = new System.Drawing.Size(982, 686);
            this.panel8.TabIndex = 34;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Controls.Add(this.canvasPanel);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.keyframeContainer1);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(1, 1);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(16, 16, 16, 8);
            this.panel9.Size = new System.Drawing.Size(980, 684);
            this.panel9.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Transparent;
            this.panel10.Location = new System.Drawing.Point(16, 412);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(948, 32);
            this.panel10.TabIndex = 30;
            // 
            // canvasPanel
            // 
            this.canvasPanel.APBox = null;
            this.canvasPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(86)))), ((int)(((byte)(97)))));
            this.canvasPanel.BrushSize = 0;
            this.canvasPanel.Controls.Add(this.srcImage);
            this.canvasPanel.GridColor = System.Drawing.Color.Transparent;
            this.canvasPanel.HandEndPos = new System.Drawing.Point(0, 0);
            this.canvasPanel.HandStartPos = new System.Drawing.Point(0, 0);
            this.canvasPanel.KeyShiftDown = false;
            this.canvasPanel.Location = new System.Drawing.Point(16, 16);
            this.canvasPanel.Margin = new System.Windows.Forms.Padding(0);
            this.canvasPanel.Name = "canvasPanel";
            this.canvasPanel.OnionSkin = null;
            this.canvasPanel.PrimaryColor = System.Drawing.Color.Black;
            this.canvasPanel.SecondaryColor = System.Drawing.Color.White;
            this.canvasPanel.SelectionEndPos = new System.Drawing.Point(0, 0);
            this.canvasPanel.SelectionStartPos = new System.Drawing.Point(0, 0);
            this.canvasPanel.ShapeEndPos = new System.Drawing.Point(0, 0);
            this.canvasPanel.ShapeStartPos = new System.Drawing.Point(0, 0);
            this.canvasPanel.Size = new System.Drawing.Size(948, 396);
            this.canvasPanel.TabIndex = 29;
            this.canvasPanel.TgtMousePos = new System.Drawing.Point(0, 0);
            this.canvasPanel.Viewport = new System.Drawing.Point(0, 0);
            this.canvasPanel.Zoom = 8;
            // 
            // srcImage
            // 
            this.srcImage.Location = new System.Drawing.Point(880, 8);
            this.srcImage.Name = "srcImage";
            this.srcImage.Size = new System.Drawing.Size(64, 64);
            this.srcImage.TabIndex = 0;
            this.srcImage.TabStop = false;
            this.srcImage.Visible = false;
            // 
            // keyframeContainer1
            // 
            this.keyframeContainer1.BackColor = System.Drawing.Color.White;
            this.keyframeContainer1.Location = new System.Drawing.Point(16, 444);
            this.keyframeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.keyframeContainer1.Name = "keyframeContainer1";
            this.keyframeContainer1.Size = new System.Drawing.Size(954, 232);
            this.keyframeContainer1.TabIndex = 0;
            // 
            // colorPicker1
            // 
            this.colorPicker1.Location = new System.Drawing.Point(7, 443);
            this.colorPicker1.Name = "colorPicker1";
            this.colorPicker1.Size = new System.Drawing.Size(232, 136);
            this.colorPicker1.TabIndex = 26;
            // 
            // activeColors
            // 
            this.activeColors.BackColor = System.Drawing.Color.Transparent;
            this.activeColors.Location = new System.Drawing.Point(11, 585);
            this.activeColors.Margin = new System.Windows.Forms.Padding(0);
            this.activeColors.Name = "activeColors";
            this.activeColors.Padding = new System.Windows.Forms.Padding(1);
            this.activeColors.Size = new System.Drawing.Size(224, 88);
            this.activeColors.TabIndex = 25;
            // 
            // toolbar
            // 
            this.toolbar.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolbar.Location = new System.Drawing.Point(1231, 33);
            this.toolbar.Margin = new System.Windows.Forms.Padding(0);
            this.toolbar.Name = "toolbar";
            this.toolbar.Size = new System.Drawing.Size(48, 686);
            this.toolbar.TabIndex = 31;
            // 
            // titlebar
            // 
            this.titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlebar.Location = new System.Drawing.Point(1, 1);
            this.titlebar.Margin = new System.Windows.Forms.Padding(0);
            this.titlebar.Name = "titlebar";
            this.titlebar.Size = new System.Drawing.Size(1278, 32);
            this.titlebar.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(16, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1);
            this.panel1.Size = new System.Drawing.Size(214, 396);
            this.panel1.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 394);
            this.panel2.TabIndex = 0;
            // 
            // EditorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.toolbar);
            this.Controls.Add(this.titlebar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditorWindow";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Untitled Sprite";
            this.Load += new System.EventHandler(this.EditorWindow_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditorWindow_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EditorWindow_KeyUp);
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.canvasPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.srcImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox srcImage;
        private PixelEditor canvasPanel;
        private Controls.Toolbar toolbar;
        private Controls.Titlebar titlebar;
        private Controls.ActiveColors activeColors;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private Controls.KeyframeContainer keyframeContainer1;
        private Controls.ColorPicker colorPicker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

