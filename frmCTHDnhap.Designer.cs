namespace GUI_PhuKienTheThao
{
    partial class frmCTHDnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCTHDnhap));
            this.grbHoaDon = new System.Windows.Forms.GroupBox();
            this.txtMaHD = new System.Windows.Forms.ComboBox();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.txtNgayTao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbNhapLieu_ChiTiet = new System.Windows.Forms.GroupBox();
            this.txtMaSP = new System.Windows.Forms.ComboBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.txtMaCTHD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvCTHDnhap = new System.Windows.Forms.DataGridView();
            this.dgv_Hoadon = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbTienIch = new System.Windows.Forms.GroupBox();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvgetMaAuto = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbHoaDon.SuspendLayout();
            this.grbNhapLieu_ChiTiet.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHDnhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Hoadon)).BeginInit();
            this.grbTienIch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgetMaAuto)).BeginInit();
            this.SuspendLayout();
            // 
            // grbHoaDon
            // 
            this.grbHoaDon.Controls.Add(this.txtMaHD);
            this.grbHoaDon.Controls.Add(this.txtMaNCC);
            this.grbHoaDon.Controls.Add(this.txtNgayTao);
            this.grbHoaDon.Controls.Add(this.label3);
            this.grbHoaDon.Controls.Add(this.label2);
            this.grbHoaDon.Controls.Add(this.label1);
            this.grbHoaDon.Location = new System.Drawing.Point(3, 4);
            this.grbHoaDon.Name = "grbHoaDon";
            this.grbHoaDon.Size = new System.Drawing.Size(265, 108);
            this.grbHoaDon.TabIndex = 0;
            this.grbHoaDon.TabStop = false;
            this.grbHoaDon.Text = "Hóa đơn nhập";
            // 
            // txtMaHD
            // 
            this.txtMaHD.FormattingEnabled = true;
            this.txtMaHD.Location = new System.Drawing.Point(94, 20);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(165, 21);
            this.txtMaHD.TabIndex = 6;
            this.txtMaHD.SelectedIndexChanged += new System.EventHandler(this.txtMaHD_SelectedIndexChanged);
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(94, 73);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(165, 20);
            this.txtMaNCC.TabIndex = 5;
            // 
            // txtNgayTao
            // 
            this.txtNgayTao.Location = new System.Drawing.Point(94, 48);
            this.txtNgayTao.Name = "txtNgayTao";
            this.txtNgayTao.Size = new System.Drawing.Size(165, 20);
            this.txtNgayTao.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhà cung cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày tạo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn";
            // 
            // grbNhapLieu_ChiTiet
            // 
            this.grbNhapLieu_ChiTiet.Controls.Add(this.txtMaSP);
            this.grbNhapLieu_ChiTiet.Controls.Add(this.txtSoluong);
            this.grbNhapLieu_ChiTiet.Controls.Add(this.txtMaCTHD);
            this.grbNhapLieu_ChiTiet.Controls.Add(this.label7);
            this.grbNhapLieu_ChiTiet.Controls.Add(this.label5);
            this.grbNhapLieu_ChiTiet.Controls.Add(this.label4);
            this.grbNhapLieu_ChiTiet.Location = new System.Drawing.Point(274, 4);
            this.grbNhapLieu_ChiTiet.Name = "grbNhapLieu_ChiTiet";
            this.grbNhapLieu_ChiTiet.Size = new System.Drawing.Size(491, 108);
            this.grbNhapLieu_ChiTiet.TabIndex = 1;
            this.grbNhapLieu_ChiTiet.TabStop = false;
            this.grbNhapLieu_ChiTiet.Text = "Chi tiết hóa đơn";
            // 
            // txtMaSP
            // 
            this.txtMaSP.FormattingEnabled = true;
            this.txtMaSP.Location = new System.Drawing.Point(92, 70);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(135, 21);
            this.txtMaSP.TabIndex = 6;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(349, 19);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(134, 20);
            this.txtSoluong.TabIndex = 5;
            // 
            // txtMaCTHD
            // 
            this.txtMaCTHD.Location = new System.Drawing.Point(92, 20);
            this.txtMaCTHD.Name = "txtMaCTHD";
            this.txtMaCTHD.Size = new System.Drawing.Size(135, 20);
            this.txtMaCTHD.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(267, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Số lượng nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tên sản phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã CTHĐ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvgetMaAuto);
            this.groupBox3.Controls.Add(this.dgvCTHDnhap);
            this.groupBox3.Location = new System.Drawing.Point(3, 192);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(762, 255);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dữ liệu CTHĐ";
            // 
            // dgvCTHDnhap
            // 
            this.dgvCTHDnhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTHDnhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHDnhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvCTHDnhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCTHDnhap.Location = new System.Drawing.Point(3, 16);
            this.dgvCTHDnhap.Name = "dgvCTHDnhap";
            this.dgvCTHDnhap.Size = new System.Drawing.Size(756, 236);
            this.dgvCTHDnhap.TabIndex = 0;
            this.dgvCTHDnhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTHDnhap_CellClick);
            // 
            // dgv_Hoadon
            // 
            this.dgv_Hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Hoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6});
            this.dgv_Hoadon.Location = new System.Drawing.Point(453, 243);
            this.dgv_Hoadon.Name = "dgv_Hoadon";
            this.dgv_Hoadon.Size = new System.Drawing.Size(240, 150);
            this.dgv_Hoadon.TabIndex = 6;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ngaynhap";
            this.Column5.HeaderText = "Ngày tạo";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "mancc";
            this.Column6.HeaderText = "Mã ncc";
            this.Column6.Name = "Column6";
            // 
            // grbTienIch
            // 
            this.grbTienIch.Controls.Add(this.btnHuyBo);
            this.grbTienIch.Controls.Add(this.btnXoa);
            this.grbTienIch.Controls.Add(this.btnSua);
            this.grbTienIch.Controls.Add(this.btnLuu);
            this.grbTienIch.Controls.Add(this.btnThemMoi);
            this.grbTienIch.Location = new System.Drawing.Point(181, 118);
            this.grbTienIch.Name = "grbTienIch";
            this.grbTienIch.Size = new System.Drawing.Size(576, 68);
            this.grbTienIch.TabIndex = 1;
            this.grbTienIch.TabStop = false;
            this.grbTienIch.Text = "Tiện ích";
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Location = new System.Drawing.Point(481, 19);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(75, 34);
            this.btnHuyBo.TabIndex = 4;
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.UseVisualStyleBackColor = true;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(368, 19);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 34);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(253, 19);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 34);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(144, 19);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 34);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(36, 19);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(75, 34);
            this.btnThemMoi.TabIndex = 0;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(62, 128);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(86, 43);
            this.btnViewAll.TabIndex = 5;
            this.btnViewAll.Text = "Xem tất cả";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "macthdn";
            this.Column1.HeaderText = "Mã CTHĐ";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "mahdn";
            this.Column2.HeaderText = "Mã HDN";
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
            this.Column4.HeaderText = "Số lượng nhập";
            this.Column4.Name = "Column4";
            // 
            // dgvgetMaAuto
            // 
            this.dgvgetMaAuto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvgetMaAuto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7});
            this.dgvgetMaAuto.Location = new System.Drawing.Point(28, 154);
            this.dgvgetMaAuto.Name = "dgvgetMaAuto";
            this.dgvgetMaAuto.Size = new System.Drawing.Size(128, 81);
            this.dgvgetMaAuto.TabIndex = 1;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "macthdn";
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            // 
            // frmCTHDnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 450);
            this.Controls.Add(this.dgv_Hoadon);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.grbTienIch);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grbNhapLieu_ChiTiet);
            this.Controls.Add(this.grbHoaDon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCTHDnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết hóa đơn nhập";
            this.Load += new System.EventHandler(this.frmCTHDnhap_Load);
            this.grbHoaDon.ResumeLayout(false);
            this.grbHoaDon.PerformLayout();
            this.grbNhapLieu_ChiTiet.ResumeLayout(false);
            this.grbNhapLieu_ChiTiet.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHDnhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Hoadon)).EndInit();
            this.grbTienIch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvgetMaAuto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbHoaDon;
        private System.Windows.Forms.ComboBox txtMaHD;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.TextBox txtNgayTao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbNhapLieu_ChiTiet;
        private System.Windows.Forms.ComboBox txtMaSP;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.TextBox txtMaCTHD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvCTHDnhap;
        private System.Windows.Forms.GroupBox grbTienIch;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.DataGridView dgv_Hoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridView dgvgetMaAuto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}