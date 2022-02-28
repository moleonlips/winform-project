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
    public partial class frmCTHDnhap : Form
    {
        public frmCTHDnhap()
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
                cmd = new SqlCommand("select maCTHDN, maHDN, tenSP, soluong from sanpham s, ChitietHDN c where s.maSP = c.maSP", con);
                adap = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adap.Fill(table);
                dgvCTHDnhap.DataSource = table;
                con.Close();
            }
            catch(SqlException)
            {
                MessageBox.Show("Lỗi kết nối, xem lại nguồn!");
            }
        }

        void cbbMake_maHD()
        {
            con = new SqlConnection(strCon);
            con.Open();
            cmd = new SqlCommand("select mahdn from hoadonnhap order by mahdn desc", con);
            adap = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adap.Fill(tbl);
            txtMaHD.DataSource = tbl;
            txtMaHD.DisplayMember = "mahdn";
            txtMaHD.ValueMember = "mahdn";
            //txtMaHD.Text = "Chọn mã HĐN";
        }

        void cbbMake_MaSP()
        {
            con = new SqlConnection(strCon);
            con.Open();
            cmd = new SqlCommand("select masp, tensp from sanpham", con);
            adap = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adap.Fill(tbl);
            txtMaSP.DataSource = tbl;
            txtMaSP.DisplayMember = "tensp";
            txtMaSP.ValueMember = "masp";
            txtMaSP.Text = "Chọn sản phẩm";
        }


        private void frmCTHDnhap_Load(object sender, EventArgs e)
        {
            dgv_Hoadon.Hide();
            dgvgetMaAuto.Hide();
            cbbMake_maHD();
            cbbMake_MaSP();
            Vohieuhoa_txt();
            Vohieuhoa_btn();
            TaiDuLieu();
            txtMaNCC.Clear();
            txtNgayTao.Clear();
            txtMaNCC.Enabled = false;
            txtNgayTao.Enabled = false;
            btnThemMoi.Enabled = true;
        }

        void TaiDuLieu_theo_mahd()
        {
            try
            {
                con = new SqlConnection(strCon);
                con.Open();
                cmd = new SqlCommand("select maCTHDN, maHDN, tenSP, soluong from sanpham s, ChitietHDN c where s.maSP = c.maSP and mahdn = '" + txtMaHD.Text+"'", con);
                adap = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adap.Fill(table);
                dgvCTHDnhap.DataSource = table;
                con.Close();
                Vohieuhoa_btn();
                btnThemMoi.Enabled = true;
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi kết nối, xem lại nguồn!");
            }
        }


        void makeData_grbHoaDdon()
        {
            con = new SqlConnection(strCon);
            con.Open();
            cmd = new SqlCommand("select ngaynhap, mancc from hoadonnhap where mahdn = '" + txtMaHD.Text + "'", con);
            adap = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adap.Fill(table);
            dgv_Hoadon.DataSource = table;
            con.Close();
        }

        private void txtMaHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaiDuLieu_theo_mahd();
            makeData_grbHoaDdon();
            try
            {
                txtNgayTao.Text = (dgv_Hoadon[0, 0].Value.ToString());
                txtMaNCC.Text = (dgv_Hoadon[1, 0].Value.ToString());
            }
            catch(Exception)
            {
            }
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            LamMoi_txt();
            TaiDuLieu();
            txtMaHD.Text = "Chọn mã HĐN";
            txtNgayTao.Clear();
            txtMaNCC.Clear();
        }


        int i;
        private void dgvCTHDnhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = dgvCTHDnhap.CurrentRow.Index;
            txtMaCTHD.Text = dgvCTHDnhap[0, i].Value.ToString();
            txtMaSP.Text = dgvCTHDnhap[2, i].Value.ToString();
            txtSoluong.Text = dgvCTHDnhap[3, i].Value.ToString();
            KichHoat_txt();
            txtMaCTHD.Enabled = false;
            Kichhoat_btn();
            btnLuu.Enabled = false;
        }


        void getIdAuto()
        {
            con = new SqlConnection(strCon);
            con.Open();
            cmd = new SqlCommand("select top(1) macthdn from ChitietHDN order by maCTHDN desc", con);
            adap = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adap.Fill(table);
            dgvgetMaAuto.DataSource = table;
            if (table.Rows.Count < 1)
            {
                txtMaCTHD.Text = "CTN001";
            }
            else
            {
                int i = Convert.ToInt32((dgvgetMaAuto[0, 0].Value.ToString()).Substring(3, 3));
                if (i < 9)
                {
                    txtMaCTHD.Text = "CTN00" + (i + 1).ToString();
                }
                else if (i < 99)
                {
                    txtMaCTHD.Text = "CTN0" + (i + 1).ToString();
                }
            }
            con.Close();
        }
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == "Chọn mã HĐN")
            {
                MessageBox.Show("Bạn cần chọn một hóa đơn để tiếp tục");
            }
            else
            {
                LamMoi_txt();
                Vohieuhoa_btn();
                btnLuu.Enabled = true;
                btnHuyBo.Enabled = true;
                getIdAuto();
            }
        }


        void KichHoat_txt()
        {
            foreach(Control ctrl in grbNhapLieu_ChiTiet.Controls)
            {
                if (ctrl is TextBox)
                    (ctrl as TextBox).Enabled = true;
                if (ctrl is ComboBox)
                    (ctrl as ComboBox).Enabled = true;
            }
            txtMaCTHD.Enabled = false;
        }

        void LamMoi_txt()
        {
            KichHoat_txt();
            foreach(Control ctrl in grbNhapLieu_ChiTiet.Controls)
            {
                if (ctrl is TextBox)
                {
                    (ctrl as TextBox).Clear();
                }
                if (ctrl is ComboBox)
                {
                    (ctrl as ComboBox).Enabled = true;
                }
                txtMaSP.Text = "Chọn sản phẩm";
            }
        }

        void Vohieuhoa_txt()
        {
            foreach (Control ctrl in grbNhapLieu_ChiTiet.Controls)
            {
                if (ctrl is TextBox)
                {
                    (ctrl as TextBox).Enabled = false;
                }
                if(ctrl is ComboBox)
                {
                    (ctrl as ComboBox).Enabled = false;
                }
            }
        }

        void Kichhoat_btn()
        {
            foreach (Control ctrl in grbTienIch.Controls)
            {
                if (ctrl is Button)
                    (ctrl as Button).Enabled = true;
            }
        }

        void Vohieuhoa_btn()
        {
            foreach (Control ctrl in grbTienIch.Controls)
            {
                if (ctrl is Button)
                    (ctrl as Button).Enabled = false;
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            Vohieuhoa_btn();
            LamMoi_txt();
            Vohieuhoa_txt();
            btnThemMoi.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtSoluong.Text.Trim() == "")
            {
                MessageBox.Show("Bạn không nên để trống dữ liệu");
            }
            else
            {
                try
                {
                    con = new SqlConnection(strCon);
                    con.Open();
                    cmd = new SqlCommand("INSERT INTO ChitietHDN values('"+txtMaCTHD.Text+"', '"+txtMaHD.Text+"', '"+txtMaSP.SelectedValue.ToString()+"', '"+txtSoluong.Text+"')",con);
                    cmd.ExecuteNonQuery();
                    TaiDuLieu_theo_mahd();
                    con.Close();
                }
                catch(SqlException)
                {
                    MessageBox.Show("Đã có lỗi, vui lòng xem lại nguồn!");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(strCon);
                con.Open();
                cmd = new SqlCommand("update chitiethdn set  masp = '"+txtMaSP.Text+"', soluong = '"+txtSoluong.Text+"' where macthdn = '"+txtMaCTHD.Text+"'",con);
                cmd.ExecuteNonQuery();
                TaiDuLieu();
                con.Close();
            }
            catch(SqlException)
            {
                MessageBox.Show("Có lỗi, vui lòng xem lại nguồn");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn có chắc muốn xóa dữ liệu?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                try
                {
                    con = new SqlConnection(strCon);
                    con.Open();
                    cmd = new SqlCommand("delete from ChitietHDN where maCTHDN = '" + txtMaCTHD.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    TaiDuLieu();
                    con.Close();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Lỗi, vui lòng xem lại nguồn!");
                }
            }
        }
    }
}
