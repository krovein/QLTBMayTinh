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
    public partial class HangBanManagerForm : Form, Interface
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["db_QuanLyBanHangThietBiMayTinh"].ConnectionString;

        private string sql_GetAll = "sp_GetAllHangBan";
        private string sql_Edit = "sp_EditHangBan";
        private string sql_Add = "sp_AddHangBan";
        private string sql_Delete = "sp_DeleteHangBan";

        private string sql_GetAllHoaDonBanHang = "sp_GetAllHoaDonBanHang";
        public HangBanManagerForm()
        {
            InitializeComponent();
        }

        private DataTable getDataHangBan()
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(sql_GetAll, cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable tbl = new DataTable();
                        da.Fill(tbl);
                        return tbl;
                    }
                }
                cnn.Close();
            }
        }

        private void showHangNhap()
        {
            DataTable dt = getDataHangBan();
            gridview.AutoGenerateColumns = false;

            gridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridview.DataSource = dt;
        }

        private DataTable getDataHoaDonBan()
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(sql_GetAllHoaDonBanHang, cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable tbl = new DataTable();
                        da.Fill(tbl);
                        return tbl;
                    }
                }
                cnn.Close();
            }
        }

        private void showNhomHangCBO()
        {
            cboMaHoaDonBan.Items.Add("Chọn hóa đơn");
            DataTable dataTable = getDataHoaDonBan();
            DataView v = new DataView(dataTable);
            cboMaHoaDonBan.DisplayMember = "sMaHoaDonBan";
            cboMaHoaDonBan.ValueMember = "sMaHoaDonBan";
            cboMaHoaDonBan.DataSource = v;
        }

        public void add()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string mahd = cboMaHoaDonBan.SelectedValue.ToString();

                using (SqlCommand cmd = new SqlCommand(sql_Add, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@mahb", txtMaHangBan.Text);
                    cmd.Parameters.AddWithValue("@mahd", mahd);
                    cmd.Parameters.AddWithValue("@soluong", txtSoLuong.Text);
                    cmd.Parameters.AddWithValue("@giaban", txtGiaBan.Text);
                    cmd.Parameters.AddWithValue("@thoigianbaohanh", txtTHoiGianBaoHanh.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                }
            }
            showHangNhap();
        }

        public void delete()
        {
            DataTable dtNhanVien = (DataTable)gridview.DataSource;
            DataRow row = dtNhanVien.Rows[gridview.CurrentRow.Index];
            string ma = row["sMaHangBan"].ToString();

            DialogResult dr;
            dr = MessageBox.Show("Xác Nhận",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql_Delete, cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@mahb", ma);
                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        cnn.Close();
                    }
                }
                showHangNhap();
            }
        }

        public void edit()
        {
            string maHD = cboMaHoaDonBan.SelectedValue.ToString();
            DataTable dt = (DataTable)gridview.DataSource;
            DataRow row = dt.Rows[gridview.CurrentRow.Index];
            string ma = row["sMaHangBan"].ToString();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sql_Edit, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@mahb", ma);
                    cmd.Parameters.AddWithValue("@mahd", maHD);
                    cmd.Parameters.AddWithValue("@soluong",Convert.ToInt32(txtSoLuong.Text));
                    cmd.Parameters.AddWithValue("@giaban", Convert.ToDouble(txtGiaBan.Text));
                    cmd.Parameters.AddWithValue("@thoigianbaohanh", Convert.ToInt32(txtTHoiGianBaoHanh.Text));
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                
                }
            }

            showHangNhap();
        }

        public void search()
        {
            string filter = "1=1";

            if (txtMaHangBan.Text != string.Empty)
            {
                filter += string.Format(" AND sMaHangBan LIKE '%{0}%'", txtMaHangBan.Text);
            }
            if (txtGiaBan.Text != string.Empty)
            {
                filter += string.Format(" AND iSoLuong LIKE '%{0}%'", txtGiaBan.Text);
            }
            if (txtSoLuong.Text != string.Empty)
            {
                filter += string.Format(" AND fGiaBan LIKE '%{0}%'", txtSoLuong.Text);
            }
            if (txtTHoiGianBaoHanh.Text != string.Empty)
            {
                filter += string.Format(" AND iThoiGianBaoHanh LIKE '%{0}%'", txtTHoiGianBaoHanh.Text);
            }

            this.filter(filter);
        }
        private void filter(string filter)
        {

            DataTable dt = getDataHangBan();
            DataView dv = new DataView(dt);
            dv.RowFilter = filter;
            gridview.AutoGenerateColumns = false;
            gridview.DataSource = dv;

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            switch (btnOK.Text)
            {
                case "Thêm":
                    add();
                    break;
                case "Sửa":
                    edit();
                    break;
                case "Tìm kiếm":
                    search();
                    break;
            }
        }

        private void HangBanManagerForm_Load(object sender, EventArgs e)
        {
            showHangNhap();
            showNhomHangCBO();
            pnFunction.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnFunction.Visible = true;
            lbTitle.Text = "Thêm";
            btnOK.Text = "Thêm";
            txtMaHangBan.Enabled = true;

            txtGiaBan.Text = "";
            txtSoLuong.Text = "";
            txtTHoiGianBaoHanh.Text = "";
 
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pnFunction.Visible = true;
            lbTitle.Text = "Sửa ";
            btnOK.Text = "Sửa";
            txtMaHangBan.Enabled = false;

            DataTable dt = (DataTable)gridview.DataSource;
            DataRow row = dt.Rows[gridview.CurrentRow.Index];
            string ma = row["sMaHangBan"].ToString();
            if (ma == string.Empty)
            {
                MessageBox.Show("Chọn nhóm hàng cần sửa");
            }
            else
            {

                txtMaHangBan.Text = ma;
                txtGiaBan.Text = row["fGiaBan"].ToString();

                txtSoLuong.Text = row["iSoLuong"].ToString();
                txtTHoiGianBaoHanh.Text = row["iThoiGianBaoHanh"].ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            pnFunction.Visible = false;
            delete();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            pnFunction.Visible = true;
            lbTitle.Text = "Tìm kiếm";
            btnOK.Text = "Tìm kiếm";

            txtMaHangBan.Enabled = true;

            txtSoLuong.Text = "";
            txtTHoiGianBaoHanh.Text = "";
            txtGiaBan.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnFunction.Visible = false;
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
