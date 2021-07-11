
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
            this.zoomCanvas = new System.Windows.Forms.TrackBar();
            this.buttonPencilTool = new System.Windows.Forms.Button();
            this.buttonEraserTool = new System.Windows.Forms.Button();
            this.buttonSelectTool = new System.Windows.Forms.Button();
            this.buttonFillTool = new System.Windows.Forms.Button();
            this.buttonHandTool = new System.Windows.Forms.Button();
            this.canvasPanel = new Pixel_Editor_Test_2.PixelEditor();
            this.srcImage = new System.Windows.Forms.PictureBox();
            this.previewContainer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel26 = new System.Windows.Forms.Panel();
            this.panel22 = new System.Windows.Forms.Panel();
            this.panel23 = new System.Windows.Forms.Panel();
            this.panel24 = new System.Windows.Forms.Panel();
            this.panel25 = new System.Windows.Forms.Panel();
            this.buttonSwitchColors = new System.Windows.Forms.Button();
            this.checkboxToggleGrid = new System.Windows.Forms.CheckBox();
            this.buttonEyedropper = new System.Windows.Forms.Button();
            this.primaryColorContainer = new System.Windows.Forms.Panel();
            this.buttonPrimaryColor = new System.Windows.Forms.Button();
            this.buttonSavePrimaryColor = new System.Windows.Forms.Button();
            this.secondaryColorContainer = new System.Windows.Forms.Panel();
            this.buttonSecondaryColor = new System.Windows.Forms.Button();
            this.buttonSaveSeconaryColor = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.inputFileName = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.replaceColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel27 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.selectionLabel = new System.Windows.Forms.Label();
            this.panel20 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.coordinatesLabel = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.checkboxTogglePreview = new System.Windows.Forms.CheckBox();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel29 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel28 = new System.Windows.Forms.Panel();
            this.panel30 = new System.Windows.Forms.Panel();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.zoomCanvas)).BeginInit();
            this.canvasPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.srcImage)).BeginInit();
            this.previewContainer.SuspendLayout();
            this.panel10.SuspendLayout();
            this.primaryColorContainer.SuspendLayout();
            this.secondaryColorContainer.SuspendLayout();
            this.panel4.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // zoomCanvas
            // 
            this.zoomCanvas.AutoSize = false;
            this.zoomCanvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.zoomCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zoomCanvas.Location = new System.Drawing.Point(8, 8);
            this.zoomCanvas.Maximum = 2;
            this.zoomCanvas.Name = "zoomCanvas";
            this.zoomCanvas.Size = new System.Drawing.Size(144, 16);
            this.zoomCanvas.TabIndex = 0;
            this.zoomCanvas.TabStop = false;
            this.zoomCanvas.TickStyle = System.Windows.Forms.TickStyle.None;
            this.zoomCanvas.Value = 1;
            this.zoomCanvas.ValueChanged += new System.EventHandler(this.zoomBar_ValueChanged);
            // 
            // buttonPencilTool
            // 
            this.buttonPencilTool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.buttonPencilTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPencilTool.FlatAppearance.BorderSize = 0;
            this.buttonPencilTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPencilTool.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonPencilTool.Location = new System.Drawing.Point(8, 96);
            this.buttonPencilTool.Name = "buttonPencilTool";
            this.buttonPencilTool.Size = new System.Drawing.Size(32, 32);
            this.buttonPencilTool.TabIndex = 9;
            this.buttonPencilTool.Text = "P";
            this.buttonPencilTool.UseVisualStyleBackColor = false;
            this.buttonPencilTool.Click += new System.EventHandler(this.buttonPencilTool_Click);
            // 
            // buttonEraserTool
            // 
            this.buttonEraserTool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.buttonEraserTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEraserTool.FlatAppearance.BorderSize = 0;
            this.buttonEraserTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEraserTool.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonEraserTool.Location = new System.Drawing.Point(8, 56);
            this.buttonEraserTool.Name = "buttonEraserTool";
            this.buttonEraserTool.Size = new System.Drawing.Size(32, 32);
            this.buttonEraserTool.TabIndex = 10;
            this.buttonEraserTool.Text = "E";
            this.buttonEraserTool.UseVisualStyleBackColor = false;
            this.buttonEraserTool.Click += new System.EventHandler(this.buttonEraserTool_Click);
            // 
            // buttonSelectTool
            // 
            this.buttonSelectTool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.buttonSelectTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSelectTool.FlatAppearance.BorderSize = 0;
            this.buttonSelectTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectTool.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonSelectTool.Location = new System.Drawing.Point(8, 16);
            this.buttonSelectTool.Name = "buttonSelectTool";
            this.buttonSelectTool.Size = new System.Drawing.Size(32, 32);
            this.buttonSelectTool.TabIndex = 11;
            this.buttonSelectTool.Text = "S";
            this.buttonSelectTool.UseVisualStyleBackColor = false;
            this.buttonSelectTool.Click += new System.EventHandler(this.buttonSelectTool_Click);
            // 
            // buttonFillTool
            // 
            this.buttonFillTool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.buttonFillTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFillTool.FlatAppearance.BorderSize = 0;
            this.buttonFillTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFillTool.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonFillTool.Location = new System.Drawing.Point(8, 136);
            this.buttonFillTool.Name = "buttonFillTool";
            this.buttonFillTool.Size = new System.Drawing.Size(32, 32);
            this.buttonFillTool.TabIndex = 12;
            this.buttonFillTool.Text = "F";
            this.buttonFillTool.UseVisualStyleBackColor = false;
            this.buttonFillTool.Click += new System.EventHandler(this.buttonFillTool_Click);
            // 
            // buttonHandTool
            // 
            this.buttonHandTool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.buttonHandTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHandTool.FlatAppearance.BorderSize = 0;
            this.buttonHandTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHandTool.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonHandTool.Location = new System.Drawing.Point(8, 176);
            this.buttonHandTool.Name = "buttonHandTool";
            this.buttonHandTool.Size = new System.Drawing.Size(32, 32);
            this.buttonHandTool.TabIndex = 13;
            this.buttonHandTool.Text = "H";
            this.buttonHandTool.UseVisualStyleBackColor = false;
            this.buttonHandTool.Click += new System.EventHandler(this.buttonHandTool_Click);
            // 
            // canvasPanel
            // 
            this.canvasPanel.APBox = this.srcImage;
            this.canvasPanel.BackColor = System.Drawing.Color.Transparent;
            this.canvasPanel.BackgroundImage = global::Pixel_Editor_Test_2.Properties.Resources.canvas_bg;
            this.canvasPanel.Controls.Add(this.previewContainer);
            this.canvasPanel.Coordinates = null;
            this.canvasPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.canvasPanel.GridColor = System.Drawing.Color.Transparent;
            this.canvasPanel.Location = new System.Drawing.Point(16, 58);
            this.canvasPanel.Margin = new System.Windows.Forms.Padding(0);
            this.canvasPanel.Name = "canvasPanel";
            this.canvasPanel.PrimaryColor = System.Drawing.Color.Black;
            this.canvasPanel.SecondaryColor = System.Drawing.Color.White;
            this.canvasPanel.Selection = null;
            this.canvasPanel.SelectionEndPos = new System.Drawing.Point(0, 0);
            this.canvasPanel.SelectionStartPos = new System.Drawing.Point(0, 0);
            this.canvasPanel.Size = new System.Drawing.Size(952, 402);
            this.canvasPanel.TabIndex = 0;
            this.canvasPanel.TgtBitmap = null;
            this.canvasPanel.TgtMousePos = new System.Drawing.Point(0, 0);
            this.canvasPanel.Viewport = new System.Drawing.Point(0, 0);
            this.canvasPanel.Zoom = 8;
            // 
            // srcImage
            // 
            this.srcImage.BackColor = System.Drawing.Color.White;
            this.srcImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.srcImage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.srcImage.Location = new System.Drawing.Point(8, 30);
            this.srcImage.Name = "srcImage";
            this.srcImage.Size = new System.Drawing.Size(248, 128);
            this.srcImage.TabIndex = 1;
            this.srcImage.TabStop = false;
            // 
            // previewContainer
            // 
            this.previewContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.previewContainer.Controls.Add(this.label1);
            this.previewContainer.Controls.Add(this.panel11);
            this.previewContainer.Controls.Add(this.srcImage);
            this.previewContainer.Location = new System.Drawing.Point(680, 10);
            this.previewContainer.Name = "previewContainer";
            this.previewContainer.Padding = new System.Windows.Forms.Padding(8);
            this.previewContainer.Size = new System.Drawing.Size(264, 166);
            this.previewContainer.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Preview";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel11.Location = new System.Drawing.Point(8, 26);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(248, 4);
            this.panel11.TabIndex = 18;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel10.Controls.Add(this.panel26);
            this.panel10.Controls.Add(this.buttonHandTool);
            this.panel10.Controls.Add(this.panel22);
            this.panel10.Controls.Add(this.buttonFillTool);
            this.panel10.Controls.Add(this.panel23);
            this.panel10.Controls.Add(this.buttonPencilTool);
            this.panel10.Controls.Add(this.panel24);
            this.panel10.Controls.Add(this.buttonEraserTool);
            this.panel10.Controls.Add(this.panel25);
            this.panel10.Controls.Add(this.buttonSelectTool);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel10.Location = new System.Drawing.Point(1232, 32);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(8, 16, 8, 8);
            this.panel10.Size = new System.Drawing.Size(48, 684);
            this.panel10.TabIndex = 21;
            this.panel10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip_MouseDown);
            this.panel10.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip_MouseMove);
            this.panel10.MouseUp += new System.Windows.Forms.MouseEventHandler(this.menuStrip_MouseUp);
            // 
            // panel26
            // 
            this.panel26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel26.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel26.Location = new System.Drawing.Point(8, 208);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(32, 8);
            this.panel26.TabIndex = 18;
            // 
            // panel22
            // 
            this.panel22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel22.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel22.Location = new System.Drawing.Point(8, 168);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(32, 8);
            this.panel22.TabIndex = 14;
            // 
            // panel23
            // 
            this.panel23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel23.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel23.Location = new System.Drawing.Point(8, 128);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(32, 8);
            this.panel23.TabIndex = 15;
            // 
            // panel24
            // 
            this.panel24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel24.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel24.Location = new System.Drawing.Point(8, 88);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(32, 8);
            this.panel24.TabIndex = 16;
            // 
            // panel25
            // 
            this.panel25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel25.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel25.Location = new System.Drawing.Point(8, 48);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(32, 8);
            this.panel25.TabIndex = 17;
            // 
            // buttonSwitchColors
            // 
            this.buttonSwitchColors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.buttonSwitchColors.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonSwitchColors.FlatAppearance.BorderSize = 0;
            this.buttonSwitchColors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSwitchColors.ForeColor = System.Drawing.Color.White;
            this.buttonSwitchColors.Location = new System.Drawing.Point(8, 8);
            this.buttonSwitchColors.Name = "buttonSwitchColors";
            this.buttonSwitchColors.Size = new System.Drawing.Size(32, 104);
            this.buttonSwitchColors.TabIndex = 13;
            this.buttonSwitchColors.Text = "<>";
            this.buttonSwitchColors.UseVisualStyleBackColor = false;
            this.buttonSwitchColors.Click += new System.EventHandler(this.buttonSwitchColors_Click);
            // 
            // checkboxToggleGrid
            // 
            this.checkboxToggleGrid.AutoSize = true;
            this.checkboxToggleGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkboxToggleGrid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.checkboxToggleGrid.Location = new System.Drawing.Point(8, 8);
            this.checkboxToggleGrid.Name = "checkboxToggleGrid";
            this.checkboxToggleGrid.Size = new System.Drawing.Size(64, 16);
            this.checkboxToggleGrid.TabIndex = 5;
            this.checkboxToggleGrid.Text = "Grid";
            this.checkboxToggleGrid.UseVisualStyleBackColor = true;
            this.checkboxToggleGrid.CheckStateChanged += new System.EventHandler(this.checkboxToggleGrid_CheckStateChanged);
            // 
            // buttonEyedropper
            // 
            this.buttonEyedropper.BackColor = System.Drawing.Color.Yellow;
            this.buttonEyedropper.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonEyedropper.FlatAppearance.BorderSize = 0;
            this.buttonEyedropper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEyedropper.ForeColor = System.Drawing.Color.White;
            this.buttonEyedropper.Location = new System.Drawing.Point(16, 436);
            this.buttonEyedropper.Name = "buttonEyedropper";
            this.buttonEyedropper.Size = new System.Drawing.Size(216, 96);
            this.buttonEyedropper.TabIndex = 18;
            this.buttonEyedropper.UseVisualStyleBackColor = false;
            this.buttonEyedropper.Click += new System.EventHandler(this.buttonEyedropper_Click);
            // 
            // primaryColorContainer
            // 
            this.primaryColorContainer.Controls.Add(this.buttonPrimaryColor);
            this.primaryColorContainer.Controls.Add(this.buttonSavePrimaryColor);
            this.primaryColorContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.primaryColorContainer.Location = new System.Drawing.Point(48, 8);
            this.primaryColorContainer.Name = "primaryColorContainer";
            this.primaryColorContainer.Size = new System.Drawing.Size(160, 48);
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
            this.buttonPrimaryColor.Size = new System.Drawing.Size(112, 48);
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
            this.buttonSavePrimaryColor.Location = new System.Drawing.Point(112, 0);
            this.buttonSavePrimaryColor.Name = "buttonSavePrimaryColor";
            this.buttonSavePrimaryColor.Size = new System.Drawing.Size(48, 48);
            this.buttonSavePrimaryColor.TabIndex = 7;
            this.buttonSavePrimaryColor.Text = "!";
            this.buttonSavePrimaryColor.UseVisualStyleBackColor = false;
            this.buttonSavePrimaryColor.Click += new System.EventHandler(this.buttonSavePrimaryColor_Click);
            // 
            // secondaryColorContainer
            // 
            this.secondaryColorContainer.Controls.Add(this.buttonSecondaryColor);
            this.secondaryColorContainer.Controls.Add(this.buttonSaveSeconaryColor);
            this.secondaryColorContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.secondaryColorContainer.Location = new System.Drawing.Point(48, 64);
            this.secondaryColorContainer.Name = "secondaryColorContainer";
            this.secondaryColorContainer.Size = new System.Drawing.Size(160, 48);
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
            this.buttonSecondaryColor.Size = new System.Drawing.Size(112, 48);
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
            this.buttonSaveSeconaryColor.Location = new System.Drawing.Point(112, 0);
            this.buttonSaveSeconaryColor.Name = "buttonSaveSeconaryColor";
            this.buttonSaveSeconaryColor.Size = new System.Drawing.Size(48, 48);
            this.buttonSaveSeconaryColor.TabIndex = 8;
            this.buttonSaveSeconaryColor.Text = "!";
            this.buttonSaveSeconaryColor.UseVisualStyleBackColor = false;
            this.buttonSaveSeconaryColor.Click += new System.EventHandler(this.buttonSaveSeconaryColor_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel4.Controls.Add(this.panel29);
            this.panel4.Controls.Add(this.panel28);
            this.panel4.Controls.Add(this.buttonEyedropper);
            this.panel4.Controls.Add(this.panel13);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 32);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(16);
            this.panel4.Size = new System.Drawing.Size(248, 684);
            this.panel4.TabIndex = 0;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip_MouseDown);
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip_MouseMove);
            this.panel4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.menuStrip_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label2.Location = new System.Drawing.Point(743, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 32);
            this.label2.TabIndex = 22;
            this.label2.Text = "Pixel Editor 3000";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // inputFileName
            // 
            this.inputFileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.inputFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputFileName.Dock = System.Windows.Forms.DockStyle.Left;
            this.inputFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputFileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.inputFileName.Location = new System.Drawing.Point(0, 0);
            this.inputFileName.MaxLength = 64;
            this.inputFileName.Name = "inputFileName";
            this.inputFileName.ShortcutsEnabled = false;
            this.inputFileName.Size = new System.Drawing.Size(248, 30);
            this.inputFileName.TabIndex = 23;
            this.inputFileName.Text = "Untitled_Sprite.png";
            this.inputFileName.WordWrap = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(16, 508);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(952, 160);
            this.panel6.TabIndex = 26;
            this.panel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip_MouseDown);
            this.panel6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip_MouseMove);
            this.panel6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.menuStrip_MouseUp);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1280, 28);
            this.menuStrip.TabIndex = 27;
            this.menuStrip.Text = "menuStrip";
            this.menuStrip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip_MouseDown);
            this.menuStrip.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip_MouseMove);
            this.menuStrip.MouseUp += new System.Windows.Forms.MouseEventHandler(this.menuStrip_MouseUp);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.newToolStripMenuItem.Text = "&New...";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.openToolStripMenuItem.Text = "&Open...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(134, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(134, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator4,
            this.replaceColorToolStripMenuItem,
            this.fXToolStripMenuItem});
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.redoToolStripMenuItem.Text = "Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(191, 6);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(191, 6);
            // 
            // replaceColorToolStripMenuItem
            // 
            this.replaceColorToolStripMenuItem.Name = "replaceColorToolStripMenuItem";
            this.replaceColorToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.replaceColorToolStripMenuItem.Text = "&Replace Color...";
            // 
            // fXToolStripMenuItem
            // 
            this.fXToolStripMenuItem.Name = "fXToolStripMenuItem";
            this.fXToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.fXToolStripMenuItem.Text = "F&X";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel19);
            this.panel1.Controls.Add(this.canvasPanel);
            this.panel1.Controls.Add(this.panel12);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(248, 32);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(16);
            this.panel1.Size = new System.Drawing.Size(984, 684);
            this.panel1.TabIndex = 28;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.menuStrip_MouseUp);
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.label2);
            this.panel19.Controls.Add(this.button2);
            this.panel19.Controls.Add(this.panel27);
            this.panel19.Controls.Add(this.inputFileName);
            this.panel19.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel19.Location = new System.Drawing.Point(16, 16);
            this.panel19.Name = "panel19";
            this.panel19.Padding = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.panel19.Size = new System.Drawing.Size(952, 48);
            this.panel19.TabIndex = 28;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.button2.Location = new System.Drawing.Point(264, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 32);
            this.button2.TabIndex = 25;
            this.button2.Text = "S";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel27
            // 
            this.panel27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel27.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel27.Location = new System.Drawing.Point(248, 0);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(16, 32);
            this.panel27.TabIndex = 24;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.panel21);
            this.panel12.Controls.Add(this.panel20);
            this.panel12.Controls.Add(this.panel14);
            this.panel12.Controls.Add(this.panel17);
            this.panel12.Controls.Add(this.panel16);
            this.panel12.Controls.Add(this.panel15);
            this.panel12.Controls.Add(this.panel18);
            this.panel12.Controls.Add(this.panel3);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel12.Location = new System.Drawing.Point(16, 460);
            this.panel12.Name = "panel12";
            this.panel12.Padding = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.panel12.Size = new System.Drawing.Size(952, 48);
            this.panel12.TabIndex = 27;
            this.panel12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip_MouseDown);
            this.panel12.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip_MouseMove);
            this.panel12.MouseUp += new System.Windows.Forms.MouseEventHandler(this.menuStrip_MouseUp);
            // 
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.panel21.Controls.Add(this.selectionLabel);
            this.panel21.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel21.Location = new System.Drawing.Point(136, 0);
            this.panel21.Name = "panel21";
            this.panel21.Padding = new System.Windows.Forms.Padding(8);
            this.panel21.Size = new System.Drawing.Size(128, 32);
            this.panel21.TabIndex = 8;
            // 
            // selectionLabel
            // 
            this.selectionLabel.AutoSize = true;
            this.selectionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectionLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.selectionLabel.Location = new System.Drawing.Point(8, 8);
            this.selectionLabel.Name = "selectionLabel";
            this.selectionLabel.Size = new System.Drawing.Size(67, 17);
            this.selectionLabel.TabIndex = 0;
            this.selectionLabel.Text = "W: 0 H: 0";
            this.selectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel20.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel20.Location = new System.Drawing.Point(128, 0);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(8, 32);
            this.panel20.TabIndex = 7;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.panel14.Controls.Add(this.coordinatesLabel);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel14.Location = new System.Drawing.Point(0, 0);
            this.panel14.Name = "panel14";
            this.panel14.Padding = new System.Windows.Forms.Padding(8);
            this.panel14.Size = new System.Drawing.Size(128, 32);
            this.panel14.TabIndex = 6;
            // 
            // coordinatesLabel
            // 
            this.coordinatesLabel.AutoSize = true;
            this.coordinatesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.coordinatesLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.coordinatesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.coordinatesLabel.Location = new System.Drawing.Point(8, 8);
            this.coordinatesLabel.Name = "coordinatesLabel";
            this.coordinatesLabel.Size = new System.Drawing.Size(62, 17);
            this.coordinatesLabel.TabIndex = 0;
            this.coordinatesLabel.Text = "X: 0 Y: 0";
            this.coordinatesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.panel17.Controls.Add(this.checkboxTogglePreview);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel17.Location = new System.Drawing.Point(600, 0);
            this.panel17.Name = "panel17";
            this.panel17.Padding = new System.Windows.Forms.Padding(8);
            this.panel17.Size = new System.Drawing.Size(96, 32);
            this.panel17.TabIndex = 3;
            // 
            // checkboxTogglePreview
            // 
            this.checkboxTogglePreview.AutoSize = true;
            this.checkboxTogglePreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkboxTogglePreview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.checkboxTogglePreview.Location = new System.Drawing.Point(8, 8);
            this.checkboxTogglePreview.Name = "checkboxTogglePreview";
            this.checkboxTogglePreview.Size = new System.Drawing.Size(80, 16);
            this.checkboxTogglePreview.TabIndex = 6;
            this.checkboxTogglePreview.Text = "Preview";
            this.checkboxTogglePreview.UseVisualStyleBackColor = true;
            this.checkboxTogglePreview.CheckStateChanged += new System.EventHandler(this.checkboxTogglePreview_CheckStateChanged);
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel16.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel16.Location = new System.Drawing.Point(696, 0);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(8, 32);
            this.panel16.TabIndex = 2;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.panel15.Controls.Add(this.checkboxToggleGrid);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel15.Location = new System.Drawing.Point(704, 0);
            this.panel15.Name = "panel15";
            this.panel15.Padding = new System.Windows.Forms.Padding(8);
            this.panel15.Size = new System.Drawing.Size(80, 32);
            this.panel15.TabIndex = 1;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel18.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel18.Location = new System.Drawing.Point(784, 0);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(8, 32);
            this.panel18.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.panel3.Controls.Add(this.zoomCanvas);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(792, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(8);
            this.panel3.Size = new System.Drawing.Size(160, 32);
            this.panel3.TabIndex = 5;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(1232, -1);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(48, 31);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 28);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1280, 4);
            this.panel8.TabIndex = 18;
            // 
            // panel29
            // 
            this.panel29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel29.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel29.Location = new System.Drawing.Point(16, 16);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(216, 404);
            this.panel29.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.primaryColorContainer);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.secondaryColorContainer);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.buttonSwitchColors);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(16, 548);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(8);
            this.panel2.Size = new System.Drawing.Size(216, 120);
            this.panel2.TabIndex = 22;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(48, 56);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(160, 8);
            this.panel5.TabIndex = 22;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(48, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(160, 8);
            this.panel7.TabIndex = 23;
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(40, 8);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(8, 104);
            this.panel9.TabIndex = 24;
            // 
            // panel13
            // 
            this.panel13.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel13.Location = new System.Drawing.Point(16, 532);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(216, 16);
            this.panel13.TabIndex = 23;
            // 
            // panel28
            // 
            this.panel28.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel28.Location = new System.Drawing.Point(16, 420);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(216, 16);
            this.panel28.TabIndex = 24;
            // 
            // panel30
            // 
            this.panel30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel30.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel30.Location = new System.Drawing.Point(0, 716);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(1280, 4);
            this.panel30.TabIndex = 29;
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            // 
            // EditorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.panel30);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditorWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Untitled Sprite";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditorWindow_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.zoomCanvas)).EndInit();
            this.canvasPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.srcImage)).EndInit();
            this.previewContainer.ResumeLayout(false);
            this.previewContainer.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.primaryColorContainer.ResumeLayout(false);
            this.secondaryColorContainer.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PixelEditor canvasPanel;
        private System.Windows.Forms.PictureBox srcImage;
        private System.Windows.Forms.TrackBar zoomCanvas;
        private System.Windows.Forms.Button buttonPencilTool;
        private System.Windows.Forms.Button buttonEraserTool;
        private System.Windows.Forms.Button buttonSelectTool;
        private System.Windows.Forms.Button buttonFillTool;
        private System.Windows.Forms.Button buttonHandTool;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel previewContainer;
        private System.Windows.Forms.Button buttonSwitchColors;
        private System.Windows.Forms.CheckBox checkboxToggleGrid;
        private System.Windows.Forms.Panel primaryColorContainer;
        private System.Windows.Forms.Button buttonSavePrimaryColor;
        private System.Windows.Forms.Button buttonPrimaryColor;
        private System.Windows.Forms.Panel secondaryColorContainer;
        private System.Windows.Forms.Button buttonSaveSeconaryColor;
        private System.Windows.Forms.Button buttonSecondaryColor;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputFileName;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Button buttonEyedropper;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem replaceColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fXToolStripMenuItem;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.CheckBox checkboxTogglePreview;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label coordinatesLabel;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Label selectionLabel;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.Panel panel29;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel30;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
    }
}

