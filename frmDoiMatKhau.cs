using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
namespace GUI_PhuKienTheThao
{
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adap;
        string strcon = @"Data Source=DESKTOP-3239J5Q\SQLEXPRESS;Initial Catalog=PhuKienTheThao;Integrated Security=True";
        bool KtraTaiKhoan()
        {
            con = new SqlConnection(strcon);
            con.Open();
            string sql = "select * from taikhoan where taikhoan = '" + txtTaikhoan.Text + "' and matkhau = '" + txtMKcu.Text + "'";
            cmd = new SqlCommand(sql, con);
            adap = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adap.Fill(table);
            if(table.Rows.Count != 1)
            {
                return false;
            }
            return true;
        }

        void ThucThi(string sql)
        {
            con = new SqlConnection(strcon);
            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if(KtraTaiKhoan() == true && txtMKmoi1.Text.Trim().Length != 0)
            {
                if(txtMKmoi1.Text == txtMKmoi2.Text)
                {
                    ThucThi("update taikhoan set matkhau = '" + txtMKmoi1.Text + "'where taikhoan = '" + txtTaikhoan.Text + "'");
                    MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else { MessageBox.Show("Nhắc lại mật khẩu không chính xác!"); }                
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác, nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtTaikhoan.Clear();
            txtMKcu.Clear();
            txtMKmoi1.Clear();
            txtMKmoi2.Clear();
        }

        private void btnHuybo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            txtTaikhoan.Focus();
        }

        private void frmDoiMatKhau_Click(object sender, EventArgs e)
        {
            txtTaikhoan.Focus();
        }
    }
}
