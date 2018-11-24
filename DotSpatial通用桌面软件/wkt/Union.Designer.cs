namespace wkt
{
    partial class Union
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbResultPath = new System.Windows.Forms.TextBox();
            this.lbResultPath = new System.Windows.Forms.Label();
            this.cbTargetLayer = new System.Windows.Forms.ComboBox();
            this.lbTargetLayer = new System.Windows.Forms.Label();
            this.cbSelectLayer = new System.Windows.Forms.ComboBox();
            this.lbSelectLayer = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(333, 92);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "选择";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(333, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tbResultPath
            // 
            this.tbResultPath.Location = new System.Drawing.Point(110, 92);
            this.tbResultPath.Name = "tbResultPath";
            this.tbResultPath.Size = new System.Drawing.Size(217, 21);
            this.tbResultPath.TabIndex = 14;
            // 
            // lbResultPath
            // 
            this.lbResultPath.AutoSize = true;
            this.lbResultPath.Location = new System.Drawing.Point(12, 97);
            this.lbResultPath.Name = "lbResultPath";
            this.lbResultPath.Size = new System.Drawing.Size(89, 12);
            this.lbResultPath.TabIndex = 13;
            this.lbResultPath.Text = "结果图层路径：";
            // 
            // cbTargetLayer
            // 
            this.cbTargetLayer.FormattingEnabled = true;
            this.cbTargetLayer.Location = new System.Drawing.Point(110, 53);
            this.cbTargetLayer.Name = "cbTargetLayer";
            this.cbTargetLayer.Size = new System.Drawing.Size(281, 20);
            this.cbTargetLayer.TabIndex = 12;
            // 
            // lbTargetLayer
            // 
            this.lbTargetLayer.AutoSize = true;
            this.lbTargetLayer.Location = new System.Drawing.Point(12, 56);
            this.lbTargetLayer.Name = "lbTargetLayer";
            this.lbTargetLayer.Size = new System.Drawing.Size(89, 12);
            this.lbTargetLayer.TabIndex = 11;
            this.lbTargetLayer.Text = "目标要素图层：";
            // 
            // cbSelectLayer
            // 
            this.cbSelectLayer.FormattingEnabled = true;
            this.cbSelectLayer.Location = new System.Drawing.Point(110, 15);
            this.cbSelectLayer.Name = "cbSelectLayer";
            this.cbSelectLayer.Size = new System.Drawing.Size(281, 20);
            this.cbSelectLayer.TabIndex = 10;
            // 
            // lbSelectLayer
            // 
            this.lbSelectLayer.AutoSize = true;
            this.lbSelectLayer.Location = new System.Drawing.Point(24, 18);
            this.lbSelectLayer.Name = "lbSelectLayer";
            this.lbSelectLayer.Size = new System.Drawing.Size(77, 12);
            this.lbSelectLayer.TabIndex = 9;
            this.lbSelectLayer.Text = "源要素图层：";
            // 
            // Union
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 169);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbResultPath);
            this.Controls.Add(this.lbResultPath);
            this.Controls.Add(this.cbTargetLayer);
            this.Controls.Add(this.lbTargetLayer);
            this.Controls.Add(this.cbSelectLayer);
            this.Controls.Add(this.lbSelectLayer);
            this.Name = "Union";
            this.Text = "联合";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbResultPath;
        private System.Windows.Forms.Label lbResultPath;
        private System.Windows.Forms.ComboBox cbTargetLayer;
        private System.Windows.Forms.Label lbTargetLayer;
        private System.Windows.Forms.ComboBox cbSelectLayer;
        private System.Windows.Forms.Label lbSelectLayer;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}