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
    public partial class DialogTraSach : Form
    {
        SqlDataAdapter? dataAdapter = null;
        DataTable? dataTable = null;
        public DialogTraSach()
        {
            InitializeComponent();
        }

        private void DialogTraSach_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            SqlConnection conn = DbHelper.Connect();
            conn.Open();

            dataAdapter = new SqlDataAdapter("SELECT * FROM TINH_TRANG_SACH", conn);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            cbTinhTrang.DataSource = dataTable;
            cbTinhTrang.DisplayMember = "TinhTrangSach";
            cbTinhTrang.ValueMember = "MaTinhTrangSach";

            lbTreHan.Text = lbTreHan.Text + FormMuonTraSach.phatQuaHan.ToString();
        }

        private void btTraSach_Click(object sender, EventArgs e)
        {

        }
    }
}
