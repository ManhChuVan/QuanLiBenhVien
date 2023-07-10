namespace Hospital
{
    partial class frmPhong
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
            this.txb_TenPhong = new System.Windows.Forms.TextBox();
            this.txb_MaPhong = new System.Windows.Forms.TextBox();
            this.btn_ADPhong = new System.Windows.Forms.Button();
            this.btn_HuyADPhong = new System.Windows.Forms.Button();
            this.cbb_MaKhu_P = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN PHÒNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Phòng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Khu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên Phòng:";
            // 
            // txb_TenPhong
            // 
            this.txb_TenPhong.Location = new System.Drawing.Point(100, 177);
            this.txb_TenPhong.Name = "txb_TenPhong";
            this.txb_TenPhong.Size = new System.Drawing.Size(191, 20);
            this.txb_TenPhong.TabIndex = 4;
            // 
            // txb_MaPhong
            // 
            this.txb_MaPhong.Location = new System.Drawing.Point(100, 79);
            this.txb_MaPhong.Name = "txb_MaPhong";
            this.txb_MaPhong.ReadOnly = true;
            this.txb_MaPhong.Size = new System.Drawing.Size(191, 20);
            this.txb_MaPhong.TabIndex = 6;
            // 
            // btn_ADPhong
            // 
            this.btn_ADPhong.Location = new System.Drawing.Point(114, 213);
            this.btn_ADPhong.Name = "btn_ADPhong";
            this.btn_ADPhong.Size = new System.Drawing.Size(75, 23);
            this.btn_ADPhong.TabIndex = 7;
            this.btn_ADPhong.Text = "Áp Dụng";
            this.btn_ADPhong.UseVisualStyleBackColor = true;
            this.btn_ADPhong.Click += new System.EventHandler(this.btn_ADPhong_Click);
            // 
            // btn_HuyADPhong
            // 
            this.btn_HuyADPhong.Location = new System.Drawing.Point(205, 213);
            this.btn_HuyADPhong.Name = "btn_HuyADPhong";
            this.btn_HuyADPhong.Size = new System.Drawing.Size(75, 23);
            this.btn_HuyADPhong.TabIndex = 8;
            this.btn_HuyADPhong.Text = "Hủy";
            this.btn_HuyADPhong.UseVisualStyleBackColor = true;
            this.btn_HuyADPhong.Click += new System.EventHandler(this.btn_HuyADPhong_Click);
            // 
            // cbb_MaKhu_P
            // 
            this.cbb_MaKhu_P.FormattingEnabled = true;
            this.cbb_MaKhu_P.Location = new System.Drawing.Point(100, 129);
            this.cbb_MaKhu_P.Name = "cbb_MaKhu_P";
            this.cbb_MaKhu_P.Size = new System.Drawing.Size(191, 21);
            this.cbb_MaKhu_P.TabIndex = 9;
            // 
            // frmPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 261);
            this.Controls.Add(this.cbb_MaKhu_P);
            this.Controls.Add(this.btn_HuyADPhong);
            this.Controls.Add(this.btn_ADPhong);
            this.Controls.Add(this.txb_MaPhong);
            this.Controls.Add(this.txb_TenPhong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPhong";
            this.Load += new System.EventHandler(this.frmPhong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_TenPhong;
        private System.Windows.Forms.TextBox txb_MaPhong;
        private System.Windows.Forms.Button btn_ADPhong;
        private System.Windows.Forms.Button btn_HuyADPhong;
        private System.Windows.Forms.ComboBox cbb_MaKhu_P;
    }
}