using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LibraryManagement
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            DbHelper.Username = tbTenDangNhap.Text.ToString();
            DbHelper.Password = tbMatKhau.Text.ToString();
            try
            {
                SqlConnection conn = DbHelper.Connect();
                conn.Open();
                SqlCommand cmd = new SqlCommand("LAY_MA_NHAN_VIEN", conn);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT [dbo].[LAY_MA_NHAN_VIEN] (@Username)";
                cmd.Parameters.AddWithValue("@Username", DbHelper.Username);

                object staffId = cmd.ExecuteScalar();
                DbHelper.MaNhanVien = staffId.ToString();

                FormTrangChu formTrangChu = new FormTrangChu(); 
                this.Hide();
                formTrangChu.ShowDialog();
                this.Close();
            }
            catch(SqlException) 
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không hợp lệ", "Thông báo");
            } 

        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}