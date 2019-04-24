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
    public partial class NhaCungCapManagerForm : Form, Interface
    {

        private string connectionString = ConfigurationManager.ConnectionStrings["db_QuanLyBanHangThietBiMayTinh"].ConnectionString;

        private string sql_GetAll = "sp_GetAllNCC";
        private string sql_Edit = "sp_EditNCC";
        private string sql_Add = "sp_AddNCC";
        private string sql_Delete = "sp_DeleteNCC";
        public NhaCungCapManagerForm()
        {
            InitializeComponent();
        }


        private DataTable getDataNCC()
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

        private void showNCC()
        {
            DataTable dt = getDataNCC();
            gridview.AutoGenerateColumns = false;

            gridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridview.DataSource = dt;
        }
        public void add()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                
                using (SqlCommand cmd = new SqlCommand(sql_Add, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ma", txtMa.Text);
                    cmd.Parameters.AddWithValue("@ten", txtTen.Text);
                    cmd.Parameters.AddWithValue("@diachi", txtDiaChi.Text);
                    cmd.Parameters.AddWithValue("@sodienthoai", txtSDT.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                }
            }
            showNCC();
        }

        public void delete()
        {
            DataTable dtNhanVien = (DataTable)gridview.DataSource;
            DataRow row = dtNhanVien.Rows[gridview.CurrentRow.Index];
            string ma = row["sMaNCC"].ToString();

            DialogResult dr;
            dr = MessageBox.Show(string.Format("Bạn có muốn xóa {0} không ?", row["sTenNCC"].ToString()),
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql_Delete, cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ma", ma);
                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        cnn.Close();
                    }
                }
                showNCC();
            }
        }

        public void edit()
        {
            
            DataTable dt = (DataTable)gridview.DataSource;
            DataRow row = dt.Rows[gridview.CurrentRow.Index];
            string ma = row["sMaNCC"].ToString();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sql_Edit, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ma", txtMa.Text);
                    cmd.Parameters.AddWithValue("@ten", txtTen.Text);
                    cmd.Parameters.AddWithValue("@diachi", txtDiaChi.Text);
                    cmd.Parameters.AddWithValue("@sodienthoai", txtSDT.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                }
            }

            showNCC();
        }

        public void search()
        {
            string filter = "1=1";

            if (txtMa.Text != string.Empty)
            {
                filter += string.Format(" AND sMaNhanVien LIKE '%{0}%'", txtMa.Text);
            }
            if (txtTen.Text != string.Empty)
            {
                filter += string.Format(" AND sTenNhanVien LIKE '%{0}%'", txtTen.Text);
            }
            if (txtDiaChi.Text != string.Empty)
            {
                filter += string.Format(" AND sDiaChi LIKE '%{0}%'", txtDiaChi.Text);
            }
            if (txtSDT.Text != string.Empty)
            {
                filter += string.Format(" AND sSoDienThoai LIKE '%{0}%'", txtSDT.Text);
            }
            this.filter(filter);
        }

        private void NhaCungCapManagerForm_Load(object sender, EventArgs e)
        {
            showNCC();
            pnFunction.Visible = false;
        }

        private void filter(string filter)
        {

            DataTable dt = getDataNCC();
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

        private void btnAddNV_Click(object sender, EventArgs e)
        {
            pnFunction.Visible = true;
            lbTitle.Text = "Thêm";
            btnOK.Text = "Thêm";
            txtMa.Enabled = true;

            txtMa.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtTen.Text = "";

        }

        private void btnEditNV_Click(object sender, EventArgs e)
        {
            pnFunction.Visible = true;
            lbTitle.Text = "Sửa";
            btnOK.Text = "Sửa";
            txtMa.Enabled = false;

            DataTable dt = (DataTable)gridview.DataSource;
            DataRow row = dt.Rows[gridview.CurrentRow.Index];
            string ma = row["sMaNCC"].ToString();
            if (ma == string.Empty)
            {
                MessageBox.Show("Chọn nhóm hàng cần sửa");
            }
            else
            {

                txtMa.Text = ma;
                txtTen.Text = row["sTenNCC"].ToString();

                txtDiaChi.Text = row["sDiaChi"].ToString();
                txtSDT.Text = row["sSoDienThoai"].ToString();
            }
        }

        private void btnDeleteNV_Click(object sender, EventArgs e)
        {
            pnFunction.Visible = false;
            delete();
        }

        private void btnSearchNV_Click(object sender, EventArgs e)
        {
            pnFunction.Visible = true;
            lbTitle.Text = "Tìm kiếm";
            btnOK.Text = "Tìm kiếm";

            txtMa.Enabled = true;

            txtMa.Text = "";
            txtTen.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
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
