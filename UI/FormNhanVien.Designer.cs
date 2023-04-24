namespace LibraryManagement.UI
{
    partial class FormNhanVien
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
            this.btXoa = new System.Windows.Forms.Button();
            this.btThemNhanVien = new System.Windows.Forms.Button();
            this.btTaiLai = new System.Windows.Forms.Button();
            this.btCapNhat = new System.Windows.Forms.Button();
            this.btHuy = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNgaySinh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNgayVaoLam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.lbTenDocGia = new System.Windows.Forms.Label();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMa = new System.Windows.Forms.TextBox();
            this.checkBoxConLamViec = new System.Windows.Forms.CheckBox();
            this.btThayDoi = new System.Windows.Forms.Button();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.lbMaDocGia = new System.Windows.Forms.Label();
            this.tbTimKiemTen = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(727, 147);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(57, 29);
            this.btXoa.TabIndex = 62;
            this.btXoa.Text = "Xoá";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThemNhanVien
            // 
            this.btThemNhanVien.Location = new System.Drawing.Point(931, 59);
            this.btThemNhanVien.Name = "btThemNhanVien";
            this.btThemNhanVien.Size = new System.Drawing.Size(108, 51);
            this.btThemNhanVien.TabIndex = 61;
            this.btThemNhanVien.Text = "Thêm nhân viên";
            this.btThemNhanVien.Click += new System.EventHandler(this.btThemNhanVien_Click);
            // 
            // btTaiLai
            // 
            this.btTaiLai.Location = new System.Drawing.Point(802, 147);
            this.btTaiLai.Name = "btTaiLai";
            this.btTaiLai.Size = new System.Drawing.Size(84, 29);
            this.btTaiLai.TabIndex = 60;
            this.btTaiLai.Text = "Tải lại";
            this.btTaiLai.Click += new System.EventHandler(this.btTaiLai_Click);
            // 
            // btCapNhat
            // 
            this.btCapNhat.Location = new System.Drawing.Point(630, 147);
            this.btCapNhat.Name = "btCapNhat";
            this.btCapNhat.Size = new System.Drawing.Size(84, 29);
            this.btCapNhat.TabIndex = 59;
            this.btCapNhat.Text = "Cập nhật";
            this.btCapNhat.Click += new System.EventHandler(this.btCapNhat_Click);
            // 
            // btHuy
            // 
            this.btHuy.Location = new System.Drawing.Point(560, 147);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(57, 29);
            this.btHuy.TabIndex = 58;
            this.btHuy.Text = "Huỷ";
            this.btHuy.UseVisualStyleBackColor = true;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(592, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.TabIndex = 57;
            this.label8.Text = "Email:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(644, 26);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(215, 27);
            this.tbEmail.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(587, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 55;
            this.label7.Text = "SĐT:";
            // 
            // tbSDT
            // 
            this.tbSDT.Location = new System.Drawing.Point(630, 87);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(135, 27);
            this.tbSDT.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(379, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 53;
            this.label6.Text = "Ngày sinh:";
            // 
            // tbNgaySinh
            // 
            this.tbNgaySinh.Location = new System.Drawing.Point(460, 87);
            this.tbNgaySinh.Name = "tbNgaySinh";
            this.tbNgaySinh.Size = new System.Drawing.Size(93, 27);
            this.tbNgaySinh.TabIndex = 52;
            this.tbNgaySinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 49;
            this.label4.Text = "Ngày vào làm:";
            // 
            // tbNgayVaoLam
            // 
            this.tbNgayVaoLam.Location = new System.Drawing.Point(482, 26);
            this.tbNgayVaoLam.Name = "tbNgayVaoLam";
            this.tbNgayVaoLam.Size = new System.Drawing.Size(93, 27);
            this.tbNgayVaoLam.TabIndex = 48;
            this.tbNgayVaoLam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Giới tính:";
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Location = new System.Drawing.Point(295, 26);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(64, 28);
            this.cbGioiTinh.TabIndex = 44;
            // 
            // lbTenDocGia
            // 
            this.lbTenDocGia.AutoSize = true;
            this.lbTenDocGia.Location = new System.Drawing.Point(14, 90);
            this.lbTenDocGia.Name = "lbTenDocGia";
            this.lbTenDocGia.Size = new System.Drawing.Size(102, 20);
            this.lbTenDocGia.TabIndex = 43;
            this.lbTenDocGia.Text = "Tên nhân viên:";
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(119, 87);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(206, 27);
            this.tbTen.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Mã nhân viên:";
            // 
            // tbMa
            // 
            this.tbMa.Enabled = false;
            this.tbMa.Location = new System.Drawing.Point(117, 26);
            this.tbMa.Name = "tbMa";
            this.tbMa.ReadOnly = true;
            this.tbMa.Size = new System.Drawing.Size(80, 27);
            this.tbMa.TabIndex = 40;
            this.tbMa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBoxConLamViec
            // 
            this.checkBoxConLamViec.AutoSize = true;
            this.checkBoxConLamViec.Location = new System.Drawing.Point(901, 149);
            this.checkBoxConLamViec.Name = "checkBoxConLamViec";
            this.checkBoxConLamViec.Size = new System.Drawing.Size(187, 24);
            this.checkBoxConLamViec.TabIndex = 39;
            this.checkBoxConLamViec.Text = "Nhân viên còn làm việc:";
            this.checkBoxConLamViec.UseVisualStyleBackColor = true;
            this.checkBoxConLamViec.CheckedChanged += new System.EventHandler(this.checkBoxConHan_CheckedChanged);
            // 
            // btThayDoi
            // 
            this.btThayDoi.Location = new System.Drawing.Point(397, 147);
            this.btThayDoi.Name = "btThayDoi";
            this.btThayDoi.Size = new System.Drawing.Size(156, 29);
            this.btThayDoi.TabIndex = 38;
            this.btThayDoi.Text = "Thay đổi thông tin";
            this.btThayDoi.UseVisualStyleBackColor = true;
            this.btThayDoi.Click += new System.EventHandler(this.btThayDoi_Click);
            // 
            // btTimKiem
            // 
            this.btTimKiem.Location = new System.Drawing.Point(295, 147);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(94, 29);
            this.btTimKiem.TabIndex = 36;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // lbMaDocGia
            // 
            this.lbMaDocGia.AutoSize = true;
            this.lbMaDocGia.Location = new System.Drawing.Point(16, 151);
            this.lbMaDocGia.Name = "lbMaDocGia";
            this.lbMaDocGia.Size = new System.Drawing.Size(102, 20);
            this.lbMaDocGia.TabIndex = 35;
            this.lbMaDocGia.Text = "Tên nhân viên:";
            // 
            // tbTimKiemTen
            // 
            this.tbTimKiemTen.Location = new System.Drawing.Point(117, 148);
            this.tbTimKiemTen.Name = "tbTimKiemTen";
            this.tbTimKiemTen.Size = new System.Drawing.Size(161, 27);
            this.tbTimKiemTen.TabIndex = 34;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(10, 190);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 29;
            this.dgv.Size = new System.Drawing.Size(1078, 336);
            this.dgv.TabIndex = 33;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 553);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThemNhanVien);
            this.Controls.Add(this.btTaiLai);
            this.Controls.Add(this.btCapNhat);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbSDT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbNgaySinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNgayVaoLam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbGioiTinh);
            this.Controls.Add(this.lbTenDocGia);
            this.Controls.Add(this.tbTen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMa);
            this.Controls.Add(this.checkBoxConLamViec);
            this.Controls.Add(this.btThayDoi);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.lbMaDocGia);
            this.Controls.Add(this.tbTimKiemTen);
            this.Controls.Add(this.dgv);
            this.Name = "FormNhanVien";
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btXoa;
        private Button btThemNhanVien;
        private Button btTaiLai;
        private Button btCapNhat;
        private Button btHuy;
        private Label label8;
        private TextBox tbEmail;
        private Label label7;
        private TextBox tbSDT;
        private Label label6;
        private TextBox tbNgaySinh;
        private Label label4;
        private TextBox tbNgayVaoLam;
        private Label label2;
        private ComboBox cbGioiTinh;
        private Label lbTenDocGia;
        private TextBox tbTen;
        private Label label1;
        private TextBox tbMa;
        private CheckBox checkBoxConLamViec;
        private Button btThayDoi;
        private Button btTimKiem;
        private Label lbMaDocGia;
        private TextBox tbTimKiemTen;
        private DataGridView dgv;
    }
}