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
    public partial class FormMuonTraSach : Form
    {
        SqlDataAdapter? dataAdapterMuonTra = null;
        DataTable? dataTableMuonTra = null;

        public static string maPhieuMuon;
        public static string maSach;
        public static DateTime ngayHetHan;

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
            }
            else if (rbDangMuon.Checked)
            {
                dataAdapterMuonTra = new SqlDataAdapter("SELECT * FROM VIEW_SACH_DANG_MUON", conn);
                dataTableMuonTra = new DataTable();
                dataTableMuonTra.Clear();
                dataAdapterMuonTra.Fill(dataTableMuonTra);
                dgvMuonTra.DataSource = dataTableMuonTra;
            }
            else if (rbDaTra.Checked)
            {
                dataAdapterMuonTra = new SqlDataAdapter("SELECT * FROM VIEW_SACH_DA_TRA", conn);
                dataTableMuonTra = new DataTable();
                dataTableMuonTra.Clear();
                dataAdapterMuonTra.Fill(dataTableMuonTra);
                dgvMuonTra.DataSource = dataTableMuonTra;
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

                    SqlCommand cmd = new SqlCommand("TIM_KIEM_MUON_TRA_PHIEU_MUON", conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM [dbo].[TIM_KIEM_MUON_TRA_PHIEU_MUON] (@MaPhieuMuon)";
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

                    SqlCommand cmd = new SqlCommand("TIM_KIEM_SACH_DANG_MUON_PHIEU_MUON", conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM [dbo].[TIM_KIEM_SACH_DANG_MUON_PHIEU_MUON] (@MaPhieuMuon)";
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

                    SqlCommand cmd = new SqlCommand("TIM_KIEM_SACH_DA_TRA_PHIEU_MUON", conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM [dbo].[TIM_KIEM_SACH_DA_TRA_PHIEU_MUON] (@MaPhieuMuon)";
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

                    SqlCommand cmd = new SqlCommand("TIM_KIEM_MUON_TRA_MA_DOC_GIA", conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM [dbo].[TIM_KIEM_MUON_TRA_MA_DOC_GIA] (@MaDocGia)";
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

                    SqlCommand cmd = new SqlCommand("TIM_KIEM_SACH_DANG_MUON_MA_DOC_GIA", conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM [dbo].[TIM_KIEM_SACH_DANG_MUON_MA_DOC_GIA] (@MaDocGia)";
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

                    SqlCommand cmd = new SqlCommand("TIM_KIEM_SACH_DA_TRA_MA_DOC_GIA", conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM [dbo].[TIM_KIEM_SACH_DA_TRA_MA_DOC_GIA] (@MaDocGia)";
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
            DialogTraSach traSach = new DialogTraSach();
            traSach.ShowDialog();
            maPhieuMuon = tbMaPhieuMuon.Text;
            maSach = tbMaSach.Text;
            ngayHetHan = DateTime.Parse(tbNgayHetHan.Text);
        }

        private void dgvMuonTra_CellClick(object? sender, DataGridViewCellEventArgs? e)
        {

            int r = dgvMuonTra.CurrentCell.RowIndex;
            tbMaPhieuMuon.Text = dgvMuonTra.Rows[r].Cells[0].Value.ToString();
            tbMaNguoiMuon.Text = dgvMuonTra.Rows[r].Cells[1].Value.ToString();
            tbMaSach.Text = dgvMuonTra.Rows[r].Cells[3].Value.ToString();
            tbNgayHetHan.Text = dgvMuonTra.Rows[r].Cells[6].Value.ToString();
        }
    }
}
