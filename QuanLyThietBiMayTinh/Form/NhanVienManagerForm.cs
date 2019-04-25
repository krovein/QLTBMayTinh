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
    public partial class NhanVienManagerForm : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["db_QuanLyBanHangThietBiMayTinh"].ConnectionString;

        private string sqlGetAllNhanVien = "sp_GettAllNhanVien";
        private string sqlAddNhanVien = "sp_AddNhanVien";
        private string sqlDeleteNhanVien = "sp_DeleteNhanVien";
        private string sqlEditNhanVien = "sp_EditNhanVien";


        public NhanVienManagerForm()
        {
            InitializeComponent();
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

        private void btnAddNV_Click(object sender, EventArgs e)
        {
            
            pnChucNang.Visible = true;
            btnOK.Text = "Thêm";
            lbTitle.Text = "Thêm nhân viên";

            lbGioiTinh.Enabled = true;
            lbNgaySinh.Enabled = true;
            dateNgaySinh.Enabled = true;
            pnGT.Enabled = true;

            txtMaNV.Enabled = true;
            txtMaNV.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtHoTenNV.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtCmnd.Text = string.Empty;


        }

        public DataTable getAllNV()
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(sqlGetAllNhanVien, cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable tbl = new DataTable("tblNhanVien");
                        da.Fill(tbl);
                        return tbl;
                    }
                }
                cnn.Close();
            }
        }

        public void showAllNhanVien ()
        {
            DataTable dt = getAllNV();
            grQuanLyNhanVien.AutoGenerateColumns = false;
            grQuanLyNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grQuanLyNhanVien.DataSource = dt;
        }

        private void NhanVienManagerForm_Load(object sender, EventArgs e)
        {
            showAllNhanVien();
            pnChucNang.Visible = false;
        }

    

        private void btnDeleteNV_Click(object sender, EventArgs e)
        {
            pnChucNang.Visible = false;
            txtMaNV.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtHoTenNV.Text = string.Empty;
            txtSDT.Text = string.Empty;

            DataTable dtNhanVien = (DataTable)grQuanLyNhanVien.DataSource;
            DataRow row = dtNhanVien.Rows[grQuanLyNhanVien.CurrentRow.Index];
            string manv = row["sMaNhanVien"].ToString();

            DialogResult dr;
            dr = MessageBox.Show(string.Format("Bạn có muốn xóa {0} không ?", row["sTenNhanVien"].ToString()),
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sqlDeleteNhanVien, cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@manv", manv);
                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        cnn.Close();
                    }
                }
                showAllNhanVien();
            }
            
        }

        private void btnEditNV_Click(object sender, EventArgs e)
        {

            pnChucNang.Visible = true;

            txtMaNV.Enabled = false;
            btnOK.Text = "Sửa";
            lbTitle.Text = "Sửa thông tin nhân viên";

            lbGioiTinh.Enabled = true;
            lbNgaySinh.Enabled = true;
            dateNgaySinh.Enabled = true;
            pnGT.Enabled = true;

            DataTable dtNhanVien = (DataTable)grQuanLyNhanVien.DataSource;
            DataRow row = dtNhanVien.Rows[grQuanLyNhanVien.CurrentRow.Index];
            txtMaNV.Text = row["sMaNhanVien"].ToString();
            txtDiaChi.Text= row["sDiaChi"].ToString();
            txtHoTenNV.Text= row["sTenNhanVien"].ToString();
            txtSDT.Text= row["sSoDienThoai"].ToString();
            txtCmnd.Text = row["sChungMinhThu"].ToString();

        }
      
        
    
        private void btnSearchNV_Click(object sender, EventArgs e)
        {

            pnChucNang.Visible = true;

            lbGioiTinh.Enabled = false;
            lbNgaySinh.Enabled = false;
            dateNgaySinh.Enabled = false;
            pnGT.Enabled = false;
            txtMaNV.Enabled = true;
            lbTitle.Text = "Tìm kiếm";
            btnOK.Text= "Tìm kiếm";

            txtMaNV.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtHoTenNV.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtCmnd.Text = string.Empty;

        }
        
        private void btnOK_Click(object sender, EventArgs e)
        {
            int gt = 0;
            DateTime ngaySinh;

            switch (btnOK.Text)
            {
                case "Tìm kiếm":
                    string filter = "1=1";

                    if (txtMaNV.Text != string.Empty)
                    {
                        filter += string.Format(" AND sMaNhanVien LIKE '%{0}%'", txtMaNV.Text);
                    }
                    if (txtHoTenNV.Text != string.Empty)
                    {
                        filter += string.Format(" AND sTenNhanVien LIKE '%{0}%'", txtHoTenNV.Text);
                    }
                    if (txtDiaChi.Text != string.Empty)
                    {
                        filter += string.Format(" AND sDiaChi LIKE '%{0}%'", txtDiaChi.Text);
                    }
                    if (txtSDT.Text != string.Empty)
                    {
                        filter += string.Format(" AND sSoDienThoai LIKE '%{0}%'", txtSDT.Text);
                    }
                    if (txtCmnd.Text != string.Empty)
                    {
                        filter += string.Format(" AND sChungMinhThu LIKE '%{0}%'", txtCmnd.Text);
                    }
                    hienNV(filter);
                    break;
                case "Sửa":
                    DataTable dtNhanVien = (DataTable)grQuanLyNhanVien.DataSource;
                    DataRow row = dtNhanVien.Rows[grQuanLyNhanVien.CurrentRow.Index];
                    string manv = row["sMaNhanVien"].ToString();
       
                    if (rbNam.Checked == true)
                    {
                        gt = 1;
                    }
                    else gt = 0;

                     ngaySinh = dateNgaySinh.Value.Date;

                    // kiem tra CMND có được nhập không
                    if (txtCmnd.Text == string.Empty)
                    {
                        MessageBox.Show("Vui lòng nhập CMND");
                        return;
                    }
                    DataTable dt2 = getAllNV();
                    DataView dv2 = new DataView(dt2);
                    string filter2 = "sChungMinhThu = '" + txtCmnd.Text + "' AND sMaNhanVien <> ' "+txtMaNV.Text +"'";
                    dv2.RowFilter = filter2;
                    //kiểm tra xem có tồn tại không
                    if (dv2.Count > 0)
                    {
                        MessageBox.Show("So CMND da ton tai trong he thong!");
                        return;
                    }


                    NhanVienManagerForm f = new NhanVienManagerForm();
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand(sqlEditNhanVien, conn))
                        {
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@sMaNV", manv);
                            cmd.Parameters.AddWithValue("@sTenNV", txtHoTenNV.Text);
                            cmd.Parameters.AddWithValue("@bGioiTinh", gt);
                            cmd.Parameters.AddWithValue("@dNgaySinh", ngaySinh);
                            cmd.Parameters.AddWithValue("@sDiaChi", txtDiaChi.Text);
                            cmd.Parameters.AddWithValue("@sSoDienThoai", txtSDT.Text);
                            cmd.Parameters.AddWithValue("@sChungMinhThu", txtCmnd.Text);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();

                        }
                    }

                    showAllNhanVien();
                    break;

                case "Thêm":       
                    if (rbNam.Checked == true)
                    {
                        gt = 1;
                    }
                    else gt = 0;

                    ngaySinh = dateNgaySinh.Value.Date;
                    // kiem tra CMND có được nhập không
                    if(txtCmnd.Text== string.Empty)
                    {
                        MessageBox.Show("Vui lòng nhập CMND");
                        return;
                    }
                    DataTable dt1 = getAllNV();
                    DataView dv1 = new DataView(dt1);
                    string filter1= "sChungMinhThu = '" + txtCmnd.Text + "'";
                    dv1.RowFilter = filter1;
                    //kiểm tra xem có tồn tại không
                    if(dv1.Count> 0)
                    {
                        MessageBox.Show("So CMND da ton tai trong he thong!");
                        return;
                    }




                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand(sqlAddNhanVien, conn))
                        {
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@sMaNV", txtMaNV.Text);
                            cmd.Parameters.AddWithValue("@sTenNV", txtHoTenNV.Text);
                            cmd.Parameters.AddWithValue("@bGioiTinh", gt);
                            cmd.Parameters.AddWithValue("@dNgaySinh", ngaySinh);
                            cmd.Parameters.AddWithValue("@sDiaChi", txtDiaChi.Text);
                            cmd.Parameters.AddWithValue("@sSoDienThoai", txtSDT.Text);
                            cmd.Parameters.AddWithValue("@sChungMinhThu", txtCmnd.Text);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();

                        }
                    }
                    showAllNhanVien();
                    break;
            }
        }
        private void hienNV(string filter)
        {
           
            DataTable dt = getAllNV();
            DataView dv = new DataView(dt);
            dv.RowFilter = filter;
            grQuanLyNhanVien.AutoGenerateColumns = false;
            grQuanLyNhanVien.DataSource = dv;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnChucNang.Visible = false;
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn trở về không ?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
    }
}
