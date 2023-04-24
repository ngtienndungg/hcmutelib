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

namespace LibraryManagement.UI
{
    public partial class FormNhanVien : Form
    {
        SqlDataAdapter? dataAdapter = null;
        DataTable? dataTable = null;
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                SqlConnection conn = DbHelper.Connect();
                conn.Open();

                if (checkBoxConLamViec.Checked == false)
                    dataAdapter = new SqlDataAdapter("SELECT * FROM VIEW_CHI_TIET_NHAN_VIEN", conn);
                else
                    dataAdapter = new SqlDataAdapter("SELECT * FROM VIEW_NHAN_VIEN_LAM_VIEC", conn);
                dataTable = new DataTable();
                dataTable.Clear();
                dataAdapter.Fill(dataTable);
                dgv.DataSource = dataTable;

                cbGioiTinh.Items.Add("Nữ");
                cbGioiTinh.Items.Add("Nam");

                dgv.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgv.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            catch
            {
                MessageBox.Show("Opps!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cbGioiTinh.Enabled = false;
            tbTen.ReadOnly = true;
            tbNgaySinh.ReadOnly = true;
            tbSDT.ReadOnly = true;
            tbEmail.ReadOnly = true;
            cbGioiTinh.ResetText();
            tbTen.ResetText();
            tbNgaySinh.ResetText();
            tbSDT.ResetText();
            tbEmail.ResetText();
            btCapNhat.Visible = false;
            btHuy.Visible = false;
            btThayDoi.Enabled = false;
            btTaiLai.Enabled = true;
            btTimKiem.Enabled = true;
            tbTimKiemTen.ReadOnly = false;
            btThemNhanVien.Enabled = true;
            btXoa.Enabled = false;
            tbNgayVaoLam.ReadOnly = true;
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btThayDoi.Enabled = true;
            btXoa.Enabled = true;

            int r = dgv.CurrentCell.RowIndex;
            tbMa.Text = dgv.Rows[r].Cells[0].Value.ToString();
            tbTen.Text = dgv.Rows[r].Cells[1].Value.ToString();
            cbGioiTinh.Text = dgv.Rows[r].Cells[2].Value.ToString();

            DateTime date = (DateTime)dgv.Rows[r].Cells[3].Value;
            tbNgaySinh.Text = date.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);

            tbSDT.Text = dgv.Rows[r].Cells[4].Value.ToString();
            tbEmail.Text = dgv.Rows[r].Cells[5].Value.ToString();

            date = (DateTime)dgv.Rows[r].Cells[6].Value;
            tbNgayVaoLam.Text = date.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
        }

        private void btThayDoi_Click(object sender, EventArgs e)
        {
            btThayDoi.Enabled = false;
            btCapNhat.Visible = true;
            btHuy.Visible = true;
            cbGioiTinh.Enabled = true;
            tbTen.ReadOnly = false;
            tbNgaySinh.ReadOnly = false;
            tbSDT.ReadOnly = false;
            tbEmail.ReadOnly = false;
            btTimKiem.Enabled = false;
            tbTimKiemTen.ReadOnly = true;
            btTaiLai.Enabled = false;
            btThemNhanVien.Enabled = false;
            btXoa.Enabled = false;
            tbNgayVaoLam.ReadOnly = false;
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DbHelper.Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand("SUA_NHAN_VIEN", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaNhanVien", SqlDbType.VarChar).Value = tbMa.Text.ToString();
            cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = tbTen.Text.ToString();
            if (cbGioiTinh.SelectedItem.ToString() == "Nữ")
                cmd.Parameters.Add("@GioiTinh", SqlDbType.Bit).Value = 0;
            else
                cmd.Parameters.Add("@GioiTinh", SqlDbType.Bit).Value = 1;

            DateTime date = DateTime.ParseExact(tbNgaySinh.Text, "dd/MM/yyyy", null);
            cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = date;
            cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = tbSDT.Text.ToString();
            cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = tbEmail.Text.ToString();

            cmd.ExecuteNonQuery();
            MessageBox.Show("Thay đổi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();

            LoadData();
        }

        private void checkBoxConHan_CheckedChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            if (tbTimKiemTen.Text.Length == 0)
                LoadData();
            else
            {
                SqlConnection conn = DbHelper.Connect();
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[TIM_KIEM_NHAN_VIEN] (@TenNhanVien)", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@TenNhanVien", tbTimKiemTen.Text);


                dataAdapter = new SqlDataAdapter(cmd);
                dataTable = new DataTable();
                dataTable.Clear();
                dataAdapter.Fill(dataTable);
                dgv.DataSource = dataTable;

            }
        }

        private void btTaiLai_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btThemNhanVien_Click(object sender, EventArgs e)
        {
            DialogThemNhanVien dialogThemNhanVien = new DialogThemNhanVien();
            dialogThemNhanVien.ShowDialog();
            LoadData();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DbHelper.Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand("XOA_NHAN_VIEN", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaNhanVien", SqlDbType.VarChar).Value = tbMa.Text.ToString();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();

            LoadData();

        }
    }
}
