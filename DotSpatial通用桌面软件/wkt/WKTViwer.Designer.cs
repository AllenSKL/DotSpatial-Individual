namespace wkt
{
    partial class WKTViwer
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.rtbWKT = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exportAsTxt = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbWKT
            // 
            this.rtbWKT.BackColor = System.Drawing.SystemColors.HighlightText;
            this.rtbWKT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbWKT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbWKT.Location = new System.Drawing.Point(0, 25);
            this.rtbWKT.Name = "rtbWKT";
            this.rtbWKT.ReadOnly = true;
            this.rtbWKT.Size = new System.Drawing.Size(469, 155);
            this.rtbWKT.TabIndex = 0;
            this.rtbWKT.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportAsTxt});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(469, 25);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exportAsTxt
            // 
            this.exportAsTxt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.exportAsTxt.Name = "exportAsTxt";
            this.exportAsTxt.Size = new System.Drawing.Size(44, 21);
            this.exportAsTxt.Text = "导出";
            this.exportAsTxt.Click += new System.EventHandler(this.exportAsTxt_Click);
            // 
            // WKTViwer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 180);
            this.Controls.Add(this.rtbWKT);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WKTViwer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查看要素WKT";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox rtbWKT;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exportAsTxt;
    }
}