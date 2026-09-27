namespace BaitapWindowsForms
{
    partial class Frmchinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmchinh));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbbai1 = new System.Windows.Forms.ToolStripButton();
            this.tsbBai2 = new System.Windows.Forms.ToolStripButton();
            this.tsbBai3 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbbai1,
            this.tsbBai2,
            this.tsbBai3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbbai1
            // 
            this.tsbbai1.Image = ((System.Drawing.Image)(resources.GetObject("tsbbai1.Image")));
            this.tsbbai1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbbai1.Name = "tsbbai1";
            this.tsbbai1.Size = new System.Drawing.Size(52, 22);
            this.tsbbai1.Text = "bài 1";
            this.tsbbai1.Click += new System.EventHandler(this.tsbbai1_Click);
            // 
            // tsbBai2
            // 
            this.tsbBai2.Image = ((System.Drawing.Image)(resources.GetObject("tsbBai2.Image")));
            this.tsbBai2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBai2.Name = "tsbBai2";
            this.tsbBai2.Size = new System.Drawing.Size(52, 22);
            this.tsbBai2.Text = "Bài 2";
            this.tsbBai2.Click += new System.EventHandler(this.tsbBai2_Click);
            // 
            // tsbBai3
            // 
            this.tsbBai3.Image = ((System.Drawing.Image)(resources.GetObject("tsbBai3.Image")));
            this.tsbBai3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBai3.Name = "tsbBai3";
            this.tsbBai3.Size = new System.Drawing.Size(52, 22);
            this.tsbBai3.Text = "Bài 3";
            this.tsbBai3.Click += new System.EventHandler(this.tsbBai3_Click);
            // 
            // Frmchinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Frmchinh";
            this.Text = "CHƯƠNG TRÌNH CHÍNH";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbbai1;
        private System.Windows.Forms.ToolStripButton tsbBai2;
        private System.Windows.Forms.ToolStripButton tsbBai3;
    }
}

