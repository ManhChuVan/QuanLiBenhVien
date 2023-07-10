namespace Hospital
{
    partial class frmBacSi
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
            this.txb_MaBSi = new System.Windows.Forms.TextBox();
            this.txb_ChuyenMonBSi = new System.Windows.Forms.TextBox();
            this.btn_CapNhatBSi = new System.Windows.Forms.Button();
            this.btn_HuyCapNhatBSi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CẬP NHẬT TT BÁC SĨ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Bác Sĩ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chuyên Môn:";
            // 
            // txb_MaBSi
            // 
            this.txb_MaBSi.Location = new System.Drawing.Point(91, 68);
            this.txb_MaBSi.Name = "txb_MaBSi";
            this.txb_MaBSi.ReadOnly = true;
            this.txb_MaBSi.Size = new System.Drawing.Size(170, 20);
            this.txb_MaBSi.TabIndex = 3;
            // 
            // txb_ChuyenMonBSi
            // 
            this.txb_ChuyenMonBSi.Location = new System.Drawing.Point(91, 110);
            this.txb_ChuyenMonBSi.Name = "txb_ChuyenMonBSi";
            this.txb_ChuyenMonBSi.Size = new System.Drawing.Size(170, 20);
            this.txb_ChuyenMonBSi.TabIndex = 4;
            // 
            // btn_CapNhatBSi
            // 
            this.btn_CapNhatBSi.Location = new System.Drawing.Point(91, 151);
            this.btn_CapNhatBSi.Name = "btn_CapNhatBSi";
            this.btn_CapNhatBSi.Size = new System.Drawing.Size(75, 23);
            this.btn_CapNhatBSi.TabIndex = 5;
            this.btn_CapNhatBSi.Text = "Cập Nhật";
            this.btn_CapNhatBSi.UseVisualStyleBackColor = true;
            this.btn_CapNhatBSi.Click += new System.EventHandler(this.btn_CapNhatBSi_Click);
            // 
            // btn_HuyCapNhatBSi
            // 
            this.btn_HuyCapNhatBSi.Location = new System.Drawing.Point(186, 151);
            this.btn_HuyCapNhatBSi.Name = "btn_HuyCapNhatBSi";
            this.btn_HuyCapNhatBSi.Size = new System.Drawing.Size(75, 23);
            this.btn_HuyCapNhatBSi.TabIndex = 6;
            this.btn_HuyCapNhatBSi.Text = "Hủy";
            this.btn_HuyCapNhatBSi.UseVisualStyleBackColor = true;
            this.btn_HuyCapNhatBSi.Click += new System.EventHandler(this.btn_HuyCapNhatBSi_Click);
            // 
            // frmBacSi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 194);
            this.Controls.Add(this.btn_HuyCapNhatBSi);
            this.Controls.Add(this.btn_CapNhatBSi);
            this.Controls.Add(this.txb_ChuyenMonBSi);
            this.Controls.Add(this.txb_MaBSi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBacSi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBacSi";
            this.Load += new System.EventHandler(this.frmBacSi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_MaBSi;
        private System.Windows.Forms.TextBox txb_ChuyenMonBSi;
        private System.Windows.Forms.Button btn_CapNhatBSi;
        private System.Windows.Forms.Button btn_HuyCapNhatBSi;
    }
}