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
    public partial class DialogThemNhanVien : Form
    {
        public DialogThemNhanVien()
        {
            InitializeComponent();
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = DbHelper.Connect();
                conn.Open();

                SqlCommand cmd = new SqlCommand("THEM_NHAN_VIEN", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                if (rbNam.Checked)
                    cmd.Parameters.Add("@GioiTinh", SqlDbType.Bit).Value = 1;
                else
                    cmd.Parameters.Add("@GioiTinh", SqlDbType.Bit).Value = 0;
                cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = tbHoTen.Text.ToString();
                cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = tbEmail.Text.ToString();
                cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = tbSDT.Text.ToString();
                cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = dateTimePicker.Value.Date;
                cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = tbTenDangNhap.Text.ToString();
                cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = tbMatKhau.Text.ToString();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conn.Close();
                this.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
