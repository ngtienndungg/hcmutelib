using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement.UI
{
    public partial class DialogDoiMatKhau : Form
    {
        public DialogDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btChapNhan_Click(object sender, EventArgs e)
        {
            if (tbMoi.Text.Equals(tbXacNhan.Text))
            {
                SqlConnection conn = DbHelper.Connect();
                conn.Open();

                SqlCommand cmd = new SqlCommand("DOI_MAT_KHAU", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@TenDangNhap", SqlDbType.VarChar).Value = DbHelper.Username;
                cmd.Parameters.Add("@MatKhauCu", SqlDbType.VarChar).Value = tbCu.Text;
                cmd.Parameters.Add("@MatKhauMoi", SqlDbType.VarChar).Value = tbMoi.Text;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Đổi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                conn.Close();
                this.Close();
            }
            else
                MessageBox.Show("Mật khẩu mới không khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
