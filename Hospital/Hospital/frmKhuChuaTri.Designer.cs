namespace Hospital
{
    partial class frmKhuChuaTri
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
            this.txb_MaKCT = new System.Windows.Forms.TextBox();
            this.txb_TenKCT = new System.Windows.Forms.TextBox();
            this.btn_ADKCT = new System.Windows.Forms.Button();
            this.btn_HuyADKCT = new System.Windows.Forms.Button();
            this.cbb_MaYTT = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin Khu Chữa Trị";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Khu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Khu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã Y Tá Trưởng:";
            // 
            // txb_MaKCT
            // 
            this.txb_MaKCT.Location = new System.Drawing.Point(112, 72);
            this.txb_MaKCT.Name = "txb_MaKCT";
            this.txb_MaKCT.ReadOnly = true;
            this.txb_MaKCT.Size = new System.Drawing.Size(179, 20);
            this.txb_MaKCT.TabIndex = 4;
            // 
            // txb_TenKCT
            // 
            this.txb_TenKCT.Location = new System.Drawing.Point(112, 108);
            this.txb_TenKCT.Name = "txb_TenKCT";
            this.txb_TenKCT.Size = new System.Drawing.Size(179, 20);
            this.txb_TenKCT.TabIndex = 5;
            // 
            // btn_ADKCT
            // 
            this.btn_ADKCT.Location = new System.Drawing.Point(112, 191);
            this.btn_ADKCT.Name = "btn_ADKCT";
            this.btn_ADKCT.Size = new System.Drawing.Size(75, 23);
            this.btn_ADKCT.TabIndex = 7;
            this.btn_ADKCT.Text = "Áp Dụng";
            this.btn_ADKCT.UseVisualStyleBackColor = true;
            this.btn_ADKCT.Click += new System.EventHandler(this.btn_ADKCT_Click);
            // 
            // btn_HuyADKCT
            // 
            this.btn_HuyADKCT.Location = new System.Drawing.Point(216, 191);
            this.btn_HuyADKCT.Name = "btn_HuyADKCT";
            this.btn_HuyADKCT.Size = new System.Drawing.Size(75, 23);
            this.btn_HuyADKCT.TabIndex = 8;
            this.btn_HuyADKCT.Text = "Hủy";
            this.btn_HuyADKCT.UseVisualStyleBackColor = true;
            this.btn_HuyADKCT.Click += new System.EventHandler(this.btn_HuyADKCT_Click);
            // 
            // cbb_MaYTT
            // 
            this.cbb_MaYTT.FormattingEnabled = true;
            this.cbb_MaYTT.Location = new System.Drawing.Point(112, 142);
            this.cbb_MaYTT.Name = "cbb_MaYTT";
            this.cbb_MaYTT.Size = new System.Drawing.Size(179, 21);
            this.cbb_MaYTT.TabIndex = 9;
            // 
            // frmKhuChuaTri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 261);
            this.Controls.Add(this.cbb_MaYTT);
            this.Controls.Add(this.btn_HuyADKCT);
            this.Controls.Add(this.btn_ADKCT);
            this.Controls.Add(this.txb_TenKCT);
            this.Controls.Add(this.txb_MaKCT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmKhuChuaTri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKhuChuaTri";
            this.Load += new System.EventHandler(this.frmKhuChuaTri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_MaKCT;
        private System.Windows.Forms.TextBox txb_TenKCT;
        private System.Windows.Forms.Button btn_ADKCT;
        private System.Windows.Forms.Button btn_HuyADKCT;
        private System.Windows.Forms.ComboBox cbb_MaYTT;
    }
}