
namespace Pixel_Editor_Test_2.Controls
{
    partial class ActiveColors
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
            this.buttonSavePrimaryColor = new System.Windows.Forms.Button();
            this.primaryContainer = new System.Windows.Forms.Panel();
            this.primaryColorPanel = new System.Windows.Forms.Panel();
            this.buttonPrimaryColor = new System.Windows.Forms.Button();
            this.secondaryContainer = new System.Windows.Forms.Panel();
            this.buttonSaveSecondaryColor = new System.Windows.Forms.Button();
            this.secondaryColorPanel = new System.Windows.Forms.Panel();
            this.buttonSecondaryColor = new System.Windows.Forms.Button();
            this.boxShadow = new System.Windows.Forms.Panel();
            this.boxOutline = new System.Windows.Forms.Panel();
            this.boxContainer = new System.Windows.Forms.Panel();
            this.primaryContainer.SuspendLayout();
            this.primaryColorPanel.SuspendLayout();
            this.secondaryContainer.SuspendLayout();
            this.secondaryColorPanel.SuspendLayout();
            this.boxOutline.SuspendLayout();
            this.boxContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSavePrimaryColor
            // 
            this.buttonSavePrimaryColor.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonSavePrimaryColor.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSavePrimaryColor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSavePrimaryColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSavePrimaryColor.Font = new System.Drawing.Font("8-bit Operator+", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSavePrimaryColor.ForeColor = System.Drawing.Color.White;
            this.buttonSavePrimaryColor.Location = new System.Drawing.Point(163, 5);
            this.buttonSavePrimaryColor.Name = "buttonSavePrimaryColor";
            this.buttonSavePrimaryColor.Size = new System.Drawing.Size(32, 32);
            this.buttonSavePrimaryColor.TabIndex = 4;
            this.buttonSavePrimaryColor.Text = "+";
            this.buttonSavePrimaryColor.UseVisualStyleBackColor = false;
            this.buttonSavePrimaryColor.Click += new System.EventHandler(this.buttonSavePrimaryColor_Click);
            // 
            // primaryContainer
            // 
            this.primaryContainer.BackColor = System.Drawing.Color.White;
            this.primaryContainer.Controls.Add(this.buttonSavePrimaryColor);
            this.primaryContainer.Controls.Add(this.primaryColorPanel);
            this.primaryContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.primaryContainer.Location = new System.Drawing.Point(0, 0);
            this.primaryContainer.Name = "primaryContainer";
            this.primaryContainer.Padding = new System.Windows.Forms.Padding(5, 5, 5, 2);
            this.primaryContainer.Size = new System.Drawing.Size(200, 39);
            this.primaryContainer.TabIndex = 5;
            // 
            // primaryColorPanel
            // 
            this.primaryColorPanel.BackColor = System.Drawing.Color.Transparent;
            this.primaryColorPanel.Controls.Add(this.buttonPrimaryColor);
            this.primaryColorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.primaryColorPanel.Location = new System.Drawing.Point(5, 5);
            this.primaryColorPanel.Name = "primaryColorPanel";
            this.primaryColorPanel.Size = new System.Drawing.Size(190, 32);
            this.primaryColorPanel.TabIndex = 6;
            // 
            // buttonPrimaryColor
            // 
            this.buttonPrimaryColor.BackColor = System.Drawing.Color.Magenta;
            this.buttonPrimaryColor.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonPrimaryColor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonPrimaryColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrimaryColor.ForeColor = System.Drawing.Color.White;
            this.buttonPrimaryColor.Location = new System.Drawing.Point(0, 0);
            this.buttonPrimaryColor.Name = "buttonPrimaryColor";
            this.buttonPrimaryColor.Size = new System.Drawing.Size(160, 32);
            this.buttonPrimaryColor.TabIndex = 8;
            this.buttonPrimaryColor.Text = "255 255 255";
            this.buttonPrimaryColor.UseVisualStyleBackColor = false;
            // 
            // secondaryContainer
            // 
            this.secondaryContainer.BackColor = System.Drawing.Color.White;
            this.secondaryContainer.Controls.Add(this.buttonSaveSecondaryColor);
            this.secondaryContainer.Controls.Add(this.secondaryColorPanel);
            this.secondaryContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.secondaryContainer.Location = new System.Drawing.Point(0, 39);
            this.secondaryContainer.Name = "secondaryContainer";
            this.secondaryContainer.Padding = new System.Windows.Forms.Padding(5, 2, 5, 5);
            this.secondaryContainer.Size = new System.Drawing.Size(200, 39);
            this.secondaryContainer.TabIndex = 6;
            // 
            // buttonSaveSecondaryColor
            // 
            this.buttonSaveSecondaryColor.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonSaveSecondaryColor.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSaveSecondaryColor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSaveSecondaryColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveSecondaryColor.Font = new System.Drawing.Font("8-bit Operator+", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveSecondaryColor.ForeColor = System.Drawing.Color.White;
            this.buttonSaveSecondaryColor.Location = new System.Drawing.Point(163, 2);
            this.buttonSaveSecondaryColor.Name = "buttonSaveSecondaryColor";
            this.buttonSaveSecondaryColor.Size = new System.Drawing.Size(32, 32);
            this.buttonSaveSecondaryColor.TabIndex = 4;
            this.buttonSaveSecondaryColor.Text = "+";
            this.buttonSaveSecondaryColor.UseVisualStyleBackColor = false;
            this.buttonSaveSecondaryColor.Click += new System.EventHandler(this.buttonSaveSecondaryColor_Click);
            // 
            // secondaryColorPanel
            // 
            this.secondaryColorPanel.BackColor = System.Drawing.Color.Transparent;
            this.secondaryColorPanel.Controls.Add(this.buttonSecondaryColor);
            this.secondaryColorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.secondaryColorPanel.Location = new System.Drawing.Point(5, 2);
            this.secondaryColorPanel.Name = "secondaryColorPanel";
            this.secondaryColorPanel.Size = new System.Drawing.Size(190, 32);
            this.secondaryColorPanel.TabIndex = 6;
            // 
            // buttonSecondaryColor
            // 
            this.buttonSecondaryColor.BackColor = System.Drawing.Color.Magenta;
            this.buttonSecondaryColor.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonSecondaryColor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSecondaryColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSecondaryColor.ForeColor = System.Drawing.Color.White;
            this.buttonSecondaryColor.Location = new System.Drawing.Point(0, 0);
            this.buttonSecondaryColor.Name = "buttonSecondaryColor";
            this.buttonSecondaryColor.Size = new System.Drawing.Size(160, 32);
            this.buttonSecondaryColor.TabIndex = 8;
            this.buttonSecondaryColor.Text = "255 255 255";
            this.buttonSecondaryColor.UseVisualStyleBackColor = false;
            // 
            // boxShadow
            // 
            this.boxShadow.BackColor = System.Drawing.Color.Black;
            this.boxShadow.Location = new System.Drawing.Point(8, 8);
            this.boxShadow.Name = "boxShadow";
            this.boxShadow.Size = new System.Drawing.Size(202, 80);
            this.boxShadow.TabIndex = 1;
            // 
            // boxOutline
            // 
            this.boxOutline.BackColor = System.Drawing.Color.Black;
            this.boxOutline.Controls.Add(this.boxContainer);
            this.boxOutline.Location = new System.Drawing.Point(0, 0);
            this.boxOutline.Margin = new System.Windows.Forms.Padding(0);
            this.boxOutline.Name = "boxOutline";
            this.boxOutline.Padding = new System.Windows.Forms.Padding(1);
            this.boxOutline.Size = new System.Drawing.Size(202, 80);
            this.boxOutline.TabIndex = 7;
            // 
            // boxContainer
            // 
            this.boxContainer.BackColor = System.Drawing.Color.White;
            this.boxContainer.Controls.Add(this.secondaryContainer);
            this.boxContainer.Controls.Add(this.primaryContainer);
            this.boxContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxContainer.Location = new System.Drawing.Point(1, 1);
            this.boxContainer.Margin = new System.Windows.Forms.Padding(0);
            this.boxContainer.Name = "boxContainer";
            this.boxContainer.Size = new System.Drawing.Size(200, 78);
            this.boxContainer.TabIndex = 0;
            // 
            // ActiveColors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.boxOutline);
            this.Controls.Add(this.boxShadow);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ActiveColors";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Size = new System.Drawing.Size(210, 88);
            this.primaryContainer.ResumeLayout(false);
            this.primaryColorPanel.ResumeLayout(false);
            this.secondaryContainer.ResumeLayout(false);
            this.secondaryColorPanel.ResumeLayout(false);
            this.boxOutline.ResumeLayout(false);
            this.boxContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel primaryContainer;
        private System.Windows.Forms.Button buttonSavePrimaryColor;
        private System.Windows.Forms.Panel secondaryContainer;
        private System.Windows.Forms.Button buttonSaveSecondaryColor;
        private System.Windows.Forms.Panel boxShadow;
        private System.Windows.Forms.Panel primaryColorPanel;
        private System.Windows.Forms.Button buttonPrimaryColor;
        private System.Windows.Forms.Panel secondaryColorPanel;
        private System.Windows.Forms.Button buttonSecondaryColor;
        private System.Windows.Forms.Panel boxOutline;
        private System.Windows.Forms.Panel boxContainer;
    }
}
