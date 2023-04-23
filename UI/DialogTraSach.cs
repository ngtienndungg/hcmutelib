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
            cbTinhTrang.DisplayMember = "TinhTrangSach";
            cbTinhTrang.ValueMember = "MaTinhTrangSach";
            cbTinhTrang.DataSource = dataTable;

            lbTreHan.Text = "Tiền phạt trễ hạn: " + FormMuonTraSach.phatQuaHan.ToString() + " VND";
        }

        private void btTraSach_Click(object sender, EventArgs e)
        {

        }

        private void cbTinhTrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTinhTrang.SelectedValue != null) 
            {
                SqlConnection conn = DbHelper.Connect();
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT [DBO].[TINH_PHAT_HU_HONG](@MaSach, @TinhTrang)", conn);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add("@MaSach", SqlDbType.VarChar).Value = FormMuonTraSach.maSach;
                cmd.Parameters.Add("@TinhTrang", SqlDbType.Int).Value = cbTinhTrang.SelectedValue;

                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                decimal phatHuHong = dr.GetDecimal(0);
                lbHuHong.Text = "Tiền phạt hư hỏng: " + phatHuHong.ToString() + " VND";
            }
        }
    }
}
