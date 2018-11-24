namespace wkt
{
    partial class RasterToVertor
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbOutput = new System.Windows.Forms.GroupBox();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.tbVectorPath = new System.Windows.Forms.TextBox();
            this.lbOutput = new System.Windows.Forms.Label();
            this.lbInput = new System.Windows.Forms.Label();
            this.gbInput = new System.Windows.Forms.GroupBox();
            this.cbRTVInput = new System.Windows.Forms.ComboBox();
            this.sfdVector = new System.Windows.Forms.SaveFileDialog();
            this.gbOutput.SuspendLayout();
            this.gbInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(364, 172);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(457, 172);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbOutput
            // 
            this.gbOutput.Controls.Add(this.btnBrowser);
            this.gbOutput.Controls.Add(this.tbVectorPath);
            this.gbOutput.Location = new System.Drawing.Point(10, 105);
            this.gbOutput.Name = "gbOutput";
            this.gbOutput.Size = new System.Drawing.Size(523, 41);
            this.gbOutput.TabIndex = 12;
            this.gbOutput.TabStop = false;
            this.gbOutput.Text = "矢量要素集";
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
            // tbVectorPath
            // 
            this.tbVectorPath.Location = new System.Drawing.Point(7, 14);
            this.tbVectorPath.Name = "tbVectorPath";
            this.tbVectorPath.Size = new System.Drawing.Size(418, 21);
            this.tbVectorPath.TabIndex = 0;
            // 
            // lbOutput
            // 
            this.lbOutput.AutoSize = true;
            this.lbOutput.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbOutput.Location = new System.Drawing.Point(10, 82);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(39, 20);
            this.lbOutput.TabIndex = 11;
            this.lbOutput.Text = "输出";
            // 
            // lbInput
            // 
            this.lbInput.AutoSize = true;
            this.lbInput.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbInput.Location = new System.Drawing.Point(11, 8);
            this.lbInput.Name = "lbInput";
            this.lbInput.Size = new System.Drawing.Size(39, 20);
            this.lbInput.TabIndex = 9;
            this.lbInput.Text = "输入";
            // 
            // gbInput
            // 
            this.gbInput.Controls.Add(this.cbRTVInput);
            this.gbInput.Location = new System.Drawing.Point(14, 31);
            this.gbInput.Name = "gbInput";
            this.gbInput.Size = new System.Drawing.Size(523, 41);
            this.gbInput.TabIndex = 7;
            this.gbInput.TabStop = false;
            this.gbInput.Text = "栅格图层";
            // 
            // cbRTVInput
            // 
            this.cbRTVInput.FormattingEnabled = true;
            this.cbRTVInput.Location = new System.Drawing.Point(7, 15);
            this.cbRTVInput.Name = "cbRTVInput";
            this.cbRTVInput.Size = new System.Drawing.Size(510, 20);
            this.cbRTVInput.TabIndex = 0;
            // 
            // RasterToVertor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 207);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbOutput);
            this.Controls.Add(this.lbOutput);
            this.Controls.Add(this.lbInput);
            this.Controls.Add(this.gbInput);
            this.Name = "RasterToVertor";
            this.Text = "栅格转矢量";
            this.gbOutput.ResumeLayout(false);
            this.gbOutput.PerformLayout();
            this.gbInput.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbOutput;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.TextBox tbVectorPath;
        private System.Windows.Forms.Label lbOutput;
        private System.Windows.Forms.Label lbInput;
        private System.Windows.Forms.GroupBox gbInput;
        private System.Windows.Forms.ComboBox cbRTVInput;
        private System.Windows.Forms.SaveFileDialog sfdVector;
    }
}