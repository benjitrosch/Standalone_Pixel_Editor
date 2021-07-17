
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
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.buttonFill = new Pixel_Editor_Test_2.Controls.ToolButton();
            this.buttonPencil = new Pixel_Editor_Test_2.Controls.ToolButton();
            this.buttonEraser = new Pixel_Editor_Test_2.Controls.ToolButton();
            this.buttonMagic = new Pixel_Editor_Test_2.Controls.ToolButton();
            this.buttonSelect = new Pixel_Editor_Test_2.Controls.ToolButton();
            this.buttonHand = new Pixel_Editor_Test_2.Controls.ToolButton();
            this.buttonLine = new Pixel_Editor_Test_2.Controls.ToolButton();
            this.buttonDropper = new Pixel_Editor_Test_2.Controls.ToolButton();
            this.buttonRectangle = new Pixel_Editor_Test_2.Controls.ToolButton();
            this.buttonEllipse = new Pixel_Editor_Test_2.Controls.ToolButton();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Black;
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Margin = new System.Windows.Forms.Padding(0);
            this.panel11.Name = "panel11";
            this.panel11.Padding = new System.Windows.Forms.Padding(1);
            this.panel11.Size = new System.Drawing.Size(48, 688);
            this.panel11.TabIndex = 21;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            this.panel12.Controls.Add(this.buttonEllipse);
            this.panel12.Controls.Add(this.buttonRectangle);
            this.panel12.Controls.Add(this.buttonDropper);
            this.panel12.Controls.Add(this.buttonLine);
            this.panel12.Controls.Add(this.buttonHand);
            this.panel12.Controls.Add(this.buttonFill);
            this.panel12.Controls.Add(this.buttonPencil);
            this.panel12.Controls.Add(this.buttonEraser);
            this.panel12.Controls.Add(this.buttonMagic);
            this.panel12.Controls.Add(this.buttonSelect);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(1, 1);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(46, 686);
            this.panel12.TabIndex = 0;
            // 
            // buttonFill
            // 
            this.buttonFill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            this.buttonFill.ButtonTool = Pixel_Editor_Test_2.Controls.PixelEditor.PixelEditor.Tool.FILL;
            this.buttonFill.Icon = global::Pixel_Editor_Test_2.Properties.Resources.fill_icon;
            this.buttonFill.Location = new System.Drawing.Point(6, 208);
            this.buttonFill.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFill.Name = "buttonFill";
            this.buttonFill.Size = new System.Drawing.Size(36, 36);
            this.buttonFill.TabIndex = 23;
            this.buttonFill.ToolCallback = null;
            this.buttonFill.Load += new System.EventHandler(this.buttonFill_Load);
            // 
            // buttonPencil
            // 
            this.buttonPencil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            this.buttonPencil.ButtonTool = Pixel_Editor_Test_2.Controls.PixelEditor.PixelEditor.Tool.PENCIL;
            this.buttonPencil.Icon = global::Pixel_Editor_Test_2.Properties.Resources.brush_icon;
            this.buttonPencil.Location = new System.Drawing.Point(6, 160);
            this.buttonPencil.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPencil.Name = "buttonPencil";
            this.buttonPencil.Size = new System.Drawing.Size(36, 36);
            this.buttonPencil.TabIndex = 7;
            this.buttonPencil.ToolCallback = null;
            this.buttonPencil.Load += new System.EventHandler(this.buttonPencil_Load);
            // 
            // buttonEraser
            // 
            this.buttonEraser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            this.buttonEraser.ButtonTool = Pixel_Editor_Test_2.Controls.PixelEditor.PixelEditor.Tool.ERASER;
            this.buttonEraser.Icon = global::Pixel_Editor_Test_2.Properties.Resources.eraser_icon;
            this.buttonEraser.Location = new System.Drawing.Point(6, 112);
            this.buttonEraser.Margin = new System.Windows.Forms.Padding(0);
            this.buttonEraser.Name = "buttonEraser";
            this.buttonEraser.Size = new System.Drawing.Size(36, 36);
            this.buttonEraser.TabIndex = 5;
            this.buttonEraser.ToolCallback = null;
            this.buttonEraser.Load += new System.EventHandler(this.buttonEraser_Load);
            // 
            // buttonMagic
            // 
            this.buttonMagic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            this.buttonMagic.ButtonTool = Pixel_Editor_Test_2.Controls.PixelEditor.PixelEditor.Tool.MAGICWAND;
            this.buttonMagic.Icon = global::Pixel_Editor_Test_2.Properties.Resources.magic_icon;
            this.buttonMagic.Location = new System.Drawing.Point(6, 64);
            this.buttonMagic.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMagic.Name = "buttonMagic";
            this.buttonMagic.Size = new System.Drawing.Size(36, 36);
            this.buttonMagic.TabIndex = 3;
            this.buttonMagic.ToolCallback = null;
            this.buttonMagic.Load += new System.EventHandler(this.buttonMagic_Load);
            // 
            // buttonSelect
            // 
            this.buttonSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            this.buttonSelect.ButtonTool = Pixel_Editor_Test_2.Controls.PixelEditor.PixelEditor.Tool.SELECT;
            this.buttonSelect.Icon = global::Pixel_Editor_Test_2.Properties.Resources.select_icon;
            this.buttonSelect.Location = new System.Drawing.Point(6, 16);
            this.buttonSelect.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(36, 36);
            this.buttonSelect.TabIndex = 1;
            this.buttonSelect.ToolCallback = null;
            this.buttonSelect.Load += new System.EventHandler(this.buttonSelect_Load);
            // 
            // buttonHand
            // 
            this.buttonHand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            this.buttonHand.ButtonTool = Pixel_Editor_Test_2.Controls.PixelEditor.PixelEditor.Tool.HAND;
            this.buttonHand.Icon = global::Pixel_Editor_Test_2.Properties.Resources.hand_icon;
            this.buttonHand.Location = new System.Drawing.Point(6, 256);
            this.buttonHand.Margin = new System.Windows.Forms.Padding(0);
            this.buttonHand.Name = "buttonHand";
            this.buttonHand.Size = new System.Drawing.Size(36, 36);
            this.buttonHand.TabIndex = 25;
            this.buttonHand.ToolCallback = null;
            this.buttonHand.Load += new System.EventHandler(this.buttonHand_Load);
            // 
            // buttonLine
            // 
            this.buttonLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            this.buttonLine.ButtonTool = Pixel_Editor_Test_2.Controls.PixelEditor.PixelEditor.Tool.LINE;
            this.buttonLine.Icon = global::Pixel_Editor_Test_2.Properties.Resources.line_icon;
            this.buttonLine.Location = new System.Drawing.Point(6, 304);
            this.buttonLine.Margin = new System.Windows.Forms.Padding(0);
            this.buttonLine.Name = "buttonLine";
            this.buttonLine.Size = new System.Drawing.Size(36, 36);
            this.buttonLine.TabIndex = 27;
            this.buttonLine.ToolCallback = null;
            this.buttonLine.Load += new System.EventHandler(this.buttonLine_Load);
            // 
            // buttonDropper
            // 
            this.buttonDropper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            this.buttonDropper.ButtonTool = Pixel_Editor_Test_2.Controls.PixelEditor.PixelEditor.Tool.EYEDROPPER;
            this.buttonDropper.Icon = global::Pixel_Editor_Test_2.Properties.Resources.eyedropper_icon;
            this.buttonDropper.Location = new System.Drawing.Point(6, 352);
            this.buttonDropper.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDropper.Name = "buttonDropper";
            this.buttonDropper.Size = new System.Drawing.Size(36, 36);
            this.buttonDropper.TabIndex = 29;
            this.buttonDropper.ToolCallback = null;
            this.buttonDropper.Load += new System.EventHandler(this.buttonDropper_Load);
            // 
            // buttonRectangle
            // 
            this.buttonRectangle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            this.buttonRectangle.ButtonTool = Pixel_Editor_Test_2.Controls.PixelEditor.PixelEditor.Tool.RECTANGLE;
            this.buttonRectangle.Icon = global::Pixel_Editor_Test_2.Properties.Resources.rectangle_icon;
            this.buttonRectangle.Location = new System.Drawing.Point(6, 400);
            this.buttonRectangle.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRectangle.Name = "buttonRectangle";
            this.buttonRectangle.Size = new System.Drawing.Size(36, 36);
            this.buttonRectangle.TabIndex = 31;
            this.buttonRectangle.ToolCallback = null;
            this.buttonRectangle.Load += new System.EventHandler(this.buttonRectangle_Load);
            // 
            // buttonEllipse
            // 
            this.buttonEllipse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(254)))), ((int)(((byte)(221)))));
            this.buttonEllipse.ButtonTool = Pixel_Editor_Test_2.Controls.PixelEditor.PixelEditor.Tool.OVAL;
            this.buttonEllipse.Icon = global::Pixel_Editor_Test_2.Properties.Resources.ellipse_icon;
            this.buttonEllipse.Location = new System.Drawing.Point(6, 448);
            this.buttonEllipse.Margin = new System.Windows.Forms.Padding(0);
            this.buttonEllipse.Name = "buttonEllipse";
            this.buttonEllipse.Size = new System.Drawing.Size(36, 36);
            this.buttonEllipse.TabIndex = 33;
            this.buttonEllipse.ToolCallback = null;
            this.buttonEllipse.Load += new System.EventHandler(this.buttonEllipse_Load);
            // 
            // Toolbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel11);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Toolbar";
            this.Size = new System.Drawing.Size(48, 688);
            this.panel11.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
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
