using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThietBiMayTinh
{
    public partial class ManagerForm : Form
    {
        
        public ManagerForm()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private Form searchOpenedForm(String formName)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name.Equals(formName))
                {
                    return f;
                }
            }
            return null;
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            Form nhanVienManagerForm = searchOpenedForm("NhanVienManagerForm");
            if (nhanVienManagerForm == null)
            {
                nhanVienManagerForm = new NhanVienManagerForm();
            }
            nhanVienManagerForm.Show();
            nhanVienManagerForm.Activate();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm f = new LoginForm();
            f.Show();
        }

        private void btnNhomHang_Click(object sender, EventArgs e)
        {
            Form form = searchOpenedForm("NhomHangManagerForm");
            if (form == null)
            {
                form = new NhomHangManagerForm();
            }
            form.Show();
            form.Activate();
        }

        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            Form form = searchOpenedForm("HangHoaManagerForm");
            if (form == null)
            {
                form = new HangHoaManagerForm();
            }
            form.Show();
            form.Activate();
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            Form form = searchOpenedForm("NhaCungCapManagerForm");
            if (form == null)
            {
                form = new NhaCungCapManagerForm();
            }
            form.Show();
            form.Activate();
        }

        private void btnHangNhap_Click(object sender, EventArgs e)
        {
            Form form = searchOpenedForm("HangNhapManagerForm");
            if (form == null)
            {
                form = new HangNhapManagerForm();
            }
            form.Show();
            form.Activate();
        }

        private void btnHoaDonXuat_Click(object sender, EventArgs e)
        {
            Form form = searchOpenedForm("HoaDonXuatManagerForm");
            if (form == null)
            {
                form = new HoaDonXuatManagerForm();
            }
            form.Show();
            form.Activate();
        }

        private void btnHoaDonNhap_Click(object sender, EventArgs e)
        {
            Form form = searchOpenedForm("HoaDonNhapManagerForm");
            if (form == null)
            {
                form = new HoaDonNhapHangManagerForm();
            }
            form.Show();
            form.Activate();
        }

        private void btnHangXuat_Click(object sender, EventArgs e)
        {
            Form form = searchOpenedForm("HangBanManagerForm");
            if (form == null)
            {
                form = new HangBanManagerForm();
            }
            form.Show();
            form.Activate();
        }
    }
}
