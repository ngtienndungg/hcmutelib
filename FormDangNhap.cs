using System.Data;
using System.Data.SqlClient;

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
            String username = tbTenDangNhap.Text.ToString();
            String password = tbMatKhau.Text.ToString();
            string connectionString = @"Data Source = (local); Initial Catalog = QuanLyThuVien;
                                        User ID = sa; Password = tiendung123";
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                SqlCommand cmd = new SqlCommand("KIEM_TRA_DANG_NHAP", connection);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM [dbo].[KIEM_TRA_DANG_NHAP] (@TenDangNhap, @MatKhau)";
                cmd.Parameters.AddWithValue("@TenDangNhap", tbTenDangNhap.Text);
                cmd.Parameters.AddWithValue("@MatKhau", tbMatKhau.Text);

                var result = cmd.ExecuteScalar();

                bool valueExists = result != null && result != DBNull.Value;

                if (valueExists)
                {
                    FormTrangChu formTrangChu = new FormTrangChu();
                    Authentication.LoginId = result.ToString();
                    this.Hide();
                    formTrangChu.ShowDialog();
                    this.Close();
                }
                else
                    MessageBox.Show("Tài khoản hoặc mật khẩu không hợp lệ", "Thông báo");
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