namespace wkt
{
    partial class InterruptLineWithLine
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
            this.btnBrowser = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.lbPath = new System.Windows.Forms.Label();
            this.cbTargetLayer = new System.Windows.Forms.ComboBox();
            this.lbTargetLayer = new System.Windows.Forms.Label();
            this.cbSelectLayer = new System.Windows.Forms.ComboBox();
            this.lbSelectLayer = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(325, 81);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(75, 23);
            this.btnBrowser.TabIndex = 35;
            this.btnBrowser.Text = "选择";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(325, 116);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(241, 116);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 33;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(107, 83);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(209, 21);
            this.tbPath.TabIndex = 32;
            // 
            // lbPath
            // 
            this.lbPath.AutoSize = true;
            this.lbPath.Location = new System.Drawing.Point(12, 86);
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(89, 12);
            this.lbPath.TabIndex = 31;
            this.lbPath.Text = "结果图层路径：";
            // 
            // cbTargetLayer
            // 
            this.cbTargetLayer.FormattingEnabled = true;
            this.cbTargetLayer.Location = new System.Drawing.Point(107, 44);
            this.cbTargetLayer.Name = "cbTargetLayer";
            this.cbTargetLayer.Size = new System.Drawing.Size(293, 20);
            this.cbTargetLayer.TabIndex = 30;
            // 
            // lbTargetLayer
            // 
            this.lbTargetLayer.AutoSize = true;
            this.lbTargetLayer.Location = new System.Drawing.Point(24, 47);
            this.lbTargetLayer.Name = "lbTargetLayer";
            this.lbTargetLayer.Size = new System.Drawing.Size(77, 12);
            this.lbTargetLayer.TabIndex = 29;
            this.lbTargetLayer.Text = "源要素图层：";
            // 
            // cbSelectLayer
            // 
            this.cbSelectLayer.FormattingEnabled = true;
            this.cbSelectLayer.Location = new System.Drawing.Point(107, 6);
            this.cbSelectLayer.Name = "cbSelectLayer";
            this.cbSelectLayer.Size = new System.Drawing.Size(293, 20);
            this.cbSelectLayer.TabIndex = 28;
            // 
            // lbSelectLayer
            // 
            this.lbSelectLayer.AutoSize = true;
            this.lbSelectLayer.Location = new System.Drawing.Point(12, 9);
            this.lbSelectLayer.Name = "lbSelectLayer";
            this.lbSelectLayer.Size = new System.Drawing.Size(89, 12);
            this.lbSelectLayer.TabIndex = 27;
            this.lbSelectLayer.Text = "目标要素图层：";
            // 
            // InterruptLineWithLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 145);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.lbPath);
            this.Controls.Add(this.cbTargetLayer);
            this.Controls.Add(this.lbTargetLayer);
            this.Controls.Add(this.cbSelectLayer);
            this.Controls.Add(this.lbSelectLayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InterruptLineWithLine";
            this.Text = "用线打断线";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Label lbPath;
        private System.Windows.Forms.ComboBox cbTargetLayer;
        private System.Windows.Forms.Label lbTargetLayer;
        private System.Windows.Forms.ComboBox cbSelectLayer;
        private System.Windows.Forms.Label lbSelectLayer;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}