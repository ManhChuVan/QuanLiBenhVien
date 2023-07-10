namespace Hospital
{
    partial class frmGiuong
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_MaGiuong = new System.Windows.Forms.TextBox();
            this.btn_APGiuong = new System.Windows.Forms.Button();
            this.btn_HuyADGiuong = new System.Windows.Forms.Button();
            this.cbb_MaPhong_G = new System.Windows.Forms.ComboBox();
            this.cbb_MaKhu_G = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN GIƯỜNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Giường:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Phòng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã Khu:";
            // 
            // txb_MaGiuong
            // 
            this.txb_MaGiuong.Location = new System.Drawing.Point(94, 71);
            this.txb_MaGiuong.Name = "txb_MaGiuong";
            this.txb_MaGiuong.ReadOnly = true;
            this.txb_MaGiuong.Size = new System.Drawing.Size(189, 20);
            this.txb_MaGiuong.TabIndex = 5;
            // 
            // btn_APGiuong
            // 
            this.btn_APGiuong.Location = new System.Drawing.Point(94, 191);
            this.btn_APGiuong.Name = "btn_APGiuong";
            this.btn_APGiuong.Size = new System.Drawing.Size(75, 23);
            this.btn_APGiuong.TabIndex = 8;
            this.btn_APGiuong.Text = "Áp Dụng";
            this.btn_APGiuong.UseVisualStyleBackColor = true;
            this.btn_APGiuong.Click += new System.EventHandler(this.btn_APGiuong_Click);
            // 
            // btn_HuyADGiuong
            // 
            this.btn_HuyADGiuong.Location = new System.Drawing.Point(208, 191);
            this.btn_HuyADGiuong.Name = "btn_HuyADGiuong";
            this.btn_HuyADGiuong.Size = new System.Drawing.Size(75, 23);
            this.btn_HuyADGiuong.TabIndex = 9;
            this.btn_HuyADGiuong.Text = "Hủy";
            this.btn_HuyADGiuong.UseVisualStyleBackColor = true;
            this.btn_HuyADGiuong.Click += new System.EventHandler(this.btn_HuyADGiuong_Click);
            // 
            // cbb_MaPhong_G
            // 
            this.cbb_MaPhong_G.FormattingEnabled = true;
            this.cbb_MaPhong_G.Location = new System.Drawing.Point(94, 111);
            this.cbb_MaPhong_G.Name = "cbb_MaPhong_G";
            this.cbb_MaPhong_G.Size = new System.Drawing.Size(189, 21);
            this.cbb_MaPhong_G.TabIndex = 10;
            // 
            // cbb_MaKhu_G
            // 
            this.cbb_MaKhu_G.FormattingEnabled = true;
            this.cbb_MaKhu_G.Location = new System.Drawing.Point(94, 148);
            this.cbb_MaKhu_G.Name = "cbb_MaKhu_G";
            this.cbb_MaKhu_G.Size = new System.Drawing.Size(189, 21);
            this.cbb_MaKhu_G.TabIndex = 10;
            // 
            // frmGiuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 237);
            this.Controls.Add(this.cbb_MaKhu_G);
            this.Controls.Add(this.cbb_MaPhong_G);
            this.Controls.Add(this.btn_HuyADGiuong);
            this.Controls.Add(this.btn_APGiuong);
            this.Controls.Add(this.txb_MaGiuong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmGiuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGiuong";
            this.Load += new System.EventHandler(this.frmGiuong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_MaGiuong;
        private System.Windows.Forms.Button btn_APGiuong;
        private System.Windows.Forms.Button btn_HuyADGiuong;
        private System.Windows.Forms.ComboBox cbb_MaPhong_G;
        private System.Windows.Forms.ComboBox cbb_MaKhu_G;
    }
}