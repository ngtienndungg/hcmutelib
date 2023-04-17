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
    public partial class FormNhaXuatBan : Form
    {
        string connectionString = @"Data Source = (local); Initial Catalog = QuanLyThuVien;
                                        User ID = sa; Password = tiendung123";
        SqlConnection? connection = null;
        SqlDataAdapter? dataAdapterNXB = null;
        DataTable? dataTableNXB = null;
        public FormNhaXuatBan()
        {
            InitializeComponent();
        }

        private void FormNhaXuatBan_Load(object sender, EventArgs e)
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
                dataAdapterNXB = new SqlDataAdapter("SELECT * FROM VIEW_NHA_XUAT_BAN", connection);
                dataTableNXB = new DataTable();
                dataTableNXB.Clear();
                dataAdapterNXB.Fill(dataTableNXB);
                dgvNXB.DataSource = dataTableNXB;
            }
            catch
            {
                MessageBox.Show("Opps!"
                     , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
