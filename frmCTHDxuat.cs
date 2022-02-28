using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace GUI_PhuKienTheThao
{
    public partial class frmCTHDxuat : Form
    {
        public frmCTHDxuat()
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
                cmd = new SqlCommand("select maCTHDx, maHDx, tenSP, soluong from sanpham s, ChitietHDx c where s.maSP = c.maSP", con);
                adap = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adap.Fill(table);
                dgvCTXuat.DataSource = table;
                txtMaHD_hdx.Text = "Chọn mã hóa đơn...";
                con.Close();
            }
            catch(SqlException)
            {
                MessageBox.Show("Lỗi kết nối, vui lòng xem lại nguồn trước khi thử lại");
            }
        }

        void TaiDuLieu_theo_HDX()
        {
            try
            {
                con = new SqlConnection(strCon);
                con.Open();
                cmd = new SqlCommand("select maCTHDx, maHDx, tenSP, soluong from sanpham s, ChitietHDx c where s.maSP = c.maSP and mahdx = '" + txtMaHD_hdx.Text+"'", con);
                adap = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adap.Fill(table);
                dgvCTXuat.DataSource = table;
                con.Close();
                VoHieuHoa_btn();
                btnThemMoi.Enabled = true;
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi kết nối, vui lòng xem lại nguồn trước khi thử lại");
            }
        }

        void makeData_cbb_sanpham_ct()
        {
            con = new SqlConnection(strCon);
            con.Open();
            cmd = new SqlCommand("select masp, tensp from sanpham", con);
            adap = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adap.Fill(table);
            txtMaSP_ct.DataSource = table;
            txtMaSP_ct.DisplayMember = "tensp";
            txtMaSP_ct.ValueMember = "masp";
            txtMaSP_ct.Text = "Chọn sản phẩm...";
        }


        void makeData_cbb_hoadon()
        {
            con = new SqlConnection(strCon);
            con.Open();
            cmd = new SqlCommand("select mahdx from hoadonxuat order by mahdx desc", con);
            adap = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adap.Fill(table);
            txtMaHD_hdx.DataSource = table;
            txtMaHD_hdx.DisplayMember = "mahdx";
            txtMaHD_hdx.ValueMember = "mahdx";
            //txtMaHD_hdx.Text = "Chọn mã hóa đơn...";
            txtNgayTao_hdx.Clear();
            txtMaKH_hdx.Clear();
            txtNgayTao_hdx.Enabled = false;
            txtMaKH_hdx.Enabled = false;
        }

        void VoHieuHoa_btn()
        {
            foreach(Control ctrl in grbTienIch.Controls)
            {
                if(ctrl is Button)
                {
                    (ctrl as Button).Enabled = false;
                }
            }
        }

        void KichHoat_btn()
        {
            foreach (Control ctrl in grbTienIch.Controls)
            {
                if (ctrl is Button)
                {
                    (ctrl as Button).Enabled = true;
                }
            }
        }

        void VoHieuHoa_txt()
        {
            foreach(Control ctrl in grbCTHDX.Controls)
            {
                if(ctrl is TextBox)
                {
                    (ctrl as TextBox).Enabled = false;
                }
            }
            txtMaSP_ct.Enabled = false;
        }

        void LamMoi_txt()
        {
            foreach (Control ctrl in grbCTHDX.Controls)
            {
                if (ctrl is TextBox)
                {
                    (ctrl as TextBox).Enabled = true;
                    (ctrl as TextBox).Clear();
                }
                else if(ctrl is ComboBox)
                {
                    (ctrl as ComboBox).Enabled = true;
                }
            }
            txtMaCTHD_ct.Enabled = false;
            txtSoLuong_ct.Focus();
            txtMaSP_ct.Text = "Chọn mã sản phẩm";
        }

        void makeData_bang_tam()
        {
            con = new SqlConnection(strCon);
            con.Open();
            cmd = new SqlCommand("select ngayxuat, makh from hoadonxuat where mahdx = '"+txtMaHD_hdx.Text+"'",con);
            adap = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adap.Fill(table);
            dgvBang_tam.DataSource = table;
            con.Close();
            try
            {
                txtNgayTao_hdx.Text = dgvBang_tam[0, 0].Value.ToString();
                txtMaKH_hdx.Text = dgvBang_tam[1, 0].Value.ToString();
            }
            catch(Exception)
            {
            }
        }
        private void txtMaHD_hdx_SelectedIndexChanged(object sender, EventArgs e)
        {
            LamMoi_txt();
            VoHieuHoa_txt();
            TaiDuLieu_theo_HDX();
            makeData_bang_tam();
            VoHieuHoa_btn();
            btnThemMoi.Enabled = true;
        }

        private void btnXemTatCa_Click(object sender, EventArgs e)
        {
            TaiDuLieu();
            LamMoi_txt();
            VoHieuHoa_txt();
        }
        
        private void dgvCTXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvCTXuat.CurrentRow.Index;
            txtMaCTHD_ct.Text = dgvCTXuat[0, i].Value.ToString();
            txtMaSP_ct.Text = dgvCTXuat[2, i].Value.ToString();
            txtSoLuong_ct.Text = dgvCTXuat[3, i].Value.ToString();
            txtMaSP_ct.Enabled = true;
            txtSoLuong_ct.Enabled = true;
            VoHieuHoa_btn();
            btnThemMoi.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }

        private void frmCTHDxuat_Load(object sender, EventArgs e)
        {
            VoHieuHoa_txt();
            txtMaCTHD_ct.Enabled = false;
            makeData_cbb_sanpham_ct();
            dgvBang_tam.Hide();
            dgvLayMaTuDong.Hide();
            TaiDuLieu();
            VoHieuHoa_btn();
            makeData_cbb_hoadon();
            btnThemMoi.Enabled = true;
            btnThemMoi.Focus();
        }

        void getIdAuto()
        {
            con = new SqlConnection(strCon);
            con.Open();
            cmd = new SqlCommand("select top(1) macthdx from ChitietHDx order by maCTHDx desc", con);
            adap = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adap.Fill(table);
            dgvLayMaTuDong.DataSource = table;
            if(table.Rows.Count < 1)
            {
                txtMaCTHD_ct.Text = "CTX001";
            }
            else
            {
                int i = Convert.ToInt32((dgvLayMaTuDong[0, 0].Value.ToString()).Substring(3, 3));
                if (i < 9)
                {
                    txtMaCTHD_ct.Text = "CTX00" + (i+1).ToString();
                }else if(i < 99)
                {
                    txtMaCTHD_ct.Text = "CTX0" + (i + 1).ToString();
                }
                else
                {
                    txtMaCTHD_ct.Text = "CTX" + (i + 1).ToString();
                }
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if(txtMaHD_hdx.Text == "Chọn mã hóa đơn...")
            {
                MessageBox.Show("Bạn cần chọn một hóa đơn để tiếp tục thao tác!");
            }
            else
            {
                LamMoi_txt();
                VoHieuHoa_btn();
                btnHuyBo.Enabled = true;
                btnLuu.Enabled = true;
                getIdAuto();
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            LamMoi_txt();
            VoHieuHoa_txt();
            VoHieuHoa_btn();
            btnThemMoi.Enabled = true;
        }

        private void txtMaHDX_ct_Click(object sender, EventArgs e)
        {
            KichHoat_btn();
            btnThemMoi.Enabled = false;
        }

        private void txtMaSP_ct_SelectedIndexChanged(object sender, EventArgs e)
        {
            KichHoat_btn();
            btnThemMoi.Enabled = false;
        }

        private void txtSoLuong_ct_TextChanged(object sender, EventArgs e)
        {
            KichHoat_btn();
            btnThemMoi.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaCTHD_ct.Text.Trim() == "" || txtMaHD_hdx.Text == "Chọn mã HDX" || txtMaSP_ct.Text == "Chọn mã sản phẩm")
            {
                MessageBox.Show("Bạn không nên để trống dữ liệu.");
            }
            else
            {
                try
                {
                    con = new SqlConnection(strCon);
                    con.Open();
                    cmd = new SqlCommand("insert into ChiTietHDX values('" + txtMaCTHD_ct.Text + "','" + txtMaHD_hdx.Text + "','" + txtMaSP_ct.SelectedValue.ToString() + "','" + txtSoLuong_ct.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    TaiDuLieu_theo_HDX();
                    con.Close();
                }
                catch(SqlException)
                {
                    MessageBox.Show("Số lượng sản phẩm trong kho hiện không đủ");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(strCon);
                con.Open();
                cmd = new SqlCommand("update chitiethdx set masp = '" + txtMaSP_ct.SelectedValue.ToString() + "', soluong = '" + txtSoLuong_ct.Text + "' where macthdx = '" + txtMaCTHD_ct.Text + "'", con);
                cmd.ExecuteNonQuery();
                TaiDuLieu();
                con.Close();
            }
            catch(SqlException)
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn có chắc muốn xóa dữ liệu?", "Click 'YES' để xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(a== DialogResult.Yes)
            {
                try
                {
                    con = new SqlConnection(strCon);
                    con.Open();
                    cmd = new SqlCommand("Delete from chitiethdx where macthdx = '" + txtMaCTHD_ct.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    if (txtMaHD_hdx.Text == "Chọn mã hóa đơn...")
                    {
                        TaiDuLieu();
                    }
                    else
                    {
                        TaiDuLieu_theo_HDX();
                    }
                    con.Close();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Lỗi");
                }
            }
        }
    }
}
