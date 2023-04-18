using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryManagement
{
    public partial class FormSach : Form
    {

        string connectionString = @"Data Source = (local); Initial Catalog = QuanLyThuVien;
                                        User ID = sa; Password = tiendung123";
        SqlConnection? connection = null;
        SqlDataAdapter? dataAdapterSach = null;
        DataTable? dataTableSach = null;
        SqlDataAdapter? dataAdapterNhaXuatBan = null;
        SqlDataAdapter? dataAdapterChuyenNganh = null;
        SqlDataAdapter? dataAdapterTacGia = null;
        DataTable? dataTableNhaXuatBan = null;
        DataTable? dataTableChuyenNganh = null;
        DataTable? dataTableTacGia1 = null;
        DataTable? dataTableTacGia2 = null;
        DataTable? dataTableTacGia3 = null;
        public FormSach()
        {
            InitializeComponent();
        }

        private void SachForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                connection = new SqlConnection(connectionString);
                if (connection.State == ConnectionState.Open) connection.Close();
                connection.Open();
                dataAdapterSach = new SqlDataAdapter("SELECT * FROM VIEW_CHI_TIET_SACH", connection);
                dataTableSach = new DataTable();
                dataTableSach.Clear();
                dataAdapterSach.Fill(dataTableSach);
                dgvSach.DataSource = dataTableSach;

                dataAdapterNhaXuatBan = new SqlDataAdapter("SELECT * FROM NHA_XUAT_BAN", connection);
                dataTableNhaXuatBan = new DataTable();
                dataAdapterNhaXuatBan.Fill(dataTableNhaXuatBan);
                cbNhaXuatBan.DataSource = dataTableNhaXuatBan;
                cbNhaXuatBan.DisplayMember = "TenNhaXuatBan";
                cbNhaXuatBan.ValueMember = "MaNhaXuatBan";

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

                dataTableTacGia3 = new DataTable();
                dataAdapterTacGia.Fill(dataTableTacGia3);
                cbTacGia3.DataSource = dataTableTacGia3;
                cbTacGia3.DisplayMember = "TenTacGia";
                cbTacGia3.ValueMember = "MaTacGia";
                cbTacGia3.SelectedIndex = -1;
            }
            catch
            {
                MessageBox.Show("Opps!"
                     , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cbChuyenNganh.Enabled = false;
            cbNhaXuatBan.Enabled = false;
            cbTacGia1.Enabled = false;
            cbTacGia2.Enabled = false;
            cbTacGia3.Enabled = false;
            tbTenSach.ReadOnly = true;
            tbGiaBia.ReadOnly = true;
            tbSoLuong.ReadOnly = true;
            tbTenSach.ReadOnly = true;
            cbChuyenNganh.ResetText();
            cbNhaXuatBan.ResetText();
            cbTacGia1.ResetText();
            cbTacGia2.ResetText();
            cbTacGia3.ResetText();
            tbTenSach.ResetText();
            tbGiaBia.ResetText();
            tbSoLuong.ResetText();
            btCapNhat.Visible = false;
            btHuy.Visible = false;
            btThayDoi.Enabled = false;
            btTaiLai.Enabled = true;
            btTimKiem.Enabled = true;
            tbTimKiemTenSach.ReadOnly = false;
            btTaiLai.Enabled = true;
            btThem.Enabled = true;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            DialogThemSach themSachForm = new DialogThemSach();
            themSachForm.ShowDialog();
        }

        private void btTaiLai_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvSach_CellClick(object? sender, DataGridViewCellEventArgs? e)
        {
            btThayDoi.Enabled = true;

            int r = dgvSach.CurrentCell.RowIndex;
            tbMaSach.Text = dgvSach.Rows[r].Cells[0].Value.ToString();
            tbTenSach.Text = dgvSach.Rows[r].Cells[1].Value.ToString();

            if (dgvSach.Rows[r].Cells[2].Value.ToString() == "Giáo trình") rbGiaoTrinh.Checked = true;
            if (dgvSach.Rows[r].Cells[2].Value.ToString() == "Sách tham khảo") rbSachThamKhao.Checked = true;

            String strTacGia = new String(dgvSach.Rows[r].Cells[3].Value.ToString());
            String[] tacGiaList = new String[3];
            tacGiaList = strTacGia.Split(" - ");
            if (tacGiaList.Length > 2)
            {
                cbTacGia1.Text = tacGiaList[0];
                cbTacGia2.Text = tacGiaList[1];
                cbTacGia3.Text = tacGiaList[2];
            }
            else if (tacGiaList.Length == 2)
            {
                cbTacGia1.Text = tacGiaList[0];
                cbTacGia2.Text = tacGiaList[1];
                cbTacGia3.SelectedIndex = -1;
            }
            else
            {
                cbTacGia1.Text = tacGiaList[0];
                cbTacGia2.SelectedIndex = -1;
                cbTacGia3.SelectedIndex = -1;
            }                
            cbNhaXuatBan.Text = dgvSach.Rows[r].Cells[4].Value.ToString();
            cbChuyenNganh.Text = dgvSach.Rows[r].Cells[5].Value.ToString();
            tbGiaBia.Text = dgvSach.Rows[r].Cells[6].Value.ToString();
            tbSoLuong.Text = dgvSach.Rows[r].Cells[7].Value.ToString();

        }

        private void btThayDoi_Click(object sender, EventArgs e)
        {
            btThayDoi.Enabled = false;
            btCapNhat.Visible = true;
            btHuy.Visible = true;
            cbTacGia1.Enabled = true;
            cbTacGia2.Enabled = true;
            cbTacGia3.Enabled = true;
            tbTenSach.ReadOnly = false;
            tbSoLuong.ReadOnly = false;
            tbGiaBia.ReadOnly = false;
            btTimKiem.Enabled = false;
            tbTimKiemTenSach.ReadOnly = true;
            btTaiLai.Enabled = false;
            btThem.Enabled = false;
            cbChuyenNganh.Enabled = true;
            cbNhaXuatBan.Enabled = true;
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            if (connection.State == ConnectionState.Open) connection.Close();
            connection.Open();

            SqlCommand cmd = new SqlCommand("XOA_SACH", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaSach", SqlDbType.VarChar).Value = tbMaSach.Text.ToString();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Xoá thành công"
                     , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection.Close();

            LoadData();
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            if (connection.State == ConnectionState.Open) connection.Close();
            connection.Open();

            SqlCommand cmd = new SqlCommand("SUA_SACH", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaSach", SqlDbType.VarChar).Value = tbMaSach.Text.ToString();
            cmd.Parameters.Add("@TenSach", SqlDbType.NVarChar).Value = tbTenSach.Text.ToString();
            if (rbGiaoTrinh.Checked == true)
                cmd.Parameters.Add("@LoaiSach", SqlDbType.Bit).Value = 0;
            else
                cmd.Parameters.Add("@LoaiSach", SqlDbType.Bit).Value = 1;

            cmd.Parameters.Add("@MaNhaXuatBan", SqlDbType.VarChar).Value = cbNhaXuatBan.SelectedValue;
            cmd.Parameters.Add("@MaChuyenNganh", SqlDbType.VarChar).Value = cbChuyenNganh.SelectedValue;

            // _ = decimal.TryParse(tbGiaBia.Text, out decimal temp);

            cmd.Parameters.Add("@GiaBia", SqlDbType.Decimal).Value = tbGiaBia.Text.ToString();

            // int soLuong = int.Parse(tbSoLuong.Text);
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
            MessageBox.Show("Thay đổi thành công"
                     , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection.Close();

            LoadData();
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            if (tbTimKiemTenSach.Text.Length == 0)
                LoadData();
            else
            {
                connection = new SqlConnection(connectionString);
                if (connection.State == ConnectionState.Open) connection.Close();
                connection.Open();

                SqlCommand cmd = new SqlCommand("TIM_KIEM_SACH", connection);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM [dbo].[TIM_KIEM_SACH] (@TenSach)";
                cmd.Parameters.AddWithValue("@TenSach", tbTimKiemTenSach.Text);


                dataAdapterSach = new SqlDataAdapter(cmd);
                dataTableSach = new DataTable();
                dataTableSach.Clear();
                dataAdapterSach.Fill(dataTableSach);
                dgvSach.DataSource = dataTableSach;
            }
        }
    }
}
