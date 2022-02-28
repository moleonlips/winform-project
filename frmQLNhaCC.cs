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
    public partial class frmQLNhaCC : Form
    {
        public frmQLNhaCC()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adap;
        string strcon = @"Data Source=DESKTOP-3239J5Q\SQLEXPRESS;Initial Catalog=PhuKienTheThao;Integrated Security=True";

        void VoHieuHoa_btn()
        {
            foreach(Control control in grbNutBam.Controls)
            {
                if (control is Button)
                    (control as Button).Enabled = false;
            }
        }

        int KiemTraMa()
        {
            int sl = 0;
            con = new SqlConnection(strcon);
            con.Open();
            cmd = new SqlCommand("select count (*) mancc from NhaCungCap where mancc = '" + txtMaNCC + "'",con);
            sl = (int)cmd.ExecuteScalar();
            con.Close();
            return sl;
        }

        void KichHoat_btn()
        {
            foreach (Control control in grbNutBam.Controls)
            {
                if (control is Button)
                    (control as Button).Enabled = true;
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
                    txtMaNCC.Focus();
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

        void KetNoi()
        {
            try
            {
                con = new SqlConnection(strcon);
                con.Open();
                cmd = new SqlCommand("select * from nhacungcap", con);
                adap = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adap.Fill(table);
                dgvDanhMuc.DataSource = table;
            }
            catch(SqlException)
            {
                MessageBox.Show("Lỗi kết nối!");
            }
            finally
            {
                con = new SqlConnection(strcon);
                con.Close();
            }
        }

        void LayMaTuDong()
        {
            con = new SqlConnection(strcon);
            con.Open();
            cmd = new SqlCommand("select top(1) mancc from NhaCungCap order by maNCC desc", con);
            adap = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            dgvLayMa.DataSource = table;
            if(table.Rows.Count < 1)
            {
                txtMaNCC.Text = "NCC01";
            }
            else
            {
                try
                {
                    int i = Int32.Parse(dgvLayMa[0, 0].Value.ToString().Substring(3, 2));
                    if (i < 9)
                    {
                        txtMaNCC.Text = "NCC0" + (i + 1).ToString();
                    }
                    else
                    {
                        txtMaNCC.Text = "NCC" + (i + 1).ToString();
                    }
                }
                catch (SqlException) { }
            }
        }

        private void frmQLNhaCC_Load(object sender, EventArgs e)
        {
            dgvLayMa.Hide();
            KetNoi();
            VoHieuHoa_txt();
            VoHieuHoa_btn();
            btnThemMoi.Enabled = true;
        }


        int index;
        private void dgvDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = dgvDanhMuc.CurrentRow.Index;
            txtMaNCC.Text = dgvDanhMuc[0, index].Value.ToString();
            txtDiaChi.Text = dgvDanhMuc[1, index].Value.ToString();
            txtSoDT.Text = dgvDanhMuc[2, index].Value.ToString();
            txtTenNCC.Text = dgvDanhMuc[3, index].Value.ToString();
            KichHoat_txt();
            KichHoat_btn();
            btnLuu.Enabled = false;
            txtMaNCC.Enabled = false;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            KichHoat_txt();
            LamMoi_txt();
            KichHoat_btn();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            LayMaTuDong();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaNCC.Text.Trim() != "" || txtTenNCC.Text.Trim() != "")
                {
                    if (KiemTraMa() == 1)
                    {
                        MessageBox.Show("Bạn không thể sử dụng mã này!");
                    }
                    else
                    {
                        ThucThi("insert into nhacungcap values ('" + txtMaNCC.Text + "', N'" + txtDiaChi.Text + "', '" + txtSoDT.Text + "', N'" + txtTenNCC.Text + "')");
                        MessageBox.Show("Thêm thành công");
                        KetNoi();
                    }
                }
                else
                {
                    MessageBox.Show("Bạn không nên để trống dữ liệu!");
                }
            }
            catch(SqlException)
            {
                MessageBox.Show("Mã của nhà cung cấp phải là duy nhất trong toàn hệ thống!");
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            LamMoi_txt();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("Xóa dữ liệu?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(x == DialogResult.Yes)
            {
                ThucThi("delete nhacungcap where mancc = '" + txtMaNCC.Text + "'");
                MessageBox.Show("Xóa thành công!");
                KetNoi();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(txtTenNCC.Text.Trim() != "")
            {
                ThucThi("update nhacungcap set diachi = N'" + txtDiaChi.Text + "', sodt = '" + txtSoDT.Text + "', tenncc = N'" + txtTenNCC.Text + "' where mancc = '"+txtMaNCC.Text+"'");
                MessageBox.Show("Cập nhật thành công");
                KetNoi();
            }
            else
            {
                MessageBox.Show("Bạn không nên để trống dữ liệu");
            }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("Nhấn 'Yes' để tới sảnh!", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(x == DialogResult.Yes)
            {
                frmMain f = new frmMain();
                f.Show();
            }
        }
    }
}
