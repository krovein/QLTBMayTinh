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
    public partial class NhomHangManagerForm : Form
    {
        private string sql_GetNhomHang = "sp_GetNhomHang";
        private string sql_EditNhomHang = "sp_EditNhomHang";
        private string sql_AddNhomHang = "sp_AddNhomHang";
        private string sql_DeleteNhomHang = "sp_DeleteNhomHang";

        private string connectionString = ConfigurationManager.ConnectionStrings["db_QuanLyBanHangThietBiMayTinh"].ConnectionString;


        public NhomHangManagerForm()
        {
            InitializeComponent();

        }
        public DataTable getDataNhomHang()
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(sql_GetNhomHang, cnn))
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
        public void showDataNhomHang()
        {
            DataTable dt = getDataNhomHang();
            grNhomHang.AutoGenerateColumns = false;
            grNhomHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grNhomHang.DataSource = dt;
        }

        private void NhomHangManagerForm_Load(object sender, EventArgs e)
        {
            pnChucNang.Visible = false;
            showDataNhomHang();
        }

        private void btnAddNhomHang_Click(object sender, EventArgs e)
        {
            pnChucNang.Visible = true;
            lbTitle.Text = "Thêm Nhóm Hàng";
            btnOK.Text = "Thêm";
            txtMaNhomHang.Enabled = true;
            lbMaNhomHang.Enabled = true;

            txtMaNhomHang.Text = "";
            txtTenNhomHang.Text = "";
            txtMoTa.Text = "";

        }

        private void hienNhomHangTheoDieuKien(string filter)
        {

            DataTable dt = getDataNhomHang();
            DataView dv = new DataView(dt);
            dv.RowFilter = filter;
            grNhomHang.AutoGenerateColumns = false;
            grNhomHang.DataSource = dv;

        }
        private void btnOK_Click(object sender, EventArgs e)
        {        
                switch (btnOK.Text)
                {
                    case "Tìm kiếm":
                        string filter = "1=1";

                        if (txtMaNhomHang.Text != string.Empty)
                        {
                            filter += string.Format(" AND sMaNhomHang LIKE '%{0}%'", txtMaNhomHang.Text);
                        }
                        if (txtTenNhomHang.Text != string.Empty)
                        {
                            filter += string.Format(" AND sTenNhomHang LIKE '%{0}%'", txtTenNhomHang.Text);
                        }
                        if (txtMoTa.Text != string.Empty)
                        {
                            filter += string.Format(" AND sMoTa LIKE '%{0}%'", txtMoTa.Text);
                        }
                        hienNhomHangTheoDieuKien(filter);
                        break;
                    case "Sửa":
                        DataTable dt = (DataTable)grNhomHang.DataSource;
                        DataRow row = dt.Rows[grNhomHang.CurrentRow.Index];
                        string ma = row["sMaNhomHang"].ToString();
                   
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            using (SqlCommand cmd = new SqlCommand(sql_EditNhomHang, conn))
                            {
                                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@ma", ma);
                                cmd.Parameters.AddWithValue("@ten", txtTenNhomHang.Text);
                                cmd.Parameters.AddWithValue("@mota", txtMoTa.Text);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();

                            }
                        }

                        showDataNhomHang();
                        break;

                    case "Thêm":
                        
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            using (SqlCommand cmd = new SqlCommand(sql_AddNhomHang, conn))
                            {
                                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@ma", txtMaNhomHang.Text);
                                cmd.Parameters.AddWithValue("@ten", txtTenNhomHang.Text);
                                cmd.Parameters.AddWithValue("@mota", txtMoTa.Text);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();

                            }
                        }
                        showDataNhomHang();
                        break;
                
            }
        }

        private void btnEditNhomHang_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)grNhomHang.DataSource;
            DataRow row = dt.Rows[grNhomHang.CurrentRow.Index];
            string ma = row["sMaNhomHang"].ToString();
            if (ma == string.Empty)
            {
                MessageBox.Show("Chọn nhóm hàng cần sửa");
            }
            else {

                btnOK.Text = "Sửa";
                pnChucNang.Visible = true;
                txtMaNhomHang.Enabled = false;
                lbMaNhomHang.Enabled = false;
                txtMaNhomHang.Text = ma;

                
                txtTenNhomHang.Text = row["sTenNhomHang"].ToString();
                txtMoTa.Text = row["sMoTa"].ToString();
               }
        }

        private void btnSearchNhomHang_Click(object sender, EventArgs e)
        {

            btnOK.Text = "Tìm kiếm";
            pnChucNang.Visible = true;
            txtMaNhomHang.Enabled = true;
            lbMaNhomHang.Enabled = true;
            txtMaNhomHang.Text = "";
            txtTenNhomHang.Text = "";
            txtMoTa.Text = "";

        }

        private void btnDeleteNV_Click(object sender, EventArgs e)
        {
           
            DataTable dtNhanVien = (DataTable)grNhomHang.DataSource;
            DataRow row = dtNhanVien.Rows[grNhomHang.CurrentRow.Index];
            string ma= row["sMaNhomHang"].ToString();

            DialogResult dr;
            dr = MessageBox.Show(string.Format("Bạn có muốn xóa {0} không ?", row["sTenNhomHang"].ToString()),
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql_DeleteNhomHang, cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ma", ma);
                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        cnn.Close();
                    }
                }
                showDataNhomHang();
            }
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
