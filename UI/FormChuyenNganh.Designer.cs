namespace LibraryManagement
{
    partial class FormChuyenNganh
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tbMa = new System.Windows.Forms.TextBox();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.btThayDoi = new System.Windows.Forms.Button();
            this.btCapNhat = new System.Windows.Forms.Button();
            this.btHuyBo = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btThem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTenThem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 205);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 29;
            this.dgv.Size = new System.Drawing.Size(1078, 336);
            this.dgv.TabIndex = 2;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocGia_CellClick);
            // 
            // tbMa
            // 
            this.tbMa.Location = new System.Drawing.Point(51, 161);
            this.tbMa.Name = "tbMa";
            this.tbMa.Size = new System.Drawing.Size(144, 27);
            this.tbMa.TabIndex = 3;
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(249, 161);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(326, 27);
            this.tbTen.TabIndex = 4;
            // 
            // btThayDoi
            // 
            this.btThayDoi.Location = new System.Drawing.Point(602, 160);
            this.btThayDoi.Name = "btThayDoi";
            this.btThayDoi.Size = new System.Drawing.Size(94, 29);
            this.btThayDoi.TabIndex = 5;
            this.btThayDoi.Text = "Thay đổi";
            this.btThayDoi.UseVisualStyleBackColor = true;
            this.btThayDoi.Click += new System.EventHandler(this.btThayDoi_Click);
            // 
            // btCapNhat
            // 
            this.btCapNhat.Location = new System.Drawing.Point(744, 160);
            this.btCapNhat.Name = "btCapNhat";
            this.btCapNhat.Size = new System.Drawing.Size(94, 29);
            this.btCapNhat.TabIndex = 6;
            this.btCapNhat.Text = "Cập nhật";
            this.btCapNhat.UseVisualStyleBackColor = true;
            this.btCapNhat.Click += new System.EventHandler(this.btCapNhat_Click);
            // 
            // btHuyBo
            // 
            this.btHuyBo.Location = new System.Drawing.Point(858, 160);
            this.btHuyBo.Name = "btHuyBo";
            this.btHuyBo.Size = new System.Drawing.Size(94, 29);
            this.btHuyBo.TabIndex = 7;
            this.btHuyBo.Text = "Huỷ bỏ";
            this.btHuyBo.UseVisualStyleBackColor = true;
            this.btHuyBo.Click += new System.EventHandler(this.btHuyBo_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(996, 158);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(94, 29);
            this.btXoa.TabIndex = 8;
            this.btXoa.Text = "Xoá";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên:";
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(383, 103);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(94, 29);
            this.btThem.TabIndex = 25;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Tên:";
            // 
            // tbTenThem
            // 
            this.tbTenThem.Location = new System.Drawing.Point(51, 104);
            this.tbTenThem.Name = "tbTenThem";
            this.tbTenThem.Size = new System.Drawing.Size(326, 27);
            this.tbTenThem.TabIndex = 23;
            // 
            // FormChuyenNganh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 553);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTenThem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btHuyBo);
            this.Controls.Add(this.btCapNhat);
            this.Controls.Add(this.btThayDoi);
            this.Controls.Add(this.tbTen);
            this.Controls.Add(this.tbMa);
            this.Controls.Add(this.dgv);
            this.Name = "FormChuyenNganh";
            this.Text = "Chuyên ngành";
            this.Load += new System.EventHandler(this.FormChuyenNganh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv;
        private TextBox tbMa;
        private TextBox tbTen;
        private Button btThayDoi;
        private Button btCapNhat;
        private Button btHuyBo;
        private Button btXoa;
        private Label label1;
        private Label label2;
        private Button btThem;
        private Label label3;
        private TextBox tbTenThem;
    }
}