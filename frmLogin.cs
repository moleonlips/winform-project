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
    public partial class frmLogin : Form
    {   
        void MoKetNoi()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3239J5Q\SQLEXPRESS;Initial Catalog=PhuKienTheThao;Integrated Security=True");
            con.Open();
        }

        void DongKetNoi()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3239J5Q\SQLEXPRESS;Initial Catalog=PhuKienTheThao;Integrated Security=True");
            con.Close();
        }

        void TaiDuLieuAccount()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3239J5Q\SQLEXPRESS;Initial Catalog=PhuKienTheThao;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from taikhoan", con);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adap.Fill(table);
        }

        bool KiemTraTaiKhoan()
        {
            bool ok;
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3239J5Q\SQLEXPRESS;Initial Catalog=PhuKienTheThao;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from taikhoan where taikhoan = '" + txtIDdnh.Text + "' and matkhau = '" + txtPassdnh.Text + "'", con);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adap.Fill(table);
            if (table.Rows.Count != 1)
            {
                ok = false;
            }
            else
            {
                ok = true;
            }
            return ok;
        }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            pnlDangKi.Hide();
            pnlDangNhap.Hide();
        }

        private void btnDangNhap1_Click(object sender, EventArgs e)
        {
            TaiDuLieuAccount();
            txtIDdnh.Clear();
            txtPassdnh.Clear();
            pnlDangNhap.Show();
            pnlDangKi.Hide();
            txtIDdnh.Focus();
        }

        private void btnDangKi1_Click(object sender, EventArgs e)
        {
            pnlDangKi.Show();
            pnlDangNhap.Hide();
        }

        private void btnHuyBodki_Click(object sender, EventArgs e)
        {
            pnlDangKi.Hide();
        }

        private void btnHuyBodnh_Click(object sender, EventArgs e)
        {
            pnlDangNhap.Hide();
        }

        private void btnDangNhap2_Click(object sender, EventArgs e)
        {
            if(KiemTraTaiKhoan() == true)
            {
                frmMain fm = new frmMain();
                fm.ShowDialog();
                this.Hide();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!");
            }
        }

        private void btnDangKi2_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtPassdki1.Text == txtPassdki2.Text && txtPassdki1.Text.Trim().Length >= 6)
                {
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3239J5Q\SQLEXPRESS;Initial Catalog=PhuKienTheThao;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO TAIKHOAN VALUES('"+txtIDdki.Text+"','"+txtPassdki1.Text+"')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đăng kí thành công!");
                }
                else if(txtIDdki.Text.Trim() == "" || txtPassdki1.Text.Trim().Length < 6)
                {
                    MessageBox.Show("Dữ liệu đăng kí không hợp lệ!\nQuy định: Dữ liệu không được để trống, mật khẩu nhiều hơn 6 kí tự\nvà nhắc lại mật khẩu chính xác");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Tài khoản đã tồn tại");
            }
            finally
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3239J5Q\SQLEXPRESS;Initial Catalog=PhuKienTheThao;Integrated Security=True");
                con.Close();
                foreach(Control control in pnlDangKi.Controls)
                {
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    txtIDdki.Focus();
                }
            }
        }
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
