namespace wkt
{
    partial class ClipRasterWithPolygon
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
            this.tbPath = new System.Windows.Forms.TextBox();
            this.cbRasterLayer = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbOut = new System.Windows.Forms.Label();
            this.lbIn = new System.Windows.Forms.Label();
            this.gbIn = new System.Windows.Forms.GroupBox();
            this.cbTPolygonLayer = new System.Windows.Forms.ComboBox();
            this.lbTPolygonLayer = new System.Windows.Forms.Label();
            this.lbRasterLayer = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.gbIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowser
            // 
            this.btnBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowser.Location = new System.Drawing.Point(355, 168);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(75, 23);
            this.btnBrowser.TabIndex = 59;
            this.btnBrowser.Text = "选择";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // tbPath
            // 
            this.tbPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPath.Location = new System.Drawing.Point(89, 168);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(260, 21);
            this.tbPath.TabIndex = 58;
            // 
            // cbRasterLayer
            // 
            this.cbRasterLayer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbRasterLayer.FormattingEnabled = true;
            this.cbRasterLayer.Location = new System.Drawing.Point(89, 55);
            this.cbRasterLayer.Name = "cbRasterLayer";
            this.cbRasterLayer.Size = new System.Drawing.Size(335, 20);
            this.cbRasterLayer.TabIndex = 55;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(355, 218);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 57;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(274, 218);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 56;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 54;
            this.label3.Text = "结果图层：";
            // 
            // lbOut
            // 
            this.lbOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbOut.AutoSize = true;
            this.lbOut.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.lbOut.Location = new System.Drawing.Point(14, 140);
            this.lbOut.Name = "lbOut";
            this.lbOut.Size = new System.Drawing.Size(39, 20);
            this.lbOut.TabIndex = 53;
            this.lbOut.Text = "输出";
            // 
            // lbIn
            // 
            this.lbIn.AutoSize = true;
            this.lbIn.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.lbIn.Location = new System.Drawing.Point(12, 10);
            this.lbIn.Name = "lbIn";
            this.lbIn.Size = new System.Drawing.Size(39, 20);
            this.lbIn.TabIndex = 52;
            this.lbIn.Text = "输入";
            // 
            // gbIn
            // 
            this.gbIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbIn.Controls.Add(this.cbTPolygonLayer);
            this.gbIn.Controls.Add(this.lbTPolygonLayer);
            this.gbIn.Controls.Add(this.lbRasterLayer);
            this.gbIn.Location = new System.Drawing.Point(12, 33);
            this.gbIn.Name = "gbIn";
            this.gbIn.Size = new System.Drawing.Size(418, 90);
            this.gbIn.TabIndex = 51;
            this.gbIn.TabStop = false;
            this.gbIn.Text = "输入图层";
            // 
            // cbTPolygonLayer
            // 
            this.cbTPolygonLayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTPolygonLayer.FormattingEnabled = true;
            this.cbTPolygonLayer.Location = new System.Drawing.Point(77, 59);
            this.cbTPolygonLayer.Name = "cbTPolygonLayer";
            this.cbTPolygonLayer.Size = new System.Drawing.Size(335, 20);
            this.cbTPolygonLayer.TabIndex = 23;
            // 
            // lbTPolygonLayer
            // 
            this.lbTPolygonLayer.AutoSize = true;
            this.lbTPolygonLayer.Location = new System.Drawing.Point(6, 62);
            this.lbTPolygonLayer.Name = "lbTPolygonLayer";
            this.lbTPolygonLayer.Size = new System.Drawing.Size(65, 12);
            this.lbTPolygonLayer.TabIndex = 22;
            this.lbTPolygonLayer.Text = "目标图层：";
            // 
            // lbRasterLayer
            // 
            this.lbRasterLayer.AutoSize = true;
            this.lbRasterLayer.Location = new System.Drawing.Point(6, 25);
            this.lbRasterLayer.Name = "lbRasterLayer";
            this.lbRasterLayer.Size = new System.Drawing.Size(65, 12);
            this.lbRasterLayer.TabIndex = 44;
            this.lbRasterLayer.Text = "栅格图层：";
            // 
            // ClipRasterWithPolygon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 250);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.cbRasterLayer);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbOut);
            this.Controls.Add(this.lbIn);
            this.Controls.Add(this.gbIn);
            this.Name = "ClipRasterWithPolygon";
            this.Text = "面分割栅格";
            this.gbIn.ResumeLayout(false);
            this.gbIn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.ComboBox cbRasterLayer;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbOut;
        private System.Windows.Forms.Label lbIn;
        private System.Windows.Forms.GroupBox gbIn;
        private System.Windows.Forms.ComboBox cbTPolygonLayer;
        private System.Windows.Forms.Label lbTPolygonLayer;
        private System.Windows.Forms.Label lbRasterLayer;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}