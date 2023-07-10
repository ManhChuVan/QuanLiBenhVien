namespace Hospital
{
    partial class frmVatTu
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
            this.txb_MaVatTu = new System.Windows.Forms.TextBox();
            this.txb_DonGiaVT = new System.Windows.Forms.TextBox();
            this.txb_DacTaVT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_HuyADVatTu = new System.Windows.Forms.Button();
            this.btn_ADVatTu = new System.Windows.Forms.Button();
            this.cbb_LoaiVT = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN VẬT TƯ";
            // 
            // txb_MaVatTu
            // 
            this.txb_MaVatTu.Location = new System.Drawing.Point(85, 71);
            this.txb_MaVatTu.Name = "txb_MaVatTu";
            this.txb_MaVatTu.ReadOnly = true;
            this.txb_MaVatTu.Size = new System.Drawing.Size(230, 20);
            this.txb_MaVatTu.TabIndex = 12;
            // 
            // txb_DonGiaVT
            // 
            this.txb_DonGiaVT.Location = new System.Drawing.Point(85, 165);
            this.txb_DonGiaVT.Name = "txb_DonGiaVT";
            this.txb_DonGiaVT.Size = new System.Drawing.Size(230, 20);
            this.txb_DonGiaVT.TabIndex = 11;
            // 
            // txb_DacTaVT
            // 
            this.txb_DacTaVT.Location = new System.Drawing.Point(85, 118);
            this.txb_DacTaVT.Name = "txb_DacTaVT";
            this.txb_DacTaVT.Size = new System.Drawing.Size(230, 20);
            this.txb_DacTaVT.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Đặc Tả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Đơn Giá:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mã Vật Tư:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Loại Vật Tư:";
            // 
            // btn_HuyADVatTu
            // 
            this.btn_HuyADVatTu.Location = new System.Drawing.Point(195, 258);
            this.btn_HuyADVatTu.Name = "btn_HuyADVatTu";
            this.btn_HuyADVatTu.Size = new System.Drawing.Size(75, 23);
            this.btn_HuyADVatTu.TabIndex = 14;
            this.btn_HuyADVatTu.Text = "Hủy";
            this.btn_HuyADVatTu.UseVisualStyleBackColor = true;
            this.btn_HuyADVatTu.Click += new System.EventHandler(this.btn_HuyADVatTu_Click);
            // 
            // btn_ADVatTu
            // 
            this.btn_ADVatTu.Location = new System.Drawing.Point(104, 258);
            this.btn_ADVatTu.Name = "btn_ADVatTu";
            this.btn_ADVatTu.Size = new System.Drawing.Size(75, 23);
            this.btn_ADVatTu.TabIndex = 13;
            this.btn_ADVatTu.Text = "Áp Dụng";
            this.btn_ADVatTu.UseVisualStyleBackColor = true;
            this.btn_ADVatTu.Click += new System.EventHandler(this.btn_ADVatTu_Click);
            // 
            // cbb_LoaiVT
            // 
            this.cbb_LoaiVT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_LoaiVT.FormattingEnabled = true;
            this.cbb_LoaiVT.Items.AddRange(new object[] {
            "Dụng Cụ",
            "Thuốc Men"});
            this.cbb_LoaiVT.Location = new System.Drawing.Point(85, 214);
            this.cbb_LoaiVT.Name = "cbb_LoaiVT";
            this.cbb_LoaiVT.Size = new System.Drawing.Size(230, 21);
            this.cbb_LoaiVT.TabIndex = 15;
            // 
            // frmVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 312);
            this.Controls.Add(this.cbb_LoaiVT);
            this.Controls.Add(this.btn_HuyADVatTu);
            this.Controls.Add(this.btn_ADVatTu);
            this.Controls.Add(this.txb_MaVatTu);
            this.Controls.Add(this.txb_DonGiaVT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txb_DacTaVT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmVatTu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVatTu";
            this.Load += new System.EventHandler(this.frmVatTu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_MaVatTu;
        private System.Windows.Forms.TextBox txb_DonGiaVT;
        private System.Windows.Forms.TextBox txb_DacTaVT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_HuyADVatTu;
        private System.Windows.Forms.Button btn_ADVatTu;
        private System.Windows.Forms.ComboBox cbb_LoaiVT;
    }
}