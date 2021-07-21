
namespace Pixel_Editor_Test_2.Controls
{
    partial class Toolbar
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
            this.toolContainer = new System.Windows.Forms.Panel();
            this.buttonEllipse = new Pixel_Editor_Test_2.Controls.ToolButton();
            this.buttonRectangle = new Pixel_Editor_Test_2.Controls.ToolButton();
            this.buttonDropper = new Pixel_Editor_Test_2.Controls.ToolButton();
            this.buttonLine = new Pixel_Editor_Test_2.Controls.ToolButton();
            this.buttonHand = new Pixel_Editor_Test_2.Controls.ToolButton();
            this.buttonFill = new Pixel_Editor_Test_2.Controls.ToolButton();
            this.buttonPencil = new Pixel_Editor_Test_2.Controls.ToolButton();
            this.buttonEraser = new Pixel_Editor_Test_2.Controls.ToolButton();
            this.buttonMagic = new Pixel_Editor_Test_2.Controls.ToolButton();
            this.buttonSelect = new Pixel_Editor_Test_2.Controls.ToolButton();
            this.boxOutline.SuspendLayout();
            this.toolContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxOutline
            // 
            this.boxOutline.BackColor = System.Drawing.Color.Black;
            this.boxOutline.Controls.Add(this.toolContainer);
            this.boxOutline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxOutline.Location = new System.Drawing.Point(0, 0);
            this.boxOutline.Margin = new System.Windows.Forms.Padding(0);
            this.boxOutline.Name = "boxOutline";
            this.boxOutline.Padding = new System.Windows.Forms.Padding(1);
            this.boxOutline.Size = new System.Drawing.Size(48, 688);
            this.boxOutline.TabIndex = 21;
            // 
            // toolContainer
            // 
            this.toolContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            this.toolContainer.Controls.Add(this.buttonEllipse);
            this.toolContainer.Controls.Add(this.buttonRectangle);
            this.toolContainer.Controls.Add(this.buttonDropper);
            this.toolContainer.Controls.Add(this.buttonLine);
            this.toolContainer.Controls.Add(this.buttonHand);
            this.toolContainer.Controls.Add(this.buttonFill);
            this.toolContainer.Controls.Add(this.buttonPencil);
            this.toolContainer.Controls.Add(this.buttonEraser);
            this.toolContainer.Controls.Add(this.buttonMagic);
            this.toolContainer.Controls.Add(this.buttonSelect);
            this.toolContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolContainer.Location = new System.Drawing.Point(1, 1);
            this.toolContainer.Name = "toolContainer";
            this.toolContainer.Size = new System.Drawing.Size(46, 686);
            this.toolContainer.TabIndex = 0;
            // 
            // buttonEllipse
            // 
            this.buttonEllipse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            this.buttonEllipse.ButtonTool = Pixel_Editor_Test_2.Controls.PixelEditor.PixelEditor.Tool.OVAL;
            this.buttonEllipse.Callback = null;
            this.buttonEllipse.Icon = global::Pixel_Editor_Test_2.Properties.Resources.ellipse_icon;
            this.buttonEllipse.Location = new System.Drawing.Point(6, 448);
            this.buttonEllipse.Margin = new System.Windows.Forms.Padding(0);
            this.buttonEllipse.Name = "buttonEllipse";
            this.buttonEllipse.Size = new System.Drawing.Size(36, 36);
            this.buttonEllipse.TabIndex = 33;
            this.buttonEllipse.Load += new System.EventHandler(this.buttonEllipse_Load);
            // 
            // buttonRectangle
            // 
            this.buttonRectangle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            this.buttonRectangle.ButtonTool = Pixel_Editor_Test_2.Controls.PixelEditor.PixelEditor.Tool.RECTANGLE;
            this.buttonRectangle.Callback = null;
            this.buttonRectangle.Icon = global::Pixel_Editor_Test_2.Properties.Resources.rectangle_icon;
            this.buttonRectangle.Location = new System.Drawing.Point(6, 400);
            this.buttonRectangle.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRectangle.Name = "buttonRectangle";
            this.buttonRectangle.Size = new System.Drawing.Size(36, 36);
            this.buttonRectangle.TabIndex = 31;
            this.buttonRectangle.Load += new System.EventHandler(this.buttonRectangle_Load);
            // 
            // buttonDropper
            // 
            this.buttonDropper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            this.buttonDropper.ButtonTool = Pixel_Editor_Test_2.Controls.PixelEditor.PixelEditor.Tool.EYEDROPPER;
            this.buttonDropper.Callback = null;
            this.buttonDropper.Icon = global::Pixel_Editor_Test_2.Properties.Resources.eyedropper_icon;
            this.buttonDropper.Location = new System.Drawing.Point(6, 352);
            this.buttonDropper.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDropper.Name = "buttonDropper";
            this.buttonDropper.Size = new System.Drawing.Size(36, 36);
            this.buttonDropper.TabIndex = 29;
            this.buttonDropper.Load += new System.EventHandler(this.buttonDropper_Load);
            // 
            // buttonLine
            // 
            this.buttonLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            this.buttonLine.ButtonTool = Pixel_Editor_Test_2.Controls.PixelEditor.PixelEditor.Tool.LINE;
            this.buttonLine.Callback = null;
            this.buttonLine.Icon = global::Pixel_Editor_Test_2.Properties.Resources.line_icon;
            this.buttonLine.Location = new System.Drawing.Point(6, 304);
            this.buttonLine.Margin = new System.Windows.Forms.Padding(0);
            this.buttonLine.Name = "buttonLine";
            this.buttonLine.Size = new System.Drawing.Size(36, 36);
            this.buttonLine.TabIndex = 27;
            this.buttonLine.Load += new System.EventHandler(this.buttonLine_Load);
            // 
            // buttonHand
            // 
            this.buttonHand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            this.buttonHand.ButtonTool = Pixel_Editor_Test_2.Controls.PixelEditor.PixelEditor.Tool.HAND;
            this.buttonHand.Callback = null;
            this.buttonHand.Icon = global::Pixel_Editor_Test_2.Properties.Resources.hand_icon;
            this.buttonHand.Location = new System.Drawing.Point(6, 256);
            this.buttonHand.Margin = new System.Windows.Forms.Padding(0);
            this.buttonHand.Name = "buttonHand";
            this.buttonHand.Size = new System.Drawing.Size(36, 36);
            this.buttonHand.TabIndex = 25;
            this.buttonHand.Load += new System.EventHandler(this.buttonHand_Load);
            // 
            // buttonFill
            // 
            this.buttonFill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            this.buttonFill.ButtonTool = Pixel_Editor_Test_2.Controls.PixelEditor.PixelEditor.Tool.FILL;
            this.buttonFill.Callback = null;
            this.buttonFill.Icon = global::Pixel_Editor_Test_2.Properties.Resources.fill_icon;
            this.buttonFill.Location = new System.Drawing.Point(6, 208);
            this.buttonFill.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFill.Name = "buttonFill";
            this.buttonFill.Size = new System.Drawing.Size(36, 36);
            this.buttonFill.TabIndex = 23;
            this.buttonFill.Load += new System.EventHandler(this.buttonFill_Load);
            // 
            // buttonPencil
            // 
            this.buttonPencil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            this.buttonPencil.ButtonTool = Pixel_Editor_Test_2.Controls.PixelEditor.PixelEditor.Tool.PENCIL;
            this.buttonPencil.Callback = null;
            this.buttonPencil.Icon = global::Pixel_Editor_Test_2.Properties.Resources.brush_icon;
            this.buttonPencil.Location = new System.Drawing.Point(6, 160);
            this.buttonPencil.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPencil.Name = "buttonPencil";
            this.buttonPencil.Size = new System.Drawing.Size(36, 36);
            this.buttonPencil.TabIndex = 7;
            this.buttonPencil.Load += new System.EventHandler(this.buttonPencil_Load);
            // 
            // buttonEraser
            // 
            this.buttonEraser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            this.buttonEraser.ButtonTool = Pixel_Editor_Test_2.Controls.PixelEditor.PixelEditor.Tool.ERASER;
            this.buttonEraser.Callback = null;
            this.buttonEraser.Icon = global::Pixel_Editor_Test_2.Properties.Resources.eraser_icon;
            this.buttonEraser.Location = new System.Drawing.Point(6, 112);
            this.buttonEraser.Margin = new System.Windows.Forms.Padding(0);
            this.buttonEraser.Name = "buttonEraser";
            this.buttonEraser.Size = new System.Drawing.Size(36, 36);
            this.buttonEraser.TabIndex = 5;
            this.buttonEraser.Load += new System.EventHandler(this.buttonEraser_Load);
            // 
            // buttonMagic
            // 
            this.buttonMagic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            this.buttonMagic.ButtonTool = Pixel_Editor_Test_2.Controls.PixelEditor.PixelEditor.Tool.MAGICWAND;
            this.buttonMagic.Callback = null;
            this.buttonMagic.Icon = global::Pixel_Editor_Test_2.Properties.Resources.magic_icon;
            this.buttonMagic.Location = new System.Drawing.Point(6, 64);
            this.buttonMagic.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMagic.Name = "buttonMagic";
            this.buttonMagic.Size = new System.Drawing.Size(36, 36);
            this.buttonMagic.TabIndex = 3;
            this.buttonMagic.Load += new System.EventHandler(this.buttonMagic_Load);
            // 
            // buttonSelect
            // 
            this.buttonSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            this.buttonSelect.ButtonTool = Pixel_Editor_Test_2.Controls.PixelEditor.PixelEditor.Tool.SELECT;
            this.buttonSelect.Callback = null;
            this.buttonSelect.Icon = global::Pixel_Editor_Test_2.Properties.Resources.select_icon;
            this.buttonSelect.Location = new System.Drawing.Point(6, 16);
            this.buttonSelect.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(36, 36);
            this.buttonSelect.TabIndex = 1;
            this.buttonSelect.Load += new System.EventHandler(this.buttonSelect_Load);
            // 
            // Toolbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.boxOutline);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Toolbar";
            this.Size = new System.Drawing.Size(48, 688);
            this.boxOutline.ResumeLayout(false);
            this.toolContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel boxOutline;
        private System.Windows.Forms.Panel toolContainer;
        private ToolButton buttonSelect;
        private ToolButton buttonMagic;
        private ToolButton buttonEraser;
        private ToolButton buttonPencil;
        private ToolButton buttonFill;
        private ToolButton buttonHand;
        private ToolButton buttonLine;
        private ToolButton buttonDropper;
        private ToolButton buttonRectangle;
        private ToolButton buttonEllipse;
    }
}
