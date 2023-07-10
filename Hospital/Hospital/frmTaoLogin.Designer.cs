namespace Hospital
{
    partial class frmTaoLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_login = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_rePassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_userName = new System.Windows.Forms.TextBox();
            this.cbb_role = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_addLogin = new System.Windows.Forms.Button();
            this.btn_exitAddLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TẠO LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên đăng nhập:";
            // 
            // txb_login
            // 
            this.txb_login.Location = new System.Drawing.Point(121, 73);
            this.txb_login.Name = "txb_login";
            this.txb_login.Size = new System.Drawing.Size(249, 20);
            this.txb_login.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mật khẩu:";
            // 
            // txb_password
            // 
            this.txb_password.Location = new System.Drawing.Point(121, 110);
            this.txb_password.Name = "txb_password";
            this.txb_password.Size = new System.Drawing.Size(249, 20);
            this.txb_password.TabIndex = 2;
            this.txb_password.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Xác nhận mật khẩu:";
            // 
            // txb_rePassword
            // 
            this.txb_rePassword.Location = new System.Drawing.Point(121, 150);
            this.txb_rePassword.Name = "txb_rePassword";
            this.txb_rePassword.Size = new System.Drawing.Size(249, 20);
            this.txb_rePassword.TabIndex = 2;
            this.txb_rePassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "UserName:";
            // 
            // txb_userName
            // 
            this.txb_userName.Location = new System.Drawing.Point(121, 191);
            this.txb_userName.Name = "txb_userName";
            this.txb_userName.Size = new System.Drawing.Size(249, 20);
            this.txb_userName.TabIndex = 2;
            // 
            // cbb_role
            // 
            this.cbb_role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_role.FormattingEnabled = true;
            this.cbb_role.Items.AddRange(new object[] {
            "Admin_Hospital_Role",
            "Doctor_Role",
            "Nurse_Role",
            "Head_Nurse_Role"});
            this.cbb_role.Location = new System.Drawing.Point(121, 230);
            this.cbb_role.Name = "cbb_role";
            this.cbb_role.Size = new System.Drawing.Size(249, 21);
            this.cbb_role.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nhóm người dùng:";
            // 
            // btn_addLogin
            // 
            this.btn_addLogin.Location = new System.Drawing.Point(137, 284);
            this.btn_addLogin.Name = "btn_addLogin";
            this.btn_addLogin.Size = new System.Drawing.Size(75, 23);
            this.btn_addLogin.TabIndex = 4;
            this.btn_addLogin.Text = "Xác nhận";
            this.btn_addLogin.UseVisualStyleBackColor = true;
            this.btn_addLogin.Click += new System.EventHandler(this.btn_addLogin_Click);
            // 
            // btn_exitAddLogin
            // 
            this.btn_exitAddLogin.Location = new System.Drawing.Point(264, 284);
            this.btn_exitAddLogin.Name = "btn_exitAddLogin";
            this.btn_exitAddLogin.Size = new System.Drawing.Size(75, 23);
            this.btn_exitAddLogin.TabIndex = 5;
            this.btn_exitAddLogin.Text = "Hủy";
            this.btn_exitAddLogin.UseVisualStyleBackColor = true;
            this.btn_exitAddLogin.Click += new System.EventHandler(this.btn_exitAddLogin_Click);
            // 
            // frmTaoLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 348);
            this.Controls.Add(this.btn_exitAddLogin);
            this.Controls.Add(this.btn_addLogin);
            this.Controls.Add(this.cbb_role);
            this.Controls.Add(this.txb_userName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txb_rePassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTaoLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTaoLogin";
            this.Load += new System.EventHandler(this.frmTaoLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_rePassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_userName;
        private System.Windows.Forms.ComboBox cbb_role;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_addLogin;
        private System.Windows.Forms.Button btn_exitAddLogin;
    }
}