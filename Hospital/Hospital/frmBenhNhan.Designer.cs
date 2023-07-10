namespace Hospital
{
    partial class frmBenhNhan
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
            this.dtp_NgSinhBN = new System.Windows.Forms.DateTimePicker();
            this.txb_CCCDBN = new System.Windows.Forms.TextBox();
            this.txb_MaBN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_HuyADBN = new System.Windows.Forms.Button();
            this.btn_ADBN = new System.Windows.Forms.Button();
            this.txb_TenBN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbb_MaBSTD = new System.Windows.Forms.ComboBox();
            this.cbb__MaBSTN = new System.Windows.Forms.ComboBox();
            this.cbb_HinhThucKham = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dtp_NgSinhBN
            // 
            this.dtp_NgSinhBN.CustomFormat = "dd/MM/yyyy";
            this.dtp_NgSinhBN.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgSinhBN.Location = new System.Drawing.Point(120, 122);
            this.dtp_NgSinhBN.Name = "dtp_NgSinhBN";
            this.dtp_NgSinhBN.Size = new System.Drawing.Size(196, 20);
            this.dtp_NgSinhBN.TabIndex = 46;
            // 
            // txb_CCCDBN
            // 
            this.txb_CCCDBN.Location = new System.Drawing.Point(120, 160);
            this.txb_CCCDBN.Name = "txb_CCCDBN";
            this.txb_CCCDBN.Size = new System.Drawing.Size(196, 20);
            this.txb_CCCDBN.TabIndex = 45;
            // 
            // txb_MaBN
            // 
            this.txb_MaBN.Location = new System.Drawing.Point(120, 59);
            this.txb_MaBN.Name = "txb_MaBN";
            this.txb_MaBN.ReadOnly = true;
            this.txb_MaBN.Size = new System.Drawing.Size(196, 20);
            this.txb_MaBN.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Mã bệnh nhân:";
            // 
            // btn_HuyADBN
            // 
            this.btn_HuyADBN.Location = new System.Drawing.Point(226, 308);
            this.btn_HuyADBN.Name = "btn_HuyADBN";
            this.btn_HuyADBN.Size = new System.Drawing.Size(75, 23);
            this.btn_HuyADBN.TabIndex = 42;
            this.btn_HuyADBN.Text = "Hủy";
            this.btn_HuyADBN.UseVisualStyleBackColor = true;
            this.btn_HuyADBN.Click += new System.EventHandler(this.btn_HuyADBN_Click);
            // 
            // btn_ADBN
            // 
            this.btn_ADBN.Location = new System.Drawing.Point(128, 308);
            this.btn_ADBN.Name = "btn_ADBN";
            this.btn_ADBN.Size = new System.Drawing.Size(75, 23);
            this.btn_ADBN.TabIndex = 41;
            this.btn_ADBN.Text = "Áp dụng";
            this.btn_ADBN.UseVisualStyleBackColor = true;
            this.btn_ADBN.Click += new System.EventHandler(this.btn_ADBN_Click);
            // 
            // txb_TenBN
            // 
            this.txb_TenBN.Location = new System.Drawing.Point(120, 90);
            this.txb_TenBN.Name = "txb_TenBN";
            this.txb_TenBN.Size = new System.Drawing.Size(196, 20);
            this.txb_TenBN.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Mã BSi tiếp nhận:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Mã BS theo dõi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "CCCD:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Ngày sinh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Họ tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "THÔNG TIN BỆNH NHÂN";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Hình thức khám:";
            // 
            // cbb_MaBSTD
            // 
            this.cbb_MaBSTD.FormattingEnabled = true;
            this.cbb_MaBSTD.Location = new System.Drawing.Point(120, 194);
            this.cbb_MaBSTD.Name = "cbb_MaBSTD";
            this.cbb_MaBSTD.Size = new System.Drawing.Size(196, 21);
            this.cbb_MaBSTD.TabIndex = 47;
            // 
            // cbb__MaBSTN
            // 
            this.cbb__MaBSTN.FormattingEnabled = true;
            this.cbb__MaBSTN.Location = new System.Drawing.Point(120, 229);
            this.cbb__MaBSTN.Name = "cbb__MaBSTN";
            this.cbb__MaBSTN.Size = new System.Drawing.Size(196, 21);
            this.cbb__MaBSTN.TabIndex = 47;
            // 
            // cbb_HinhThucKham
            // 
            this.cbb_HinhThucKham.FormattingEnabled = true;
            this.cbb_HinhThucKham.Items.AddRange(new object[] {
            "Ngoại Trú",
            "Nội Trú"});
            this.cbb_HinhThucKham.Location = new System.Drawing.Point(120, 267);
            this.cbb_HinhThucKham.Name = "cbb_HinhThucKham";
            this.cbb_HinhThucKham.Size = new System.Drawing.Size(196, 21);
            this.cbb_HinhThucKham.TabIndex = 48;
            // 
            // frmBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 360);
            this.Controls.Add(this.cbb_HinhThucKham);
            this.Controls.Add(this.cbb__MaBSTN);
            this.Controls.Add(this.cbb_MaBSTD);
            this.Controls.Add(this.dtp_NgSinhBN);
            this.Controls.Add(this.txb_CCCDBN);
            this.Controls.Add(this.txb_MaBN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_HuyADBN);
            this.Controls.Add(this.btn_ADBN);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txb_TenBN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBenhNhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBenhNhan";
            this.Load += new System.EventHandler(this.frmBenhNhan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_NgSinhBN;
        private System.Windows.Forms.TextBox txb_CCCDBN;
        private System.Windows.Forms.TextBox txb_MaBN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_HuyADBN;
        private System.Windows.Forms.Button btn_ADBN;
        private System.Windows.Forms.TextBox txb_TenBN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbb_MaBSTD;
        private System.Windows.Forms.ComboBox cbb__MaBSTN;
        private System.Windows.Forms.ComboBox cbb_HinhThucKham;
    }
}