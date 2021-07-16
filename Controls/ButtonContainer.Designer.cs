
namespace Pixel_Editor_Test_2.Controls
{
    partial class ButtonContainer
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
            this.button = new System.Windows.Forms.Button();
            this.buttonShadow = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.White;
            this.button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button.FlatAppearance.BorderSize = 2;
            this.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button.Font = new System.Drawing.Font("Minecraftia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.Location = new System.Drawing.Point(0, 0);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(32, 32);
            this.button.TabIndex = 1;
            this.button.Text = "O";
            this.button.UseVisualStyleBackColor = false;
            // 
            // buttonShadow
            // 
            this.buttonShadow.BackColor = System.Drawing.Color.Black;
            this.buttonShadow.Location = new System.Drawing.Point(8, 8);
            this.buttonShadow.Name = "buttonShadow";
            this.buttonShadow.Size = new System.Drawing.Size(32, 32);
            this.buttonShadow.TabIndex = 2;
            // 
            // ButtonContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.button);
            this.Controls.Add(this.buttonShadow);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ButtonContainer";
            this.Size = new System.Drawing.Size(40, 40);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Panel buttonShadow;
    }
}
