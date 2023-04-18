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
    public partial class DialogChoMuon : Form
    {
        string connectionString = @"Data Source = (local); Initial Catalog = QuanLyThuVien;
                                        User ID = sa; Password = tiendung123";
        SqlConnection? connection = null;
        SqlDataAdapter? dataAdapterSach = null;
        DataTable? dataTableSach = null;

        public DialogChoMuon()
        {
            InitializeComponent();
        }

        private void DialogChoMuon_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            label12.Text = Authentication.LoginId;
            connection = new SqlConnection(connectionString);
            if (connection.State == ConnectionState.Open) connection.Close();
            connection.Open();

            dataAdapterSach = new SqlDataAdapter("SELECT MaSach AS [Mã sách], TenSach AS [Tên sách] FROM SACH", connection);
            dataTableSach = new DataTable();
            dataAdapterSach.Fill(dataTableSach);
            dgvSach.DataSource = dataTableSach;

            var labels = new List<Label>() { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10 };
            foreach (var label in labels)
            {
                label.ResetText();
            }

            var dtpickers = new List<DateTimePicker>() { dt1, dt2, dt3, dt4, dt5, dt6, dt7, dt8, dt9, dt10 };
            {
                foreach (var dtpicker in dtpickers)
                {
                    dtpicker.Visible = false;
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            var labels = new List<Label>() { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10 };
            foreach (var label in labels)
            {
                if (label.Text == "")
                {
                    label.Text = tbMaSach.Text;
                    tbMaSach.ResetText();
                    break;
                }
            }

            var dtpickers = new List<DateTimePicker>() { dt1, dt2, dt3, dt4, dt5, dt6, dt7, dt8, dt9, dt10 };
            {
                foreach(var dtpicker in dtpickers)
                {
                    if (dtpicker.Visible == false)
                    {
                        dtpicker.Visible = true;
                        break;
                    }
                }    
            }
        }
        private void dgvSach_CellClick(object? sender, DataGridViewCellEventArgs? e)
        {
            int r = dgvSach.CurrentCell.RowIndex;
            tbMaSach.Text = dgvSach.Rows[r].Cells[0].Value.ToString();
        }

        private void btChoMuon_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            if (connection.State == ConnectionState.Open) connection.Close();
            connection.Open();

            SqlCommand cmd = new SqlCommand("Auto_MaPhieuMuon", connection);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT [dbo].[Auto_MaPhieuMuon]()";
            var result = cmd.ExecuteScalar();
            String maPhieuMuon = (String)result;

            SqlCommand cmd1 = new SqlCommand("THEM_PHIEU_MUON", connection);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.Add("@MaDocGia", SqlDbType.VarChar).Value = tbMaDocGia.Text;
            cmd1.Parameters.Add("@MaNhanVien", SqlDbType.VarChar).Value = Authentication.LoginId;
            cmd1.ExecuteNonQuery();


            var labels = new List<Label>() { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10 };
            foreach (var label in labels)
            {
                if (label.Text != "")
                {
                    SqlCommand cmd2 = new SqlCommand("THEM_SACH_MUON", connection);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.Add("@MaPhieuMuon", SqlDbType.VarChar).Value = maPhieuMuon;
                    cmd2.Parameters.Add("@MaSach", SqlDbType.VarChar).Value = label.Text;
                    cmd2.ExecuteNonQuery();
                }
                else break;
            }    
            MessageBox.Show("Đã mượn thành công"
                     , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection.Close();
            this.Close();
        }
    }
}
