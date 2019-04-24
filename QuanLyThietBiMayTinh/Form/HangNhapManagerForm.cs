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
    public partial class HangNhapManagerForm : Form, Interface
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["db_QuanLyBanHangThietBiMayTinh"].ConnectionString;

        private string sql_GetAll = "sp_GetAllHangNhap";
        private string sql_Edit = "sp_EditHangNhap";
        private string sql_Add = "sp_AddHangNhap";
        private string sql_Delete = "sp_DeleteHangNhap";

        private string sql_GetAllHoaDonNhapHang = "sp_GetAllHoaDonNhapHang";
        public HangNhapManagerForm()
        {
            InitializeComponent();
        }


        private DataTable getDataHangNhap()
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
            DataTable dt = getDataHangNhap();
            grHangNhap.AutoGenerateColumns = false;

            grHangNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grHangNhap.DataSource = dt;
        }



        private DataTable getDataHoaDonNhap()
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(sql_GetAllHoaDonNhapHang, cnn))
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
            cboMaHoaDonNhap.Items.Add("Chọn hóa đơn");
            DataTable dataTable = getDataHoaDonNhap();
            DataView v = new DataView(dataTable);
            cboMaHoaDonNhap.DisplayMember = "sMaHoaDonNhap";
            cboMaHoaDonNhap.ValueMember = "sMaHoaDonNhap";
            cboMaHoaDonNhap.DataSource = v;
        }

        public void add()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string ma = cboMaHoaDonNhap.SelectedValue.ToString();

                using (SqlCommand cmd = new SqlCommand(sql_Add, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@mahang", txtMaHangNhap.Text);
                    cmd.Parameters.AddWithValue("@ten", txtTenHangHoa.Text);
                    cmd.Parameters.AddWithValue("@mahoadon", ma);
                    cmd.Parameters.AddWithValue("@mausac", txtMauSac.Text);
                    cmd.Parameters.AddWithValue("@dactinh", txtDacTinh.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                }
            }
            showHangNhap();
        }

        public void delete()
        {
            DataTable dtNhanVien = (DataTable)grHangNhap.DataSource;
            DataRow row = dtNhanVien.Rows[grHangNhap.CurrentRow.Index];
            string ma = row["sMaHang"].ToString();

            DialogResult dr;
            dr = MessageBox.Show(string.Format("Bạn có muốn xóa {0} không ?", row["sTenHang"].ToString()),
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql_Delete, cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@mahang", ma);
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
            string maHD = cboMaHoaDonNhap.SelectedValue.ToString();
            DataTable dt = (DataTable)grHangNhap.DataSource;
            DataRow row = dt.Rows[grHangNhap.CurrentRow.Index];
            string ma = row["sMaHang"].ToString();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sql_Edit, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@mahang", ma);
                    cmd.Parameters.AddWithValue("@ten", txtTenHangHoa.Text);
                    cmd.Parameters.AddWithValue("@mahoadon", maHD);
                    cmd.Parameters.AddWithValue("@mausac", txtMauSac.Text);
                    cmd.Parameters.AddWithValue("@dactinh", txtDacTinh.Text);
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

            if (txtMaHangNhap.Text != string.Empty)
            {
                filter += string.Format(" AND sMaHang LIKE '%{0}%'", txtMaHangNhap.Text);
            }
            if (txtTenHangHoa.Text != string.Empty)
            {
                filter += string.Format(" AND sTenHang LIKE '%{0}%'", txtTenHangHoa.Text);
            }
            if (txtMauSac.Text != string.Empty)
            {
                filter += string.Format(" AND sMauSac LIKE '%{0}%'", txtMauSac.Text);
            }
            if (txtDacTinh.Text != string.Empty)
            {
                filter += string.Format(" AND sDacTinhKyThuat LIKE '%{0}%'", txtDacTinh.Text);
            }
            
            this.filter(filter);
        }
        private void filter(string filter)
        {

            DataTable dt = getDataHangNhap();
            DataView dv = new DataView(dt);
            dv.RowFilter = filter;
            grHangNhap.AutoGenerateColumns = false;
            grHangNhap.DataSource = dv;

        }

        private void HangNhapManagerForm_Load(object sender, EventArgs e)
        {
            showHangNhap();
            showNhomHangCBO();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnFunction.Visible = true;
            lbTitle.Text = "Thêm Hàng Nhập";
            btnOK.Text = "Thêm";
            txtMaHangNhap.Enabled = true;

            txtDacTinh.Text = "";
            txtMaHangNhap.Text = "";
            txtMauSac.Text = "";
            txtTenHangHoa.Text = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pnFunction.Visible = true;
            lbTitle.Text = "Sửa ";
            btnOK.Text = "Sửa";
            txtMaHangNhap.Enabled = false;

            DataTable dt = (DataTable)grHangNhap.DataSource;
            DataRow row = dt.Rows[grHangNhap.CurrentRow.Index];
            string ma = row["sMaHang"].ToString();
            if (ma == string.Empty)
            {
                MessageBox.Show("Chọn nhóm hàng cần sửa");
            }
            else
            {

                txtMaHangNhap.Text = ma;
                txtTenHangHoa.Text = row["sTenHang"].ToString();

                txtDacTinh.Text = row["sDacTinhKyThuat"].ToString();
                txtMauSac.Text = row["sMauSac"].ToString();
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

            txtMaHangNhap.Enabled = true;

            txtDacTinh.Text = "";
            txtMaHangNhap.Text = "";
            txtMauSac.Text = "";
            txtTenHangHoa.Text = "";
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
