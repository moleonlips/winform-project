namespace GUI_PhuKienTheThao
{
    partial class frmCTHDxuat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCTHDxuat));
            this.grbHDX = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaKH_hdx = new System.Windows.Forms.TextBox();
            this.txtNgayTao_hdx = new System.Windows.Forms.TextBox();
            this.txtMaHD_hdx = new System.Windows.Forms.ComboBox();
            this.grbCTHDX = new System.Windows.Forms.GroupBox();
            this.txtSoLuong_ct = new System.Windows.Forms.TextBox();
            this.txtMaCTHD_ct = new System.Windows.Forms.TextBox();
            this.txtMaSP_ct = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grbBangDL = new System.Windows.Forms.GroupBox();
            this.dgvBang_tam = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCTXuat = new System.Windows.Forms.DataGridView();
            this.grbTienIch = new System.Windows.Forms.GroupBox();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnXemTatCa = new System.Windows.Forms.Button();
            this.dgvLayMaTuDong = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbHDX.SuspendLayout();
            this.grbCTHDX.SuspendLayout();
            this.grbBangDL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBang_tam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTXuat)).BeginInit();
            this.grbTienIch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLayMaTuDong)).BeginInit();
            this.SuspendLayout();
            // 
            // grbHDX
            // 
            this.grbHDX.Controls.Add(this.label3);
            this.grbHDX.Controls.Add(this.label2);
            this.grbHDX.Controls.Add(this.label1);
            this.grbHDX.Controls.Add(this.txtMaKH_hdx);
            this.grbHDX.Controls.Add(this.txtNgayTao_hdx);
            this.grbHDX.Controls.Add(this.txtMaHD_hdx);
            this.grbHDX.Location = new System.Drawing.Point(4, 4);
            this.grbHDX.Name = "grbHDX";
            this.grbHDX.Size = new System.Drawing.Size(275, 100);
            this.grbHDX.TabIndex = 0;
            this.grbHDX.TabStop = false;
            this.grbHDX.Text = "Hóa đơn xuất";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ngày tạo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã hóa đơn";
            // 
            // txtMaKH_hdx
            // 
            this.txtMaKH_hdx.Location = new System.Drawing.Point(103, 71);
            this.txtMaKH_hdx.Name = "txtMaKH_hdx";
            this.txtMaKH_hdx.Size = new System.Drawing.Size(166, 20);
            this.txtMaKH_hdx.TabIndex = 2;
            // 
            // txtNgayTao_hdx
            // 
            this.txtNgayTao_hdx.Location = new System.Drawing.Point(103, 45);
            this.txtNgayTao_hdx.Name = "txtNgayTao_hdx";
            this.txtNgayTao_hdx.Size = new System.Drawing.Size(166, 20);
            this.txtNgayTao_hdx.TabIndex = 1;
            // 
            // txtMaHD_hdx
            // 
            this.txtMaHD_hdx.FormattingEnabled = true;
            this.txtMaHD_hdx.Location = new System.Drawing.Point(103, 17);
            this.txtMaHD_hdx.Name = "txtMaHD_hdx";
            this.txtMaHD_hdx.Size = new System.Drawing.Size(166, 21);
            this.txtMaHD_hdx.TabIndex = 0;
            this.txtMaHD_hdx.SelectedIndexChanged += new System.EventHandler(this.txtMaHD_hdx_SelectedIndexChanged);
            // 
            // grbCTHDX
            // 
            this.grbCTHDX.Controls.Add(this.txtSoLuong_ct);
            this.grbCTHDX.Controls.Add(this.txtMaCTHD_ct);
            this.grbCTHDX.Controls.Add(this.txtMaSP_ct);
            this.grbCTHDX.Controls.Add(this.label7);
            this.grbCTHDX.Controls.Add(this.label6);
            this.grbCTHDX.Controls.Add(this.label4);
            this.grbCTHDX.Location = new System.Drawing.Point(285, 4);
            this.grbCTHDX.Name = "grbCTHDX";
            this.grbCTHDX.Size = new System.Drawing.Size(512, 100);
            this.grbCTHDX.TabIndex = 1;
            this.grbCTHDX.TabStop = false;
            this.grbCTHDX.Text = "Chi tiết hóa đơn";
            // 
            // txtSoLuong_ct
            // 
            this.txtSoLuong_ct.Location = new System.Drawing.Point(347, 15);
            this.txtSoLuong_ct.Name = "txtSoLuong_ct";
            this.txtSoLuong_ct.Size = new System.Drawing.Size(141, 20);
            this.txtSoLuong_ct.TabIndex = 7;
            // 
            // txtMaCTHD_ct
            // 
            this.txtMaCTHD_ct.Location = new System.Drawing.Point(103, 16);
            this.txtMaCTHD_ct.Name = "txtMaCTHD_ct";
            this.txtMaCTHD_ct.Size = new System.Drawing.Size(144, 20);
            this.txtMaCTHD_ct.TabIndex = 6;
            // 
            // txtMaSP_ct
            // 
            this.txtMaSP_ct.FormattingEnabled = true;
            this.txtMaSP_ct.Location = new System.Drawing.Point(103, 66);
            this.txtMaSP_ct.Name = "txtMaSP_ct";
            this.txtMaSP_ct.Size = new System.Drawing.Size(144, 21);
            this.txtMaSP_ct.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(268, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Số lượng xuất";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tên sản phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã CTHĐ";
            // 
            // grbBangDL
            // 
            this.grbBangDL.Controls.Add(this.dgvLayMaTuDong);
            this.grbBangDL.Controls.Add(this.dgvBang_tam);
            this.grbBangDL.Controls.Add(this.dgvCTXuat);
            this.grbBangDL.Location = new System.Drawing.Point(4, 205);
            this.grbBangDL.Name = "grbBangDL";
            this.grbBangDL.Size = new System.Drawing.Size(793, 233);
            this.grbBangDL.TabIndex = 1;
            this.grbBangDL.TabStop = false;
            this.grbBangDL.Text = "Bảng dữ liệu";
            // 
            // dgvBang_tam
            // 
            this.dgvBang_tam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBang_tam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6});
            this.dgvBang_tam.Location = new System.Drawing.Point(508, 68);
            this.dgvBang_tam.Name = "dgvBang_tam";
            this.dgvBang_tam.Size = new System.Drawing.Size(240, 150);
            this.dgvBang_tam.TabIndex = 1;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ngayxuat";
            this.Column5.HeaderText = "ngày xuất";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "makh";
            this.Column6.HeaderText = "mã kh";
            this.Column6.Name = "Column6";
            // 
            // dgvCTXuat
            // 
            this.dgvCTXuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTXuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvCTXuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCTXuat.Location = new System.Drawing.Point(3, 16);
            this.dgvCTXuat.Name = "dgvCTXuat";
            this.dgvCTXuat.Size = new System.Drawing.Size(787, 214);
            this.dgvCTXuat.TabIndex = 0;
            this.dgvCTXuat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTXuat_CellClick);
            // 
            // grbTienIch
            // 
            this.grbTienIch.Controls.Add(this.btnHuyBo);
            this.grbTienIch.Controls.Add(this.btnXoa);
            this.grbTienIch.Controls.Add(this.btnSua);
            this.grbTienIch.Controls.Add(this.btnLuu);
            this.grbTienIch.Controls.Add(this.btnThemMoi);
            this.grbTienIch.Location = new System.Drawing.Point(152, 108);
            this.grbTienIch.Name = "grbTienIch";
            this.grbTienIch.Size = new System.Drawing.Size(645, 91);
            this.grbTienIch.TabIndex = 2;
            this.grbTienIch.TabStop = false;
            this.grbTienIch.Text = "Tiện ích";
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Location = new System.Drawing.Point(521, 29);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(90, 37);
            this.btnHuyBo.TabIndex = 12;
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.UseVisualStyleBackColor = true;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(399, 29);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 37);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(275, 29);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 37);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(153, 29);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(90, 37);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(31, 29);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(90, 37);
            this.btnThemMoi.TabIndex = 8;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnXemTatCa
            // 
            this.btnXemTatCa.Location = new System.Drawing.Point(21, 130);
            this.btnXemTatCa.Name = "btnXemTatCa";
            this.btnXemTatCa.Size = new System.Drawing.Size(98, 52);
            this.btnXemTatCa.TabIndex = 3;
            this.btnXemTatCa.Text = "Xem tất cả";
            this.btnXemTatCa.UseVisualStyleBackColor = true;
            this.btnXemTatCa.Click += new System.EventHandler(this.btnXemTatCa_Click);
            // 
            // dgvLayMaTuDong
            // 
            this.dgvLayMaTuDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLayMaTuDong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7});
            this.dgvLayMaTuDong.Location = new System.Drawing.Point(92, 139);
            this.dgvLayMaTuDong.Name = "dgvLayMaTuDong";
            this.dgvLayMaTuDong.Size = new System.Drawing.Size(42, 27);
            this.dgvLayMaTuDong.TabIndex = 2;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "macthdx";
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "macthdx";
            this.Column1.HeaderText = "Mã CTHĐ";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "mahdx";
            this.Column2.HeaderText = "Mã HDX";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "tensp";
            this.Column3.HeaderText = "Tên sản phẩm";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "soluong";
            this.Column4.HeaderText = "Số lượng";
            this.Column4.Name = "Column4";
            // 
            // frmCTHDxuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnXemTatCa);
            this.Controls.Add(this.grbTienIch);
            this.Controls.Add(this.grbCTHDX);
            this.Controls.Add(this.grbBangDL);
            this.Controls.Add(this.grbHDX);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCTHDxuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết hóa đơn xuất";
            this.Load += new System.EventHandler(this.frmCTHDxuat_Load);
            this.grbHDX.ResumeLayout(false);
            this.grbHDX.PerformLayout();
            this.grbCTHDX.ResumeLayout(false);
            this.grbCTHDX.PerformLayout();
            this.grbBangDL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBang_tam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTXuat)).EndInit();
            this.grbTienIch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLayMaTuDong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbHDX;
        private System.Windows.Forms.GroupBox grbCTHDX;
        private System.Windows.Forms.GroupBox grbBangDL;
        private System.Windows.Forms.GroupBox grbTienIch;
        private System.Windows.Forms.ComboBox txtMaHD_hdx;
        private System.Windows.Forms.Button btnXemTatCa;
        private System.Windows.Forms.TextBox txtMaKH_hdx;
        private System.Windows.Forms.TextBox txtNgayTao_hdx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoLuong_ct;
        private System.Windows.Forms.TextBox txtMaCTHD_ct;
        private System.Windows.Forms.ComboBox txtMaSP_ct;
        private System.Windows.Forms.DataGridView dgvBang_tam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridView dgvCTXuat;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.DataGridView dgvLayMaTuDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}