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
        string connectionString = @"Data Source = (local); Initial Catalog = QuanLyThuVien;
                                        User ID = sa; Password = tiendung123";
        SqlConnection? connection = null;
        SqlDataAdapter? dataAdapterMuonTra = null;
        DataTable? dataTableMuonTra = null;
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
            connection = new SqlConnection(connectionString);
            if (connection.State == ConnectionState.Open) connection.Close();
            connection.Open();

            if (rbToanBo.Checked)
            {
                dataAdapterMuonTra = new SqlDataAdapter("SELECT * FROM VIEW_CHI_TIET_MUON_TRA", connection);
                dataTableMuonTra = new DataTable();
                dataTableMuonTra.Clear();
                dataAdapterMuonTra.Fill(dataTableMuonTra);
                dgvMuonTra.DataSource = dataTableMuonTra;
            }
            else if (rbDangMuon.Checked)
            {
                dataAdapterMuonTra = new SqlDataAdapter("SELECT * FROM VIEW_SACH_DANG_MUON", connection);
                dataTableMuonTra = new DataTable();
                dataTableMuonTra.Clear();
                dataAdapterMuonTra.Fill(dataTableMuonTra);
                dgvMuonTra.DataSource = dataTableMuonTra;
            }
            else if (rbDaTra.Checked)
            {
                dataAdapterMuonTra = new SqlDataAdapter("SELECT * FROM VIEW_SACH_DA_TRA", connection);
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
    }
}
