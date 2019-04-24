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
    public partial class LoginForm : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["db_QuanLyBanHangThietBiMayTinh"].ConnectionString;
        string sqlGetUser = "sp_GetUser";

        public LoginForm()
        {
            InitializeComponent();
        }

        private DataTable getUser()
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(sqlGetUser, cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable tbl = new DataTable("tblUser");
                        da.Fill(tbl);
                        return tbl;
                    }
                }
                cnn.Close();
            }
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string txtName = txtUsername.Text;
            string txtPw = txtPassword.Text;
            string username;
            string password;

            DataTable dt = getUser();
            foreach (DataRow dr in dt.Rows)
            {
                username = dr["sUserName"].ToString();
                password = dr["sPassword"].ToString();
                if (username.Equals(txtName) && password.Equals(txtPw))
                    {
                    Form f = searchOpenedForm("ManagerForm");
                    if (f == null)
                    {
                        f = new ManagerForm();

                    }
                    f.Show();
                    f.Activate();
                    this.Hide();
                    
                }
                else MessageBox.Show("Kiểm tra lại thông tin đăng nhập");
                
            }
        }

        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn thoát khỏi chương trình không ?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
