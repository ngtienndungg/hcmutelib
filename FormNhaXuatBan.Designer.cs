﻿namespace LibraryManagement
{
    partial class FormNhaXuatBan
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
            this.btThem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTenThem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btXoa = new System.Windows.Forms.Button();
            this.btHuyBo = new System.Windows.Forms.Button();
            this.btCapNhat = new System.Windows.Forms.Button();
            this.btThayDoi = new System.Windows.Forms.Button();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.tbMa = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(383, 102);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(94, 29);
            this.btThem.TabIndex = 34;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Tên:";
            // 
            // tbTenThem
            // 
            this.tbTenThem.Location = new System.Drawing.Point(51, 103);
            this.tbTenThem.Name = "tbTenThem";
            this.tbTenThem.Size = new System.Drawing.Size(326, 27);
            this.tbTenThem.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Mã:";
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(996, 167);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(94, 29);
            this.btXoa.TabIndex = 29;
            this.btXoa.Text = "Xoá";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btHuyBo
            // 
            this.btHuyBo.Location = new System.Drawing.Point(858, 169);
            this.btHuyBo.Name = "btHuyBo";
            this.btHuyBo.Size = new System.Drawing.Size(94, 29);
            this.btHuyBo.TabIndex = 28;
            this.btHuyBo.Text = "Huỷ bỏ";
            this.btHuyBo.UseVisualStyleBackColor = true;
            this.btHuyBo.Click += new System.EventHandler(this.btHuyBo_Click);
            // 
            // btCapNhat
            // 
            this.btCapNhat.Location = new System.Drawing.Point(744, 169);
            this.btCapNhat.Name = "btCapNhat";
            this.btCapNhat.Size = new System.Drawing.Size(94, 29);
            this.btCapNhat.TabIndex = 27;
            this.btCapNhat.Text = "Cập nhật";
            this.btCapNhat.UseVisualStyleBackColor = true;
            this.btCapNhat.Click += new System.EventHandler(this.btCapNhat_Click);
            // 
            // btThayDoi
            // 
            this.btThayDoi.Location = new System.Drawing.Point(602, 169);
            this.btThayDoi.Name = "btThayDoi";
            this.btThayDoi.Size = new System.Drawing.Size(94, 29);
            this.btThayDoi.TabIndex = 26;
            this.btThayDoi.Text = "Thay đổi";
            this.btThayDoi.UseVisualStyleBackColor = true;
            this.btThayDoi.Click += new System.EventHandler(this.btThayDoi_Click);
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(249, 170);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(326, 27);
            this.tbTen.TabIndex = 25;
            // 
            // tbMa
            // 
            this.tbMa.Location = new System.Drawing.Point(51, 170);
            this.tbMa.Name = "tbMa";
            this.tbMa.Size = new System.Drawing.Size(144, 27);
            this.tbMa.TabIndex = 24;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 214);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 29;
            this.dgv.Size = new System.Drawing.Size(1078, 336);
            this.dgv.TabIndex = 23;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // FormNhaXuatBan
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
            this.Name = "FormNhaXuatBan";
            this.Text = "Nhà xuất bản";
            this.Load += new System.EventHandler(this.FormNhaXuatBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btThem;
        private Label label3;
        private TextBox tbTenThem;
        private Label label2;
        private Label label1;
        private Button btXoa;
        private Button btHuyBo;
        private Button btCapNhat;
        private Button btThayDoi;
        private TextBox tbTen;
        private TextBox tbMa;
        private DataGridView dgv;
    }
}