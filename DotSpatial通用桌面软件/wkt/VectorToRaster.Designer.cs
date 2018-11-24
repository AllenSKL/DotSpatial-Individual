namespace wkt
{
    partial class VectorToRaster
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
            this.gbShape = new System.Windows.Forms.GroupBox();
            this.cbVTRInput = new System.Windows.Forms.ComboBox();
            this.lbInput = new System.Windows.Forms.Label();
            this.gbField = new System.Windows.Forms.GroupBox();
            this.cbFiledName = new System.Windows.Forms.ComboBox();
            this.gbCellSize = new System.Windows.Forms.GroupBox();
            this.tbPixelSize = new System.Windows.Forms.TextBox();
            this.lbOutput = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.tbRasterPath = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.sfdRaster = new System.Windows.Forms.SaveFileDialog();
            this.gbShape.SuspendLayout();
            this.gbField.SuspendLayout();
            this.gbCellSize.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbShape
            // 
            this.gbShape.Controls.Add(this.cbVTRInput);
            this.gbShape.Location = new System.Drawing.Point(12, 28);
            this.gbShape.Name = "gbShape";
            this.gbShape.Size = new System.Drawing.Size(523, 41);
            this.gbShape.TabIndex = 0;
            this.gbShape.TabStop = false;
            this.gbShape.Text = "矢量图层";
            // 
            // cbVTRInput
            // 
            this.cbVTRInput.FormattingEnabled = true;
            this.cbVTRInput.Location = new System.Drawing.Point(7, 15);
            this.cbVTRInput.Name = "cbVTRInput";
            this.cbVTRInput.Size = new System.Drawing.Size(510, 20);
            this.cbVTRInput.TabIndex = 0;
            this.cbVTRInput.SelectedIndexChanged += new System.EventHandler(this.cbVTRInput_SelectedIndexChanged);
            // 
            // lbInput
            // 
            this.lbInput.AutoSize = true;
            this.lbInput.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbInput.Location = new System.Drawing.Point(9, 5);
            this.lbInput.Name = "lbInput";
            this.lbInput.Size = new System.Drawing.Size(39, 20);
            this.lbInput.TabIndex = 1;
            this.lbInput.Text = "输入";
            // 
            // gbField
            // 
            this.gbField.Controls.Add(this.cbFiledName);
            this.gbField.Location = new System.Drawing.Point(12, 75);
            this.gbField.Name = "gbField";
            this.gbField.Size = new System.Drawing.Size(523, 41);
            this.gbField.TabIndex = 2;
            this.gbField.TabStop = false;
            this.gbField.Text = "选择字段";
            // 
            // cbFiledName
            // 
            this.cbFiledName.FormattingEnabled = true;
            this.cbFiledName.Location = new System.Drawing.Point(8, 15);
            this.cbFiledName.Name = "cbFiledName";
            this.cbFiledName.Size = new System.Drawing.Size(510, 20);
            this.cbFiledName.TabIndex = 1;
            // 
            // gbCellSize
            // 
            this.gbCellSize.Controls.Add(this.tbPixelSize);
            this.gbCellSize.Location = new System.Drawing.Point(13, 122);
            this.gbCellSize.Name = "gbCellSize";
            this.gbCellSize.Size = new System.Drawing.Size(523, 41);
            this.gbCellSize.TabIndex = 1;
            this.gbCellSize.TabStop = false;
            this.gbCellSize.Text = "像元大小";
            // 
            // tbPixelSize
            // 
            this.tbPixelSize.Location = new System.Drawing.Point(6, 14);
            this.tbPixelSize.Name = "tbPixelSize";
            this.tbPixelSize.Size = new System.Drawing.Size(511, 21);
            this.tbPixelSize.TabIndex = 1;
            // 
            // lbOutput
            // 
            this.lbOutput.AutoSize = true;
            this.lbOutput.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbOutput.Location = new System.Drawing.Point(12, 177);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(39, 20);
            this.lbOutput.TabIndex = 3;
            this.lbOutput.Text = "输出";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnBrowser);
            this.groupBox4.Controls.Add(this.tbRasterPath);
            this.groupBox4.Location = new System.Drawing.Point(12, 200);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(523, 41);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "输出栅格";
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(443, 14);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(75, 23);
            this.btnBrowser.TabIndex = 1;
            this.btnBrowser.Text = "浏览";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // tbRasterPath
            // 
            this.tbRasterPath.Location = new System.Drawing.Point(7, 14);
            this.tbRasterPath.Name = "tbRasterPath";
            this.tbRasterPath.Size = new System.Drawing.Size(418, 21);
            this.tbRasterPath.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(455, 278);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(362, 278);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // VectorToRaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 312);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lbOutput);
            this.Controls.Add(this.gbCellSize);
            this.Controls.Add(this.gbField);
            this.Controls.Add(this.lbInput);
            this.Controls.Add(this.gbShape);
            this.Name = "VectorToRaster";
            this.Text = "矢量转栅格";
            this.gbShape.ResumeLayout(false);
            this.gbField.ResumeLayout(false);
            this.gbCellSize.ResumeLayout(false);
            this.gbCellSize.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbShape;
        private System.Windows.Forms.Label lbInput;
        private System.Windows.Forms.GroupBox gbField;
        private System.Windows.Forms.GroupBox gbCellSize;
        private System.Windows.Forms.Label lbOutput;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cbVTRInput;
        private System.Windows.Forms.ComboBox cbFiledName;
        private System.Windows.Forms.TextBox tbPixelSize;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.TextBox tbRasterPath;
        private System.Windows.Forms.SaveFileDialog sfdRaster;
    }
}