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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LibraryManagement
{
    public partial class DialogThemDocGia : Form
    {
        SqlDataAdapter? dataAdapterDoiTuong = null;
        DataTable? dataTableDoiTuong = null;
        public DialogThemDocGia()
        {
            InitializeComponent();
        }

        private void DialogThemDocGia_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            SqlConnection conn = DbHelper.Connect();
            conn.Open();

            dataAdapterDoiTuong = new SqlDataAdapter("SELECT * FROM DOI_TUONG_DOC_GIA", conn);
            dataTableDoiTuong = new DataTable();
            dataAdapterDoiTuong.Fill(dataTableDoiTuong);
            cbDoiTuong.DataSource = dataTableDoiTuong;
            cbDoiTuong.DisplayMember = "TenDoiTuong";
            cbDoiTuong.ValueMember = "MaDoiTuong";
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = DbHelper.Connect();
                conn.Open();

                SqlCommand cmd = new SqlCommand("THEM_DOC_GIA", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaDocGia", SqlDbType.VarChar).Value = tbMaDocGia.Text.ToString();
                if (rbNam.Checked)
                    cmd.Parameters.Add("@GioiTinh", SqlDbType.Bit).Value = 1;
                else
                    cmd.Parameters.Add("@GioiTinh", SqlDbType.Bit).Value = 0;
                cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = tbHoTen.Text.ToString();
                cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = tbEmail.Text.ToString();
                cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = tbSDT.Text.ToString();
                cmd.Parameters.Add("@MaDoiTuong", SqlDbType.Int).Value = cbDoiTuong.SelectedValue;
                cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = dateTimePicker.Value.Date;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã thêm thành công"
                         , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                this.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
