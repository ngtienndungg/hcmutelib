namespace LibraryManagement.UI
{
    partial class DialogDoiMatKhau
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
            this.tbCu = new System.Windows.Forms.TextBox();
            this.tbMoi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbXacNhan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btChapNhan = new System.Windows.Forms.Button();
            this.btHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu cũ:";
            // 
            // tbCu
            // 
            this.tbCu.Location = new System.Drawing.Point(116, 5);
            this.tbCu.Name = "tbCu";
            this.tbCu.Size = new System.Drawing.Size(198, 27);
            this.tbCu.TabIndex = 1;
            this.tbCu.UseSystemPasswordChar = true;
            // 
            // tbMoi
            // 
            this.tbMoi.Location = new System.Drawing.Point(116, 39);
            this.tbMoi.Name = "tbMoi";
            this.tbMoi.Size = new System.Drawing.Size(198, 27);
            this.tbMoi.TabIndex = 3;
            this.tbMoi.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu mới:";
            // 
            // tbXacNhan
            // 
            this.tbXacNhan.Location = new System.Drawing.Point(116, 72);
            this.tbXacNhan.Name = "tbXacNhan";
            this.tbXacNhan.Size = new System.Drawing.Size(198, 27);
            this.tbXacNhan.TabIndex = 5;
            this.tbXacNhan.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Xác nhận:";
            // 
            // btChapNhan
            // 
            this.btChapNhan.Location = new System.Drawing.Point(220, 105);
            this.btChapNhan.Name = "btChapNhan";
            this.btChapNhan.Size = new System.Drawing.Size(94, 29);
            this.btChapNhan.TabIndex = 6;
            this.btChapNhan.Text = "Chấp nhận";
            this.btChapNhan.UseVisualStyleBackColor = true;
            this.btChapNhan.Click += new System.EventHandler(this.btChapNhan_Click);
            // 
            // btHuy
            // 
            this.btHuy.Location = new System.Drawing.Point(116, 105);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(94, 29);
            this.btHuy.TabIndex = 7;
            this.btHuy.Text = "Huỷ bỏ";
            this.btHuy.UseVisualStyleBackColor = true;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // DialogDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 142);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btChapNhan);
            this.Controls.Add(this.tbXacNhan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbMoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCu);
            this.Controls.Add(this.label1);
            this.Name = "DialogDoiMatKhau";
            this.Text = "Đổi mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tbCu;
        private TextBox tbMoi;
        private Label label2;
        private TextBox tbXacNhan;
        private Label label3;
        private Button btChapNhan;
        private Button btHuy;
    }
}