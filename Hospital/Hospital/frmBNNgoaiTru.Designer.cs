namespace Hospital
{
    partial class frmBNNgoaiTru
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
            this.btn_HuyCapNhatNgoaiTru = new System.Windows.Forms.Button();
            this.btn_CapNhatNgoaiTru = new System.Windows.Forms.Button();
            this.txb_MoTaBenhNgoaiTru = new System.Windows.Forms.TextBox();
            this.txb_MaBNNgoaiTru = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_HuyCapNhatNgoaiTru
            // 
            this.btn_HuyCapNhatNgoaiTru.Location = new System.Drawing.Point(189, 163);
            this.btn_HuyCapNhatNgoaiTru.Name = "btn_HuyCapNhatNgoaiTru";
            this.btn_HuyCapNhatNgoaiTru.Size = new System.Drawing.Size(75, 23);
            this.btn_HuyCapNhatNgoaiTru.TabIndex = 22;
            this.btn_HuyCapNhatNgoaiTru.Text = "Hủy";
            this.btn_HuyCapNhatNgoaiTru.UseVisualStyleBackColor = true;
            this.btn_HuyCapNhatNgoaiTru.Click += new System.EventHandler(this.btn_HuyCapNhatNgoaiTru_Click);
            // 
            // btn_CapNhatNgoaiTru
            // 
            this.btn_CapNhatNgoaiTru.Location = new System.Drawing.Point(94, 163);
            this.btn_CapNhatNgoaiTru.Name = "btn_CapNhatNgoaiTru";
            this.btn_CapNhatNgoaiTru.Size = new System.Drawing.Size(75, 23);
            this.btn_CapNhatNgoaiTru.TabIndex = 21;
            this.btn_CapNhatNgoaiTru.Text = "Cập Nhật";
            this.btn_CapNhatNgoaiTru.UseVisualStyleBackColor = true;
            this.btn_CapNhatNgoaiTru.Click += new System.EventHandler(this.btn_CapNhatNgoaiTru_Click);
            // 
            // txb_MoTaBenhNgoaiTru
            // 
            this.txb_MoTaBenhNgoaiTru.Location = new System.Drawing.Point(94, 114);
            this.txb_MoTaBenhNgoaiTru.Name = "txb_MoTaBenhNgoaiTru";
            this.txb_MoTaBenhNgoaiTru.Size = new System.Drawing.Size(170, 20);
            this.txb_MoTaBenhNgoaiTru.TabIndex = 20;
            // 
            // txb_MaBNNgoaiTru
            // 
            this.txb_MaBNNgoaiTru.Location = new System.Drawing.Point(94, 72);
            this.txb_MaBNNgoaiTru.Name = "txb_MaBNNgoaiTru";
            this.txb_MaBNNgoaiTru.ReadOnly = true;
            this.txb_MaBNNgoaiTru.Size = new System.Drawing.Size(170, 20);
            this.txb_MaBNNgoaiTru.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Mô tả bệnh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mã BN:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "CẬP NHẬT TT BN NGOẠI TRÚ";
            // 
            // frmBNNgoaiTru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 234);
            this.Controls.Add(this.btn_HuyCapNhatNgoaiTru);
            this.Controls.Add(this.btn_CapNhatNgoaiTru);
            this.Controls.Add(this.txb_MoTaBenhNgoaiTru);
            this.Controls.Add(this.txb_MaBNNgoaiTru);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBNNgoaiTru";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBNNgoaiTru";
            this.Load += new System.EventHandler(this.frmBNNgoaiTru_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_HuyCapNhatNgoaiTru;
        private System.Windows.Forms.Button btn_CapNhatNgoaiTru;
        private System.Windows.Forms.TextBox txb_MoTaBenhNgoaiTru;
        private System.Windows.Forms.TextBox txb_MaBNNgoaiTru;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}