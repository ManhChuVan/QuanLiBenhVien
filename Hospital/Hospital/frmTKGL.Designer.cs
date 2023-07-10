namespace Hospital
{
    partial class frmTKGL
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
            this.txb_SoGioLV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_HuyADTKGL = new System.Windows.Forms.Button();
            this.btn_ADTKGL = new System.Windows.Forms.Button();
            this.cbb_MaNV_TKGL = new System.Windows.Forms.ComboBox();
            this.cbb_MaKhu_TKGL = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txb_SoGioLV
            // 
            this.txb_SoGioLV.Location = new System.Drawing.Point(103, 129);
            this.txb_SoGioLV.Name = "txb_SoGioLV";
            this.txb_SoGioLV.Size = new System.Drawing.Size(196, 20);
            this.txb_SoGioLV.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Mã nhân viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Số giờ làm việc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Mã khu làm việc:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "THÔNG TIN  GIỜ LÀM";
            // 
            // btn_HuyADTKGL
            // 
            this.btn_HuyADTKGL.Location = new System.Drawing.Point(224, 173);
            this.btn_HuyADTKGL.Name = "btn_HuyADTKGL";
            this.btn_HuyADTKGL.Size = new System.Drawing.Size(75, 23);
            this.btn_HuyADTKGL.TabIndex = 54;
            this.btn_HuyADTKGL.Text = "Hủy";
            this.btn_HuyADTKGL.UseVisualStyleBackColor = true;
            this.btn_HuyADTKGL.Click += new System.EventHandler(this.btn_HuyADTKGL_Click);
            // 
            // btn_ADTKGL
            // 
            this.btn_ADTKGL.Location = new System.Drawing.Point(103, 173);
            this.btn_ADTKGL.Name = "btn_ADTKGL";
            this.btn_ADTKGL.Size = new System.Drawing.Size(75, 23);
            this.btn_ADTKGL.TabIndex = 53;
            this.btn_ADTKGL.Text = "Áp dụng";
            this.btn_ADTKGL.UseVisualStyleBackColor = true;
            this.btn_ADTKGL.Click += new System.EventHandler(this.btn_ADTKGL_Click);
            // 
            // cbb_MaNV_TKGL
            // 
            this.cbb_MaNV_TKGL.FormattingEnabled = true;
            this.cbb_MaNV_TKGL.Location = new System.Drawing.Point(103, 63);
            this.cbb_MaNV_TKGL.Name = "cbb_MaNV_TKGL";
            this.cbb_MaNV_TKGL.Size = new System.Drawing.Size(196, 21);
            this.cbb_MaNV_TKGL.TabIndex = 55;
            // 
            // cbb_MaKhu_TKGL
            // 
            this.cbb_MaKhu_TKGL.FormattingEnabled = true;
            this.cbb_MaKhu_TKGL.Location = new System.Drawing.Point(103, 94);
            this.cbb_MaKhu_TKGL.Name = "cbb_MaKhu_TKGL";
            this.cbb_MaKhu_TKGL.Size = new System.Drawing.Size(196, 21);
            this.cbb_MaKhu_TKGL.TabIndex = 55;
            // 
            // frmTKGL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 235);
            this.Controls.Add(this.cbb_MaKhu_TKGL);
            this.Controls.Add(this.cbb_MaNV_TKGL);
            this.Controls.Add(this.btn_HuyADTKGL);
            this.Controls.Add(this.btn_ADTKGL);
            this.Controls.Add(this.txb_SoGioLV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTKGL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTKGL";
            this.Load += new System.EventHandler(this.frmTKGL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_SoGioLV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_HuyADTKGL;
        private System.Windows.Forms.Button btn_ADTKGL;
        private System.Windows.Forms.ComboBox cbb_MaNV_TKGL;
        private System.Windows.Forms.ComboBox cbb_MaKhu_TKGL;
    }
}