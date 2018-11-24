namespace wkt
{
    partial class LinkDB
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
            this.lbDB = new System.Windows.Forms.Label();
            this.tbDB = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbUser = new System.Windows.Forms.Label();
            this.lbPwd = new System.Windows.Forms.Label();
            this.lbServer = new System.Windows.Forms.Label();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.tbPwd = new System.Windows.Forms.TextBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbDB
            // 
            this.lbDB.AutoSize = true;
            this.lbDB.Location = new System.Drawing.Point(12, 119);
            this.lbDB.Name = "lbDB";
            this.lbDB.Size = new System.Drawing.Size(77, 12);
            this.lbDB.TabIndex = 5;
            this.lbDB.Text = "数据库名称：";
            // 
            // tbDB
            // 
            this.tbDB.Location = new System.Drawing.Point(96, 116);
            this.tbDB.Name = "tbDB";
            this.tbDB.Size = new System.Drawing.Size(238, 21);
            this.tbDB.TabIndex = 9;
            this.tbDB.Text = "geo";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(164, 154);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(259, 154);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Location = new System.Drawing.Point(36, 52);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(53, 12);
            this.lbUser.TabIndex = 2;
            this.lbUser.Text = "用户名：";
            // 
            // lbPwd
            // 
            this.lbPwd.AutoSize = true;
            this.lbPwd.Location = new System.Drawing.Point(48, 83);
            this.lbPwd.Name = "lbPwd";
            this.lbPwd.Size = new System.Drawing.Size(41, 12);
            this.lbPwd.TabIndex = 3;
            this.lbPwd.Text = "密码：";
            // 
            // lbServer
            // 
            this.lbServer.AutoSize = true;
            this.lbServer.Location = new System.Drawing.Point(12, 22);
            this.lbServer.Name = "lbServer";
            this.lbServer.Size = new System.Drawing.Size(77, 12);
            this.lbServer.TabIndex = 4;
            this.lbServer.Text = "服务器名称：";
            // 
            // tbServer
            // 
            this.tbServer.Location = new System.Drawing.Point(96, 19);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(238, 21);
            this.tbServer.TabIndex = 6;
            this.tbServer.Text = ".";
            // 
            // tbPwd
            // 
            this.tbPwd.Location = new System.Drawing.Point(96, 80);
            this.tbPwd.Name = "tbPwd";
            this.tbPwd.PasswordChar = '*';
            this.tbPwd.Size = new System.Drawing.Size(238, 21);
            this.tbPwd.TabIndex = 8;
            this.tbPwd.Text = "2018";
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(96, 49);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(238, 21);
            this.tbUser.TabIndex = 7;
            this.tbUser.Text = "sa";
            // 
            // LinkDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 189);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.tbPwd);
            this.Controls.Add(this.tbDB);
            this.Controls.Add(this.tbServer);
            this.Controls.Add(this.lbDB);
            this.Controls.Add(this.lbServer);
            this.Controls.Add(this.lbPwd);
            this.Controls.Add(this.lbUser);
            this.Name = "LinkDB";
            this.Text = "连接数据库";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbDB;
        private System.Windows.Forms.TextBox tbDB;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbPwd;
        private System.Windows.Forms.Label lbServer;
        private System.Windows.Forms.TextBox tbServer;
        private System.Windows.Forms.TextBox tbPwd;
        private System.Windows.Forms.TextBox tbUser;
    }
}