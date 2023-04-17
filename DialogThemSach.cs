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
    public partial class DialogThemSach : Form
    {
        string connectionString = @"Data Source = (local); Initial Catalog = QuanLyThuVien;
                                        User ID = sa; Password = tiendung123";
        SqlConnection? connection = null;
        SqlDataAdapter? dataAdapterNhaXuatBan = null;
        SqlDataAdapter? dataAdapterChuyenNganh = null;
        SqlDataAdapter? dataAdapterTacGia = null;
        DataTable? dataTableNhaXuatBan = null;
        DataTable? dataTableChuyenNganh = null;
        DataTable? dataTableTacGia1 = null;
        DataTable? dataTableTacGia2 = null;
        DataTable? dataTableTacGia3 = null;
        public DialogThemSach()
        {
            InitializeComponent();
        }

        private void ThemSachForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            connection = new SqlConnection(connectionString);
            if (connection.State == ConnectionState.Open) connection.Close();
            connection.Open();

            dataAdapterNhaXuatBan = new SqlDataAdapter("SELECT * FROM NHA_XUAT_BAN", connection);
            dataTableNhaXuatBan = new DataTable();
            dataAdapterNhaXuatBan.Fill(dataTableNhaXuatBan);
            cbNhaXuatBan.DataSource = dataTableNhaXuatBan;
            cbNhaXuatBan.DisplayMember = "TenNhaXuatBan";
            cbNhaXuatBan.ValueMember= "MaNhaXuatBan";

            dataAdapterChuyenNganh = new SqlDataAdapter("SELECT * FROM CHUYEN_NGANH", connection);
            dataTableChuyenNganh = new DataTable();
            dataAdapterChuyenNganh.Fill(dataTableChuyenNganh);
            cbChuyenNganh.DataSource = dataTableChuyenNganh;
            cbChuyenNganh.DisplayMember = "TenChuyenNganh";
            cbChuyenNganh.ValueMember = "MaChuyenNganh";

            dataAdapterTacGia = new SqlDataAdapter("SELECT * FROM TAC_GIA", connection);

            dataTableTacGia1 = new DataTable();
            dataAdapterTacGia.Fill(dataTableTacGia1);
            cbTacGia1.DataSource = dataTableTacGia1;
            cbTacGia1.DisplayMember = "TenTacGia";
            cbTacGia1.ValueMember = "MaTacGia";

            dataTableTacGia2 = new DataTable();
            dataAdapterTacGia.Fill(dataTableTacGia2);
            cbTacGia2.DataSource = dataTableTacGia2;
            cbTacGia2.DisplayMember = "TenTacGia";
            cbTacGia2.ValueMember = "MaTacGia";
            cbTacGia2.SelectedIndex = -1;
            cbTacGia2.Text = "(Tuỳ chọn)";

            dataTableTacGia3 = new DataTable();
            dataAdapterTacGia.Fill(dataTableTacGia3);
            cbTacGia3.DataSource = dataTableTacGia3;
            cbTacGia3.DisplayMember = "TenTacGia";
            cbTacGia3.ValueMember = "MaTacGia";
            cbTacGia3.SelectedIndex = -1;
            cbTacGia3.Text = "(Tuỳ chọn)";
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

            SqlCommand cmd = new SqlCommand("THEM_SACH", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TenSach",SqlDbType.VarChar).Value = tbTenSach.Text.ToString();
            if (rbGiaoTrinh.Checked)
                cmd.Parameters.Add("@LoaiSach",SqlDbType.Bit).Value = 0;
            else
                cmd.Parameters.Add("@LoaiSach", SqlDbType.Bit).Value = 1;
            cmd.Parameters.Add("@MaNhaXuatBan", SqlDbType.VarChar).Value = cbNhaXuatBan.SelectedValue;
            cmd.Parameters.Add("@MaChuyenNganh", SqlDbType.VarChar).Value = cbChuyenNganh.SelectedValue;
            cmd.Parameters.Add("@GiaBia", SqlDbType.Decimal).Value = tbGiaBia.Text.ToString();
            cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = tbSoLuong.Text.ToString();
            cmd.Parameters.Add("@MaTacGia1", SqlDbType.VarChar).Value = cbTacGia1.SelectedValue;
            if (cbTacGia2.SelectedIndex == -1)
                cmd.Parameters.Add("@MaTacGia2", SqlDbType.VarChar).Value = DBNull.Value;
            else
                cmd.Parameters.Add("@MaTacGia2", SqlDbType.VarChar).Value = cbTacGia2.SelectedValue;
            if (cbTacGia3.SelectedIndex == -1)
                cmd.Parameters.Add("@MaTacGia3", SqlDbType.VarChar).Value = DBNull.Value;
            else
            cmd.Parameters.Add("@MaTacGia3", SqlDbType.VarChar).Value = cbTacGia3.SelectedValue;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đã thêm thành công"
                     , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection.Close();
            this.Close();
        }
    }
}
