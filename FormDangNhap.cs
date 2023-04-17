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
                                        User ID = " + username + "; Password = " + password;
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                FormTrangChu formTrangChu = new FormTrangChu();
                this.Hide();
                formTrangChu.ShowDialog();
                this.Close();
            }
            catch (SqlException)
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