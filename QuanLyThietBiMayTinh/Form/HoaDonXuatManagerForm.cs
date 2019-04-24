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
    public partial class HoaDonXuatManagerForm : Form, Interface
    {

        private string connectionString = ConfigurationManager.ConnectionStrings["db_QuanLyBanHangThietBiMayTinh"].ConnectionString;

        private string sql_GetAll = "sp_GetAllHoaDonBanHang";
        private string sql_Edit = "sp_EditHoaDonBanHang";
        private string sql_Add = "sp_AddHoaDonBanHang";
        private string sql_Delete = "sp_DeleteHoaDonBan";

        private string sql_GetNhanVien = "sp_GettAllNhanVien";
        public HoaDonXuatManagerForm()
        {
            InitializeComponent();
        }

        private DataTable getDataHoaDonBan()
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

        private void showHoaDonBan()
        {
            DataTable dt = getDataHoaDonBan();
            grHoaDonNhap.AutoGenerateColumns = false;

            grHoaDonNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grHoaDonNhap.DataSource = dt;
        }

        private DataTable getDataNhanVien()
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(sql_GetNhanVien, cnn))
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

        private void showNhanVienCBO()
        {
            cboNhanVien.Items.Add("Chọn Nhân Viên");
            DataTable dataTable = getDataNhanVien();
            DataView v = new DataView(dataTable);
            cboNhanVien.DisplayMember = "sTenNhanVien";
            cboNhanVien.ValueMember = "sMaNhanVien";
            cboNhanVien.DataSource = v;
        }

        public void add()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string maNV = cboNhanVien.SelectedValue.ToString();

                DateTime date = dateNgayBan.Value.Date;
                string status;
                if (rbDaThanhToan.Checked)
                {
                    status = "Đã thanh toán";
                }
                else status = "Chưa thanh toán";
                using (SqlCommand cmd = new SqlCommand(sql_Add, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@mahoadon", txtMaHD.Text);
                    cmd.Parameters.AddWithValue("@manv", maNV);
                    cmd.Parameters.AddWithValue("@tenkh", txtTenKH.Text);
                    cmd.Parameters.AddWithValue("@thoigianban", date);
                    cmd.Parameters.AddWithValue("@tinhtrang", status);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                }
            }
            showHoaDonBan();
        }

        public void delete()
        {
            DataTable dt = (DataTable)grHoaDonNhap.DataSource;
            DataRow row = dt.Rows[grHoaDonNhap.CurrentRow.Index];
            string ma = row["sMaHoaDonBan"].ToString();

            DialogResult dr;
            dr = MessageBox.Show("Xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql_Delete, cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@mahoadon", ma);
                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        cnn.Close();
                    }
                }
                showHoaDonBan();
            }
        }

        public void edit()
        {
            string maNV = cboNhanVien.SelectedValue.ToString();
            DateTime date = dateNgayBan.Value.Date;
            string status;
            if (rbDaThanhToan.Checked)
            {
                status = "Đã thanh toán";
            }
            else status = "Chưa thanh toán";

            DataTable dt = (DataTable)grHoaDonNhap.DataSource;
            DataRow row = dt.Rows[grHoaDonNhap.CurrentRow.Index];
            string ma = row["sMaHoaDonBan"].ToString();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sql_Edit, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@mahoadon", txtMaHD.Text);
                    cmd.Parameters.AddWithValue("@manv", maNV);
                    cmd.Parameters.AddWithValue("@tenkh", txtTenKH.Text);
                    cmd.Parameters.AddWithValue("@thoigianban", date);
                    cmd.Parameters.AddWithValue("@tinhtrang", status);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                }
            }

            showHoaDonBan();
        }

        public void search()
        {
            throw new NotImplementedException();
        }

        private void HoaDonXuatManagerForm_Load(object sender, EventArgs e)
        {
            pnFunction.Visible = false;
            showHoaDonBan();
            showNhanVienCBO();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnFunction.Visible = true;
            lbTitle.Text = "Thêm Hóa Đơn Nhập";
            btnOK.Text = "Thêm";
            txtMaHD.Enabled = true;
            txtMaHD.Text = "";
            txtTenKH.Text = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pnFunction.Visible = true;
            lbTitle.Text = "Sửa Hóa Đơn Nhập";
            btnOK.Text = "Sửa";
            txtMaHD.Enabled = false;

            DataTable dt = (DataTable)grHoaDonNhap.DataSource;
            DataRow row = dt.Rows[grHoaDonNhap.CurrentRow.Index];
            string ma = row["sMaHoaDonBan"].ToString();
            if (ma == string.Empty)
            {
                MessageBox.Show("Chọn nhóm hàng cần sửa");
            }
            else
            {

                txtMaHD.Text = ma;
                txtTenKH.Text = row["sTenKhachHang"].ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            pnFunction.Visible = false;
            delete();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
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
    }
}
