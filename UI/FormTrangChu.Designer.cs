namespace LibraryManagement
{
    partial class FormTrangChu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTrangChu));
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.độcGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tácGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhàXuấtBảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chuyênNgànhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mượnSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trảSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.độcGiảToolStripMenuItem,
            this.sáchToolStripMenuItem,
            this.tácGiảToolStripMenuItem,
            this.nhàXuấtBảnToolStripMenuItem,
            this.chuyênNgànhToolStripMenuItem,
            this.mượnSáchToolStripMenuItem,
            this.trảSáchToolStripMenuItem,
            this.thốngKêToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1127, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Menu";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhậpToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.đăngNhậpToolStripMenuItem.Text = "Đăng nhập";
            // 
            // độcGiảToolStripMenuItem
            // 
            this.độcGiảToolStripMenuItem.Name = "độcGiảToolStripMenuItem";
            this.độcGiảToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.độcGiảToolStripMenuItem.Text = "Độc giả";
            this.độcGiảToolStripMenuItem.Click += new System.EventHandler(this.DocGia_Click);
            // 
            // sáchToolStripMenuItem
            // 
            this.sáchToolStripMenuItem.Name = "sáchToolStripMenuItem";
            this.sáchToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.sáchToolStripMenuItem.Text = "Sách";
            this.sáchToolStripMenuItem.Click += new System.EventHandler(this.Sach_Click);
            // 
            // tácGiảToolStripMenuItem
            // 
            this.tácGiảToolStripMenuItem.Name = "tácGiảToolStripMenuItem";
            this.tácGiảToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.tácGiảToolStripMenuItem.Text = "Tác giả";
            this.tácGiảToolStripMenuItem.Click += new System.EventHandler(this.TacGia_Click);
            // 
            // nhàXuấtBảnToolStripMenuItem
            // 
            this.nhàXuấtBảnToolStripMenuItem.Name = "nhàXuấtBảnToolStripMenuItem";
            this.nhàXuấtBảnToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.nhàXuấtBảnToolStripMenuItem.Text = "Nhà xuất bản";
            this.nhàXuấtBảnToolStripMenuItem.Click += new System.EventHandler(this.NhaXuatBan_Click);
            // 
            // chuyênNgànhToolStripMenuItem
            // 
            this.chuyênNgànhToolStripMenuItem.Name = "chuyênNgànhToolStripMenuItem";
            this.chuyênNgànhToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.chuyênNgànhToolStripMenuItem.Text = "Chuyên Ngành";
            this.chuyênNgànhToolStripMenuItem.Click += new System.EventHandler(this.ChuyenNganh_Click);
            // 
            // mượnSáchToolStripMenuItem
            // 
            this.mượnSáchToolStripMenuItem.Name = "mượnSáchToolStripMenuItem";
            this.mượnSáchToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.mượnSáchToolStripMenuItem.Text = "Mượn trả sách";
            this.mượnSáchToolStripMenuItem.Click += new System.EventHandler(this.MuonTra_Click);
            // 
            // trảSáchToolStripMenuItem
            // 
            this.trảSáchToolStripMenuItem.Name = "trảSáchToolStripMenuItem";
            this.trảSáchToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.trảSáchToolStripMenuItem.Text = "Trả sách";
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // FormTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1127, 633);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormTrangChu";
            this.Text = "Quản lý thư viện";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BindingSource bindingSource1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private ToolStripMenuItem sáchToolStripMenuItem;
        private ToolStripMenuItem độcGiảToolStripMenuItem;
        private ToolStripMenuItem tácGiảToolStripMenuItem;
        private ToolStripMenuItem nhàXuấtBảnToolStripMenuItem;
        private ToolStripMenuItem chuyênNgànhToolStripMenuItem;
        private ToolStripMenuItem mượnSáchToolStripMenuItem;
        private ToolStripMenuItem trảSáchToolStripMenuItem;
        private ToolStripMenuItem thốngKêToolStripMenuItem;
    }
}