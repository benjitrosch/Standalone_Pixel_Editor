
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.primaryColorContainer = new System.Windows.Forms.Panel();
            this.buttonPrimaryColor = new System.Windows.Forms.Button();
            this.buttonSavePrimaryColor = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.secondaryColorContainer = new System.Windows.Forms.Panel();
            this.buttonSecondaryColor = new System.Windows.Forms.Button();
            this.buttonSaveSeconaryColor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.colorWheel1 = new Pixel_Editor_Test_2.Controls.ColorWheel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.toolbar = new Pixel_Editor_Test_2.Controls.Toolbar();
            this.keyframeContainer = new Pixel_Editor_Test_2.Controls.KeyframeContainer();
            this.canvasPanel = new Pixel_Editor_Test_2.Controls.PixelEditor.PixelEditor();
            this.activeColors = new Pixel_Editor_Test_2.Controls.ActiveColors();
            this.srcImage = new System.Windows.Forms.PictureBox();
            this.titlebar = new Pixel_Editor_Test_2.Controls.Titlebar();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.primaryColorContainer.SuspendLayout();
            this.secondaryColorContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.canvasPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.srcImage)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.primaryColorContainer);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.secondaryColorContainer);
            this.panel2.Location = new System.Drawing.Point(19, 206);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(16);
            this.panel2.Size = new System.Drawing.Size(216, 112);
            this.panel2.TabIndex = 22;
            // 
            // primaryColorContainer
            // 
            this.primaryColorContainer.Controls.Add(this.buttonPrimaryColor);
            this.primaryColorContainer.Controls.Add(this.buttonSavePrimaryColor);
            this.primaryColorContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.primaryColorContainer.Location = new System.Drawing.Point(16, 16);
            this.primaryColorContainer.Name = "primaryColorContainer";
            this.primaryColorContainer.Size = new System.Drawing.Size(184, 32);
            this.primaryColorContainer.TabIndex = 21;
            // 
            // buttonPrimaryColor
            // 
            this.buttonPrimaryColor.BackColor = System.Drawing.Color.Lime;
            this.buttonPrimaryColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPrimaryColor.FlatAppearance.BorderSize = 0;
            this.buttonPrimaryColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrimaryColor.ForeColor = System.Drawing.Color.White;
            this.buttonPrimaryColor.Location = new System.Drawing.Point(0, 0);
            this.buttonPrimaryColor.Name = "buttonPrimaryColor";
            this.buttonPrimaryColor.Size = new System.Drawing.Size(152, 32);
            this.buttonPrimaryColor.TabIndex = 3;
            this.buttonPrimaryColor.Text = "255, 255, 255";
            this.buttonPrimaryColor.UseVisualStyleBackColor = false;
            this.buttonPrimaryColor.Click += new System.EventHandler(this.buttonPrimaryColor_Click);
            // 
            // buttonSavePrimaryColor
            // 
            this.buttonSavePrimaryColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.buttonSavePrimaryColor.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSavePrimaryColor.FlatAppearance.BorderSize = 0;
            this.buttonSavePrimaryColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSavePrimaryColor.ForeColor = System.Drawing.Color.White;
            this.buttonSavePrimaryColor.Location = new System.Drawing.Point(152, 0);
            this.buttonSavePrimaryColor.Name = "buttonSavePrimaryColor";
            this.buttonSavePrimaryColor.Size = new System.Drawing.Size(32, 32);
            this.buttonSavePrimaryColor.TabIndex = 7;
            this.buttonSavePrimaryColor.Text = "!";
            this.buttonSavePrimaryColor.UseVisualStyleBackColor = false;
            this.buttonSavePrimaryColor.Click += new System.EventHandler(this.buttonSavePrimaryColor_Click);
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(16, 48);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(184, 16);
            this.panel5.TabIndex = 22;
            // 
            // secondaryColorContainer
            // 
            this.secondaryColorContainer.Controls.Add(this.buttonSecondaryColor);
            this.secondaryColorContainer.Controls.Add(this.buttonSaveSeconaryColor);
            this.secondaryColorContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.secondaryColorContainer.Location = new System.Drawing.Point(16, 64);
            this.secondaryColorContainer.Name = "secondaryColorContainer";
            this.secondaryColorContainer.Size = new System.Drawing.Size(184, 32);
            this.secondaryColorContainer.TabIndex = 20;
            // 
            // buttonSecondaryColor
            // 
            this.buttonSecondaryColor.BackColor = System.Drawing.Color.Magenta;
            this.buttonSecondaryColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSecondaryColor.FlatAppearance.BorderSize = 0;
            this.buttonSecondaryColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSecondaryColor.ForeColor = System.Drawing.Color.White;
            this.buttonSecondaryColor.Location = new System.Drawing.Point(0, 0);
            this.buttonSecondaryColor.Name = "buttonSecondaryColor";
            this.buttonSecondaryColor.Size = new System.Drawing.Size(152, 32);
            this.buttonSecondaryColor.TabIndex = 4;
            this.buttonSecondaryColor.Text = "255, 255, 255";
            this.buttonSecondaryColor.UseVisualStyleBackColor = false;
            this.buttonSecondaryColor.Click += new System.EventHandler(this.buttonSecondaryColor_Click);
            // 
            // buttonSaveSeconaryColor
            // 
            this.buttonSaveSeconaryColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.buttonSaveSeconaryColor.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSaveSeconaryColor.FlatAppearance.BorderSize = 0;
            this.buttonSaveSeconaryColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveSeconaryColor.ForeColor = System.Drawing.Color.White;
            this.buttonSaveSeconaryColor.Location = new System.Drawing.Point(152, 0);
            this.buttonSaveSeconaryColor.Name = "buttonSaveSeconaryColor";
            this.buttonSaveSeconaryColor.Size = new System.Drawing.Size(32, 32);
            this.buttonSaveSeconaryColor.TabIndex = 8;
            this.buttonSaveSeconaryColor.Text = "!";
            this.buttonSaveSeconaryColor.UseVisualStyleBackColor = false;
            this.buttonSaveSeconaryColor.Click += new System.EventHandler(this.buttonSaveSeconaryColor_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(29, 428);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1);
            this.panel1.Size = new System.Drawing.Size(192, 128);
            this.panel1.TabIndex = 23;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.colorWheel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(1, 1);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(1);
            this.panel3.Size = new System.Drawing.Size(190, 126);
            this.panel3.TabIndex = 24;
            // 
            // colorWheel1
            // 
            this.colorWheel1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorWheel1.Location = new System.Drawing.Point(31, -2);
            this.colorWheel1.Name = "colorWheel1";
            this.colorWheel1.Size = new System.Drawing.Size(128, 128);
            this.colorWheel1.TabIndex = 0;
            this.colorWheel1.Text = "colorWheel1";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(35, 435);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(192, 128);
            this.panel6.TabIndex = 24;
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
            // keyframeContainer
            // 
            this.keyframeContainer.BackColor = System.Drawing.Color.White;
            this.keyframeContainer.Location = new System.Drawing.Point(269, 454);
            this.keyframeContainer.Name = "keyframeContainer";
            this.keyframeContainer.Size = new System.Drawing.Size(955, 232);
            this.keyframeContainer.TabIndex = 30;
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
            this.canvasPanel.Location = new System.Drawing.Point(269, 46);
            this.canvasPanel.Margin = new System.Windows.Forms.Padding(0);
            this.canvasPanel.Name = "canvasPanel";
            this.canvasPanel.OnionSkin = null;
            this.canvasPanel.PrimaryColor = System.Drawing.Color.Black;
            this.canvasPanel.SecondaryColor = System.Drawing.Color.White;
            this.canvasPanel.SelectionEndPos = new System.Drawing.Point(0, 0);
            this.canvasPanel.SelectionStartPos = new System.Drawing.Point(0, 0);
            this.canvasPanel.ShapeEndPos = new System.Drawing.Point(0, 0);
            this.canvasPanel.ShapeStartPos = new System.Drawing.Point(0, 0);
            this.canvasPanel.Size = new System.Drawing.Size(945, 384);
            this.canvasPanel.TabIndex = 29;
            this.canvasPanel.TgtMousePos = new System.Drawing.Point(0, 0);
            this.canvasPanel.Viewport = new System.Drawing.Point(0, 0);
            this.canvasPanel.Zoom = 8;
            // 
            // activeColors
            // 
            this.activeColors.BackColor = System.Drawing.Color.Transparent;
            this.activeColors.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.activeColors.Location = new System.Drawing.Point(16, 582);
            this.activeColors.Margin = new System.Windows.Forms.Padding(0);
            this.activeColors.Name = "activeColors";
            this.activeColors.Padding = new System.Windows.Forms.Padding(1);
            this.activeColors.Size = new System.Drawing.Size(216, 88);
            this.activeColors.TabIndex = 25;
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
            // titlebar
            // 
            this.titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlebar.Location = new System.Drawing.Point(1, 1);
            this.titlebar.Margin = new System.Windows.Forms.Padding(0);
            this.titlebar.Name = "titlebar";
            this.titlebar.Size = new System.Drawing.Size(1278, 32);
            this.titlebar.TabIndex = 32;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(1, 33);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(248, 686);
            this.panel4.TabIndex = 33;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.panel2);
            this.panel7.Controls.Add(this.activeColors);
            this.panel7.Controls.Add(this.panel1);
            this.panel7.Controls.Add(this.panel6);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(16);
            this.panel7.Size = new System.Drawing.Size(248, 686);
            this.panel7.TabIndex = 0;
            // 
            // EditorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.toolbar);
            this.Controls.Add(this.keyframeContainer);
            this.Controls.Add(this.canvasPanel);
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
            this.panel2.ResumeLayout(false);
            this.primaryColorContainer.ResumeLayout(false);
            this.secondaryColorContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.canvasPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.srcImage)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel primaryColorContainer;
        private System.Windows.Forms.Button buttonPrimaryColor;
        private System.Windows.Forms.Button buttonSavePrimaryColor;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel secondaryColorContainer;
        private System.Windows.Forms.Button buttonSecondaryColor;
        private System.Windows.Forms.Button buttonSaveSeconaryColor;
        private System.Windows.Forms.PictureBox srcImage;
        private Controls.KeyframeContainer keyframeContainer;
        private PixelEditor canvasPanel;
        private Controls.Toolbar toolbar;
        private Controls.Titlebar titlebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private Controls.ColorWheel colorWheel1;
        private System.Windows.Forms.Panel panel6;
        private Controls.ActiveColors activeColors;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
    }
}

