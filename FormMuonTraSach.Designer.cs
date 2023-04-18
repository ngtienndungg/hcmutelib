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
            this.rbDangMuon.Location = new System.Drawing.Point(191, 175);
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
            this.rbDaTra.Location = new System.Drawing.Point(407, 175);
            this.rbDaTra.Name = "rbDaTra";
            this.rbDaTra.Size = new System.Drawing.Size(141, 24);
            this.rbDaTra.TabIndex = 6;
            this.rbDaTra.Text = "Danh sách đã trả";
            this.rbDaTra.UseVisualStyleBackColor = true;
            this.rbDaTra.CheckedChanged += new System.EventHandler(this.rbDaTra_CheckedChanged);
            // 
            // btChoMuon
            // 
            this.btChoMuon.Location = new System.Drawing.Point(968, 73);
            this.btChoMuon.Name = "btChoMuon";
            this.btChoMuon.Size = new System.Drawing.Size(94, 29);
            this.btChoMuon.TabIndex = 7;
            this.btChoMuon.Text = "Cho mượn";
            this.btChoMuon.UseVisualStyleBackColor = true;
            this.btChoMuon.Click += new System.EventHandler(this.btChoMuon_Click);
            // 
            // FormMuonTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 553);
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
    }
}