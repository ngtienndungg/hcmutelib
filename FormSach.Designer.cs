namespace LibraryManagement
{
    partial class FormSach
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
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.btThem = new System.Windows.Forms.Button();
            this.btTaiLai = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMaSach = new System.Windows.Forms.TextBox();
            this.lbTenDocGia = new System.Windows.Forms.Label();
            this.tbTenSach = new System.Windows.Forms.TextBox();
            this.cbChuyenNganh = new System.Windows.Forms.ComboBox();
            this.lbChuyenNganh = new System.Windows.Forms.Label();
            this.lbNhaXuatBan = new System.Windows.Forms.Label();
            this.cbNhaXuatBan = new System.Windows.Forms.ComboBox();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.lbGiaBia = new System.Windows.Forms.Label();
            this.tbSoLuong = new System.Windows.Forms.TextBox();
            this.tbGiaBia = new System.Windows.Forms.TextBox();
            this.lbTacGia3 = new System.Windows.Forms.Label();
            this.lbTacGia2 = new System.Windows.Forms.Label();
            this.cbTacGia3 = new System.Windows.Forms.ComboBox();
            this.cbTacGia2 = new System.Windows.Forms.ComboBox();
            this.lbTacGia1 = new System.Windows.Forms.Label();
            this.cbTacGia1 = new System.Windows.Forms.ComboBox();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.lbMaDocGia = new System.Windows.Forms.Label();
            this.tbTimKiemTenSach = new System.Windows.Forms.TextBox();
            this.btCapNhat = new System.Windows.Forms.Button();
            this.btHuy = new System.Windows.Forms.Button();
            this.btThayDoi = new System.Windows.Forms.Button();
            this.rbSachThamKhao = new System.Windows.Forms.RadioButton();
            this.rbGiaoTrinh = new System.Windows.Forms.RadioButton();
            this.btXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSach
            // 
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Location = new System.Drawing.Point(16, 208);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.RowHeadersWidth = 51;
            this.dgvSach.RowTemplate.Height = 29;
            this.dgvSach.Size = new System.Drawing.Size(1078, 333);
            this.dgvSach.TabIndex = 0;
            this.dgvSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSach_CellClick);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(869, 165);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(106, 29);
            this.btThem.TabIndex = 1;
            this.btThem.Text = "Thêm sách";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btTaiLai
            // 
            this.btTaiLai.Location = new System.Drawing.Point(987, 165);
            this.btTaiLai.Name = "btTaiLai";
            this.btTaiLai.Size = new System.Drawing.Size(107, 29);
            this.btTaiLai.TabIndex = 2;
            this.btTaiLai.Text = "Tải lại";
            this.btTaiLai.UseVisualStyleBackColor = true;
            this.btTaiLai.Click += new System.EventHandler(this.btTaiLai_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mã sách:";
            // 
            // tbMaSach
            // 
            this.tbMaSach.Enabled = false;
            this.tbMaSach.Location = new System.Drawing.Point(84, 40);
            this.tbMaSach.Name = "tbMaSach";
            this.tbMaSach.ReadOnly = true;
            this.tbMaSach.Size = new System.Drawing.Size(101, 27);
            this.tbMaSach.TabIndex = 11;
            this.tbMaSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbTenDocGia
            // 
            this.lbTenDocGia.AutoSize = true;
            this.lbTenDocGia.Location = new System.Drawing.Point(16, 107);
            this.lbTenDocGia.Name = "lbTenDocGia";
            this.lbTenDocGia.Size = new System.Drawing.Size(68, 20);
            this.lbTenDocGia.TabIndex = 14;
            this.lbTenDocGia.Text = "Tên sách:";
            // 
            // tbTenSach
            // 
            this.tbTenSach.Location = new System.Drawing.Point(85, 103);
            this.tbTenSach.Name = "tbTenSach";
            this.tbTenSach.Size = new System.Drawing.Size(204, 27);
            this.tbTenSach.TabIndex = 13;
            // 
            // cbChuyenNganh
            // 
            this.cbChuyenNganh.FormattingEnabled = true;
            this.cbChuyenNganh.Location = new System.Drawing.Point(406, 104);
            this.cbChuyenNganh.Name = "cbChuyenNganh";
            this.cbChuyenNganh.Size = new System.Drawing.Size(156, 28);
            this.cbChuyenNganh.TabIndex = 18;
            // 
            // lbChuyenNganh
            // 
            this.lbChuyenNganh.AutoSize = true;
            this.lbChuyenNganh.Location = new System.Drawing.Point(298, 107);
            this.lbChuyenNganh.Name = "lbChuyenNganh";
            this.lbChuyenNganh.Size = new System.Drawing.Size(105, 20);
            this.lbChuyenNganh.TabIndex = 17;
            this.lbChuyenNganh.Text = "Chuyên ngành:";
            // 
            // lbNhaXuatBan
            // 
            this.lbNhaXuatBan.AutoSize = true;
            this.lbNhaXuatBan.Location = new System.Drawing.Point(430, 43);
            this.lbNhaXuatBan.Name = "lbNhaXuatBan";
            this.lbNhaXuatBan.Size = new System.Drawing.Size(100, 20);
            this.lbNhaXuatBan.TabIndex = 16;
            this.lbNhaXuatBan.Text = "Nhà xuất bản:";
            // 
            // cbNhaXuatBan
            // 
            this.cbNhaXuatBan.FormattingEnabled = true;
            this.cbNhaXuatBan.Location = new System.Drawing.Point(531, 40);
            this.cbNhaXuatBan.Name = "cbNhaXuatBan";
            this.cbNhaXuatBan.Size = new System.Drawing.Size(165, 28);
            this.cbNhaXuatBan.TabIndex = 15;
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Location = new System.Drawing.Point(193, 43);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(72, 20);
            this.lbSoLuong.TabIndex = 24;
            this.lbSoLuong.Text = "Số lượng:";
            // 
            // lbGiaBia
            // 
            this.lbGiaBia.AutoSize = true;
            this.lbGiaBia.Location = new System.Drawing.Point(307, 43);
            this.lbGiaBia.Name = "lbGiaBia";
            this.lbGiaBia.Size = new System.Drawing.Size(59, 20);
            this.lbGiaBia.TabIndex = 23;
            this.lbGiaBia.Text = "Giá bìa:";
            // 
            // tbSoLuong
            // 
            this.tbSoLuong.Location = new System.Drawing.Point(268, 40);
            this.tbSoLuong.Name = "tbSoLuong";
            this.tbSoLuong.Size = new System.Drawing.Size(36, 27);
            this.tbSoLuong.TabIndex = 22;
            // 
            // tbGiaBia
            // 
            this.tbGiaBia.Location = new System.Drawing.Point(369, 40);
            this.tbGiaBia.Name = "tbGiaBia";
            this.tbGiaBia.Size = new System.Drawing.Size(57, 27);
            this.tbGiaBia.TabIndex = 21;
            // 
            // lbTacGia3
            // 
            this.lbTacGia3.AutoSize = true;
            this.lbTacGia3.Location = new System.Drawing.Point(847, 106);
            this.lbTacGia3.Name = "lbTacGia3";
            this.lbTacGia3.Size = new System.Drawing.Size(70, 20);
            this.lbTacGia3.TabIndex = 30;
            this.lbTacGia3.Text = "Tác giả 3:";
            // 
            // lbTacGia2
            // 
            this.lbTacGia2.AutoSize = true;
            this.lbTacGia2.Location = new System.Drawing.Point(584, 106);
            this.lbTacGia2.Name = "lbTacGia2";
            this.lbTacGia2.Size = new System.Drawing.Size(70, 20);
            this.lbTacGia2.TabIndex = 29;
            this.lbTacGia2.Text = "Tác giả 2:";
            // 
            // cbTacGia3
            // 
            this.cbTacGia3.FormattingEnabled = true;
            this.cbTacGia3.Location = new System.Drawing.Point(923, 103);
            this.cbTacGia3.Name = "cbTacGia3";
            this.cbTacGia3.Size = new System.Drawing.Size(171, 28);
            this.cbTacGia3.TabIndex = 28;
            // 
            // cbTacGia2
            // 
            this.cbTacGia2.FormattingEnabled = true;
            this.cbTacGia2.Location = new System.Drawing.Point(660, 104);
            this.cbTacGia2.Name = "cbTacGia2";
            this.cbTacGia2.Size = new System.Drawing.Size(169, 28);
            this.cbTacGia2.TabIndex = 27;
            // 
            // lbTacGia1
            // 
            this.lbTacGia1.AutoSize = true;
            this.lbTacGia1.Location = new System.Drawing.Point(700, 43);
            this.lbTacGia1.Name = "lbTacGia1";
            this.lbTacGia1.Size = new System.Drawing.Size(70, 20);
            this.lbTacGia1.TabIndex = 26;
            this.lbTacGia1.Text = "Tác giả 1:";
            // 
            // cbTacGia1
            // 
            this.cbTacGia1.FormattingEnabled = true;
            this.cbTacGia1.Location = new System.Drawing.Point(773, 40);
            this.cbTacGia1.Name = "cbTacGia1";
            this.cbTacGia1.Size = new System.Drawing.Size(171, 28);
            this.cbTacGia1.TabIndex = 25;
            // 
            // btTimKiem
            // 
            this.btTimKiem.Location = new System.Drawing.Point(298, 165);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(94, 29);
            this.btTimKiem.TabIndex = 33;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // lbMaDocGia
            // 
            this.lbMaDocGia.AutoSize = true;
            this.lbMaDocGia.Location = new System.Drawing.Point(16, 169);
            this.lbMaDocGia.Name = "lbMaDocGia";
            this.lbMaDocGia.Size = new System.Drawing.Size(68, 20);
            this.lbMaDocGia.TabIndex = 32;
            this.lbMaDocGia.Text = "Tên sách:";
            // 
            // tbTimKiemTenSach
            // 
            this.tbTimKiemTenSach.Location = new System.Drawing.Point(85, 166);
            this.tbTimKiemTenSach.Name = "tbTimKiemTenSach";
            this.tbTimKiemTenSach.Size = new System.Drawing.Size(204, 27);
            this.tbTimKiemTenSach.TabIndex = 31;
            // 
            // btCapNhat
            // 
            this.btCapNhat.Location = new System.Drawing.Point(671, 165);
            this.btCapNhat.Name = "btCapNhat";
            this.btCapNhat.Size = new System.Drawing.Size(84, 29);
            this.btCapNhat.TabIndex = 36;
            this.btCapNhat.Text = "Cập nhật";
            this.btCapNhat.Click += new System.EventHandler(this.btCapNhat_Click);
            // 
            // btHuy
            // 
            this.btHuy.Location = new System.Drawing.Point(601, 165);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(57, 29);
            this.btHuy.TabIndex = 35;
            this.btHuy.Text = "Huỷ";
            this.btHuy.UseVisualStyleBackColor = true;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // btThayDoi
            // 
            this.btThayDoi.Location = new System.Drawing.Point(438, 165);
            this.btThayDoi.Name = "btThayDoi";
            this.btThayDoi.Size = new System.Drawing.Size(156, 29);
            this.btThayDoi.TabIndex = 34;
            this.btThayDoi.Text = "Thay đổi thông tin";
            this.btThayDoi.UseVisualStyleBackColor = true;
            this.btThayDoi.Click += new System.EventHandler(this.btThayDoi_Click);
            // 
            // rbSachThamKhao
            // 
            this.rbSachThamKhao.AutoSize = true;
            this.rbSachThamKhao.Location = new System.Drawing.Point(966, 59);
            this.rbSachThamKhao.Name = "rbSachThamKhao";
            this.rbSachThamKhao.Size = new System.Drawing.Size(135, 24);
            this.rbSachThamKhao.TabIndex = 38;
            this.rbSachThamKhao.Text = "Sách tham khảo";
            this.rbSachThamKhao.UseVisualStyleBackColor = true;
            // 
            // rbGiaoTrinh
            // 
            this.rbGiaoTrinh.AutoSize = true;
            this.rbGiaoTrinh.Checked = true;
            this.rbGiaoTrinh.Location = new System.Drawing.Point(966, 29);
            this.rbGiaoTrinh.Name = "rbGiaoTrinh";
            this.rbGiaoTrinh.Size = new System.Drawing.Size(95, 24);
            this.rbGiaoTrinh.TabIndex = 37;
            this.rbGiaoTrinh.TabStop = true;
            this.rbGiaoTrinh.Text = "Giáo trình";
            this.rbGiaoTrinh.UseVisualStyleBackColor = true;
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(787, 165);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(57, 29);
            this.btXoa.TabIndex = 39;
            this.btXoa.Text = "Xoá";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // FormSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 553);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.rbSachThamKhao);
            this.Controls.Add(this.rbGiaoTrinh);
            this.Controls.Add(this.btCapNhat);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btThayDoi);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.lbMaDocGia);
            this.Controls.Add(this.tbTimKiemTenSach);
            this.Controls.Add(this.lbTacGia3);
            this.Controls.Add(this.lbTacGia2);
            this.Controls.Add(this.cbTacGia3);
            this.Controls.Add(this.cbTacGia2);
            this.Controls.Add(this.lbTacGia1);
            this.Controls.Add(this.cbTacGia1);
            this.Controls.Add(this.lbSoLuong);
            this.Controls.Add(this.lbGiaBia);
            this.Controls.Add(this.tbSoLuong);
            this.Controls.Add(this.tbGiaBia);
            this.Controls.Add(this.cbChuyenNganh);
            this.Controls.Add(this.lbChuyenNganh);
            this.Controls.Add(this.lbNhaXuatBan);
            this.Controls.Add(this.cbNhaXuatBan);
            this.Controls.Add(this.lbTenDocGia);
            this.Controls.Add(this.tbTenSach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMaSach);
            this.Controls.Add(this.btTaiLai);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.dgvSach);
            this.Name = "FormSach";
            this.Text = "Sách";
            this.Load += new System.EventHandler(this.SachForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvSach;
        private Button btThem;
        private Button btTaiLai;
        private Label label1;
        private TextBox tbMaSach;
        private Label lbTenDocGia;
        private TextBox tbTenSach;
        private ComboBox cbChuyenNganh;
        private Label lbChuyenNganh;
        private Label lbNhaXuatBan;
        private ComboBox cbNhaXuatBan;
        private Label lbSoLuong;
        private Label lbGiaBia;
        private TextBox tbSoLuong;
        private TextBox tbGiaBia;
        private Label lbTacGia3;
        private Label lbTacGia2;
        private ComboBox cbTacGia3;
        private ComboBox cbTacGia2;
        private Label lbTacGia1;
        private ComboBox cbTacGia1;
        private Button btTimKiem;
        private Label lbMaDocGia;
        private TextBox tbTimKiemTenSach;
        private Button btCapNhat;
        private Button btHuy;
        private Button btThayDoi;
        private RadioButton rbSachThamKhao;
        private RadioButton rbGiaoTrinh;
        private Button btXoa;
    }
}