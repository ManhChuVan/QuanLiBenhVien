namespace Hospital
{
    partial class frmBackupDB
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
            this.txb_link = new System.Windows.Forms.TextBox();
            this.btn_link = new System.Windows.Forms.Button();
            this.txb_nameFile = new System.Windows.Forms.TextBox();
            this.btn_SaoLuu = new System.Windows.Forms.Button();
            this.btn_huySaoLuu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SAO LƯU DỮ LIỆU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập đường dẫn tới file sao lưu:";
            // 
            // txb_link
            // 
            this.txb_link.Location = new System.Drawing.Point(33, 114);
            this.txb_link.Name = "txb_link";
            this.txb_link.Size = new System.Drawing.Size(292, 20);
            this.txb_link.TabIndex = 2;
            // 
            // btn_link
            // 
            this.btn_link.Location = new System.Drawing.Point(344, 114);
            this.btn_link.Name = "btn_link";
            this.btn_link.Size = new System.Drawing.Size(75, 23);
            this.btn_link.TabIndex = 3;
            this.btn_link.Text = "...";
            this.btn_link.UseVisualStyleBackColor = true;
            this.btn_link.Click += new System.EventHandler(this.btn_link_Click);
            // 
            // txb_nameFile
            // 
            this.txb_nameFile.Location = new System.Drawing.Point(33, 173);
            this.txb_nameFile.Name = "txb_nameFile";
            this.txb_nameFile.Size = new System.Drawing.Size(292, 20);
            this.txb_nameFile.TabIndex = 2;
            // 
            // btn_SaoLuu
            // 
            this.btn_SaoLuu.Location = new System.Drawing.Point(125, 212);
            this.btn_SaoLuu.Name = "btn_SaoLuu";
            this.btn_SaoLuu.Size = new System.Drawing.Size(75, 23);
            this.btn_SaoLuu.TabIndex = 3;
            this.btn_SaoLuu.Text = "Sao lưu";
            this.btn_SaoLuu.UseVisualStyleBackColor = true;
            this.btn_SaoLuu.Click += new System.EventHandler(this.btn_SaoLuu_Click);
            // 
            // btn_huySaoLuu
            // 
            this.btn_huySaoLuu.Location = new System.Drawing.Point(235, 212);
            this.btn_huySaoLuu.Name = "btn_huySaoLuu";
            this.btn_huySaoLuu.Size = new System.Drawing.Size(75, 23);
            this.btn_huySaoLuu.TabIndex = 3;
            this.btn_huySaoLuu.Text = "Hủy";
            this.btn_huySaoLuu.UseVisualStyleBackColor = true;
            this.btn_huySaoLuu.Click += new System.EventHandler(this.btn_huySaoLuu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nhập tên file:";
            // 
            // frmBackupDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 263);
            this.Controls.Add(this.btn_huySaoLuu);
            this.Controls.Add(this.btn_SaoLuu);
            this.Controls.Add(this.btn_link);
            this.Controls.Add(this.txb_nameFile);
            this.Controls.Add(this.txb_link);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBackupDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBackupDB";
            this.Load += new System.EventHandler(this.frmBackupDB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_link;
        private System.Windows.Forms.Button btn_link;
        private System.Windows.Forms.TextBox txb_nameFile;
        private System.Windows.Forms.Button btn_SaoLuu;
        private System.Windows.Forms.Button btn_huySaoLuu;
        private System.Windows.Forms.Label label3;
    }
}