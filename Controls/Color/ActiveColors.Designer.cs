
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSavePrimaryColor = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonPrimaryColor = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonSaveSecondaryColor = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonSecondaryColor = new System.Windows.Forms.Button();
            this.container1 = new Pixel_Editor_Test_2.Controls.Container();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 80);
            this.panel1.TabIndex = 1;
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
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.buttonSavePrimaryColor);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(1, 1);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(214, 39);
            this.panel3.TabIndex = 5;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.buttonSaveSecondaryColor);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Location = new System.Drawing.Point(1, 40);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(214, 39);
            this.panel2.TabIndex = 6;
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
            // container1
            // 
            this.container1.Location = new System.Drawing.Point(0, 0);
            this.container1.Margin = new System.Windows.Forms.Padding(0);
            this.container1.Name = "container1";
            this.container1.Size = new System.Drawing.Size(216, 80);
            this.container1.TabIndex = 0;
            // 
            // ActiveColors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.container1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ActiveColors";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Size = new System.Drawing.Size(224, 88);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Container container1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonSavePrimaryColor;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonPrimaryColor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonSaveSecondaryColor;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button buttonSecondaryColor;
    }
}
