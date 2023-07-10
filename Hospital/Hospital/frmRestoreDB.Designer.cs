namespace Hospital
{
    partial class frmRestoreDB
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
            this.btn_huyPhucHoi = new System.Windows.Forms.Button();
            this.btn_PhucHoi = new System.Windows.Forms.Button();
            this.btn_linkRestore = new System.Windows.Forms.Button();
            this.txb_linkRestore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_huyPhucHoi
            // 
            this.btn_huyPhucHoi.Location = new System.Drawing.Point(260, 160);
            this.btn_huyPhucHoi.Name = "btn_huyPhucHoi";
            this.btn_huyPhucHoi.Size = new System.Drawing.Size(75, 23);
            this.btn_huyPhucHoi.TabIndex = 9;
            this.btn_huyPhucHoi.Text = "Hủy";
            this.btn_huyPhucHoi.UseVisualStyleBackColor = true;
            this.btn_huyPhucHoi.Click += new System.EventHandler(this.btn_huyPhucHoi_Click);
            // 
            // btn_PhucHoi
            // 
            this.btn_PhucHoi.Location = new System.Drawing.Point(150, 160);
            this.btn_PhucHoi.Name = "btn_PhucHoi";
            this.btn_PhucHoi.Size = new System.Drawing.Size(75, 23);
            this.btn_PhucHoi.TabIndex = 10;
            this.btn_PhucHoi.Text = "Phục hồi";
            this.btn_PhucHoi.UseVisualStyleBackColor = true;
            this.btn_PhucHoi.Click += new System.EventHandler(this.btn_PhucHoi_Click);
            // 
            // btn_linkRestore
            // 
            this.btn_linkRestore.Location = new System.Drawing.Point(354, 108);
            this.btn_linkRestore.Name = "btn_linkRestore";
            this.btn_linkRestore.Size = new System.Drawing.Size(75, 23);
            this.btn_linkRestore.TabIndex = 11;
            this.btn_linkRestore.Text = "...";
            this.btn_linkRestore.UseVisualStyleBackColor = true;
            this.btn_linkRestore.Click += new System.EventHandler(this.btn_linkRestore_Click);
            // 
            // txb_linkRestore
            // 
            this.txb_linkRestore.Location = new System.Drawing.Point(43, 108);
            this.txb_linkRestore.Name = "txb_linkRestore";
            this.txb_linkRestore.Size = new System.Drawing.Size(292, 20);
            this.txb_linkRestore.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nhập đường dẫn tới file để phục hồi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "PHỤC HỒI DỮ LIỆU";
            // 
            // frmRestoreDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 219);
            this.Controls.Add(this.btn_huyPhucHoi);
            this.Controls.Add(this.btn_PhucHoi);
            this.Controls.Add(this.btn_linkRestore);
            this.Controls.Add(this.txb_linkRestore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmRestoreDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRestoreDB";
            this.Load += new System.EventHandler(this.frmRestoreDB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_huyPhucHoi;
        private System.Windows.Forms.Button btn_PhucHoi;
        private System.Windows.Forms.Button btn_linkRestore;
        private System.Windows.Forms.TextBox txb_linkRestore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}