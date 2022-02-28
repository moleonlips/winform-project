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
    public partial class frmQLLoaiSP : Form
    {
        public frmQLLoaiSP()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adap;
        string strcon = @"Data Source=DESKTOP-3239J5Q\SQLEXPRESS;Initial Catalog=PhuKienTheThao;Integrated Security=True";

        void KetNoi()
        {
            try
            {
                con = new SqlConnection(strcon);
                con.Open();
                cmd = new SqlCommand("select * from loaisp", con);
                adap = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adap.Fill(table);
                dataGridView1.DataSource = table;
            }
            catch(SqlException)
            {
                MessageBox.Show("Lỗi hệ thống");
            }
            finally
            {
                con.Close();
            }
        }

        int KiemTraMa()
        {
            int sl = 0;
            con = new SqlConnection(strcon);
            con.Open();
            cmd = new SqlCommand("select count (*) maloaisp from loaisp where maloaisp = '" + txtMaLoaiSP.Text + "'", con);
            sl = (int)cmd.ExecuteScalar(); // dùng với các câu truy vấn trả về giá trị vô hướng
            con.Close();
            return sl;
        }

        void KichHoat_btn()
        {
            foreach (Control control in grbTienIch.Controls)
            {
                if (control is Button)
                    (control as Button).Enabled = true;
            }
        }

        void VohieuHoa_btn()
        {
            foreach (Control control in grbTienIch.Controls)
            {
                if (control is Button)
                    (control as Button).Enabled = false;
            }
        }

        void ThucThi(string sql)
        {
            con = new SqlConnection(strcon);
            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        void VoHieuHoa_txt()
        {
            foreach (Control control in grbNhapLieu.Controls)
            {
                if (control is TextBox)
                {
                    (control as TextBox).Enabled = false;
                }
            }
        }


        void LamMoi_txt()
        {

            foreach (Control control in grbNhapLieu.Controls)
            {
                if (control is TextBox)
                {
                    (control as TextBox).Clear();
                    txtMaLoaiSP.Focus();
                }
            }
        }


        void KichHoat_txt()
        {
            foreach (Control control in grbNhapLieu.Controls)
            {
                if (control is TextBox)
                    (control as TextBox).Enabled = true;
            }
        }


        private void btnOut_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("Nhấn 'Yes' để tới sảnh!", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (x == DialogResult.Yes)
            {
                frmMain f = new frmMain();
                f.Show();
            }
        }

        private void frmQLLoaiSP_Load(object sender, EventArgs e)
        {
            KetNoi();
            VoHieuHoa_txt();
            VohieuHoa_btn();
            btnThemMoi.Enabled = true;
        }

        int i;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = dataGridView1.CurrentRow.Index;
            txtMaLoaiSP.Text = dataGridView1[0, i].Value.ToString();
            txtTenLoaiSP.Text = dataGridView1[1, i].Value.ToString();
            txtChucNang.Text = dataGridView1[2, i].Value.ToString();
            KichHoat_btn();
            KichHoat_txt();
            txtMaLoaiSP.Enabled = false;
            btnLuu.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaLoaiSP.Text.Trim() != "" || txtTenLoaiSP.Text.Trim() != "")
                {
                    if (KiemTraMa() == 0)
                    {
                        ThucThi("insert into loaisp values('"+txtMaLoaiSP.Text+"', N'"+txtTenLoaiSP.Text+"', N'"+txtChucNang.Text+"')");
                        MessageBox.Show("Thêm thành công!");
                        KetNoi();
                    }
                    else { MessageBox.Show("Bạn không thể sử dụng mã này!"); }
                }
                else
                {
                    MessageBox.Show("Bạn không nên để trống dữ liệu!");
                }
            }
            catch(SqlException)
            {
                MessageBox.Show("Mã loại sản phẩm phải là duy nhất trong hệ thống!");
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            KichHoat_txt();
            LamMoi_txt();
            KichHoat_btn();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Tất cả dữ liệu liên quan cũng sẽ bị xóa theo, bạn có chắc muốn xóa?", "Xác nhận xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (a == DialogResult.OK)
            {
                ThucThi("delete loaisp where maloaisp = '"+txtMaLoaiSP.Text+"'");
                MessageBox.Show("Đã xóa!");
                LamMoi_txt();
                KetNoi();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenLoaiSP.Text.Trim() != "")
                {
                    ThucThi("update LoaiSP set TenLoaiSP = N'" + txtTenLoaiSP.Text + "', ChucNang = N'" + txtChucNang.Text + "' where MaLoaiSP = N'" + txtMaLoaiSP.Text + "'");
                    MessageBox.Show("Cập nhật thành công");
                    LamMoi_txt();
                    KetNoi();
                }
                else
                {
                    MessageBox.Show("Bạn không nên để trống dữ liệu đầu vào!");
                }
            }
            catch(SqlException)
            {
                MessageBox.Show("Lỗi, xem lại mã nguồn");
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            LamMoi_txt();
            VoHieuHoa_txt();
            VohieuHoa_btn();
            btnThemMoi.Enabled = true;
        }
    }
}
