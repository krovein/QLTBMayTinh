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
    public partial class HoaDonNhapHangManagerForm : Form, Interface
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["db_QuanLyBanHangThietBiMayTinh"].ConnectionString;

        private string sql_GetAll = "sp_GetAllHoaDonNhapHang";
        private string sql_Edit = "sp_EditHoaDonNhap";
        private string sql_Add = "sp_AddHoaDonNhap";
        private string sql_Delete = "sp_DeleteHoaDonNhap";

        private string sql_GetNhanVien = "sp_GettAllNhanVien";
        private string sql_GetAllNCC = "sp_GetAllNCC";



        public HoaDonNhapHangManagerForm()
        {
            InitializeComponent();
        }

      
        private void HoaDonNhapHangManagerForm_Load(object sender, EventArgs e)
        {
            pnFunction.Visible = false;
            showHoaDonNhap();
            showNhanVienCBO();
            showNhaCungCapCBO();

        }

        public void add()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string maNV = cboNhanVien.SelectedValue.ToString();
                string maNCC = cboNCC.SelectedValue.ToString();

                DateTime ngayNhap = dateNgayNhap.Value.Date;
                using (SqlCommand cmd = new SqlCommand(sql_Add, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@mahoadon", txtMaHDNhap.Text);
                    cmd.Parameters.AddWithValue("@manv", maNV);
                    cmd.Parameters.AddWithValue("@mancc", maNCC);
                    cmd.Parameters.AddWithValue("@ngaynhap", ngayNhap);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                }
            }
            showHoaDonNhap();
        }

        public void delete()
        {
            DataTable dt = (DataTable)grHoaDonNhap.DataSource;
            DataRow row = dt.Rows[grHoaDonNhap.CurrentRow.Index];
            string ma = row["sMaHoaDonNhap"].ToString();

            DialogResult dr;
            dr = MessageBox.Show("Xóa ?","Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                showHoaDonNhap();
            }
        }

        public void edit()
        {
            string maNV = cboNhanVien.SelectedValue.ToString();
            string maNCC = cboNCC.SelectedValue.ToString();
            DateTime ngayNhap = dateNgayNhap.Value.Date;

            DataTable dt = (DataTable)grHoaDonNhap.DataSource;
            DataRow row = dt.Rows[grHoaDonNhap.CurrentRow.Index];
            string ma = row["sMaHoaDonNhap"].ToString();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sql_Edit, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@mahoadon", txtMaHDNhap.Text);
                    cmd.Parameters.AddWithValue("@manv", maNV);
                    cmd.Parameters.AddWithValue("@mancc", maNCC);
                    cmd.Parameters.AddWithValue("@ngaynhap", ngayNhap);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                }
            }

            showHoaDonNhap();
        }

        public void search()
        {
            throw new NotImplementedException();
        }


        private DataTable getDataHoaDonNhap()
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

        private void showHoaDonNhap()
        {
            DataTable dt = getDataHoaDonNhap();
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

        private DataTable getDataNCC()
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(sql_GetAllNCC, cnn))
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

        private void showNhaCungCapCBO()
        {
            cboNCC.Items.Add("Chọn nhóm hàng");
            DataTable dataTable = getDataNCC();
            DataView v = new DataView(dataTable);
            cboNCC.DisplayMember = "sTenNCC";
            cboNCC.ValueMember = "sMaNCC";
            cboNCC.DataSource = v;
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

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            pnFunction.Visible = false;
            delete();
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pnFunction.Visible = true;
            lbTitle.Text = "Sửa Hóa Đơn Nhập";
            btnOK.Text = "Sửa";
            txtMaHDNhap.Enabled = false;

            DataTable dt = (DataTable)grHoaDonNhap.DataSource;
            DataRow row = dt.Rows[grHoaDonNhap.CurrentRow.Index];
            string ma = row["sMaHoaDonNhap"].ToString();
            if (ma == string.Empty)
            {
                MessageBox.Show("Chọn nhóm hàng cần sửa");
            }
            else
            {

                txtMaHDNhap.Text = ma;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnFunction.Visible = true;
            lbTitle.Text = "Thêm Hóa Đơn Nhập";
            btnOK.Text = "Thêm";
            txtMaHDNhap.Enabled = true;
            txtMaHDNhap.Text = "";
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
