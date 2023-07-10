namespace Hospital
{
    partial class frmSuChuaTri
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
            this.btn_HuyADSCT = new System.Windows.Forms.Button();
            this.btn_ADSCT = new System.Windows.Forms.Button();
            this.txb_TenSCT = new System.Windows.Forms.TextBox();
            this.txb_MaSCT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_HuyADSCT
            // 
            this.btn_HuyADSCT.Location = new System.Drawing.Point(206, 178);
            this.btn_HuyADSCT.Name = "btn_HuyADSCT";
            this.btn_HuyADSCT.Size = new System.Drawing.Size(75, 23);
            this.btn_HuyADSCT.TabIndex = 13;
            this.btn_HuyADSCT.Text = "Hủy";
            this.btn_HuyADSCT.UseVisualStyleBackColor = true;
            this.btn_HuyADSCT.Click += new System.EventHandler(this.btn_HuyADSCT_Click);
            // 
            // btn_ADSCT
            // 
            this.btn_ADSCT.Location = new System.Drawing.Point(97, 178);
            this.btn_ADSCT.Name = "btn_ADSCT";
            this.btn_ADSCT.Size = new System.Drawing.Size(75, 23);
            this.btn_ADSCT.TabIndex = 12;
            this.btn_ADSCT.Text = "Áp Dụng";
            this.btn_ADSCT.UseVisualStyleBackColor = true;
            this.btn_ADSCT.Click += new System.EventHandler(this.btn_ADSCT_Click);
            // 
            // txb_TenSCT
            // 
            this.txb_TenSCT.Location = new System.Drawing.Point(97, 137);
            this.txb_TenSCT.Name = "txb_TenSCT";
            this.txb_TenSCT.Size = new System.Drawing.Size(184, 20);
            this.txb_TenSCT.TabIndex = 11;
            // 
            // txb_MaSCT
            // 
            this.txb_MaSCT.Location = new System.Drawing.Point(97, 95);
            this.txb_MaSCT.Name = "txb_MaSCT";
            this.txb_MaSCT.ReadOnly = true;
            this.txb_MaSCT.Size = new System.Drawing.Size(184, 20);
            this.txb_MaSCT.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tên SCT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mã Chữa Trị:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "THÔNG TIN SỰ CHỮA TRỊ";
            // 
            // frmSuChuaTri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 235);
            this.Controls.Add(this.btn_HuyADSCT);
            this.Controls.Add(this.btn_ADSCT);
            this.Controls.Add(this.txb_TenSCT);
            this.Controls.Add(this.txb_MaSCT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSuChuaTri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSuChuaTri";
            this.Load += new System.EventHandler(this.frmSuChuaTri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_HuyADSCT;
        private System.Windows.Forms.Button btn_ADSCT;
        private System.Windows.Forms.TextBox txb_TenSCT;
        private System.Windows.Forms.TextBox txb_MaSCT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}