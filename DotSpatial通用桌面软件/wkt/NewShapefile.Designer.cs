namespace wkt
{
    partial class NewShapefile
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
            this.lbLayer = new System.Windows.Forms.Label();
            this.tbFilename = new System.Windows.Forms.TextBox();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbFeatureType = new System.Windows.Forms.GroupBox();
            this.rbtnMPoint = new System.Windows.Forms.RadioButton();
            this.rbtnPolygon = new System.Windows.Forms.RadioButton();
            this.rbtnLine = new System.Windows.Forms.RadioButton();
            this.rbtnPoint = new System.Windows.Forms.RadioButton();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.gbFeatureType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbLayer
            // 
            this.lbLayer.AutoSize = true;
            this.lbLayer.Location = new System.Drawing.Point(11, 77);
            this.lbLayer.Name = "lbLayer";
            this.lbLayer.Size = new System.Drawing.Size(65, 12);
            this.lbLayer.TabIndex = 2;
            this.lbLayer.Text = "图层名称：";
            // 
            // tbFilename
            // 
            this.tbFilename.Location = new System.Drawing.Point(81, 74);
            this.tbFilename.Name = "tbFilename";
            this.tbFilename.Size = new System.Drawing.Size(162, 21);
            this.tbFilename.TabIndex = 3;
            // 
            // btnBrowser
            // 
            this.btnBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowser.Location = new System.Drawing.Point(249, 73);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(55, 23);
            this.btnBrowser.TabIndex = 4;
            this.btnBrowser.Text = "选择";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(148, 118);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "确认";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(229, 118);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbFeatureType
            // 
            this.gbFeatureType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFeatureType.Controls.Add(this.rbtnMPoint);
            this.gbFeatureType.Controls.Add(this.rbtnPolygon);
            this.gbFeatureType.Controls.Add(this.rbtnLine);
            this.gbFeatureType.Controls.Add(this.rbtnPoint);
            this.gbFeatureType.Location = new System.Drawing.Point(12, 12);
            this.gbFeatureType.Name = "gbFeatureType";
            this.gbFeatureType.Size = new System.Drawing.Size(292, 47);
            this.gbFeatureType.TabIndex = 7;
            this.gbFeatureType.TabStop = false;
            this.gbFeatureType.Text = "要素类型";
            // 
            // rbtnMPoint
            // 
            this.rbtnMPoint.AutoSize = true;
            this.rbtnMPoint.Location = new System.Drawing.Point(237, 21);
            this.rbtnMPoint.Name = "rbtnMPoint";
            this.rbtnMPoint.Size = new System.Drawing.Size(47, 16);
            this.rbtnMPoint.TabIndex = 3;
            this.rbtnMPoint.Text = "多点";
            this.rbtnMPoint.UseVisualStyleBackColor = true;
            // 
            // rbtnPolygon
            // 
            this.rbtnPolygon.AutoSize = true;
            this.rbtnPolygon.Location = new System.Drawing.Point(160, 21);
            this.rbtnPolygon.Name = "rbtnPolygon";
            this.rbtnPolygon.Size = new System.Drawing.Size(35, 16);
            this.rbtnPolygon.TabIndex = 2;
            this.rbtnPolygon.Text = "面";
            this.rbtnPolygon.UseVisualStyleBackColor = true;
            // 
            // rbtnLine
            // 
            this.rbtnLine.AutoSize = true;
            this.rbtnLine.Location = new System.Drawing.Point(83, 21);
            this.rbtnLine.Name = "rbtnLine";
            this.rbtnLine.Size = new System.Drawing.Size(35, 16);
            this.rbtnLine.TabIndex = 1;
            this.rbtnLine.Text = "线";
            this.rbtnLine.UseVisualStyleBackColor = true;
            // 
            // rbtnPoint
            // 
            this.rbtnPoint.AutoSize = true;
            this.rbtnPoint.Checked = true;
            this.rbtnPoint.Location = new System.Drawing.Point(6, 21);
            this.rbtnPoint.Name = "rbtnPoint";
            this.rbtnPoint.Size = new System.Drawing.Size(35, 16);
            this.rbtnPoint.TabIndex = 0;
            this.rbtnPoint.TabStop = true;
            this.rbtnPoint.Text = "点";
            this.rbtnPoint.UseVisualStyleBackColor = true;
            // 
            // NewShapefile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 153);
            this.Controls.Add(this.gbFeatureType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.tbFilename);
            this.Controls.Add(this.lbLayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NewShapefile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "创建新Shapefile";
            this.gbFeatureType.ResumeLayout(false);
            this.gbFeatureType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbLayer;
        private System.Windows.Forms.TextBox tbFilename;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbFeatureType;
        private System.Windows.Forms.RadioButton rbtnMPoint;
        private System.Windows.Forms.RadioButton rbtnPolygon;
        private System.Windows.Forms.RadioButton rbtnLine;
        private System.Windows.Forms.RadioButton rbtnPoint;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}