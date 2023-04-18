using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class FormTrangChu : Form
    {
        public FormTrangChu()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        private void Sach_Click(object sender, EventArgs e) 
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == typeof(FormSach))
                {
                    if (form.WindowState == FormWindowState.Minimized)
                    {
                        form.WindowState = FormWindowState.Normal;
                    }
                    form.Activate();
                    return;
                }
            }
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            FormSach formSach = new();
            formSach.MdiParent = this;
            formSach.Show();
            formSach.StartPosition = FormStartPosition.Manual;
            formSach.Location = new Point(0, 0);
        }

        private void DocGia_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == typeof(FormDocGia))
                {
                    if (form.WindowState == FormWindowState.Minimized)
                    {
                        form.WindowState = FormWindowState.Normal;
                    }
                    form.Activate();
                    return;
                }
            }
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            FormDocGia formDocGia = new();
            formDocGia.MdiParent = this;
            formDocGia.Show();
            formDocGia.StartPosition = FormStartPosition.Manual;
            formDocGia.Location = new Point(0, 0);
        }

        private void TacGia_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == typeof(DialogThemSach))
                {
                    if (form.WindowState == FormWindowState.Minimized)
                    {
                        form.WindowState = FormWindowState.Normal;
                    }
                    form.Activate();
                    return;
                }
            }
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            FormTacGia formTacGia = new();
            formTacGia.MdiParent = this;
            formTacGia.Show();
            formTacGia.StartPosition = FormStartPosition.Manual;
            formTacGia.Location = new Point(0, 0);
        }

        private void NhaXuatBan_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == typeof(FormNhaXuatBan))
                {
                    if (form.WindowState == FormWindowState.Minimized)
                    {
                        form.WindowState = FormWindowState.Normal;
                    }
                    form.Activate();
                    return;
                }
            }
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            FormNhaXuatBan formNhaXuatBan = new();
            formNhaXuatBan.MdiParent = this;
            formNhaXuatBan.Show();
            formNhaXuatBan.StartPosition = FormStartPosition.Manual;
            formNhaXuatBan.Location = new Point(0, 0);
        }

        private void ChuyenNganh_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == typeof(FormChuyenNganh))
                {
                    if (form.WindowState == FormWindowState.Minimized)
                    {
                        form.WindowState = FormWindowState.Normal;
                    }
                    form.Activate();
                    return;
                }
            }
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            FormChuyenNganh formChuyenNganh = new();
            formChuyenNganh.MdiParent = this;
            formChuyenNganh.Show();
            formChuyenNganh.StartPosition = FormStartPosition.Manual;
            formChuyenNganh.Location = new Point(0, 0);
        }

        private void MuonTra_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == typeof(FormMuonTraSach))
                {
                    if (form.WindowState == FormWindowState.Minimized)
                    {
                        form.WindowState = FormWindowState.Normal;
                    }
                    form.Activate();
                    return;
                }
            }
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            FormMuonTraSach formMuonTraSach = new FormMuonTraSach();
            formMuonTraSach.MdiParent = this;
            formMuonTraSach.Show();
            formMuonTraSach.StartPosition = FormStartPosition.Manual;
            formMuonTraSach.Location = new Point(0, 0);
        }

    }
}
