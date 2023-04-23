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

namespace LibraryManagement
{
    public partial class FormDocGia : Form
    {
        SqlDataAdapter? dataAdapterDocGia = null;
        SqlDataAdapter? dataAdapterDoiTuong = null;
        DataTable? dataTableDocGia = null;
        DataTable? dataTableDoiTuong = null;
        public FormDocGia()
        {
            InitializeComponent();
        }

        private void FormDocGia_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                SqlConnection conn = DbHelper.Connect();
                conn.Open();

                if (checkBoxConHan.Checked == false)
                    dataAdapterDocGia = new SqlDataAdapter("SELECT * FROM VIEW_CHI_TIET_THE_DOC_GIA", conn);
                else
                    dataAdapterDocGia = new SqlDataAdapter("SELECT * FROM VIEW_DOC_GIA_CON_HAN", conn);
                dataTableDocGia = new DataTable();
                dataTableDocGia.Clear();
                dataAdapterDocGia.Fill(dataTableDocGia);
                dgvDocGia.DataSource = dataTableDocGia;

                dataAdapterDoiTuong = new SqlDataAdapter("SELECT * FROM DOI_TUONG_DOC_GIA", conn);
                dataTableDoiTuong = new DataTable();
                dataTableDoiTuong.Clear();
                dataAdapterDoiTuong.Fill(dataTableDoiTuong);

                cbDoiTuong.DataSource = dataTableDoiTuong;
                cbDoiTuong.DisplayMember = "TenDoiTuong";
                cbDoiTuong.ValueMember = "MaDoiTuong";
                cbDoiTuong.SelectedIndex = -1;

                cbGioiTinh.Items.Add("Nữ");
                cbGioiTinh.Items.Add("Nam");

                dgvDocGia.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvDocGia.Columns[8].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            catch
            {
                MessageBox.Show("Opps!"
                     , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cbDoiTuong.Enabled = false;
            cbGioiTinh.Enabled = false;
            tbTenDocGia.ReadOnly = true;
            tbNgaySinh.ReadOnly = true;
            tbSDT.ReadOnly = true;
            tbEmail.ReadOnly = true;
            cbDoiTuong.ResetText();
            cbGioiTinh.ResetText();
            tbTenDocGia.ResetText();
            tbNgaySinh.ResetText();
            tbSDT.ResetText();
            tbEmail.ResetText();
            btCapNhat.Visible = false;
            btHuy.Visible = false;
            btThayDoi.Enabled = false;
            btGiaHan.Enabled = false;
            btTaiLai.Enabled = true;
            btTimKiem.Enabled = true;
            tbTimKiemMaDocGia.ReadOnly = false;
            btThemDocGia.Enabled = true;
            btXoa.Enabled = false;
        }

        private void dgvDocGia_CellClick(object? sender, DataGridViewCellEventArgs? e)
        {
            btThayDoi.Enabled = true;
            btGiaHan.Enabled = true;
            btXoa.Enabled = true;

            int r = dgvDocGia.CurrentCell.RowIndex;
            tbMaDocGia.Text = dgvDocGia.Rows[r].Cells[0].Value.ToString();
            tbTenDocGia.Text = dgvDocGia.Rows[r].Cells[1].Value.ToString();
            
            cbDoiTuong.Text = dgvDocGia.Rows[r].Cells[2].Value.ToString();
            cbGioiTinh.Text = dgvDocGia.Rows[r].Cells[3].Value.ToString();

            DateTime date = (DateTime)dgvDocGia.Rows[r].Cells[4].Value;
            tbNgaySinh.Text = date.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);

            tbSDT.Text = dgvDocGia.Rows[r].Cells[5].Value.ToString();
            tbEmail.Text = dgvDocGia.Rows[r].Cells[6].Value.ToString();

            date = (DateTime)dgvDocGia.Rows[r].Cells[7].Value;
            tbNgayLamThe.Text = date.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);

            date = (DateTime)dgvDocGia.Rows[r].Cells[8].Value;
            tbNgayHetHan.Text = date.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);

        }

        private void btThayDoi_Click(object sender, EventArgs e)
        {
            btThayDoi.Enabled = false;
            btCapNhat.Visible = true;
            btHuy.Visible = true;
            cbDoiTuong.Enabled = true;
            cbGioiTinh.Enabled = true;
            tbTenDocGia.ReadOnly = false;
            tbNgaySinh.ReadOnly = false;
            tbSDT.ReadOnly = false;
            tbEmail.ReadOnly = false;
            btGiaHan.Enabled = false;
            btTimKiem.Enabled = false;
            tbTimKiemMaDocGia.ReadOnly = true;
            btTaiLai.Enabled = false;
            btThemDocGia.Enabled = false;
            btXoa.Enabled = false;
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btGiaHan_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DbHelper.Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand("GIA_HAN", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaDocGia", SqlDbType.VarChar).Value = tbMaDocGia.Text.ToString();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Gia hạn thành công"
                     , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();

            LoadData();
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DbHelper.Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand("SUA_DOC_GIA", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaDocGia", SqlDbType.VarChar).Value = tbMaDocGia.Text.ToString();
            cmd.Parameters.Add("@MaDoiTuong", SqlDbType.Int).Value = cbDoiTuong.SelectedValue;
            cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = tbTenDocGia.Text.ToString();
            if (cbGioiTinh.SelectedItem.ToString() == "Nữ")
                cmd.Parameters.Add("@GioiTinh", SqlDbType.Bit).Value = 0;
            else
                cmd.Parameters.Add("@GioiTinh", SqlDbType.Bit).Value = 1;

            DateTime date = DateTime.ParseExact(tbNgaySinh.Text, "dd/MM/yyyy", null);
            cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = date;
            cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = tbSDT.Text.ToString();
            cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = tbEmail.Text.ToString();

            cmd.ExecuteNonQuery();
            MessageBox.Show("Thay đổi thành công"
                     , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();

            LoadData();
        }

        private void checkBoxConHan_CheckedChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            if (tbTimKiemMaDocGia.Text.Length == 0)
                LoadData();
            else
            {
                SqlConnection conn = DbHelper.Connect();
                conn.Open();

                SqlCommand cmd = new SqlCommand("TIM_KIEM_MA_DOC_GIA", conn);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM [dbo].[TIM_KIEM_MA_DOC_GIA] (@MaDocGia)";
                cmd.Parameters.AddWithValue("@MaDocGia", tbTimKiemMaDocGia.Text);


                dataAdapterDocGia = new SqlDataAdapter(cmd);
                dataTableDocGia = new DataTable();
                dataTableDocGia.Clear();
                dataAdapterDocGia.Fill(dataTableDocGia);
                dgvDocGia.DataSource = dataTableDocGia;

            }
        }

        private void btTaiLai_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btThemDocGia_Click(object sender, EventArgs e)
        {
            DialogThemDocGia dialogThemDocGia = new DialogThemDocGia();
            dialogThemDocGia.ShowDialog();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DbHelper.Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand("XOA_DOC_GIA", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaDocGia", SqlDbType.VarChar).Value = tbMaDocGia.Text.ToString();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Xoá thành công"
                     , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();

            LoadData();

        }
    }
}
