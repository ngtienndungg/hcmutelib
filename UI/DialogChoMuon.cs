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
            SqlConnection conn = DbHelper.Connect();
            conn.Open();

            dataAdapterSach = new SqlDataAdapter("SELECT MaSach AS [Mã sách], TenSach AS [Tên sách] FROM SACH", conn);
            dataTableSach = new DataTable();
            dataAdapterSach.Fill(dataTableSach);
            dgvSach.DataSource = dataTableSach;

            var labels = new List<Label>() { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10 };
            foreach (var label in labels)
            {
                label.ResetText();
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
        }
        private void dgvSach_CellClick(object? sender, DataGridViewCellEventArgs? e)
        {
            int r = dgvSach.CurrentCell.RowIndex;
            tbMaSach.Text = dgvSach.Rows[r].Cells[0].Value.ToString();
        }

        private void btChoMuon_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DbHelper.Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand("Auto_MaPhieuMuon", conn);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT [dbo].[Auto_MaPhieuMuon]()";
            var result = cmd.ExecuteScalar();
            String maPhieuMuon = (String)result;

            SqlCommand cmd1 = new SqlCommand("THEM_PHIEU_MUON", conn);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.Add("@MaDocGia", SqlDbType.VarChar).Value = tbMaDocGia.Text;
            cmd1.Parameters.Add("@MaNhanVien", SqlDbType.VarChar).Value = DbHelper.MaNhanVien;
            cmd1.ExecuteNonQuery();


            var labels = new List<Label>() { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10 };
            foreach (var label in labels)
            {
                if (label.Text != "")
                {
                    SqlCommand cmd2 = new SqlCommand("THEM_SACH_MUON", conn);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.Add("@MaPhieuMuon", SqlDbType.VarChar).Value = maPhieuMuon;
                    cmd2.Parameters.Add("@MaSach", SqlDbType.VarChar).Value = label.Text;
                    cmd2.ExecuteNonQuery();
                }
                else break;
            }
            LoadData();
            MessageBox.Show("Đã mượn thành công"
                     , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();
            this.Close();
        }
    }
}
