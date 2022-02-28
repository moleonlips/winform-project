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
    public partial class frmQLSanPham : Form
    {
        string strCon = @"Data Source=DESKTOP-3239J5Q\SQLEXPRESS;Initial Catalog=PhuKienTheThao;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adap;
        void KetNoi()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3239J5Q\SQLEXPRESS;Initial Catalog=PhuKienTheThao;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select s.masp, tensp, l.TenLoaiSP, gianhap, giaban, soluongton from sanpham s left join loaisp l on s.maloaisp = l.maloaisp", con);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adap.Fill(table);
                dgvDanhMuc.DataSource = table;
            }
            catch(SqlException)
            {
                MessageBox.Show("Lỗi kết nối, xem lại nguồn dữ liệu.");
            }
            finally
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3239J5Q\SQLEXPRESS;Initial Catalog=PhuKienTheThao;Integrated Security=True");
                con.Close();
            }
        }

        /// <summary>
        /// Thực thi các câu lệnh thao tác trên Database: 'thêm, sửa, xóa'
        /// </summary>
        /// <param name="sql"></param>
        void ThucThi(string sql)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3239J5Q\SQLEXPRESS;Initial Catalog=PhuKienTheThao;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
        }


        /// <summary>
        /// Lấy dữ liệu hiển thị cho ComboBox từ Database
        /// </summary>
        void CBBMakeData()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3239J5Q\SQLEXPRESS;Initial Catalog=PhuKienTheThao;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from loaisp", con);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adap.Fill(table);
            cbbMaLoai.DataSource = table;
            cbbMaLoai.DisplayMember = "tenloaisp";
            cbbMaLoai.ValueMember = "maloaiSP";
            cbbMaLoai.Text = "Chọn loại sp..";
        }


        public frmQLSanPham()
        {
            InitializeComponent();
        }

        void vohieuhoaTXT()
        {
            foreach (Control ctrol in grbNhapLieu.Controls)
            {
                if (ctrol is TextBox)
                {
                    (ctrol as TextBox).Enabled = false;
                }
            }
            cbbMaLoai.Enabled = false;
        }

        void kichhoatTXT()
        {
            foreach (Control ctrol in grbNhapLieu.Controls)
            {
                if (ctrol is TextBox)
                {
                    (ctrol as TextBox).Enabled = true;
                    txtMaSP.Enabled = false;
                }
            }
            cbbMaLoai.Enabled = true;
        }

        void LamMoi_txt()
        {
            kichhoatTXT();
            foreach(Control ctrl in grbNhapLieu.Controls)
            {
                if(ctrl is TextBox)
                {
                    (ctrl as TextBox).Clear();
                    txtTenSP.Focus();
                }
            }
        }

        /// <summary>
        /// Kiểm tra chuỗi nhập vào có phải kiểu số hay không
        /// </summary>
        /// <param name="str">Chuỗi truyền vào</param>
        /// <returns>Trả về 'false nếu kết quả kiểm tra sai, 'true' nếu kết quả kiểm tra là đúng</returns>
        bool CheckStringIsNumb(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] < '0' || str[i] > '9')
                {
                    return false;
                }
            }
            return true;
        }

        void LayMaTuDong()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3239J5Q\SQLEXPRESS;Initial Catalog=PhuKienTheThao;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select top(1) masp from sanpham order by masp desc", con);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adap.Fill(table);
            dgvLayMa.DataSource = table;
            try
            {
                int i = Int32.Parse(dgvLayMa[0, 0].Value.ToString().Substring(2, 3));
                if (i < 1)
                {
                    txtMaSP.Text = "SP001";
                }
                else if(i < 9) { txtMaSP.Text = "SP00" + (i + 1).ToString(); }
                else if (i < 99) { txtMaSP.Text = "SP0" + (i + 1).ToString(); }
                else { txtMaSP.Text = "SP" + (i + 1).ToString(); }
            }
            catch { }
        }

        //void onlyOneCheck()
        //{
        //    for(int i = 0; i< )
        //}
        private void frmQLSanPham_Load(object sender, EventArgs e)
        {
            dgvLayMa.Hide();
            KetNoi();
            CBBMakeData();
            vohieuhoaTXT();
            VoHieuHoa_BTN();
            btnLamMoi.Enabled = true;
            DataTimLoai();
        }


        void KichHoat_BTN()
        {
            foreach (Control ctrl in grbNutBam.Controls)
            {
                if (ctrl is Button)
                {
                    (ctrl as Button).Enabled = true;
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            LamMoi_txt();
            vohieuhoaTXT();
            VoHieuHoa_BTN();
            btnLamMoi.Enabled = true;
            KetNoi();
            CBBMakeData();
        }

        void VoHieuHoa_BTN()
        {
            foreach(Control ctrl in grbNutBam.Controls)
            {
                if(ctrl is Button)
                {
                    (ctrl as Button).Enabled = false;
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            VoHieuHoa_BTN();
            btnThem.Enabled = true;
            btnHuyBo.Enabled = true;
            LamMoi_txt();
            KetNoi();
            CBBMakeData();
            LayMaTuDong();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtMaSP.Text.Trim().Length > 10 || txtMaSP.Text.Trim() == "" || txtTenSP.Text.Trim() == "" || txtGiaNhap.Text.Trim() == "" || txtGiaNhap.Text.Trim() == "" || CheckStringIsNumb(txtGiaNhap.Text) == false || CheckStringIsNumb(txtGiaBan.Text) == false || CheckStringIsNumb(txtSoLuongton.Text) == false)
            {
                MessageBox.Show("Dữ liệu truyền vào không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string sql = "insert into sanpham values('" + txtMaSP.Text + "',N'" + txtTenSP.Text + "', '" + cbbMaLoai.SelectedValue.ToString() + "', '" + txtGiaNhap.Text + "', '" + txtGiaBan.Text + "', '" + txtSoLuongton.Text + "')";
                    ThucThi(sql);
                    MessageBox.Show("Đã thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException)
                {
                    MessageBox.Show("Bạn không thể sử dụng mã Sản phẩm này, do đã tồn tại!");
                }
                finally
                {
                    KetNoi();
                }
            }            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "delete sanpham where masp = '" + txtMaSP.Text + "'";
                ThucThi(sql);
                MessageBox.Show("Đã xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LamMoi_txt();
                vohieuhoaTXT();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thể xóa, do sản phẩm nằm trong danh mục đã bán!");
            }
            finally
            {
                KetNoi();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenSP.Text.Trim().Length > 40 || txtTenSP.Text.Trim() == "" || txtGiaNhap.Text.Trim() == "" || txtGiaNhap.Text.Trim() == "")
            {
                MessageBox.Show("Dữ liệu truyền vào không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn thay đổi dữ liệu?", "Yêu cầu xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(dr == DialogResult.OK)
                {
                    try
                    {
                        string sql = "update sanpham set tensp = N'" + txtTenSP.Text + "', maloaisp = '" + cbbMaLoai.SelectedValue.ToString() + "', gianhap = '" + txtGiaNhap.Text + "', giaban = '" + txtGiaBan.Text + "', soluongton = '" + txtSoLuongton.Text + "' where masp = '" + txtMaSP.Text + "'";
                        ThucThi(sql);
                        MessageBox.Show("Đã sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Bạn không thể sử dụng mã Sản phẩm này, do đã tồn tại!");
                    }
                    finally
                    {
                        KetNoi();
                        txtMaSP.Enabled = true;
                    }
                }
            }
        }

        private void dgvDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = dgvDanhMuc.CurrentRow.Index;
            txtMaSP.Text = dgvDanhMuc[0, id].Value.ToString();
            txtTenSP.Text = dgvDanhMuc[1, id].Value.ToString();
            cbbMaLoai.Text = dgvDanhMuc[2, id].Value.ToString();
            txtGiaNhap.Text = dgvDanhMuc[3, id].Value.ToString();
            txtGiaBan.Text = dgvDanhMuc[4, id].Value.ToString();
            txtSoLuongton.Text = dgvDanhMuc[5, id].Value.ToString();
            kichhoatTXT();
            KichHoat_BTN();
            btnThem.Enabled = false;
            txtMaSP.Enabled = false;
        }

        private void cbbMaLoai_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("Bạn muốn đi ra sảnh?", "Thoát?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(x == DialogResult.OK)
            {
                frmMain fm = new frmMain();
                fm.ShowDialog();
                this.Hide();
                this.Close();
            }
        }

        void TaiDuLieu_TheoGia(string sql)
        {
            con = new SqlConnection(strCon);
            con.Open();
            cmd = new SqlCommand(sql, con);
            adap = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adap.Fill(table);
            dgvDanhMuc.DataSource = table;
            con.Close();
        }
        private void btnTimGia_Click(object sender, EventArgs e)
        {
            if(ckb500mns.Checked == true)
            {
                TaiDuLieu_TheoGia("select * from SanPham where giaBan <= 500000");
            }
            if(ckb500pls.Checked == true)
            {
                TaiDuLieu_TheoGia("select * from SanPham where giaBan >= 500000 and giaban <= 600000");
            }
            if(ckb1000mns.Checked == true)
            {
                TaiDuLieu_TheoGia("select * from SanPham where giaBan >= 800000 and giaban <= 1200000");
            }
            if(ckb1000pls.Checked == true)
            {
                TaiDuLieu_TheoGia("select * from SanPham where giaBan >= 1000000");
            }
        }

        private void ckb500pls_Click(object sender, EventArgs e)
        {
            ckb1000mns.Checked = false;
            ckb1000pls.Checked = false;
            ckb500mns.Checked = false;
            ckb500pls.Checked = true;
            cbbTimLoai.Text = "";
        }

        private void ckb1000pls_Click(object sender, EventArgs e)
        {
            ckb1000mns.Checked = false;
            ckb1000pls.Checked = true;
            ckb500mns.Checked = false;
            ckb500pls.Checked = false;
            cbbTimLoai.Text = "";
        }

        private void ckb500mns_Click(object sender, EventArgs e)
        {
            ckb1000mns.Checked = false;
            ckb1000pls.Checked = false;
            ckb500mns.Checked = true;
            ckb500pls.Checked = false;
            cbbTimLoai.Text = "";
        }

        private void ckb1000mns_Click(object sender, EventArgs e)
        {
            ckb1000mns.Checked = true;
            ckb1000pls.Checked = false;
            ckb500mns.Checked = false;
            ckb500pls.Checked = false;
            cbbTimLoai.Text = "";
        }

        void unCheck()
        {
            foreach(Control ctrl in grbTimGia.Controls)
            {
                if(ctrl is CheckBox)
                {
                    (ctrl as CheckBox).Checked = false;
                }
            }
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            KetNoi();
            cbbTimLoai.Text = "";
            unCheck();
        }

        void DataTimLoai()
        {
            con = new SqlConnection(strCon);
            con.Open();
            cmd = new SqlCommand("select MaLoaiSP, TenLoaiSP from LoaiSP", con);
            adap = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adap.Fill(table);
            cbbTimLoai.DataSource = table;
            cbbTimLoai.DisplayMember = "tenloaisp";
            cbbTimLoai.ValueMember = "maloaisp";
            cbbTimLoai.Text = "Chọn loại muốn tìm";
        }

        private void btnTimLoai_Click(object sender, EventArgs e)
        {
            TaiDuLieu_TheoGia("select * from sanpham where maLoaiSP = '"+cbbTimLoai.SelectedValue.ToString()+"'");
        }

        private void cbbTimLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            unCheck();
        }
    }
}
