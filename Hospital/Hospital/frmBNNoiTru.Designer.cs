namespace Hospital
{
    partial class frmBNNoiTru
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
            this.btn_HuyCapNhatNoiTru = new System.Windows.Forms.Button();
            this.btn_CapNhatNoiTru = new System.Windows.Forms.Button();
            this.txb_MoTaBenhNoiTru = new System.Windows.Forms.TextBox();
            this.txb_MaBNNoiTru = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbb_MaGiuong = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_HuyCapNhatNoiTru
            // 
            this.btn_HuyCapNhatNoiTru.Location = new System.Drawing.Point(184, 202);
            this.btn_HuyCapNhatNoiTru.Name = "btn_HuyCapNhatNoiTru";
            this.btn_HuyCapNhatNoiTru.Size = new System.Drawing.Size(75, 23);
            this.btn_HuyCapNhatNoiTru.TabIndex = 13;
            this.btn_HuyCapNhatNoiTru.Text = "Hủy";
            this.btn_HuyCapNhatNoiTru.UseVisualStyleBackColor = true;
            this.btn_HuyCapNhatNoiTru.Click += new System.EventHandler(this.btn_HuyCapNhatNoiTru_Click);
            // 
            // btn_CapNhatNoiTru
            // 
            this.btn_CapNhatNoiTru.Location = new System.Drawing.Point(89, 202);
            this.btn_CapNhatNoiTru.Name = "btn_CapNhatNoiTru";
            this.btn_CapNhatNoiTru.Size = new System.Drawing.Size(75, 23);
            this.btn_CapNhatNoiTru.TabIndex = 12;
            this.btn_CapNhatNoiTru.Text = "Cập Nhật";
            this.btn_CapNhatNoiTru.UseVisualStyleBackColor = true;
            this.btn_CapNhatNoiTru.Click += new System.EventHandler(this.btn_CapNhatNoiTru_Click);
            // 
            // txb_MoTaBenhNoiTru
            // 
            this.txb_MoTaBenhNoiTru.Location = new System.Drawing.Point(89, 117);
            this.txb_MoTaBenhNoiTru.Name = "txb_MoTaBenhNoiTru";
            this.txb_MoTaBenhNoiTru.Size = new System.Drawing.Size(170, 20);
            this.txb_MoTaBenhNoiTru.TabIndex = 11;
            // 
            // txb_MaBNNoiTru
            // 
            this.txb_MaBNNoiTru.Location = new System.Drawing.Point(89, 75);
            this.txb_MaBNNoiTru.Name = "txb_MaBNNoiTru";
            this.txb_MaBNNoiTru.ReadOnly = true;
            this.txb_MaBNNoiTru.Size = new System.Drawing.Size(170, 20);
            this.txb_MaBNNoiTru.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mô tả bệnh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mã BN:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "CẬP NHẬT TT BN NỘI TRÚ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mã Giường";
            // 
            // cbb_MaGiuong
            // 
            this.cbb_MaGiuong.FormattingEnabled = true;
            this.cbb_MaGiuong.Location = new System.Drawing.Point(89, 156);
            this.cbb_MaGiuong.Name = "cbb_MaGiuong";
            this.cbb_MaGiuong.Size = new System.Drawing.Size(170, 21);
            this.cbb_MaGiuong.TabIndex = 14;
            // 
            // frmBNNoiTru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cbb_MaGiuong);
            this.Controls.Add(this.btn_HuyCapNhatNoiTru);
            this.Controls.Add(this.btn_CapNhatNoiTru);
            this.Controls.Add(this.txb_MoTaBenhNoiTru);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_MaBNNoiTru);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBNNoiTru";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBNNoiTru";
            this.Load += new System.EventHandler(this.frmBNNoiTru_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_HuyCapNhatNoiTru;
        private System.Windows.Forms.Button btn_CapNhatNoiTru;
        private System.Windows.Forms.TextBox txb_MoTaBenhNoiTru;
        private System.Windows.Forms.TextBox txb_MaBNNoiTru;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbb_MaGiuong;
    }
}