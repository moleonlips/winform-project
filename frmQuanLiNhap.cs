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
    public partial class frmQuanLiNhap : Form
    {
        public frmQuanLiNhap()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adap;
        string strCon = @"Data Source=DESKTOP-3239J5Q\SQLEXPRESS;Initial Catalog=PhuKienTheThao;Integrated Security=True";
        
        // Xử lí đối với grbText
        void VoHieuHoa_txt()
        {
            txtMaHD.Enabled = false;
            txtNCC.Enabled = false;
            txtNgayTao.Enabled = false;
            txtNgayTao2.Enabled = false;
            txtNVnhap.Enabled = false;
        }

        void KichHoat_txt()
        {
            txtMaHD.Enabled = true;
            txtNCC.Enabled = true;
            txtNgayTao.Enabled = true;
            txtNgayTao2.Enabled = true;
            txtNVnhap.Enabled = true;
        }

        void LamMoi_txt()
        {
            KichHoat_txt();
            foreach (Control ctrl in grbText.Controls)
                if (ctrl is TextBox)
                    (ctrl as TextBox).Clear();
            txtMaHD.Enabled = false;
            txtNCC.Text = "Chọn 1 nhà cung cấp";
            txtNVnhap.Text = "Chọn mã NV nhập kho";
            txtNCC.Focus();
        }

        // Xử lí đối với grbButton
        void VoHieuHoa_btn() 
        {
            foreach (Control ctrl in grbButton.Controls)
                if (ctrl is Button)
                    (ctrl as Button).Enabled = false;
        }

        void KichHoat_btn()
        {
            foreach (Control ctrl in grbButton.Controls)
                if (ctrl is Button)
                    (ctrl as Button).Enabled = true;
        }


        //Lấy Mã NCC cho combobox
        void getMaNCC_cbb()
        {
            con = new SqlConnection(strCon);
            con.Open();
            cmd = new SqlCommand("select mancc from nhacungcap",con);
            adap = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adap.Fill(tbl);
            txtNCC.DataSource = tbl;
            txtNCC.ValueMember = "mancc";
            txtNCC.DisplayMember = "mancc";
            txtNCC.Text = "Chọn nhà cung cấp...";
        }


        // Xử lí đối với dgvBangDL

        int i;
        private void dgvBangDL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = dgvBangDL.CurrentRow.Index;
            txtMaHD.Text = dgvBangDL[0, i].Value.ToString();
            txtNCC.Text = dgvBangDL[1, i].Value.ToString();
            txtNVnhap.Text = dgvBangDL[3, i].Value.ToString();
            txtNgayTao2.Show();
            txtNgayTao2.Text = dgvBangDL[2, i].Value.ToString();
            txtNgayTao.Hide();
            KichHoat_txt();
            KichHoat_btn();
            txtMaHD.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
        }

        void TaiDuLieu()
        {
            try
            {
                con = new SqlConnection(strCon);
                con.Open();
                cmd = new SqlCommand("select h.mahdn, maNCC, ngaynhap, tenNV, giatrihoadon = sum(s.giaNhap*c.soluong) from HoaDonNhap h, NV_QLkho n, ChitietHDN c, SanPham s where h.manv = n.maNV and h.maHDN = c.maHDN and c.maSP = s.maSP group by h.mahdn, maNCC, ngaynhap, tenNV", con);
                adap = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adap.Fill(table);
                dgvBangDL.DataSource = table;
                con.Close();
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối!");
            }
        }

        void LayMaTuDong()
        {
            con = new SqlConnection(strCon);
            con.Open();
            cmd = new SqlCommand("select top(1) mahdn from hoadonnhap order by mahdn desc", con);
            adap = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adap.Fill(table);
            dgvLayMa.DataSource = table;
            if(table.Rows.Count < 1)
            {
                txtMaHD.Text = "HD001";
            }
            else
            {
                try
                {
                    int a = Int32.Parse(dgvLayMa[0, 0].Value.ToString().Substring(2, 3));
                    if (a < 9) { txtMaHD.Text = "HD00" + (a + 1).ToString(); }
                    else if (a < 99) { txtMaHD.Text = "HD0" + (a + 1).ToString(); }
                    else { txtMaHD.Text = "HD" + (a + 1).ToString(); }
                }
                catch{}
            }
        }

        void makeDataNVnhap()
        {
            con = new SqlConnection(strCon);
            con.Open();
            cmd = new SqlCommand("select manv, tennv from nv_qlkho", con);
            adap = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adap.Fill(table);
            txtNVnhap.DataSource = table;
            txtNVnhap.ValueMember = "manv";
            txtNVnhap.DisplayMember = "tennv";
            txtNVnhap.Text = "Chọn NVQL nhập";
        }

        private void frmQuanLiNhap_Load(object sender, EventArgs e)
        {
            dgvLayMa.Hide();
            VoHieuHoa_btn();
            btnThemMoi.Enabled = true;
            VoHieuHoa_txt();
            TaiDuLieu();
            getMaNCC_cbb();
            makeDataNVnhap();
            MakeData_CBB_Timloai();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            LamMoi_txt();
            txtNgayTao2.Hide();
            txtNgayTao.Show();
            KichHoat_btn();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            LayMaTuDong();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            frmMain f = new frmMain();
            f.Show();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(strCon);
                con.Open();
                cmd = new SqlCommand("insert into HoaDonNhap values ('" + txtMaHD.Text + "','" + txtNCC.Text + "','" + txtNgayTao.Text + "','" + txtNVnhap.SelectedValue.ToString() + "')", con);
                cmd.ExecuteNonQuery();
                TaiDuLieu();
                DialogResult r = MessageBox.Show("Thêm thành công.\nThông tin hóa đơn mới hiện vẫn trống\nBạn có muốn bổ sung ngay?", "Done", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(r == DialogResult.Yes)
                {
                    frmCTHDnhap f = new frmCTHDnhap();
                    f.Show();
                }
                con.Close();
            }
            catch
            {
                MessageBox.Show("Đã có lỗi!\n(Có thể bạn chưa nhập đúng định dạng ngày tháng?!)");
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            LamMoi_txt();
            VoHieuHoa_txt();
            VoHieuHoa_btn();
            btnThemMoi.Enabled = true;            
        }

        private void txtNgayTao2_Click(object sender, EventArgs e)
        {
            txtNgayTao2.Hide();
            txtNgayTao.Show();
            txtNgayTao.Focus();
            btnSua.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(strCon);
                con.Open();
                cmd = new SqlCommand("update HoaDonNhap set maNCC='"+txtNCC.Text+"', ngaynhap='"+txtNgayTao.Text+"' where maHDN='"+txtMaHD.Text+"'", con);
                cmd.ExecuteNonQuery();
                TaiDuLieu();
                MessageBox.Show("Sửa thành công!");
                con.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Phát hiện lỗi\n(Có thể có dữ liệu nhập vào bị sai định dạng!)");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("Các dữ liệu liên quan cũng sẽ bị xóa thoe!", "Click 'Yes' để xóa",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (x == DialogResult.Yes)
            {
                try
                {
                    con = new SqlConnection(strCon);
                    con.Open();
                    cmd = new SqlCommand("delete hoadonnhap where mahdn = '"+txtMaHD.Text+"'",con);
                    cmd.ExecuteNonQuery();
                    TaiDuLieu();
                    MessageBox.Show("Đã xóa!");
                    con.Close();
                }
                catch(SqlException)
                {
                    MessageBox.Show("Lỗi!");
                }
            }
        }

        private void btnCTHDxuat_Click(object sender, EventArgs e)
        {
            frmCTHDnhap f = new frmCTHDnhap();
            f.Show();
        }

        private void txtNCC_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
        }


        void TaiDuLieu_tuychon(string sql)
        {
            con = new SqlConnection(strCon);
            con.Open();
            cmd = new SqlCommand(sql, con);
            adap = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adap.Fill(table);
            dgvBangDL.DataSource = table;
            con.Close();
        }
        private void btnTimGia_Click(object sender, EventArgs e)
        {
            if(ckb1mns.Checked == true)
            {
                TaiDuLieu_tuychon("select h.mahdn, maNCC, ngaynhap, tenNV, giatrihoadon = sum(s.giaNhap*c.soluong) from HoaDonNhap h, NV_QLkho n, ChitietHDN c, SanPham s where h.manv = n.maNV and h.maHDN = c.maHDN and c.maSP = s.maSP group by h.mahdn, maNCC, ngaynhap, tenNV having sum(s.giaNhap*c.soluong) < 1000000");
            }
            if (ckb1to5.Checked == true)
            {
                TaiDuLieu_tuychon("select h.mahdn, maNCC, ngaynhap, tenNV, giatrihoadon = sum(s.giaNhap*c.soluong) from HoaDonNhap h, NV_QLkho n, ChitietHDN c, SanPham s where h.manv = n.maNV and h.maHDN = c.maHDN and c.maSP = s.maSP group by h.mahdn, maNCC, ngaynhap, tenNV having sum(s.giaNhap*c.soluong) >= 1000000 and sum(s.giaNhap*c.soluong) <= 5000000");
            }
            if (ckb5to10.Checked == true)
            {
                TaiDuLieu_tuychon("select h.mahdn, maNCC, ngaynhap, tenNV, giatrihoadon = sum(s.giaNhap*c.soluong) from HoaDonNhap h, NV_QLkho n, ChitietHDN c, SanPham s where h.manv = n.maNV and h.maHDN = c.maHDN and c.maSP = s.maSP group by h.mahdn, maNCC, ngaynhap, tenNV having sum(s.giaNhap*c.soluong) >= 5000000 and sum(s.giaNhap*c.soluong) <= 10000000");
            }
            if (ckb10to50.Checked == true)
            {
                TaiDuLieu_tuychon("select h.mahdn, maNCC, ngaynhap, tenNV, giatrihoadon = sum(s.giaNhap*c.soluong) from HoaDonNhap h, NV_QLkho n, ChitietHDN c, SanPham s where h.manv = n.maNV and h.maHDN = c.maHDN and c.maSP = s.maSP group by h.mahdn, maNCC, ngaynhap, tenNV having sum(s.giaNhap*c.soluong) >= 10000000 and sum(s.giaNhap*c.soluong) <= 50000000");
            }
            if (ckb50pls.Checked == true)
            {
                TaiDuLieu_tuychon("select h.mahdn, maNCC, ngaynhap, tenNV, giatrihoadon = sum(s.giaNhap*c.soluong) from HoaDonNhap h, NV_QLkho n, ChitietHDN c, SanPham s where h.manv = n.maNV and h.maHDN = c.maHDN and c.maSP = s.maSP group by h.mahdn, maNCC, ngaynhap, tenNV having sum(s.giaNhap*c.soluong) > 50000000");
            }
        }

        private void ckb1mns_Click(object sender, EventArgs e)
        {
            ckb1mns.Checked = true;
            ckb1to5.Checked = false;
            ckb5to10.Checked = false;
            ckb10to50.Checked = false;
            ckb50pls.Checked = false;
        }

        private void ckb1to5_Click(object sender, EventArgs e)
        {
            ckb1mns.Checked = false;
            ckb1to5.Checked = true;
            ckb5to10.Checked = false;
            ckb10to50.Checked = false;
            ckb50pls.Checked = false;
        }

        private void ckb5to10_Click(object sender, EventArgs e)
        {
            ckb1mns.Checked = false;
            ckb1to5.Checked = false;
            ckb5to10.Checked = true;
            ckb10to50.Checked = false;
            ckb50pls.Checked = false;
        }

        private void ckb10to50_Click(object sender, EventArgs e)
        {
            ckb1mns.Checked = false;
            ckb1to5.Checked = false;
            ckb5to10.Checked = false;
            ckb10to50.Checked = true;
            ckb50pls.Checked = false;
        }

        private void ckb50pls_Click(object sender, EventArgs e)
        {
            ckb1mns.Checked = false;
            ckb1to5.Checked = false;
            ckb5to10.Checked = false;
            ckb10to50.Checked = false;
            ckb50pls.Checked = true;
        }

        void MakeData_CBB_Timloai()
        {
            con = new SqlConnection(strCon);
            con.Open();
            cmd = new SqlCommand("select mancc, tenncc from nhacungcap", con);
            adap = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adap.Fill(table);
            cbbTimNcc.DataSource = table;
            cbbTimNcc.DisplayMember = "tenncc";
            cbbTimNcc.ValueMember = "mancc";
            cbbTimNcc.Text = "";
            con.Close();
        }

        private void btnTimNcc_Click(object sender, EventArgs e)
        {
            TaiDuLieu_tuychon("select h.mahdn, maNCC, ngaynhap, tenNV, giatrihoadon = sum(s.giaNhap*c.soluong) from HoaDonNhap h, NV_QLkho n, ChitietHDN c, SanPham s where h.manv = n.maNV and h.maHDN = c.maHDN and c.maSP = s.maSP and maNCC = '"+cbbTimNcc.SelectedValue.ToString()+"' group by h.mahdn, maNCC, ngaynhap, tenNV");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TaiDuLieu();
        }

        private void btnUpDateBill_Click(object sender, EventArgs e)
        {
            TaiDuLieu();
        }
    }
}
