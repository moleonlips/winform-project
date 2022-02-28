using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_PhuKienTheThao
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
            
        private void frmMain_Load(object sender, EventArgs e)
        {
            frmLogin fli = new frmLogin();
            tssDate.Text = DateTime.Now.ToLongDateString();
        }

        private void tllThayDoiGD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tính năng đang nâng cấp, cảm ơn bạn đã quan tâm!");
        }

        private void btnQLSanPham_Click(object sender, EventArgs e)
        {
            frmQLSanPham fsp = new frmQLSanPham();
            fsp.ShowDialog();
            this.Close();
        }

        private void btnQLLoaiSP_Click(object sender, EventArgs e)
        {
            frmQLLoaiSP f = new frmQLLoaiSP();
            f.ShowDialog();
            this.Close();
        }

        private void btnQLNhaCC_Click(object sender, EventArgs e)
        {
            frmQLNhaCC f = new frmQLNhaCC();
            f.ShowDialog();
            this.Close();
        }

        private void QLKhachHang_Click(object sender, EventArgs e)
        {
            frmQLKhachHang f = new frmQLKhachHang();
            f.Show();
        }

        private void btnQLNhap_Click(object sender, EventArgs e)
        {
            frmQuanLiNhap f = new frmQuanLiNhap();
            f.Show();
        }

        private void btnQLXuat_Click(object sender, EventArgs e)
        {
            frmQuanLiXuat f = new frmQuanLiXuat();
            f.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau f = new frmDoiMatKhau();
            f.Show();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            frmLogin fli = new frmLogin();
            fli.Show();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaoCao bc = new frmBaoCao();
            bc.Show();
        }
    }
}
