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
    public partial class frmQuanLiXuat : Form
    {
        public frmQuanLiXuat()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adap;
        string strCon = @"Data Source=DESKTOP-3239J5Q\SQLEXPRESS;Initial Catalog=PhuKienTheThao;Integrated Security=True";

        void VoHieuHoa_txt()
        {
            btnNewCustom.Enabled = false;
            txtMaHDX.Enabled = false;
            txtMaKH.Enabled = false;
            txtNgayTao.Enabled = false;
            txtNgayTao2.Enabled = false;
            txtNVxuat.Enabled = false;
        }

        void KichHoat_txt()
        {
            txtMaHDX.Enabled = true;
            txtMaKH.Enabled = true;
            txtNgayTao.Enabled = true;
            txtNgayTao2.Enabled = true; 
            txtNVxuat.Enabled = true;
            btnNewCustom.Enabled = true;
        }

        void LamMoi_txt()
        {
            KichHoat_txt();
            foreach (Control ctrl in grbText.Controls)
                if (ctrl is TextBox)
                    (ctrl as TextBox).Clear();
            txtMaHDX.Enabled = false;
            txtMaKH.Text = "Chọn khách hàng";
            txtNVxuat.Text = "Chọn nhân viên xuất";
            txtMaKH.Focus();
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

        void getMaKH_cbb()
        {
            con = new SqlConnection(strCon);
            con.Open();
            cmd = new SqlCommand("select makh, tenkh from khachhang", con);
            adap = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adap.Fill(table);
            txtMaKH.DataSource = table;
            txtMaKH.DisplayMember = "tenkh";
            txtMaKH.ValueMember = "makh";
            txtMaKH.Text = "Chọn khách hàng..";
        }

        void TaiDuLieu()
        {
            try
            {
                con = new SqlConnection(strCon);
                con.Open();
                cmd = new SqlCommand("select h.maHDX, k.tenkh, ngayxuat, tenNV, giatrihoadon = sum(s.giaBan*c.soluong) from HoaDonXuat h, NV_QLxuat n, ChiTietHDX c, SanPham s, khachhang k where k.makh = h.makh and h.manv = n.maNV and h.maHDX = c.maHDX and c.maSP = s.maSP group by h.maHDX, tenkh, ngayxuat, tenNV", con);
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
            cmd = new SqlCommand("select top(1) mahdx from hoadonxuat order by maHDX desc", con);
            adap = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adap.Fill(table);
            dgvLayMa.DataSource = table;
            if(table.Rows.Count < 1)
            {
                txtMaHDX.Text = "HD001";
            }
            else
            {
                try
                {
                    int c = Int32.Parse(dgvLayMa[0, 0].Value.ToString().Substring(2, 3));
                    if (c < 9)
                    {
                        txtMaHDX.Text = "HD00" + (c + 1).ToString();
                    }
                    else if(c < 99)
                    {
                        txtMaHDX.Text = "HD0" + (c + 1).ToString();
                    }
                    else
                    {
                        txtMaHDX.Text = "HD" + (c + 1).ToString();
                    }
                }
                catch(SqlException)
                {
                
                }
            }
        }
        void MakeDataNVXuat()
        {
            con = new SqlConnection(strCon);
            con.Open();
            cmd = new SqlCommand("select manv, tennv from NV_QLxuat", con);
            adap = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adap.Fill(table);
            txtNVxuat.DataSource = table;
            txtNVxuat.DisplayMember = "tennv";
            txtNVxuat.ValueMember = "manv";
            txtNVxuat.Text = "Chọn NVQL xuất";
            con.Close();
        }
        private void frmQuanLiXuat_Load(object sender, EventArgs e)
        {
            VoHieuHoa_btn();
            btnThemMoi.Enabled = true;
            VoHieuHoa_txt();
            TaiDuLieu();
            getMaKH_cbb();
            MakeDataNVXuat();
            dgvLayMa.Hide();
            TaiDL_TimKH();
        }

        void TaiDL_TimKH()
        {
            con = new SqlConnection(strCon);
            con.Open();
            cmd = new SqlCommand("select makh, tenkh from khachhang", con);
            adap = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adap.Fill(table);
            cbbTimKH.DataSource = table;
            cbbTimKH.DisplayMember = "tenkh";
            cbbTimKH.ValueMember = "makh";
            cbbTimKH.Text = "Chọn khách hàng..";
        }

        int i;
        private void dgvBangDL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = dgvBangDL.CurrentRow.Index;
            txtMaHDX.Text = dgvBangDL[0, i].Value.ToString();
            txtMaKH.Text = dgvBangDL[1, i].Value.ToString();
            txtNVxuat.Text = dgvBangDL[3, i].Value.ToString();
            txtNgayTao2.Show();
            txtNgayTao2.Text = dgvBangDL[2, i].Value.ToString();
            txtNgayTao.Hide();
            KichHoat_txt();
            KichHoat_btn();
            txtMaHDX.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            LamMoi_txt();
            txtNgayTao2.Hide();
            txtNgayTao.Show();
            txtNgayTao.Clear();
//            txtMaKH.Text = "Chọn mã khách hàng...";
            KichHoat_btn();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            LayMaTuDong();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(strCon);
                con.Open();
                cmd = new SqlCommand("insert into hoadonxuat values('"+txtMaHDX.Text+"','"+ txtMaKH.SelectedValue.ToString()+"','"+txtNgayTao.Text+ "','" + txtNVxuat.SelectedValue.ToString() + "')", con);
                cmd.ExecuteNonQuery();
                TaiDuLieu();
                DialogResult r = MessageBox.Show("Thêm thành công!\nHóa đơn vừa thêm hiện chưa có chi tiết hóa đơn nào,\nBạn có muốn bổ sung ngay?","Done",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(r == DialogResult.Yes)
                {
                    frmCTHDxuat f = new frmCTHDxuat();
                    f.ShowDialog();
                }
                con.Close();
            }
            catch
            {
                MessageBox.Show("Đã có lỗi!\n(Có thể bạn chưa nhập đúng định dạng ngày tháng?!)");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Các dữ liệu liên quan cũng sẽ bị xóa theo\n Bạn có chắc muốn xóa?", "Chọn 'Yes' để xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(a == DialogResult.Yes)
            {
                try
                {
                    con = new SqlConnection(strCon);
                    con.Open();
                    cmd = new SqlCommand("delete from hoadonxuat where mahdx = '"+txtMaHDX.Text+"'", con);
                    cmd.ExecuteNonQuery();
                    TaiDuLieu();
                    con.Close();
                }
                catch(SqlException)
                {
                    MessageBox.Show("Đã có lỗi, vui lòng kiểm tra nguổn!");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(strCon);
                con.Open();
                cmd = new SqlCommand("update hoadonxuat set makh='" + txtMaKH.SelectedValue.ToString() + "', ngayxuat='" + txtNgayTao.Text + "' where maHDx='" + txtMaHDX.Text + "'", con);
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

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            LamMoi_txt();
            VoHieuHoa_txt();
            VoHieuHoa_btn();
            txtMaKH.Text = "Chọn mã khách hàng...";
            btnThemMoi.Enabled = true;
        }

        private void txtNgayTao2_Click(object sender, EventArgs e)
        {
            txtNgayTao2.Hide();
            txtNgayTao.Show();
            txtNgayTao.Focus();
            btnSua.Enabled = true;
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            frmMain f = new frmMain();
            f.Show();
        }

        private void btnCTHDxuat_Click(object sender, EventArgs e)
        {
            frmCTHDxuat f = new frmCTHDxuat();
            f.Show();
        }

        private void txtMaKH_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TaiDuLieu();
            //getMaKH_cbb();
            //con = new SqlConnection(strCon);
            //con.Open();
            //cmd = new SqlCommand("select * from HoaDonNhap where substring(maHDN,5,1) = '0' or substring(maHDN,5,1) = '2' or substring(maHDN,5,1) = '4' or substring(maHDN,5,1) = '6' or substring(maHDN,5,1) = '8'", con);
            //adap = new SqlDataAdapter(cmd);
            //DataTable table = new DataTable();
            //adap.Fill(table);
            //dgvBangDL.DataSource = table;
        }

        void TaiDL_TuyChon(string a)
        {
            con = new SqlConnection(strCon);
            con.Open();
            cmd = new SqlCommand(a, con);
            adap = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adap.Fill(table);
            dgvBangDL.DataSource = table;
            con.Close();
        }
        private void btnTimKH_Click(object sender, EventArgs e)
        {
            if(cbbTimKH.Text == "Chọn khách hàng..")
            {
                MessageBox.Show("Bạn cần chọn một khách hàng để tiếp tục thao tác!");
            }
            else
            {
                TaiDL_TuyChon("select h.maHDX, k.tenkh, ngayxuat, tenNV, giatrihoadon = sum(s.giaBan*c.soluong) from HoaDonXuat h, NV_QLxuat n, ChiTietHDX c, SanPham s, khachhang k where k.makh = h.makh and h.manv = n.maNV and h.maHDX = c.maHDX and c.maSP = s.maSP and k.makh = '" + cbbTimKH.SelectedValue.ToString() + "' group by h.maHDX, tenkh, ngayxuat, tenNV");
            }
        }

        private void btnTimGia_Click(object sender, EventArgs e)
        {
            if (ckbnho1.Checked == false && ckb1to5.Checked == false && ckb5to10.Checked == false && ckb10to500.Checked == false && ckbhon50.Checked == false)
            {
                MessageBox.Show("Bạn cần chọn một mức giá để tiếp tục thao tác!");
            }
            if(ckbnho1.Checked == true)
            {
                TaiDL_TuyChon("select h.maHDX, tenkh, ngayxuat, tenNV, giatrihoadon = sum(s.giaBan*c.soluong) from HoaDonXuat h, NV_QLxuat n, ChiTietHDX c, SanPham s, khachhang k where k.makh = h.makh and h.manv = n.maNV and h.maHDX = c.maHDX and c.maSP = s.maSP group by h.maHDX, tenkh, ngayxuat, tenNV having sum(s.giaBan*c.soluong) < 1000000");
            }
            if (ckb1to5.Checked == true)
            {
                TaiDL_TuyChon("select h.maHDX, tenkh, ngayxuat, tenNV, giatrihoadon = sum(s.giaBan*c.soluong) from HoaDonXuat h, NV_QLxuat n, ChiTietHDX c, SanPham s, khachhang k where k.makh = h.makh and h.manv = n.maNV and h.maHDX = c.maHDX and c.maSP = s.maSP group by h.maHDX, tenkh, ngayxuat, tenNV having sum(s.giaBan*c.soluong) >= 1000000 and sum(s.giaBan*c.soluong) < 5000000");
            }
            if (ckb5to10.Checked == true)
            {
                TaiDL_TuyChon("select h.maHDX, tenkh, ngayxuat, tenNV, giatrihoadon = sum(s.giaBan*c.soluong) from HoaDonXuat h, NV_QLxuat n, ChiTietHDX c, SanPham s, khachhang k where k.makh = h.makh and h.manv = n.maNV and h.maHDX = c.maHDX and c.maSP = s.maSP group by h.maHDX, tenkh, ngayxuat, tenNV having sum(s.giaBan*c.soluong) >= 5000000 and sum(s.giaBan*c.soluong) < 10000000");
            }
            if (ckb10to500.Checked == true)
            {
                TaiDL_TuyChon("select h.maHDX, tenkh, ngayxuat, tenNV, giatrihoadon = sum(s.giaBan*c.soluong) from HoaDonXuat h, NV_QLxuat n, ChiTietHDX c, SanPham s, khachhang k where k.makh = h.makh and h.manv = n.maNV and h.maHDX = c.maHDX and c.maSP = s.maSP group by h.maHDX, tenkh, ngayxuat, tenNV having sum(s.giaBan*c.soluong) >= 10000000 and sum(s.giaBan*c.soluong) <= 50000000");
            }
            if (ckbhon50.Checked == true)
            {
                TaiDL_TuyChon("select h.maHDX, tenkh, ngayxuat, tenNV, giatrihoadon = sum(s.giaBan*c.soluong) from HoaDonXuat h, NV_QLxuat n, ChiTietHDX c, SanPham s, khachhang k where k.makh = h.makh and h.manv = n.maNV and h.maHDX = c.maHDX and c.maSP = s.maSP group by h.maHDX, tenkh, ngayxuat, tenNV having sum(s.giaBan*c.soluong) > 50000000");
            }
        }
        void unCheck()
        {
            foreach(Control ctrl in grbTimGia.Controls)
            {
                if (ctrl is CheckBox)
                    (ctrl as CheckBox).Checked = false;
            }
        }

        private void ckbnho1_Click(object sender, EventArgs e)
        {
            unCheck();
            ckbnho1.Checked = true;
            cbbTimKH.Text = "Chọn khách hàng..";
        }

        private void ckb1to5_Click(object sender, EventArgs e)
        {
            unCheck();
            ckb1to5.Checked = true;
            cbbTimKH.Text = "Chọn khách hàng..";
        }

        private void ckb5to10_Click(object sender, EventArgs e)
        {
            unCheck();
            ckb5to10.Checked = true;
            cbbTimKH.Text = "Chọn khách hàng..";
        }

        private void ckb10to500_Click(object sender, EventArgs e)
        {
            unCheck();
            ckb10to500.Checked = true;
            cbbTimKH.Text = "Chọn khách hàng..";
        }

        private void ckbhon50_Click(object sender, EventArgs e)
        {
            unCheck();
            ckbhon50.Checked = true;
            cbbTimKH.Text = "Chọn khách hàng..";
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            TaiDuLieu();
            unCheck();
            cbbTimKH.Text = "Chọn khách hàng..";
        }

        private void cbbTimKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            unCheck();
        }

        private void btnNewCustom_Click(object sender, EventArgs e)
        {
            frmNewCustom f = new frmNewCustom();
            f.Show();
        }
    }
}
