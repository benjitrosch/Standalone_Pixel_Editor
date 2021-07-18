
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
            this.SuspendLayout();
            // 
            // textLayerName
            // 
            this.textLayerName.BackColor = System.Drawing.Color.White;
            this.textLayerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textLayerName.Dock = System.Windows.Forms.DockStyle.Left;
            this.textLayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLayerName.ForeColor = System.Drawing.Color.Black;
            this.textLayerName.Location = new System.Drawing.Point(1, 1);
            this.textLayerName.Name = "textLayerName";
            this.textLayerName.Size = new System.Drawing.Size(100, 15);
            this.textLayerName.TabIndex = 0;
            this.textLayerName.Text = "New Layer";
            this.textLayerName.WordWrap = false;
            // 
            // frameLayout
            // 
            this.frameLayout.BackColor = System.Drawing.Color.White;
            this.frameLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frameLayout.Location = new System.Drawing.Point(102, 1);
            this.frameLayout.Margin = new System.Windows.Forms.Padding(0);
            this.frameLayout.Name = "frameLayout";
            this.frameLayout.Size = new System.Drawing.Size(836, 30);
            this.frameLayout.TabIndex = 1;
            // 
            // divider
            // 
            this.divider.Dock = System.Windows.Forms.DockStyle.Left;
            this.divider.Location = new System.Drawing.Point(101, 1);
            this.divider.Margin = new System.Windows.Forms.Padding(0);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(1, 30);
            this.divider.TabIndex = 2;
            // 
            // LayerContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.frameLayout);
            this.Controls.Add(this.divider);
            this.Controls.Add(this.textLayerName);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "LayerContainer";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Size = new System.Drawing.Size(939, 32);
            this.Load += new System.EventHandler(this.LayerContainer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textLayerName;
        private System.Windows.Forms.Panel divider;
        public System.Windows.Forms.FlowLayoutPanel frameLayout;
    }
}
