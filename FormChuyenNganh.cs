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
    public partial class FormChuyenNganh : Form
    {
        string connectionString = @"Data Source = (local); Initial Catalog = QuanLyThuVien;
                                        User ID = sa; Password = tiendung123";
        SqlConnection? connection = null;
        SqlDataAdapter? dataAdapterChuyenNganh = null;
        DataTable? dataTableChuyenNganh = null;
        public FormChuyenNganh()
        {
            InitializeComponent();
        }

        private void FormChuyenNganh_Load(object sender, EventArgs e)
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
                dataAdapterChuyenNganh = new SqlDataAdapter("SELECT * FROM VIEW_CHUYEN_NGANH", connection);
                dataTableChuyenNganh = new DataTable();
                dataTableChuyenNganh.Clear();
                dataAdapterChuyenNganh.Fill(dataTableChuyenNganh);
                dgvDocGia.DataSource = dataTableChuyenNganh;
            }
            catch
            {
                MessageBox.Show("Opps!"
                     , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
