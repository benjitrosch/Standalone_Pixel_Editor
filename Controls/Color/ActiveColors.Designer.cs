
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
            this.boxShadow = new System.Windows.Forms.Panel();
            this.buttonSavePrimaryColor = new System.Windows.Forms.Button();
            this.primaryContainer = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonPrimaryColor = new System.Windows.Forms.Button();
            this.secondaryContainer = new System.Windows.Forms.Panel();
            this.buttonSaveSecondaryColor = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonSecondaryColor = new System.Windows.Forms.Button();
            this.container = new Pixel_Editor_Test_2.Controls.Container();
            this.primaryContainer.SuspendLayout();
            this.panel4.SuspendLayout();
            this.secondaryContainer.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxShadow
            // 
            this.boxShadow.BackColor = System.Drawing.Color.Black;
            this.boxShadow.Location = new System.Drawing.Point(8, 8);
            this.boxShadow.Name = "boxShadow";
            this.boxShadow.Size = new System.Drawing.Size(216, 80);
            this.boxShadow.TabIndex = 1;
            // 
            // buttonSavePrimaryColor
            // 
            this.buttonSavePrimaryColor.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonSavePrimaryColor.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSavePrimaryColor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSavePrimaryColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSavePrimaryColor.Font = new System.Drawing.Font("8-bit Operator+", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSavePrimaryColor.ForeColor = System.Drawing.Color.White;
            this.buttonSavePrimaryColor.Location = new System.Drawing.Point(177, 5);
            this.buttonSavePrimaryColor.Name = "buttonSavePrimaryColor";
            this.buttonSavePrimaryColor.Size = new System.Drawing.Size(32, 29);
            this.buttonSavePrimaryColor.TabIndex = 4;
            this.buttonSavePrimaryColor.Text = "+";
            this.buttonSavePrimaryColor.UseVisualStyleBackColor = false;
            this.buttonSavePrimaryColor.Click += new System.EventHandler(this.buttonSavePrimaryColor_Click);
            // 
            // primaryContainer
            // 
            this.primaryContainer.BackColor = System.Drawing.Color.White;
            this.primaryContainer.Controls.Add(this.buttonSavePrimaryColor);
            this.primaryContainer.Controls.Add(this.panel4);
            this.primaryContainer.Location = new System.Drawing.Point(1, 1);
            this.primaryContainer.Name = "primaryContainer";
            this.primaryContainer.Padding = new System.Windows.Forms.Padding(5);
            this.primaryContainer.Size = new System.Drawing.Size(214, 39);
            this.primaryContainer.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonPrimaryColor);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(5, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(204, 29);
            this.panel4.TabIndex = 6;
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
            this.buttonPrimaryColor.Size = new System.Drawing.Size(160, 29);
            this.buttonPrimaryColor.TabIndex = 8;
            this.buttonPrimaryColor.Text = "255 255 255";
            this.buttonPrimaryColor.UseVisualStyleBackColor = false;
            // 
            // secondaryContainer
            // 
            this.secondaryContainer.BackColor = System.Drawing.Color.White;
            this.secondaryContainer.Controls.Add(this.buttonSaveSecondaryColor);
            this.secondaryContainer.Controls.Add(this.panel5);
            this.secondaryContainer.Location = new System.Drawing.Point(1, 40);
            this.secondaryContainer.Name = "secondaryContainer";
            this.secondaryContainer.Padding = new System.Windows.Forms.Padding(5);
            this.secondaryContainer.Size = new System.Drawing.Size(214, 39);
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
            this.buttonSaveSecondaryColor.Location = new System.Drawing.Point(177, 5);
            this.buttonSaveSecondaryColor.Name = "buttonSaveSecondaryColor";
            this.buttonSaveSecondaryColor.Size = new System.Drawing.Size(32, 29);
            this.buttonSaveSecondaryColor.TabIndex = 4;
            this.buttonSaveSecondaryColor.Text = "+";
            this.buttonSaveSecondaryColor.UseVisualStyleBackColor = false;
            this.buttonSaveSecondaryColor.Click += new System.EventHandler(this.buttonSaveSecondaryColor_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.buttonSecondaryColor);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(5, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(204, 29);
            this.panel5.TabIndex = 6;
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
            this.buttonSecondaryColor.Size = new System.Drawing.Size(160, 29);
            this.buttonSecondaryColor.TabIndex = 8;
            this.buttonSecondaryColor.Text = "255 255 255";
            this.buttonSecondaryColor.UseVisualStyleBackColor = false;
            // 
            // container
            // 
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Margin = new System.Windows.Forms.Padding(0);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(216, 80);
            this.container.TabIndex = 0;
            // 
            // ActiveColors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.primaryContainer);
            this.Controls.Add(this.secondaryContainer);
            this.Controls.Add(this.container);
            this.Controls.Add(this.boxShadow);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ActiveColors";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Size = new System.Drawing.Size(224, 88);
            this.Load += new System.EventHandler(this.ActiveColors_Load);
            this.primaryContainer.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.secondaryContainer.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Container container;
        private System.Windows.Forms.Panel boxShadow;
        private System.Windows.Forms.Panel primaryContainer;
        private System.Windows.Forms.Button buttonSavePrimaryColor;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonPrimaryColor;
        private System.Windows.Forms.Panel secondaryContainer;
        private System.Windows.Forms.Button buttonSaveSecondaryColor;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button buttonSecondaryColor;
    }
}
