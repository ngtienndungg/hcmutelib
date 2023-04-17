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

namespace LibraryManagement
{
    public partial class DialogThemDocGia : Form
    {
        string connectionString = @"Data Source = (local); Initial Catalog = QuanLyThuVien;
                                        User ID = sa; Password = tiendung123";
        SqlConnection? connection = null;
        SqlDataAdapter? dataAdapterDoiTuong = null;
        DataTable? dataTableDoiTuong = null;
        public DialogThemDocGia()
        {
            InitializeComponent();
        }

        private void DialogThemDocGia_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            connection = new SqlConnection(connectionString);
            if (connection.State == ConnectionState.Open) connection.Close();
            connection.Open();

            dataAdapterDoiTuong = new SqlDataAdapter("SELECT * FROM DOI_TUONG_DOC_GIA", connection);
            dataTableDoiTuong = new DataTable();
            dataAdapterDoiTuong.Fill(dataTableDoiTuong);
            cbDoiTuong.DataSource = dataTableDoiTuong;
            cbDoiTuong.DisplayMember = "TenDoiTuong";
            cbDoiTuong.ValueMember = "MaDoiTuong";
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            if (connection.State == ConnectionState.Open) connection.Close();
            connection.Open();

            SqlCommand cmd = new SqlCommand("THEM_DOC_GIA", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaDocGia", SqlDbType.VarChar).Value = tbMaDocGia.Text.ToString();
            if (rbNam.Checked)
                cmd.Parameters.Add("@GioiTinh", SqlDbType.Bit).Value = 1;
            else
                cmd.Parameters.Add("@GioiTinh", SqlDbType.Bit).Value = 0;
            cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = tbHoTen.Text.ToString();
            cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = tbEmail.Text.ToString();
            cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = tbSDT.Text.ToString();
            cmd.Parameters.Add("@MaDoiTuong", SqlDbType.Int).Value = cbDoiTuong.SelectedValue;
            cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = dateTimePicker.Value.Date;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đã thêm thành công"
                     , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection.Close();
            this.Close();
        }
    }
}
