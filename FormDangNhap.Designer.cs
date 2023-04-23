namespace LibraryManagement
{
    partial class FormDangNhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbTenDangNhap = new System.Windows.Forms.TextBox();
            this.tbMatKhau = new System.Windows.Forms.TextBox();
            this.btDangNhap = new System.Windows.Forms.Button();
            this.lbTdn = new System.Windows.Forms.Label();
            this.lbMk = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbTenDangNhap
            // 
            this.tbTenDangNhap.Location = new System.Drawing.Point(128, 37);
            this.tbTenDangNhap.Name = "tbTenDangNhap";
            this.tbTenDangNhap.Size = new System.Drawing.Size(234, 27);
            this.tbTenDangNhap.TabIndex = 0;
            // 
            // tbMatKhau
            // 
            this.tbMatKhau.Location = new System.Drawing.Point(128, 82);
            this.tbMatKhau.Name = "tbMatKhau";
            this.tbMatKhau.Size = new System.Drawing.Size(234, 27);
            this.tbMatKhau.TabIndex = 1;
            this.tbMatKhau.UseSystemPasswordChar = true;
            // 
            // btDangNhap
            // 
            this.btDangNhap.Location = new System.Drawing.Point(268, 132);
            this.btDangNhap.Name = "btDangNhap";
            this.btDangNhap.Size = new System.Drawing.Size(94, 29);
            this.btDangNhap.TabIndex = 2;
            this.btDangNhap.Text = "Đăng nhập";
            this.btDangNhap.UseVisualStyleBackColor = true;
            this.btDangNhap.Click += new System.EventHandler(this.btDangNhap_Click);
            // 
            // lbTdn
            // 
            this.lbTdn.AutoSize = true;
            this.lbTdn.Location = new System.Drawing.Point(12, 40);
            this.lbTdn.Name = "lbTdn";
            this.lbTdn.Size = new System.Drawing.Size(110, 20);
            this.lbTdn.TabIndex = 3;
            this.lbTdn.Text = "Tên đăng nhập:";
            // 
            // lbMk
            // 
            this.lbMk.AutoSize = true;
            this.lbMk.Location = new System.Drawing.Point(49, 85);
            this.lbMk.Name = "lbMk";
            this.lbMk.Size = new System.Drawing.Size(73, 20);
            this.lbMk.TabIndex = 4;
            this.lbMk.Text = "Mật khẩu:";
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(128, 132);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(94, 29);
            this.btThoat.TabIndex = 5;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // FormDangNhap
            // 
            this.AcceptButton = this.btDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 188);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.lbMk);
            this.Controls.Add(this.lbTdn);
            this.Controls.Add(this.btDangNhap);
            this.Controls.Add(this.tbMatKhau);
            this.Controls.Add(this.tbTenDangNhap);
            this.Name = "FormDangNhap";
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbTenDangNhap;
        private TextBox tbMatKhau;
        private Button btDangNhap;
        private Label lbTdn;
        private Label lbMk;
        private Button btThoat;
    }
}