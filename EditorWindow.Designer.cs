
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
            this.canvasOutline = new System.Windows.Forms.Panel();
            this.canvasContainer = new System.Windows.Forms.Panel();
            this.brushSize = new Pixel_Editor_Test_2.Controls.BrushSize();
            this.canvasPanel = new Pixel_Editor_Test_2.Controls.PixelEditor.PixelEditor();
            this.srcImage = new System.Windows.Forms.PictureBox();
            this.padding = new System.Windows.Forms.Panel();
            this.keyframeContainer1 = new Pixel_Editor_Test_2.Controls.KeyframeContainer();
            this.toolbar = new Pixel_Editor_Test_2.Controls.Toolbar();
            this.titlebar = new Pixel_Editor_Test_2.Controls.Titlebar();
            this.colorContainer = new System.Windows.Forms.Panel();
            this.palette = new Pixel_Editor_Test_2.Controls.Palette();
            this.colorPicker1 = new Pixel_Editor_Test_2.Controls.ColorPicker();
            this.activeColors = new Pixel_Editor_Test_2.Controls.ActiveColors();
            this.colorOutline = new System.Windows.Forms.Panel();
            this.canvasOutline.SuspendLayout();
            this.canvasContainer.SuspendLayout();
            this.canvasPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.srcImage)).BeginInit();
            this.colorContainer.SuspendLayout();
            this.colorOutline.SuspendLayout();
            this.SuspendLayout();
            // 
            // canvasOutline
            // 
            this.canvasOutline.Controls.Add(this.canvasContainer);
            this.canvasOutline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvasOutline.Location = new System.Drawing.Point(249, 33);
            this.canvasOutline.Margin = new System.Windows.Forms.Padding(0);
            this.canvasOutline.Name = "canvasOutline";
            this.canvasOutline.Padding = new System.Windows.Forms.Padding(1);
            this.canvasOutline.Size = new System.Drawing.Size(982, 686);
            this.canvasOutline.TabIndex = 34;
            // 
            // canvasContainer
            // 
            this.canvasContainer.BackColor = System.Drawing.Color.White;
            this.canvasContainer.Controls.Add(this.brushSize);
            this.canvasContainer.Controls.Add(this.canvasPanel);
            this.canvasContainer.Controls.Add(this.padding);
            this.canvasContainer.Controls.Add(this.keyframeContainer1);
            this.canvasContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvasContainer.Location = new System.Drawing.Point(1, 1);
            this.canvasContainer.Name = "canvasContainer";
            this.canvasContainer.Padding = new System.Windows.Forms.Padding(16, 16, 16, 8);
            this.canvasContainer.Size = new System.Drawing.Size(980, 684);
            this.canvasContainer.TabIndex = 0;
            // 
            // brushSize
            // 
            this.brushSize.Location = new System.Drawing.Point(787, 400);
            this.brushSize.Name = "brushSize";
            this.brushSize.Size = new System.Drawing.Size(160, 32);
            this.brushSize.TabIndex = 31;
            // 
            // canvasPanel
            // 
            this.canvasPanel.APBox = null;
            this.canvasPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(86)))), ((int)(((byte)(97)))));
            this.canvasPanel.Controls.Add(this.srcImage);
            this.canvasPanel.HandEndPos = new System.Drawing.Point(0, 0);
            this.canvasPanel.HandStartPos = new System.Drawing.Point(0, 0);
            this.canvasPanel.KeyShiftDown = false;
            this.canvasPanel.Location = new System.Drawing.Point(16, 16);
            this.canvasPanel.Margin = new System.Windows.Forms.Padding(0);
            this.canvasPanel.Name = "canvasPanel";
            this.canvasPanel.OnionSkin = null;
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
            this.srcImage.Location = new System.Drawing.Point(817, 3);
            this.srcImage.Name = "srcImage";
            this.srcImage.Size = new System.Drawing.Size(128, 128);
            this.srcImage.TabIndex = 0;
            this.srcImage.TabStop = false;
            this.srcImage.Visible = false;
            // 
            // padding
            // 
            this.padding.BackColor = System.Drawing.Color.Transparent;
            this.padding.Location = new System.Drawing.Point(16, 412);
            this.padding.Name = "padding";
            this.padding.Size = new System.Drawing.Size(948, 32);
            this.padding.TabIndex = 30;
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
            // colorContainer
            // 
            this.colorContainer.BackColor = System.Drawing.Color.White;
            this.colorContainer.Controls.Add(this.palette);
            this.colorContainer.Controls.Add(this.colorPicker1);
            this.colorContainer.Controls.Add(this.activeColors);
            this.colorContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorContainer.Location = new System.Drawing.Point(1, 1);
            this.colorContainer.Margin = new System.Windows.Forms.Padding(0);
            this.colorContainer.Name = "colorContainer";
            this.colorContainer.Padding = new System.Windows.Forms.Padding(16);
            this.colorContainer.Size = new System.Drawing.Size(246, 684);
            this.colorContainer.TabIndex = 0;
            // 
            // palette
            // 
            this.palette.BackColor = System.Drawing.Color.Transparent;
            this.palette.Location = new System.Drawing.Point(20, 19);
            this.palette.Name = "palette";
            this.palette.Size = new System.Drawing.Size(208, 400);
            this.palette.TabIndex = 27;
            // 
            // colorPicker1
            // 
            this.colorPicker1.BackColor = System.Drawing.Color.Transparent;
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
            // colorOutline
            // 
            this.colorOutline.BackColor = System.Drawing.Color.Black;
            this.colorOutline.Controls.Add(this.colorContainer);
            this.colorOutline.Dock = System.Windows.Forms.DockStyle.Left;
            this.colorOutline.Location = new System.Drawing.Point(1, 33);
            this.colorOutline.Margin = new System.Windows.Forms.Padding(0);
            this.colorOutline.Name = "colorOutline";
            this.colorOutline.Padding = new System.Windows.Forms.Padding(1);
            this.colorOutline.Size = new System.Drawing.Size(248, 686);
            this.colorOutline.TabIndex = 33;
            // 
            // EditorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.canvasOutline);
            this.Controls.Add(this.colorOutline);
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
            this.canvasOutline.ResumeLayout(false);
            this.canvasContainer.ResumeLayout(false);
            this.canvasPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.srcImage)).EndInit();
            this.colorContainer.ResumeLayout(false);
            this.colorOutline.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox srcImage;
        private Controls.Toolbar toolbar;
        private Controls.Titlebar titlebar;
        private System.Windows.Forms.Panel canvasOutline;
        private System.Windows.Forms.Panel canvasContainer;
        private System.Windows.Forms.Panel padding;
        private Controls.KeyframeContainer keyframeContainer1;
        private Controls.BrushSize brushSize;
        private System.Windows.Forms.Panel colorContainer;
        private Controls.Palette palette;
        private Controls.ColorPicker colorPicker1;
        private Controls.ActiveColors activeColors;
        private System.Windows.Forms.Panel colorOutline;
        public PixelEditor canvasPanel;
    }
}

