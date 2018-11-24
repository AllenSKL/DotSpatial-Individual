namespace wkt
{
    partial class Buffer
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
            this.lbDistance = new System.Windows.Forms.Label();
            this.tbDistance = new System.Windows.Forms.TextBox();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.tbResultPath = new System.Windows.Forms.TextBox();
            this.lbResultPath = new System.Windows.Forms.Label();
            this.lbSelectLayer = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.cbSelectLayer = new System.Windows.Forms.ComboBox();
            this.saveFileDialogBuffer = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // lbDistance
            // 
            this.lbDistance.AutoSize = true;
            this.lbDistance.Location = new System.Drawing.Point(21, 57);
            this.lbDistance.Name = "lbDistance";
            this.lbDistance.Size = new System.Drawing.Size(77, 12);
            this.lbDistance.TabIndex = 18;
            this.lbDistance.Text = "缓冲区半径：";
            // 
            // tbDistance
            // 
            this.tbDistance.Location = new System.Drawing.Point(104, 54);
            this.tbDistance.Name = "tbDistance";
            this.tbDistance.Size = new System.Drawing.Size(301, 21);
            this.tbDistance.TabIndex = 17;
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(413, 84);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(75, 23);
            this.btnBrowser.TabIndex = 16;
            this.btnBrowser.Text = "选择目录";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // tbResultPath
            // 
            this.tbResultPath.Location = new System.Drawing.Point(104, 84);
            this.tbResultPath.Name = "tbResultPath";
            this.tbResultPath.Size = new System.Drawing.Size(301, 21);
            this.tbResultPath.TabIndex = 15;
            // 
            // lbResultPath
            // 
            this.lbResultPath.AutoSize = true;
            this.lbResultPath.Location = new System.Drawing.Point(21, 87);
            this.lbResultPath.Name = "lbResultPath";
            this.lbResultPath.Size = new System.Drawing.Size(77, 12);
            this.lbResultPath.TabIndex = 14;
            this.lbResultPath.Text = "缓冲区图层：";
            // 
            // lbSelectLayer
            // 
            this.lbSelectLayer.AutoSize = true;
            this.lbSelectLayer.Location = new System.Drawing.Point(33, 21);
            this.lbSelectLayer.Name = "lbSelectLayer";
            this.lbSelectLayer.Size = new System.Drawing.Size(65, 12);
            this.lbSelectLayer.TabIndex = 13;
            this.lbSelectLayer.Text = "选择图层：";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(413, 124);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(332, 124);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cbSelectLayer
            // 
            this.cbSelectLayer.FormattingEnabled = true;
            this.cbSelectLayer.Location = new System.Drawing.Point(104, 21);
            this.cbSelectLayer.Name = "cbSelectLayer";
            this.cbSelectLayer.Size = new System.Drawing.Size(384, 20);
            this.cbSelectLayer.TabIndex = 10;
            // 
            // Buffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 159);
            this.Controls.Add(this.lbDistance);
            this.Controls.Add(this.tbDistance);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.tbResultPath);
            this.Controls.Add(this.lbResultPath);
            this.Controls.Add(this.lbSelectLayer);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbSelectLayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Buffer";
            this.Text = "缓冲区分析";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDistance;
        private System.Windows.Forms.TextBox tbDistance;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.TextBox tbResultPath;
        private System.Windows.Forms.Label lbResultPath;
        private System.Windows.Forms.Label lbSelectLayer;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cbSelectLayer;
        private System.Windows.Forms.SaveFileDialog saveFileDialogBuffer;
    }
}