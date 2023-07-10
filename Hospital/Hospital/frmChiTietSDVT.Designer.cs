namespace Hospital
{
    partial class frmChiTietSDVT
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
            this.dgv_ChiTietSDVT = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_TenBNSDVT = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietSDVT)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHI TIẾT SDVT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bệnh Nhân:";
            // 
            // dgv_ChiTietSDVT
            // 
            this.dgv_ChiTietSDVT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ChiTietSDVT.Location = new System.Drawing.Point(28, 156);
            this.dgv_ChiTietSDVT.Name = "dgv_ChiTietSDVT";
            this.dgv_ChiTietSDVT.Size = new System.Drawing.Size(445, 123);
            this.dgv_ChiTietSDVT.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Chi tiết các vật tư sử dụng:";
            // 
            // txb_TenBNSDVT
            // 
            this.txb_TenBNSDVT.Location = new System.Drawing.Point(163, 86);
            this.txb_TenBNSDVT.Name = "txb_TenBNSDVT";
            this.txb_TenBNSDVT.ReadOnly = true;
            this.txb_TenBNSDVT.Size = new System.Drawing.Size(211, 20);
            this.txb_TenBNSDVT.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmChiTietSDVT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 338);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txb_TenBNSDVT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_ChiTietSDVT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmChiTietSDVT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChiTietSDVT";
            this.Load += new System.EventHandler(this.frmChiTietSDVT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietSDVT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_ChiTietSDVT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_TenBNSDVT;
        private System.Windows.Forms.Button button1;
    }
}