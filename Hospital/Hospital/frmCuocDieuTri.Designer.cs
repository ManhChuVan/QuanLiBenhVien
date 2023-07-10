namespace Hospital
{
    partial class frmCuocDieuTri
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
            this.dtp_NgayDT = new System.Windows.Forms.DateTimePicker();
            this.txb_IDCDT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_HuyADCDT = new System.Windows.Forms.Button();
            this.btn_ADCDT = new System.Windows.Forms.Button();
            this.txb_ThGianDT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txb_KetQuaCDT = new System.Windows.Forms.TextBox();
            this.cbb_MaBSiDT = new System.Windows.Forms.ComboBox();
            this.cbb_MaBNDT = new System.Windows.Forms.ComboBox();
            this.cbb_MaSCT_CDT = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dtp_NgayDT
            // 
            this.dtp_NgayDT.CustomFormat = "dd/MM/yyyy";
            this.dtp_NgayDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayDT.Location = new System.Drawing.Point(128, 234);
            this.dtp_NgayDT.Name = "dtp_NgayDT";
            this.dtp_NgayDT.Size = new System.Drawing.Size(196, 20);
            this.dtp_NgayDT.TabIndex = 46;
            // 
            // txb_IDCDT
            // 
            this.txb_IDCDT.Location = new System.Drawing.Point(128, 61);
            this.txb_IDCDT.Name = "txb_IDCDT";
            this.txb_IDCDT.ReadOnly = true;
            this.txb_IDCDT.Size = new System.Drawing.Size(196, 20);
            this.txb_IDCDT.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "ID_CDT:";
            // 
            // btn_HuyADCDT
            // 
            this.btn_HuyADCDT.Location = new System.Drawing.Point(249, 307);
            this.btn_HuyADCDT.Name = "btn_HuyADCDT";
            this.btn_HuyADCDT.Size = new System.Drawing.Size(75, 23);
            this.btn_HuyADCDT.TabIndex = 42;
            this.btn_HuyADCDT.Text = "Hủy";
            this.btn_HuyADCDT.UseVisualStyleBackColor = true;
            this.btn_HuyADCDT.Click += new System.EventHandler(this.btn_HuyADCDT_Click);
            // 
            // btn_ADCDT
            // 
            this.btn_ADCDT.Location = new System.Drawing.Point(128, 307);
            this.btn_ADCDT.Name = "btn_ADCDT";
            this.btn_ADCDT.Size = new System.Drawing.Size(75, 23);
            this.btn_ADCDT.TabIndex = 41;
            this.btn_ADCDT.Text = "Áp dụng";
            this.btn_ADCDT.UseVisualStyleBackColor = true;
            this.btn_ADCDT.Click += new System.EventHandler(this.btn_ADCDT_Click);
            // 
            // txb_ThGianDT
            // 
            this.txb_ThGianDT.Location = new System.Drawing.Point(128, 196);
            this.txb_ThGianDT.Name = "txb_ThGianDT";
            this.txb_ThGianDT.Size = new System.Drawing.Size(196, 20);
            this.txb_ThGianDT.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Ngày ĐT:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Thời gian điều trị:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Mã sự chữa trị:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Mã bệnh nhân:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Mã bác sĩ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "THÔNG TIN CUỘC ĐIỀU TRỊ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Kết quả:";
            // 
            // txb_KetQuaCDT
            // 
            this.txb_KetQuaCDT.Location = new System.Drawing.Point(128, 265);
            this.txb_KetQuaCDT.Name = "txb_KetQuaCDT";
            this.txb_KetQuaCDT.Size = new System.Drawing.Size(196, 20);
            this.txb_KetQuaCDT.TabIndex = 40;
            // 
            // cbb_MaBSiDT
            // 
            this.cbb_MaBSiDT.FormattingEnabled = true;
            this.cbb_MaBSiDT.Location = new System.Drawing.Point(128, 96);
            this.cbb_MaBSiDT.Name = "cbb_MaBSiDT";
            this.cbb_MaBSiDT.Size = new System.Drawing.Size(196, 21);
            this.cbb_MaBSiDT.TabIndex = 47;
            // 
            // cbb_MaBNDT
            // 
            this.cbb_MaBNDT.FormattingEnabled = true;
            this.cbb_MaBNDT.Location = new System.Drawing.Point(128, 127);
            this.cbb_MaBNDT.Name = "cbb_MaBNDT";
            this.cbb_MaBNDT.Size = new System.Drawing.Size(196, 21);
            this.cbb_MaBNDT.TabIndex = 47;
            // 
            // cbb_MaSCT_CDT
            // 
            this.cbb_MaSCT_CDT.FormattingEnabled = true;
            this.cbb_MaSCT_CDT.Location = new System.Drawing.Point(128, 162);
            this.cbb_MaSCT_CDT.Name = "cbb_MaSCT_CDT";
            this.cbb_MaSCT_CDT.Size = new System.Drawing.Size(196, 21);
            this.cbb_MaSCT_CDT.TabIndex = 47;
            // 
            // frmCuocDieuTri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 351);
            this.Controls.Add(this.cbb_MaSCT_CDT);
            this.Controls.Add(this.cbb_MaBNDT);
            this.Controls.Add(this.cbb_MaBSiDT);
            this.Controls.Add(this.dtp_NgayDT);
            this.Controls.Add(this.txb_IDCDT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_HuyADCDT);
            this.Controls.Add(this.btn_ADCDT);
            this.Controls.Add(this.txb_KetQuaCDT);
            this.Controls.Add(this.txb_ThGianDT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCuocDieuTri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCuocDieuTri";
            this.Load += new System.EventHandler(this.frmCuocDieuTri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_NgayDT;
        private System.Windows.Forms.TextBox txb_IDCDT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_HuyADCDT;
        private System.Windows.Forms.Button btn_ADCDT;
        private System.Windows.Forms.TextBox txb_ThGianDT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txb_KetQuaCDT;
        private System.Windows.Forms.ComboBox cbb_MaBSiDT;
        private System.Windows.Forms.ComboBox cbb_MaBNDT;
        private System.Windows.Forms.ComboBox cbb_MaSCT_CDT;
    }
}