﻿using System;
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
                SqlConnection conn = DbHelper.Connect();
                conn.Open();

                dataAdapterChuyenNganh = new SqlDataAdapter("SELECT * FROM VIEW_CHUYEN_NGANH", conn);
                dataTableChuyenNganh = new DataTable();
                dataTableChuyenNganh.Clear();
                dataAdapterChuyenNganh.Fill(dataTableChuyenNganh);
                dgv.DataSource = dataTableChuyenNganh;
            }
            catch
            {
                MessageBox.Show("Opps!"
                     , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btThayDoi.Enabled = false;
            btCapNhat.Visible = false;
            btHuyBo.Visible = false;
            btXoa.Enabled = false;
            tbTen.ReadOnly = true;
            tbMa.ReadOnly = true;
            tbTenThem.Enabled = true;
            btThem.Enabled = true;
        }

        private void dgvDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btThayDoi.Enabled = true;
            btXoa.Enabled = true;

            int r = dgv.CurrentCell.RowIndex;
            tbMa.Text = dgv.Rows[r].Cells[0].Value.ToString();
            tbTen.Text = dgv.Rows[r].Cells[1].Value.ToString();
        }

        private void btThayDoi_Click(object sender, EventArgs e)
        {
            tbTen.ReadOnly = false;
            btCapNhat.Visible = true;
            btHuyBo.Visible = true;
            btXoa.Enabled = false;
            btThayDoi.Enabled = false;
            tbTenThem.Enabled = false;
            btThem.Enabled = false;
        }

        private void btHuyBo_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DbHelper.Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand("XOA_CHUYEN_NGANH", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaChuyenNganh", SqlDbType.VarChar).Value = tbMa.Text.ToString();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Xoá thành công"
                     , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();

            LoadData();
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DbHelper.Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand("SUA_CHUYEN_NGANH", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaChuyenNganh", SqlDbType.VarChar).Value = tbMa.Text.ToString();
            cmd.Parameters.Add("@TenChuyenNganh", SqlDbType.NVarChar).Value = tbTen.Text.ToString();
            cmd.ExecuteNonQuery();

            MessageBox.Show("Cập nhật thành công"
                     , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();

            LoadData();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DbHelper.Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand("THEM_CHUYEN_NGANH", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TenChuyenNganh", SqlDbType.NVarChar).Value = tbTenThem.Text.ToString();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Thêm thành công"
                     , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();

            LoadData();
        }
    }
}
