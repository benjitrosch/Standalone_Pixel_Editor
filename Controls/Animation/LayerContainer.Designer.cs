
namespace Pixel_Editor_Test_2.Controls.Animation
{
    partial class LayerContainer
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
            this.textLayerName = new System.Windows.Forms.TextBox();
            this.frameLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.divider = new System.Windows.Forms.Panel();
            this.buttonVisibility = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // textLayerName
            // 
            this.textLayerName.BackColor = System.Drawing.Color.White;
            this.textLayerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textLayerName.Dock = System.Windows.Forms.DockStyle.Left;
            this.textLayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLayerName.ForeColor = System.Drawing.Color.Black;
            this.textLayerName.Location = new System.Drawing.Point(33, 0);
            this.textLayerName.Name = "textLayerName";
            this.textLayerName.Size = new System.Drawing.Size(128, 15);
            this.textLayerName.TabIndex = 0;
            this.textLayerName.Text = "New Layer";
            this.textLayerName.WordWrap = false;
            // 
            // frameLayout
            // 
            this.frameLayout.BackColor = System.Drawing.Color.White;
            this.frameLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frameLayout.Location = new System.Drawing.Point(162, 0);
            this.frameLayout.Margin = new System.Windows.Forms.Padding(0);
            this.frameLayout.Name = "frameLayout";
            this.frameLayout.Size = new System.Drawing.Size(774, 31);
            this.frameLayout.TabIndex = 1;
            // 
            // divider
            // 
            this.divider.Dock = System.Windows.Forms.DockStyle.Left;
            this.divider.Location = new System.Drawing.Point(161, 0);
            this.divider.Margin = new System.Windows.Forms.Padding(0);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(1, 31);
            this.divider.TabIndex = 2;
            // 
            // buttonVisibility
            // 
            this.buttonVisibility.BackColor = System.Drawing.Color.White;
            this.buttonVisibility.BackgroundImage = global::Pixel_Editor_Test_2.Properties.Resources.eye_icon;
            this.buttonVisibility.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonVisibility.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonVisibility.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonVisibility.FlatAppearance.BorderSize = 0;
            this.buttonVisibility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVisibility.Location = new System.Drawing.Point(0, 0);
            this.buttonVisibility.Margin = new System.Windows.Forms.Padding(0);
            this.buttonVisibility.Name = "buttonVisibility";
            this.buttonVisibility.Size = new System.Drawing.Size(32, 31);
            this.buttonVisibility.TabIndex = 3;
            this.buttonVisibility.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(32, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 31);
            this.panel1.TabIndex = 4;
            // 
            // LayerContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.frameLayout);
            this.Controls.Add(this.divider);
            this.Controls.Add(this.textLayerName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonVisibility);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "LayerContainer";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.Size = new System.Drawing.Size(936, 32);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textLayerName;
        private System.Windows.Forms.Panel divider;
        public System.Windows.Forms.FlowLayoutPanel frameLayout;
        private System.Windows.Forms.Button buttonVisibility;
        private System.Windows.Forms.Panel panel1;
    }
}
