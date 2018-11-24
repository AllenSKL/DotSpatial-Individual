namespace wkt
{
    partial class IntersectionBoundary
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
            this.gbIn = new System.Windows.Forms.GroupBox();
            this.cbPolyLayer = new System.Windows.Forms.ComboBox();
            this.lbSelectLayer = new System.Windows.Forms.Label();
            this.cbBoundaryLayer = new System.Windows.Forms.ComboBox();
            this.lbTargetLayer = new System.Windows.Forms.Label();
            this.lbIn = new System.Windows.Forms.Label();
            this.lbOut = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.gbIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbIn
            // 
            this.gbIn.Controls.Add(this.cbPolyLayer);
            this.gbIn.Controls.Add(this.lbSelectLayer);
            this.gbIn.Location = new System.Drawing.Point(12, 32);
            this.gbIn.Name = "gbIn";
            this.gbIn.Size = new System.Drawing.Size(418, 90);
            this.gbIn.TabIndex = 0;
            this.gbIn.TabStop = false;
            this.gbIn.Text = "输入图层";
            // 
            // cbPolyLayer
            // 
            this.cbPolyLayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPolyLayer.FormattingEnabled = true;
            this.cbPolyLayer.Location = new System.Drawing.Point(77, 59);
            this.cbPolyLayer.Name = "cbPolyLayer";
            this.cbPolyLayer.Size = new System.Drawing.Size(335, 20);
            this.cbPolyLayer.TabIndex = 23;
            // 
            // lbSelectLayer
            // 
            this.lbSelectLayer.AutoSize = true;
            this.lbSelectLayer.Location = new System.Drawing.Point(6, 62);
            this.lbSelectLayer.Name = "lbSelectLayer";
            this.lbSelectLayer.Size = new System.Drawing.Size(65, 12);
            this.lbSelectLayer.TabIndex = 22;
            this.lbSelectLayer.Text = "目标图层：";
            // 
            // cbBoundaryLayer
            // 
            this.cbBoundaryLayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBoundaryLayer.FormattingEnabled = true;
            this.cbBoundaryLayer.Location = new System.Drawing.Point(89, 54);
            this.cbBoundaryLayer.Name = "cbBoundaryLayer";
            this.cbBoundaryLayer.Size = new System.Drawing.Size(335, 20);
            this.cbBoundaryLayer.TabIndex = 25;
            // 
            // lbTargetLayer
            // 
            this.lbTargetLayer.AutoSize = true;
            this.lbTargetLayer.Location = new System.Drawing.Point(30, 57);
            this.lbTargetLayer.Name = "lbTargetLayer";
            this.lbTargetLayer.Size = new System.Drawing.Size(53, 12);
            this.lbTargetLayer.TabIndex = 24;
            this.lbTargetLayer.Text = "源图层：";
            // 
            // lbIn
            // 
            this.lbIn.AutoSize = true;
            this.lbIn.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.lbIn.Location = new System.Drawing.Point(12, 9);
            this.lbIn.Name = "lbIn";
            this.lbIn.Size = new System.Drawing.Size(39, 20);
            this.lbIn.TabIndex = 1;
            this.lbIn.Text = "输入";
            // 
            // lbOut
            // 
            this.lbOut.AutoSize = true;
            this.lbOut.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.lbOut.Location = new System.Drawing.Point(14, 139);
            this.lbOut.Name = "lbOut";
            this.lbOut.Size = new System.Drawing.Size(39, 20);
            this.lbOut.TabIndex = 2;
            this.lbOut.Text = "输出";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 24;
            this.label3.Text = "结果路径：";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(274, 217);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 26;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(355, 217);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnBrowser
            // 
            this.btnBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowser.Location = new System.Drawing.Point(380, 165);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(50, 23);
            this.btnBrowser.TabIndex = 28;
            this.btnBrowser.Text = "浏览";
            this.btnBrowser.UseVisualStyleBackColor = true;
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(89, 167);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(285, 21);
            this.tbPath.TabIndex = 29;
            // 
            // IntersectionBoundary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 252);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.cbBoundaryLayer);
            this.Controls.Add(this.lbTargetLayer);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbOut);
            this.Controls.Add(this.lbIn);
            this.Controls.Add(this.gbIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "IntersectionBoundary";
            this.Text = "相交提取边界";
            this.gbIn.ResumeLayout(false);
            this.gbIn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbIn;
        private System.Windows.Forms.Label lbIn;
        private System.Windows.Forms.Label lbOut;
        private System.Windows.Forms.ComboBox cbBoundaryLayer;
        private System.Windows.Forms.Label lbTargetLayer;
        private System.Windows.Forms.ComboBox cbPolyLayer;
        private System.Windows.Forms.Label lbSelectLayer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.TextBox tbPath;
    }
}