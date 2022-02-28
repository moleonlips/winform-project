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
    public partial class frmNewCustom : Form
    {
        public frmNewCustom()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adap;
        string strCon = @"Data Source=DESKTOP-3239J5Q\SQLEXPRESS;Initial Catalog=PhuKienTheThao;Integrated Security=True";


        private void frmNewCustom_Load(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            LayMaTuDong();
            txtMa.Enabled = false;
            txtTen.Focus();
        }

        void LayMaTuDong()
        {
            con = new SqlConnection(strCon);
            con.Open();
            cmd = new SqlCommand("select top(1) makh from KhachHang order by maKH desc", con);
            adap = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adap.Fill(table);
            dataGridView1.DataSource = table;
            if (table.Rows.Count < 1)
            { txtMa.Text = "KH001"; }
            else
            {
                try
                {
                    int i = Int32.Parse(dataGridView1[0, 0].Value.ToString().Substring(2, 3));
                    if (i < 9)
                    {
                        txtMa.Text = "KH00" + (i + 1).ToString();
                    }
                    else if (i < 99)
                    {
                        txtMa.Text = "KH0" + (i + 1).ToString();
                    }
                    else
                    {
                        txtMa.Text = "KH" + (i + 1).ToString();
                    }
                }
                catch (SqlException) { }
            }
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            if(txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Bạn không được để trống dữ liệu");
            }
            try
            {
                con = new SqlConnection(strCon);
                con.Open();
                cmd = new SqlCommand("insert into khachhang values('"+txtMa.Text+"',N'"+txtTen.Text+"',N'"+txtDiaChi.Text+"')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công!");
                con.Close();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Lỗi! Xem lại nguồn.");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
