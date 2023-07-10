namespace Hospital
{
    partial class frmSDVT
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
            this.txb_IDSDVT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_HuyADSDVT = new System.Windows.Forms.Button();
            this.btn_ADSDVT = new System.Windows.Forms.Button();
            this.txb_SoLuongSDVT = new System.Windows.Forms.TextBox();
            this.txb_ThGianSDVT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_NgaySD = new System.Windows.Forms.DateTimePicker();
            this.cbb_MaBNSDVT = new System.Windows.Forms.ComboBox();
            this.cbb_MaVTSD = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txb_IDSDVT
            // 
            this.txb_IDSDVT.Location = new System.Drawing.Point(132, 53);
            this.txb_IDSDVT.Name = "txb_IDSDVT";
            this.txb_IDSDVT.ReadOnly = true;
            this.txb_IDSDVT.Size = new System.Drawing.Size(196, 20);
            this.txb_IDSDVT.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "ID_SDVT:";
            // 
            // btn_HuyADSDVT
            // 
            this.btn_HuyADSDVT.Location = new System.Drawing.Point(253, 262);
            this.btn_HuyADSDVT.Name = "btn_HuyADSDVT";
            this.btn_HuyADSDVT.Size = new System.Drawing.Size(75, 23);
            this.btn_HuyADSDVT.TabIndex = 27;
            this.btn_HuyADSDVT.Text = "Hủy";
            this.btn_HuyADSDVT.UseVisualStyleBackColor = true;
            this.btn_HuyADSDVT.Click += new System.EventHandler(this.btn_HuyADSDVT_Click);
            // 
            // btn_ADSDVT
            // 
            this.btn_ADSDVT.Location = new System.Drawing.Point(132, 262);
            this.btn_ADSDVT.Name = "btn_ADSDVT";
            this.btn_ADSDVT.Size = new System.Drawing.Size(75, 23);
            this.btn_ADSDVT.TabIndex = 26;
            this.btn_ADSDVT.Text = "Áp dụng";
            this.btn_ADSDVT.UseVisualStyleBackColor = true;
            this.btn_ADSDVT.Click += new System.EventHandler(this.btn_ADSDVT_Click);
            // 
            // txb_SoLuongSDVT
            // 
            this.txb_SoLuongSDVT.Location = new System.Drawing.Point(132, 223);
            this.txb_SoLuongSDVT.Name = "txb_SoLuongSDVT";
            this.txb_SoLuongSDVT.Size = new System.Drawing.Size(196, 20);
            this.txb_SoLuongSDVT.TabIndex = 25;
            // 
            // txb_ThGianSDVT
            // 
            this.txb_ThGianSDVT.Location = new System.Drawing.Point(132, 188);
            this.txb_ThGianSDVT.Name = "txb_ThGianSDVT";
            this.txb_ThGianSDVT.Size = new System.Drawing.Size(196, 20);
            this.txb_ThGianSDVT.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Số lượng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Thời gian sử dụng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Ngày sử dụng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Mã vật tư:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mã bệnh nhân:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "THÔNG TIN SỬ DỤNG VẬT TƯ";
            // 
            // dtp_NgaySD
            // 
            this.dtp_NgaySD.CustomFormat = "dd/MM/yyyy";
            this.dtp_NgaySD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgaySD.Location = new System.Drawing.Point(132, 157);
            this.dtp_NgaySD.Name = "dtp_NgaySD";
            this.dtp_NgaySD.Size = new System.Drawing.Size(196, 20);
            this.dtp_NgaySD.TabIndex = 31;
            // 
            // cbb_MaBNSDVT
            // 
            this.cbb_MaBNSDVT.FormattingEnabled = true;
            this.cbb_MaBNSDVT.Location = new System.Drawing.Point(132, 88);
            this.cbb_MaBNSDVT.Name = "cbb_MaBNSDVT";
            this.cbb_MaBNSDVT.Size = new System.Drawing.Size(196, 21);
            this.cbb_MaBNSDVT.TabIndex = 32;
            // 
            // cbb_MaVTSD
            // 
            this.cbb_MaVTSD.FormattingEnabled = true;
            this.cbb_MaVTSD.Location = new System.Drawing.Point(132, 119);
            this.cbb_MaVTSD.Name = "cbb_MaVTSD";
            this.cbb_MaVTSD.Size = new System.Drawing.Size(196, 21);
            this.cbb_MaVTSD.TabIndex = 33;
            // 
            // frmSDVT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 303);
            this.Controls.Add(this.cbb_MaVTSD);
            this.Controls.Add(this.cbb_MaBNSDVT);
            this.Controls.Add(this.dtp_NgaySD);
            this.Controls.Add(this.txb_IDSDVT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_HuyADSDVT);
            this.Controls.Add(this.btn_ADSDVT);
            this.Controls.Add(this.txb_SoLuongSDVT);
            this.Controls.Add(this.txb_ThGianSDVT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSDVT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSDVT";
            this.Load += new System.EventHandler(this.frmSDVT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_IDSDVT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_HuyADSDVT;
        private System.Windows.Forms.Button btn_ADSDVT;
        private System.Windows.Forms.TextBox txb_SoLuongSDVT;
        private System.Windows.Forms.TextBox txb_ThGianSDVT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_NgaySD;
        private System.Windows.Forms.ComboBox cbb_MaBNSDVT;
        private System.Windows.Forms.ComboBox cbb_MaVTSD;
    }
}