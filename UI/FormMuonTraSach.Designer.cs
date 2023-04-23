namespace LibraryManagement
{
    partial class FormMuonTraSach
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
            this.dgvMuonTra = new System.Windows.Forms.DataGridView();
            this.rbToanBo = new System.Windows.Forms.RadioButton();
            this.rbDangMuon = new System.Windows.Forms.RadioButton();
            this.rbDaTra = new System.Windows.Forms.RadioButton();
            this.btChoMuon = new System.Windows.Forms.Button();
            this.btTimKiem1 = new System.Windows.Forms.Button();
            this.tbTimKiemMaPhieuMuon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTimKiemMaDocGia = new System.Windows.Forms.TextBox();
            this.btTimKiem2 = new System.Windows.Forms.Button();
            this.tbMaPhieuMuon = new System.Windows.Forms.TextBox();
            this.tbMaNguoiMuon = new System.Windows.Forms.TextBox();
            this.tbMaSach = new System.Windows.Forms.TextBox();
            this.tbNgayHetHan = new System.Windows.Forms.TextBox();
            this.btGiaHan = new System.Windows.Forms.Button();
            this.btTraSach = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuonTra)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMuonTra
            // 
            this.dgvMuonTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuonTra.Location = new System.Drawing.Point(12, 205);
            this.dgvMuonTra.Name = "dgvMuonTra";
            this.dgvMuonTra.RowHeadersWidth = 51;
            this.dgvMuonTra.RowTemplate.Height = 29;
            this.dgvMuonTra.Size = new System.Drawing.Size(1078, 336);
            this.dgvMuonTra.TabIndex = 3;
            this.dgvMuonTra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMuonTra_CellClick);
            // 
            // rbToanBo
            // 
            this.rbToanBo.AutoSize = true;
            this.rbToanBo.Checked = true;
            this.rbToanBo.Location = new System.Drawing.Point(12, 175);
            this.rbToanBo.Name = "rbToanBo";
            this.rbToanBo.Size = new System.Drawing.Size(154, 24);
            this.rbToanBo.TabIndex = 4;
            this.rbToanBo.TabStop = true;
            this.rbToanBo.Text = "Toàn bộ danh sách";
            this.rbToanBo.UseVisualStyleBackColor = true;
            this.rbToanBo.CheckedChanged += new System.EventHandler(this.rbToanBo_CheckedChanged);
            // 
            // rbDangMuon
            // 
            this.rbDangMuon.AutoSize = true;
            this.rbDangMuon.Location = new System.Drawing.Point(166, 175);
            this.rbDangMuon.Name = "rbDangMuon";
            this.rbDangMuon.Size = new System.Drawing.Size(179, 24);
            this.rbDangMuon.TabIndex = 5;
            this.rbDangMuon.Text = "Danh sách đang mượn";
            this.rbDangMuon.UseVisualStyleBackColor = true;
            this.rbDangMuon.CheckedChanged += new System.EventHandler(this.rbDangMuon_CheckedChanged);
            // 
            // rbDaTra
            // 
            this.rbDaTra.AutoSize = true;
            this.rbDaTra.Location = new System.Drawing.Point(346, 175);
            this.rbDaTra.Name = "rbDaTra";
            this.rbDaTra.Size = new System.Drawing.Size(141, 24);
            this.rbDaTra.TabIndex = 6;
            this.rbDaTra.Text = "Danh sách đã trả";
            this.rbDaTra.UseVisualStyleBackColor = true;
            this.rbDaTra.CheckedChanged += new System.EventHandler(this.rbDaTra_CheckedChanged);
            // 
            // btChoMuon
            // 
            this.btChoMuon.Location = new System.Drawing.Point(996, 76);
            this.btChoMuon.Name = "btChoMuon";
            this.btChoMuon.Size = new System.Drawing.Size(94, 29);
            this.btChoMuon.TabIndex = 7;
            this.btChoMuon.Text = "Cho mượn";
            this.btChoMuon.UseVisualStyleBackColor = true;
            this.btChoMuon.Click += new System.EventHandler(this.btChoMuon_Click);
            // 
            // btTimKiem1
            // 
            this.btTimKiem1.Location = new System.Drawing.Point(996, 173);
            this.btTimKiem1.Name = "btTimKiem1";
            this.btTimKiem1.Size = new System.Drawing.Size(94, 29);
            this.btTimKiem1.TabIndex = 8;
            this.btTimKiem1.Text = "Tìm kiếm";
            this.btTimKiem1.UseVisualStyleBackColor = true;
            this.btTimKiem1.Click += new System.EventHandler(this.btTimKiem1_Click);
            // 
            // tbTimKiemMaPhieuMuon
            // 
            this.tbTimKiemMaPhieuMuon.Location = new System.Drawing.Point(852, 174);
            this.tbTimKiemMaPhieuMuon.Name = "tbTimKiemMaPhieuMuon";
            this.tbTimKiemMaPhieuMuon.Size = new System.Drawing.Size(138, 27);
            this.tbTimKiemMaPhieuMuon.TabIndex = 9;
            this.tbTimKiemMaPhieuMuon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(732, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã phiếu mượn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(732, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã người mượn:";
            // 
            // tbTimKiemMaDocGia
            // 
            this.tbTimKiemMaDocGia.Location = new System.Drawing.Point(852, 126);
            this.tbTimKiemMaDocGia.Name = "tbTimKiemMaDocGia";
            this.tbTimKiemMaDocGia.Size = new System.Drawing.Size(138, 27);
            this.tbTimKiemMaDocGia.TabIndex = 12;
            this.tbTimKiemMaDocGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btTimKiem2
            // 
            this.btTimKiem2.Location = new System.Drawing.Point(996, 125);
            this.btTimKiem2.Name = "btTimKiem2";
            this.btTimKiem2.Size = new System.Drawing.Size(94, 29);
            this.btTimKiem2.TabIndex = 11;
            this.btTimKiem2.Text = "Tìm kiếm";
            this.btTimKiem2.UseVisualStyleBackColor = true;
            this.btTimKiem2.Click += new System.EventHandler(this.btTimKiem2_Click);
            // 
            // tbMaPhieuMuon
            // 
            this.tbMaPhieuMuon.Location = new System.Drawing.Point(148, 39);
            this.tbMaPhieuMuon.Name = "tbMaPhieuMuon";
            this.tbMaPhieuMuon.Size = new System.Drawing.Size(125, 27);
            this.tbMaPhieuMuon.TabIndex = 14;
            // 
            // tbMaNguoiMuon
            // 
            this.tbMaNguoiMuon.Location = new System.Drawing.Point(148, 101);
            this.tbMaNguoiMuon.Name = "tbMaNguoiMuon";
            this.tbMaNguoiMuon.Size = new System.Drawing.Size(125, 27);
            this.tbMaNguoiMuon.TabIndex = 15;
            // 
            // tbMaSach
            // 
            this.tbMaSach.Location = new System.Drawing.Point(362, 39);
            this.tbMaSach.Name = "tbMaSach";
            this.tbMaSach.Size = new System.Drawing.Size(125, 27);
            this.tbMaSach.TabIndex = 16;
            // 
            // tbNgayHetHan
            // 
            this.tbNgayHetHan.Location = new System.Drawing.Point(393, 101);
            this.tbNgayHetHan.Name = "tbNgayHetHan";
            this.tbNgayHetHan.Size = new System.Drawing.Size(125, 27);
            this.tbNgayHetHan.TabIndex = 17;
            // 
            // btGiaHan
            // 
            this.btGiaHan.Location = new System.Drawing.Point(557, 172);
            this.btGiaHan.Name = "btGiaHan";
            this.btGiaHan.Size = new System.Drawing.Size(94, 29);
            this.btGiaHan.TabIndex = 19;
            this.btGiaHan.Text = "Gia hạn";
            this.btGiaHan.UseVisualStyleBackColor = true;
            // 
            // btTraSach
            // 
            this.btTraSach.Location = new System.Drawing.Point(574, 76);
            this.btTraSach.Name = "btTraSach";
            this.btTraSach.Size = new System.Drawing.Size(94, 29);
            this.btTraSach.TabIndex = 20;
            this.btTraSach.Text = "Trả sách";
            this.btTraSach.UseVisualStyleBackColor = true;
            this.btTraSach.Click += new System.EventHandler(this.btTraSach_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Mã phiếu mượn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Mã người mượn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Mã sách:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Ngày hết hạn:";
            // 
            // FormMuonTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 553);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btTraSach);
            this.Controls.Add(this.btGiaHan);
            this.Controls.Add(this.tbNgayHetHan);
            this.Controls.Add(this.tbMaSach);
            this.Controls.Add(this.tbMaNguoiMuon);
            this.Controls.Add(this.tbMaPhieuMuon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTimKiemMaDocGia);
            this.Controls.Add(this.btTimKiem2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTimKiemMaPhieuMuon);
            this.Controls.Add(this.btTimKiem1);
            this.Controls.Add(this.btChoMuon);
            this.Controls.Add(this.rbDaTra);
            this.Controls.Add(this.rbDangMuon);
            this.Controls.Add(this.rbToanBo);
            this.Controls.Add(this.dgvMuonTra);
            this.Name = "FormMuonTraSach";
            this.Text = "Mượn trả sách";
            this.Load += new System.EventHandler(this.FormMuonTraSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuonTra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvMuonTra;
        private RadioButton rbToanBo;
        private RadioButton rbDangMuon;
        private RadioButton rbDaTra;
        private Button btChoMuon;
        private Button btTimKiem1;
        private TextBox tbTimKiemMaPhieuMuon;
        private Label label1;
        private Label label2;
        private TextBox tbTimKiemMaDocGia;
        private Button btTimKiem2;
        private TextBox tbMaPhieuMuon;
        private TextBox tbMaNguoiMuon;
        private TextBox tbMaSach;
        private TextBox tbNgayHetHan;
        private Button btGiaHan;
        private Button btTraSach;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}