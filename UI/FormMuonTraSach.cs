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
    public partial class FormMuonTraSach : Form
    {
        SqlDataAdapter? dataAdapterMuonTra = null;
        DataTable? dataTableMuonTra = null;

        public static string maPhieuMuon = "";
        public static string maSach = "";
        public static decimal phatQuaHan;

        public FormMuonTraSach()
        {
            InitializeComponent();
        }

        private void FormMuonTraSach_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            SqlConnection conn = DbHelper.Connect();
            conn.Open();

            if (rbToanBo.Checked)
            {
                dataAdapterMuonTra = new SqlDataAdapter("SELECT * FROM VIEW_CHI_TIET_MUON_TRA", conn);
                dataTableMuonTra = new DataTable();
                dataTableMuonTra.Clear();
                dataAdapterMuonTra.Fill(dataTableMuonTra);
                dgvMuonTra.DataSource = dataTableMuonTra;

                dgvMuonTra.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvMuonTra.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            else if (rbDangMuon.Checked)
            {
                dataAdapterMuonTra = new SqlDataAdapter("SELECT * FROM VIEW_SACH_DANG_MUON", conn);
                dataTableMuonTra = new DataTable();
                dataTableMuonTra.Clear();
                dataAdapterMuonTra.Fill(dataTableMuonTra);
                dgvMuonTra.DataSource = dataTableMuonTra;

                dgvMuonTra.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvMuonTra.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            else if (rbDaTra.Checked)
            {
                dataAdapterMuonTra = new SqlDataAdapter("SELECT * FROM VIEW_SACH_DA_TRA", conn);
                dataTableMuonTra = new DataTable();
                dataTableMuonTra.Clear();
                dataAdapterMuonTra.Fill(dataTableMuonTra);
                dgvMuonTra.DataSource = dataTableMuonTra;

                dgvMuonTra.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvMuonTra.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

        }

        private void btChoMuon_Click(object sender, EventArgs e)
        {
            DialogChoMuon choMuon = new DialogChoMuon();
            choMuon.ShowDialog();
        }

        private void rbToanBo_CheckedChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void rbDangMuon_CheckedChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void rbDaTra_CheckedChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btTimKiem1_Click(object sender, EventArgs e)
        {
            if (rbToanBo.Checked)
            {
                if (tbTimKiemMaPhieuMuon.Text.Length == 0)
                    LoadData();
                else
                {
                    SqlConnection conn = DbHelper.Connect();
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[TIM_KIEM_MUON_TRA_PHIEU_MUON] (@MaPhieuMuon)", conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@MaPhieuMuon", tbTimKiemMaPhieuMuon.Text);


                    dataAdapterMuonTra = new SqlDataAdapter(cmd);
                    dataTableMuonTra = new DataTable();
                    dataTableMuonTra.Clear();
                    dataAdapterMuonTra.Fill(dataTableMuonTra);
                    dgvMuonTra.DataSource = dataTableMuonTra;
                }
            }
            else if (rbDangMuon.Checked)
            {
                if (tbTimKiemMaPhieuMuon.Text.Length == 0)
                    LoadData();
                else
                {
                    SqlConnection conn = DbHelper.Connect();
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[TIM_KIEM_SACH_DANG_MUON_PHIEU_MUON] (@MaPhieuMuon)", conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@MaPhieuMuon", tbTimKiemMaPhieuMuon.Text);


                    dataAdapterMuonTra = new SqlDataAdapter(cmd);
                    dataTableMuonTra = new DataTable();
                    dataTableMuonTra.Clear();
                    dataAdapterMuonTra.Fill(dataTableMuonTra);
                    dgvMuonTra.DataSource = dataTableMuonTra;
                }
            }
            else
            {
                if (tbTimKiemMaPhieuMuon.Text.Length == 0)
                    LoadData();
                else
                {
                    SqlConnection conn = DbHelper.Connect();
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[TIM_KIEM_SACH_DA_TRA_PHIEU_MUON] (@MaPhieuMuon)", conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@MaPhieuMuon", tbTimKiemMaPhieuMuon.Text);


                    dataAdapterMuonTra = new SqlDataAdapter(cmd);
                    dataTableMuonTra = new DataTable();
                    dataTableMuonTra.Clear();
                    dataAdapterMuonTra.Fill(dataTableMuonTra);
                    dgvMuonTra.DataSource = dataTableMuonTra;
                }
            }
        }

        private void btTimKiem2_Click(object sender, EventArgs e)
        {
            if (rbToanBo.Checked)
            {
                if (tbTimKiemMaDocGia.Text.Length == 0)
                    LoadData();
                else
                {
                    SqlConnection conn = DbHelper.Connect();
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[TIM_KIEM_MUON_TRA_MA_DOC_GIA] (@MaDocGia)", conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@MaDocGia", tbTimKiemMaDocGia.Text);


                    dataAdapterMuonTra = new SqlDataAdapter(cmd);
                    dataTableMuonTra = new DataTable();
                    dataTableMuonTra.Clear();
                    dataAdapterMuonTra.Fill(dataTableMuonTra);
                    dgvMuonTra.DataSource = dataTableMuonTra;
                }
            }
            else if (rbDangMuon.Checked)
            {
                if (tbTimKiemMaDocGia.Text.Length == 0)
                    LoadData();
                else
                {
                    SqlConnection conn = DbHelper.Connect();
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[TIM_KIEM_SACH_DANG_MUON_MA_DOC_GIA] (@MaDocGia)", conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@MaDocGia", tbTimKiemMaDocGia.Text);


                    dataAdapterMuonTra = new SqlDataAdapter(cmd);
                    dataTableMuonTra = new DataTable();
                    dataTableMuonTra.Clear();
                    dataAdapterMuonTra.Fill(dataTableMuonTra);
                    dgvMuonTra.DataSource = dataTableMuonTra;
                }
            }
            else
            {
                if(tbTimKiemMaDocGia.Text.Length == 0)
                    LoadData();
                else
                {
                    SqlConnection conn = DbHelper.Connect();
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[TIM_KIEM_SACH_DA_TRA_MA_DOC_GIA] (@MaDocGia)", conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@MaDocGia", tbTimKiemMaDocGia.Text);


                    dataAdapterMuonTra = new SqlDataAdapter(cmd);
                    dataTableMuonTra = new DataTable();
                    dataTableMuonTra.Clear();
                    dataAdapterMuonTra.Fill(dataTableMuonTra);
                    dgvMuonTra.DataSource = dataTableMuonTra;
                }
            }
        }

        private void btTraSach_Click(object sender, EventArgs e)
        {           
            maPhieuMuon = tbMaPhieuMuon.Text;
            maSach = tbMaSach.Text;
            
            SqlConnection conn = DbHelper.Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT [DBO].[TINH_PHAT_TRE_HAN](@NgayHetHan)", conn);
            cmd.CommandType = CommandType.Text;

            DateTime date = DateTime.ParseExact(tbNgayHetHan.Text, "dd/MM/yyyy", null);
            cmd.Parameters.Add("@NgayHetHan", SqlDbType.Date).Value = date;
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            phatQuaHan = dr.GetDecimal(0);

            DialogTraSach traSach = new DialogTraSach();
            traSach.ShowDialog();

            LoadData();
        }

        private void dgvMuonTra_CellClick(object? sender, DataGridViewCellEventArgs? e)
        {

            int r = dgvMuonTra.CurrentCell.RowIndex;
            tbMaPhieuMuon.Text = dgvMuonTra.Rows[r].Cells[0].Value.ToString();
            tbMaNguoiMuon.Text = dgvMuonTra.Rows[r].Cells[1].Value.ToString();
            tbMaSach.Text = dgvMuonTra.Rows[r].Cells[3].Value.ToString();

            DateTime date = (DateTime)dgvMuonTra.Rows[r].Cells[6].Value;
            tbNgayHetHan.Text = date.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
        }

        private void btGiaHan_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DbHelper.Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand("GIA_HAN_SACH", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaPhieuMuon", SqlDbType.VarChar).Value = tbMaPhieuMuon.Text;
            cmd.Parameters.Add("@MaSach", SqlDbType.VarChar).Value = tbMaSach.Text;
            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Gia hạn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadData();
        }
    }
}
