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
    public partial class HangHoaManagerForm : Form, Interface
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["db_QuanLyBanHangThietBiMayTinh"].ConnectionString;

        private string sql_GetAll = "sp_GetAllHangHoa";
        private string sql_Edit = "sp_EditHangHoa";
        private string sql_Add = "sp_AddHangHoa";
        private string sql_Delete = "sp_DeleteHangHoa";

        private string sql_GetNhomHang = "sp_GetNhomHang";

        public HangHoaManagerForm()
        {
            InitializeComponent();
        }

        
        private void HangHoaManagerForm_Load(object sender, EventArgs e)
        {
            showHangHoa();
            showNhomHangCBO();
            pnFunction.Visible = false;
        }

        private DataTable getDataHangHoa()
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(sql_GetAll, cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable tbl = new DataTable("tblHangHoa");
                        da.Fill(tbl);
                        return tbl;
                    }
                }
                cnn.Close();
            }
        }

        private void showHangHoa()
        {
            DataTable dt = getDataHangHoa();
            grHangHoa.AutoGenerateColumns = false;
          
            grHangHoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grHangHoa.DataSource = dt;
        }



        private DataTable getDataNhomHang()
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

        private void showNhomHangCBO()
        {
            cboNhomHang.Items.Add("Chọn nhóm hàng");
            DataTable dataTable = getDataNhomHang();
            DataView v = new DataView(dataTable);
            cboNhomHang.DisplayMember = "sTenNhomHang";
            cboNhomHang.ValueMember = "sMaNhomHang";
            cboNhomHang.DataSource = v;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnFunction.Visible = true;
            lbTitle.Text = "Thêm Hàng Hóa";
            btnOK.Text = "Thêm";
            txtMaHangHoa.Enabled = true;

            txtDacTinh.Text = "";
            txtMaHangHoa.Text = "";
            txtMauSac.Text = "";
            txtTenHangHoa.Text = "";
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pnFunction.Visible = true;
            lbTitle.Text = "Sửa Hàng Hóa";
            btnOK.Text = "Sửa";
            txtMaHangHoa.Enabled = false;

            DataTable dt = (DataTable)grHangHoa.DataSource;
            DataRow row = dt.Rows[grHangHoa.CurrentRow.Index];
            string ma = row["sMaHang"].ToString();
            if (ma == string.Empty)
            {
                MessageBox.Show("Chọn nhóm hàng cần sửa");
            }
            else
            {

                txtMaHangHoa.Text = ma;
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

            txtMaHangHoa.Enabled = true;

            txtDacTinh.Text = "";
            txtMaHangHoa.Text = "";
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

        private void hienNhomHangTheoDieuKien(string filter)
        {

            DataTable dt = getDataHangHoa();
            DataView dv = new DataView(dt);
            dv.RowFilter = filter;
            grHangHoa.AutoGenerateColumns = false;
            grHangHoa.DataSource = dv;

        }

        public void add()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string maNhomHang = cboNhomHang.SelectedValue.ToString();
                using (SqlCommand cmd = new SqlCommand(sql_Add, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@mahang", txtMaHangHoa.Text);
                    cmd.Parameters.AddWithValue("@tenhang", txtTenHangHoa.Text);
                    cmd.Parameters.AddWithValue("@manhomhang", maNhomHang);
                    cmd.Parameters.AddWithValue("@mausac", txtMauSac.Text);
                    cmd.Parameters.AddWithValue("@dactinh", txtDacTinh.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                }
            }
            showHangHoa();
        }

        public void edit()
        {

            string maNhomHang = cboNhomHang.SelectedValue.ToString();
            DataTable dt = (DataTable)grHangHoa.DataSource;
            DataRow row = dt.Rows[grHangHoa.CurrentRow.Index];
            string ma = row["sMaHang"].ToString();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sql_Edit, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@mahang", ma);
                    cmd.Parameters.AddWithValue("@tenhang", txtTenHangHoa.Text);
                    cmd.Parameters.AddWithValue("@manhomhang", maNhomHang);
                    cmd.Parameters.AddWithValue("@mausac", txtMauSac.Text);
                    cmd.Parameters.AddWithValue("@dactinh", txtDacTinh.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                }
            }

            showHangHoa();
        }

        public void delete()
        {
            DataTable dtNhanVien = (DataTable)grHangHoa.DataSource;
            DataRow row = dtNhanVien.Rows[grHangHoa.CurrentRow.Index];
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
                showHangHoa();
            }
        }

        public void search()
        {
            string filter = "1=1";

            if (txtMaHangHoa.Text != string.Empty)
            {
                filter += string.Format(" AND sMaHang LIKE '%{0}%'", txtMaHangHoa.Text);
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
            if (cboNhomHang.SelectedText.ToString() != string.Empty)
            {
                filter += string.Format(" AND sTenNhomHang LIKE '%{0}%'", cboNhomHang.SelectedText.ToString());
            }
            hienNhomHangTheoDieuKien(filter);
        }
    }
}
