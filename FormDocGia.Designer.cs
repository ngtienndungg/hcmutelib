namespace LibraryManagement
{
    partial class FormDocGia
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
            this.dgvDocGia = new System.Windows.Forms.DataGridView();
            this.tbTimKiemMaDocGia = new System.Windows.Forms.TextBox();
            this.lbMaDocGia = new System.Windows.Forms.Label();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.btGiaHan = new System.Windows.Forms.Button();
            this.btThayDoi = new System.Windows.Forms.Button();
            this.checkBoxConHan = new System.Windows.Forms.CheckBox();
            this.tbMaDocGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTenDocGia = new System.Windows.Forms.Label();
            this.tbTenDocGia = new System.Windows.Forms.TextBox();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDoiTuong = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNgayLamThe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNgayHetHan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNgaySinh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btHuy = new System.Windows.Forms.Button();
            this.btCapNhat = new System.Windows.Forms.Button();
            this.btTaiLai = new System.Windows.Forms.Button();
            this.btThemDocGia = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDocGia
            // 
            this.dgvDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocGia.Location = new System.Drawing.Point(12, 205);
            this.dgvDocGia.Name = "dgvDocGia";
            this.dgvDocGia.RowHeadersWidth = 51;
            this.dgvDocGia.RowTemplate.Height = 29;
            this.dgvDocGia.Size = new System.Drawing.Size(1078, 336);
            this.dgvDocGia.TabIndex = 1;
            this.dgvDocGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocGia_CellClick);
            // 
            // tbTimKiemMaDocGia
            // 
            this.tbTimKiemMaDocGia.Location = new System.Drawing.Point(111, 162);
            this.tbTimKiemMaDocGia.Name = "tbTimKiemMaDocGia";
            this.tbTimKiemMaDocGia.Size = new System.Drawing.Size(125, 27);
            this.tbTimKiemMaDocGia.TabIndex = 2;
            // 
            // lbMaDocGia
            // 
            this.lbMaDocGia.AutoSize = true;
            this.lbMaDocGia.Location = new System.Drawing.Point(18, 166);
            this.lbMaDocGia.Name = "lbMaDocGia";
            this.lbMaDocGia.Size = new System.Drawing.Size(87, 20);
            this.lbMaDocGia.TabIndex = 4;
            this.lbMaDocGia.Text = "Mã độc giả:";
            // 
            // btTimKiem
            // 
            this.btTimKiem.Location = new System.Drawing.Point(248, 162);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(94, 29);
            this.btTimKiem.TabIndex = 5;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // btGiaHan
            // 
            this.btGiaHan.Location = new System.Drawing.Point(750, 162);
            this.btGiaHan.Name = "btGiaHan";
            this.btGiaHan.Size = new System.Drawing.Size(121, 29);
            this.btGiaHan.TabIndex = 6;
            this.btGiaHan.Text = "Gia hạn thẻ";
            this.btGiaHan.UseVisualStyleBackColor = true;
            this.btGiaHan.Click += new System.EventHandler(this.btGiaHan_Click);
            // 
            // btThayDoi
            // 
            this.btThayDoi.Location = new System.Drawing.Point(352, 162);
            this.btThayDoi.Name = "btThayDoi";
            this.btThayDoi.Size = new System.Drawing.Size(156, 29);
            this.btThayDoi.TabIndex = 7;
            this.btThayDoi.Text = "Thay đổi thông tin";
            this.btThayDoi.UseVisualStyleBackColor = true;
            this.btThayDoi.Click += new System.EventHandler(this.btThayDoi_Click);
            // 
            // checkBoxConHan
            // 
            this.checkBoxConHan.AutoSize = true;
            this.checkBoxConHan.Location = new System.Drawing.Point(984, 165);
            this.checkBoxConHan.Name = "checkBoxConHan";
            this.checkBoxConHan.Size = new System.Drawing.Size(111, 24);
            this.checkBoxConHan.TabIndex = 8;
            this.checkBoxConHan.Text = "Thẻ còn hạn";
            this.checkBoxConHan.UseVisualStyleBackColor = true;
            this.checkBoxConHan.CheckedChanged += new System.EventHandler(this.checkBoxConHan_CheckedChanged);
            // 
            // tbMaDocGia
            // 
            this.tbMaDocGia.Enabled = false;
            this.tbMaDocGia.Location = new System.Drawing.Point(111, 41);
            this.tbMaDocGia.Name = "tbMaDocGia";
            this.tbMaDocGia.ReadOnly = true;
            this.tbMaDocGia.Size = new System.Drawing.Size(80, 27);
            this.tbMaDocGia.TabIndex = 9;
            this.tbMaDocGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã độc giả:";
            // 
            // lbTenDocGia
            // 
            this.lbTenDocGia.AutoSize = true;
            this.lbTenDocGia.Location = new System.Drawing.Point(16, 105);
            this.lbTenDocGia.Name = "lbTenDocGia";
            this.lbTenDocGia.Size = new System.Drawing.Size(89, 20);
            this.lbTenDocGia.TabIndex = 12;
            this.lbTenDocGia.Text = "Tên độc giả:";
            // 
            // tbTenDocGia
            // 
            this.tbTenDocGia.Location = new System.Drawing.Point(111, 102);
            this.tbTenDocGia.Name = "tbTenDocGia";
            this.tbTenDocGia.Size = new System.Drawing.Size(206, 27);
            this.tbTenDocGia.TabIndex = 11;
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Location = new System.Drawing.Point(275, 41);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(64, 28);
            this.cbGioiTinh.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Giới tính:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Đối tượng:";
            // 
            // cbDoiTuong
            // 
            this.cbDoiTuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDoiTuong.FormattingEnabled = true;
            this.cbDoiTuong.Location = new System.Drawing.Point(447, 41);
            this.cbDoiTuong.Name = "cbDoiTuong";
            this.cbDoiTuong.Size = new System.Drawing.Size(223, 28);
            this.cbDoiTuong.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(683, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Ngày làm thẻ:";
            // 
            // tbNgayLamThe
            // 
            this.tbNgayLamThe.Location = new System.Drawing.Point(785, 41);
            this.tbNgayLamThe.Name = "tbNgayLamThe";
            this.tbNgayLamThe.ReadOnly = true;
            this.tbNgayLamThe.Size = new System.Drawing.Size(93, 27);
            this.tbNgayLamThe.TabIndex = 17;
            this.tbNgayLamThe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(895, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Ngày hết hạn:";
            // 
            // tbNgayHetHan
            // 
            this.tbNgayHetHan.Location = new System.Drawing.Point(997, 41);
            this.tbNgayHetHan.Name = "tbNgayHetHan";
            this.tbNgayHetHan.ReadOnly = true;
            this.tbNgayHetHan.Size = new System.Drawing.Size(93, 27);
            this.tbNgayHetHan.TabIndex = 21;
            this.tbNgayHetHan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Ngày sinh:";
            // 
            // tbNgaySinh
            // 
            this.tbNgaySinh.Location = new System.Drawing.Point(415, 102);
            this.tbNgaySinh.Name = "tbNgaySinh";
            this.tbNgaySinh.Size = new System.Drawing.Size(93, 27);
            this.tbNgaySinh.TabIndex = 22;
            this.tbNgaySinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(538, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "SĐT:";
            // 
            // tbSDT
            // 
            this.tbSDT.Location = new System.Drawing.Point(581, 102);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(93, 27);
            this.tbSDT.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(702, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Email:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(754, 102);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(226, 27);
            this.tbEmail.TabIndex = 26;
            // 
            // btHuy
            // 
            this.btHuy.Location = new System.Drawing.Point(515, 162);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(57, 29);
            this.btHuy.TabIndex = 28;
            this.btHuy.Text = "Huỷ";
            this.btHuy.UseVisualStyleBackColor = true;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // btCapNhat
            // 
            this.btCapNhat.Location = new System.Drawing.Point(585, 162);
            this.btCapNhat.Name = "btCapNhat";
            this.btCapNhat.Size = new System.Drawing.Size(84, 29);
            this.btCapNhat.TabIndex = 29;
            this.btCapNhat.Text = "Cập nhật";
            this.btCapNhat.Click += new System.EventHandler(this.btCapNhat_Click);
            // 
            // btTaiLai
            // 
            this.btTaiLai.Location = new System.Drawing.Point(885, 162);
            this.btTaiLai.Name = "btTaiLai";
            this.btTaiLai.Size = new System.Drawing.Size(84, 29);
            this.btTaiLai.TabIndex = 30;
            this.btTaiLai.Text = "Tải lại";
            this.btTaiLai.Click += new System.EventHandler(this.btTaiLai_Click);
            // 
            // btThemDocGia
            // 
            this.btThemDocGia.Location = new System.Drawing.Point(998, 101);
            this.btThemDocGia.Name = "btThemDocGia";
            this.btThemDocGia.Size = new System.Drawing.Size(92, 29);
            this.btThemDocGia.TabIndex = 31;
            this.btThemDocGia.Text = "Tạo mới";
            this.btThemDocGia.Click += new System.EventHandler(this.btThemDocGia_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(682, 162);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(57, 29);
            this.btXoa.TabIndex = 32;
            this.btXoa.Text = "Xoá";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // FormDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 553);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThemDocGia);
            this.Controls.Add(this.btTaiLai);
            this.Controls.Add(this.btCapNhat);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbSDT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbNgaySinh);
            this.Controls.Add(this.tbNgayHetHan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNgayLamThe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbDoiTuong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbGioiTinh);
            this.Controls.Add(this.lbTenDocGia);
            this.Controls.Add(this.tbTenDocGia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMaDocGia);
            this.Controls.Add(this.checkBoxConHan);
            this.Controls.Add(this.btThayDoi);
            this.Controls.Add(this.btGiaHan);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.lbMaDocGia);
            this.Controls.Add(this.tbTimKiemMaDocGia);
            this.Controls.Add(this.dgvDocGia);
            this.Name = "FormDocGia";
            this.Text = "Độc giả";
            this.Load += new System.EventHandler(this.FormDocGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvDocGia;
        private TextBox tbTimKiemMaDocGia;
        private Label lbMaDocGia;
        private Button btTimKiem;
        private Button btGiaHan;
        private Button btThayDoi;
        private CheckBox checkBoxConHan;
        private TextBox tbMaDocGia;
        private Label label1;
        private Label lbTenDocGia;
        private TextBox tbTenDocGia;
        private ComboBox cbGioiTinh;
        private Label label2;
        private Label label3;
        private ComboBox cbDoiTuong;
        private Label label4;
        private TextBox tbNgayLamThe;
        private Label label5;
        private TextBox tbNgayHetHan;
        private Label label6;
        private TextBox tbNgaySinh;
        private Label label7;
        private TextBox tbSDT;
        private Label label8;
        private TextBox tbEmail;
        private Button btHuy;
        private Button btCapNhat;
        private Button btTaiLai;
        private Button btThemDocGia;
        private Button btXoa;
    }
}