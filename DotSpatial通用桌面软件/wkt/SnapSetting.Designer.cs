namespace wkt
{
    partial class SnapSetting
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
            this.cbSnapToggle = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbSnapToggle
            // 
            this.cbSnapToggle.AutoSize = true;
            this.cbSnapToggle.Location = new System.Drawing.Point(13, 13);
            this.cbSnapToggle.Name = "cbSnapToggle";
            this.cbSnapToggle.Size = new System.Drawing.Size(120, 16);
            this.cbSnapToggle.TabIndex = 0;
            this.cbSnapToggle.Text = "启用节点捕捉功能";
            this.cbSnapToggle.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(229, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // SnapSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 46);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbSnapToggle);
            this.Name = "SnapSetting";
            this.Text = "捕捉设置";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbSnapToggle;
        private System.Windows.Forms.Button btnSave;
    }
}