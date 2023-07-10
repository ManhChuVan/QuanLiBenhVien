namespace Hospital
{
    partial class frmYTa
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
            this.btn_CapNhatYTa = new System.Windows.Forms.Button();
            this.cbb_VTLV = new System.Windows.Forms.ComboBox();
            this.txb_MaYTa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_HuyCapNhatYTa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CẬP NHẬT TT Y TÁ";
            // 
            // btn_CapNhatYTa
            // 
            this.btn_CapNhatYTa.Location = new System.Drawing.Point(99, 166);
            this.btn_CapNhatYTa.Name = "btn_CapNhatYTa";
            this.btn_CapNhatYTa.Size = new System.Drawing.Size(75, 23);
            this.btn_CapNhatYTa.TabIndex = 1;
            this.btn_CapNhatYTa.Text = "Cập Nhật";
            this.btn_CapNhatYTa.UseVisualStyleBackColor = true;
            this.btn_CapNhatYTa.Click += new System.EventHandler(this.btn_CapNhatYTa_Click);
            // 
            // cbb_VTLV
            // 
            this.cbb_VTLV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_VTLV.FormattingEnabled = true;
            this.cbb_VTLV.Items.AddRange(new object[] {
            "Y Tá Chính",
            "Y Tá Phụ"});
            this.cbb_VTLV.Location = new System.Drawing.Point(99, 109);
            this.cbb_VTLV.Name = "cbb_VTLV";
            this.cbb_VTLV.Size = new System.Drawing.Size(177, 21);
            this.cbb_VTLV.TabIndex = 3;
            // 
            // txb_MaYTa
            // 
            this.txb_MaYTa.Location = new System.Drawing.Point(99, 62);
            this.txb_MaYTa.Name = "txb_MaYTa";
            this.txb_MaYTa.ReadOnly = true;
            this.txb_MaYTa.Size = new System.Drawing.Size(177, 20);
            this.txb_MaYTa.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã Y Tá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vị trí làm việc:";
            // 
            // btn_HuyCapNhatYTa
            // 
            this.btn_HuyCapNhatYTa.Location = new System.Drawing.Point(201, 166);
            this.btn_HuyCapNhatYTa.Name = "btn_HuyCapNhatYTa";
            this.btn_HuyCapNhatYTa.Size = new System.Drawing.Size(75, 23);
            this.btn_HuyCapNhatYTa.TabIndex = 7;
            this.btn_HuyCapNhatYTa.Text = "Hủy";
            this.btn_HuyCapNhatYTa.UseVisualStyleBackColor = true;
            this.btn_HuyCapNhatYTa.Click += new System.EventHandler(this.btn_HuyCapNhatYTa_Click);
            // 
            // frmYTa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 229);
            this.Controls.Add(this.btn_HuyCapNhatYTa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_MaYTa);
            this.Controls.Add(this.cbb_VTLV);
            this.Controls.Add(this.btn_CapNhatYTa);
            this.Controls.Add(this.label1);
            this.Name = "frmYTa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmYTa";
            this.Load += new System.EventHandler(this.frmYTa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_CapNhatYTa;
        private System.Windows.Forms.ComboBox cbb_VTLV;
        private System.Windows.Forms.TextBox txb_MaYTa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_HuyCapNhatYTa;
    }
}