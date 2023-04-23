namespace LibraryManagement
{
    partial class DialogTraSach
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
            this.cbTinhTrang = new System.Windows.Forms.ComboBox();
            this.btTraSach = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTreHan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbTinhTrang
            // 
            this.cbTinhTrang.FormattingEnabled = true;
            this.cbTinhTrang.Location = new System.Drawing.Point(251, 56);
            this.cbTinhTrang.Name = "cbTinhTrang";
            this.cbTinhTrang.Size = new System.Drawing.Size(218, 28);
            this.cbTinhTrang.TabIndex = 0;
            // 
            // btTraSach
            // 
            this.btTraSach.Location = new System.Drawing.Point(311, 97);
            this.btTraSach.Name = "btTraSach";
            this.btTraSach.Size = new System.Drawing.Size(94, 29);
            this.btTraSach.TabIndex = 1;
            this.btTraSach.Text = "Trả sách";
            this.btTraSach.UseVisualStyleBackColor = true;
            this.btTraSach.Click += new System.EventHandler(this.btTraSach_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hãy chọn tình trạng sách:";
            // 
            // lbTreHan
            // 
            this.lbTreHan.AutoSize = true;
            this.lbTreHan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTreHan.Location = new System.Drawing.Point(12, 32);
            this.lbTreHan.Name = "lbTreHan";
            this.lbTreHan.Size = new System.Drawing.Size(130, 22);
            this.lbTreHan.TabIndex = 3;
            this.lbTreHan.Text = "Tiền phạt trễ hạn: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tiền phạt hư hỏng:";
            // 
            // DialogTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 138);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTreHan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btTraSach);
            this.Controls.Add(this.cbTinhTrang);
            this.Name = "DialogTraSach";
            this.Text = "Trả sách";
            this.Load += new System.EventHandler(this.DialogTraSach_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbTinhTrang;
        private Button btTraSach;
        private Label label1;
        private Label lbTreHan;
        private Label label2;
    }
}