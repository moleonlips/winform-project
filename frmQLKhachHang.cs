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
    public partial class frmQLKhachHang : Form
    {
        public frmQLKhachHang()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adap;
        string strCon = @"Data Source=DESKTOP-3239J5Q\SQLEXPRESS;Initial Catalog=PhuKienTheThao;Integrated Security=True";


        void TaiDuLieu()
        {
            try
            {
                con = new SqlConnection(strCon);
                con.Open();
                cmd = new SqlCommand("select * from khachhang", con);
                adap = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adap.Fill(table);
                dgvDSKH.DataSource = table;
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối");
            }
            finally
            {
                con.Close();
            }
        }

        int KiemtraMa()
        {
            int sl = 0;
            con = new SqlConnection(strCon);
            con.Open();
            cmd = new SqlCommand("select count (*) from khachhang where makh = '"+txtMaKH.Text+"'", con);
            sl = (int)cmd.ExecuteScalar();
            return sl;
        }

        void VoHieuHoa_btn()
        {
            foreach (Control ctrl in grbTienIch.Controls)
            {
                if (ctrl is Button)
                    (ctrl as Button).Enabled = false;
            }
        }


        void KichHoat_btn()
        {
            foreach (Control ctrl in grbTienIch.Controls)
            {
                if (ctrl is Button)
                    (ctrl as Button).Enabled = true;
            }
        }


        void VoHieuHoa_txt()
        {
            foreach(Control ctrl in grbNhapLieu.Controls)
            {
                if (ctrl is TextBox)
                    (ctrl as TextBox).Enabled = false;
            }
        }

        void KichHoat_txt()
        {
            foreach (Control ctrl in grbNhapLieu.Controls)
            {
                if (ctrl is TextBox)
                    (ctrl as TextBox).Enabled = true;
            }
        }

        void LayMaTuDong()
        {
            con = new SqlConnection(strCon);
            con.Open();
            cmd = new SqlCommand("select top(1) makh from KhachHang order by maKH desc", con);
            adap = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adap.Fill(table);
            dgvLayMa.DataSource = table;
            if(table.Rows.Count < 1)
            {txtMaKH.Text = "KH001";}
            else
            {
                try 
                {
                    int i = Int32.Parse(dgvLayMa[0, 0].Value.ToString().Substring(2, 3));
                    if (i < 9)
                    {
                        txtMaKH.Text = "KH00" + (i + 1).ToString();
                    }
                    else if (i < 99)
                    {
                        txtMaKH.Text = "KH0" + (i + 1).ToString();
                    }
                    else
                    {
                        txtMaKH.Text = "KH" + (i + 1).ToString();
                    }
                } 
                catch(SqlException){}
            }
        }

        void LamMoi_txt()
        {
            KichHoat_txt();
            foreach (Control ctrl in grbNhapLieu.Controls)
            {
                if (ctrl is TextBox)
                    (ctrl as TextBox).Clear();
            }
            KichHoat_txt();
            txtMaKH.Enabled = false;
            txtTenKH.Focus();
        }

        private void frmQLKhachHang_Load(object sender, EventArgs e)
        {
            dgvLayMa.Hide();
            TaiDuLieu();
            VoHieuHoa_txt();
            VoHieuHoa_btn();
            btnThemMoi.Enabled = true;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            LamMoi_txt();
            KichHoat_btn();
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            LayMaTuDong();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            LamMoi_txt();
            VoHieuHoa_txt();
            VoHieuHoa_btn();
            btnThemMoi.Enabled = true;
        }


        int id;
        private void dgvDSKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dgvDSKH.CurrentRow.Index;
            txtMaKH.Text = dgvDSKH[0, id].Value.ToString();
            txtTenKH.Text = dgvDSKH[1, id].Value.ToString();
            txtDiaChi.Text = dgvDSKH[2, id].Value.ToString();
            KichHoat_btn();
            btnLuu.Enabled = false;
            KichHoat_txt();
            txtMaKH.Enabled = false;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtMaKH.Text.Trim() != "" || txtTenKH.Text.Trim() != "")
            {
                try
                {
                    con = new SqlConnection(strCon);
                    con.Open();
                    cmd = new SqlCommand("insert into khachhang values ('" + txtMaKH.Text + "',N'" + txtTenKH.Text + "',N'" + txtDiaChi.Text + "')",con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công!");
                    TaiDuLieu();
                    con.Close();
                }
                catch(SqlException)
                {
                    MessageBox.Show("Bạn cần chắc rằng những khách hàng khách nhau có mã khác nhau!");
                }
            }
            else
            {
                MessageBox.Show("Bạn cần điền đủ thông tin trước khi thực hiện thêm mới!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("Các dữ liệu liên quan cũng sẽ bị xóa theo, bạn có chắc muốn xóa dữ liệu?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (x == DialogResult.Yes)
            {
                try
                {
                    con = new SqlConnection(strCon);
                    con.Open();
                    cmd = new SqlCommand("delete khachhang where makh = '" + txtMaKH.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công!");
                    TaiDuLieu();
                    con.Close();
                    LamMoi_txt();
                    VoHieuHoa_txt();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không xác định được dữ liệu muốn xóa!");
                }
            }
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            if(txtTenKH.Text.Trim() != "")
            {
                try
                {
                    con = new SqlConnection(strCon);
                    con.Open();
                    cmd = new SqlCommand("update khachhang set tenkh = N'" + txtTenKH.Text + "', diachi = N'"+txtDiaChi.Text+"' where makh = '"+txtMaKH.Text+"'", con);
                    cmd.ExecuteNonQuery();
                    TaiDuLieu();
                    MessageBox.Show("Sửa thành công!");
                    con.Close();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Đã có lỗi, thực thi thất bại!");
                }
            }
            else 
            {
                MessageBox.Show("Bạn không nên để trống dữ liệu!");
            }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            frmMain f = new frmMain();
            f.Show();
        }
    }
}
