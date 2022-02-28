namespace GUI_PhuKienTheThao
{
    partial class frmQLSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLSanPham));
            this.grbNhapLieu = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbMaLoai = new System.Windows.Forms.ComboBox();
            this.txtSoLuongton = new System.Windows.Forms.TextBox();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.grbDanhMucSP = new System.Windows.Forms.GroupBox();
            this.dgvLayMa = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDanhMuc = new System.Windows.Forms.DataGridView();
            this.grbNutBam = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbTimLoai = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTimLoai = new System.Windows.Forms.Button();
            this.grbTimGia = new System.Windows.Forms.GroupBox();
            this.btnTimGia = new System.Windows.Forms.Button();
            this.ckb500mns = new System.Windows.Forms.CheckBox();
            this.ckb1000pls = new System.Windows.Forms.CheckBox();
            this.ckb1000mns = new System.Windows.Forms.CheckBox();
            this.ckb500pls = new System.Windows.Forms.CheckBox();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbNhapLieu.SuspendLayout();
            this.grbDanhMucSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLayMa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).BeginInit();
            this.grbNutBam.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grbTimGia.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbNhapLieu
            // 
            this.grbNhapLieu.BackColor = System.Drawing.Color.Transparent;
            this.grbNhapLieu.Controls.Add(this.label6);
            this.grbNhapLieu.Controls.Add(this.label5);
            this.grbNhapLieu.Controls.Add(this.label4);
            this.grbNhapLieu.Controls.Add(this.label3);
            this.grbNhapLieu.Controls.Add(this.label2);
            this.grbNhapLieu.Controls.Add(this.label1);
            this.grbNhapLieu.Controls.Add(this.cbbMaLoai);
            this.grbNhapLieu.Controls.Add(this.txtSoLuongton);
            this.grbNhapLieu.Controls.Add(this.txtGiaNhap);
            this.grbNhapLieu.Controls.Add(this.txtGiaBan);
            this.grbNhapLieu.Controls.Add(this.txtTenSP);
            this.grbNhapLieu.Controls.Add(this.txtMaSP);
            this.grbNhapLieu.Location = new System.Drawing.Point(9, 6);
            this.grbNhapLieu.Name = "grbNhapLieu";
            this.grbNhapLieu.Size = new System.Drawing.Size(803, 111);
            this.grbNhapLieu.TabIndex = 0;
            this.grbNhapLieu.TabStop = false;
            this.grbNhapLieu.Text = "Nhập liệu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(464, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Số lượng tồn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(464, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Giá bán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(464, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Giá nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Loại sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã sản phẩm";
            // 
            // cbbMaLoai
            // 
            this.cbbMaLoai.DisplayMember = "Lựa chọn mã loại SP";
            this.cbbMaLoai.FormattingEnabled = true;
            this.cbbMaLoai.Location = new System.Drawing.Point(178, 75);
            this.cbbMaLoai.Name = "cbbMaLoai";
            this.cbbMaLoai.Size = new System.Drawing.Size(148, 21);
            this.cbbMaLoai.TabIndex = 6;
            this.cbbMaLoai.ValueMember = "Lựa chọn mã loại SP";
            this.cbbMaLoai.SelectedValueChanged += new System.EventHandler(this.cbbMaLoai_SelectedValueChanged);
            // 
            // txtSoLuongton
            // 
            this.txtSoLuongton.Location = new System.Drawing.Point(575, 75);
            this.txtSoLuongton.Name = "txtSoLuongton";
            this.txtSoLuongton.Size = new System.Drawing.Size(148, 20);
            this.txtSoLuongton.TabIndex = 5;
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(575, 23);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(148, 20);
            this.txtGiaNhap.TabIndex = 4;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(575, 49);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(148, 20);
            this.txtGiaBan.TabIndex = 2;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(178, 49);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(148, 20);
            this.txtTenSP.TabIndex = 1;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(178, 23);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(148, 20);
            this.txtMaSP.TabIndex = 0;
            // 
            // grbDanhMucSP
            // 
            this.grbDanhMucSP.BackColor = System.Drawing.Color.Transparent;
            this.grbDanhMucSP.Controls.Add(this.dgvLayMa);
            this.grbDanhMucSP.Controls.Add(this.dgvDanhMuc);
            this.grbDanhMucSP.Location = new System.Drawing.Point(9, 282);
            this.grbDanhMucSP.Name = "grbDanhMucSP";
            this.grbDanhMucSP.Size = new System.Drawing.Size(803, 192);
            this.grbDanhMucSP.TabIndex = 1;
            this.grbDanhMucSP.TabStop = false;
            this.grbDanhMucSP.Text = "Danh mục sản phẩm";
            // 
            // dgvLayMa
            // 
            this.dgvLayMa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLayMa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7});
            this.dgvLayMa.Location = new System.Drawing.Point(628, 73);
            this.dgvLayMa.Name = "dgvLayMa";
            this.dgvLayMa.Size = new System.Drawing.Size(153, 100);
            this.dgvLayMa.TabIndex = 4;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "masp";
            this.Column7.HeaderText = "masp";
            this.Column7.Name = "Column7";
            // 
            // dgvDanhMuc
            // 
            this.dgvDanhMuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhMuc.Location = new System.Drawing.Point(3, 16);
            this.dgvDanhMuc.Name = "dgvDanhMuc";
            this.dgvDanhMuc.Size = new System.Drawing.Size(797, 173);
            this.dgvDanhMuc.TabIndex = 0;
            this.dgvDanhMuc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhMuc_CellClick);
            // 
            // grbNutBam
            // 
            this.grbNutBam.BackColor = System.Drawing.Color.Transparent;
            this.grbNutBam.Controls.Add(this.btnThem);
            this.grbNutBam.Controls.Add(this.btnSua);
            this.grbNutBam.Controls.Add(this.btnXoa);
            this.grbNutBam.Controls.Add(this.btnHuyBo);
            this.grbNutBam.Controls.Add(this.btnLamMoi);
            this.grbNutBam.Location = new System.Drawing.Point(9, 122);
            this.grbNutBam.Name = "grbNutBam";
            this.grbNutBam.Size = new System.Drawing.Size(380, 154);
            this.grbNutBam.TabIndex = 2;
            this.grbNutBam.TabStop = false;
            this.grbNutBam.Text = "Tiện ích";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DimGray;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThem.Location = new System.Drawing.Point(146, 24);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(88, 42);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Lưu";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.DimGray;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSua.Location = new System.Drawing.Point(146, 97);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(88, 42);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.DimGray;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXoa.Location = new System.Drawing.Point(268, 24);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(88, 42);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.BackColor = System.Drawing.Color.DimGray;
            this.btnHuyBo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyBo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHuyBo.Location = new System.Drawing.Point(268, 97);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(88, 42);
            this.btnHuyBo.TabIndex = 1;
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.UseVisualStyleBackColor = false;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.DimGray;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLamMoi.Location = new System.Drawing.Point(25, 59);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(88, 42);
            this.btnLamMoi.TabIndex = 0;
            this.btnLamMoi.Text = "Thêm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnOut
            // 
            this.btnOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOut.Location = new System.Drawing.Point(674, 480);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(96, 36);
            this.btnOut.TabIndex = 3;
            this.btnOut.Text = "Ra sảnh";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbbTimLoai);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnTimLoai);
            this.groupBox1.Location = new System.Drawing.Point(414, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 48);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm theo loại sản phẩm";
            // 
            // cbbTimLoai
            // 
            this.cbbTimLoai.FormattingEnabled = true;
            this.cbbTimLoai.Location = new System.Drawing.Point(102, 16);
            this.cbbTimLoai.Name = "cbbTimLoai";
            this.cbbTimLoai.Size = new System.Drawing.Size(152, 21);
            this.cbbTimLoai.TabIndex = 3;
            this.cbbTimLoai.SelectedIndexChanged += new System.EventHandler(this.cbbTimLoai_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Loại sản phẩm";
            // 
            // btnTimLoai
            // 
            this.btnTimLoai.Location = new System.Drawing.Point(260, 12);
            this.btnTimLoai.Name = "btnTimLoai";
            this.btnTimLoai.Size = new System.Drawing.Size(75, 29);
            this.btnTimLoai.TabIndex = 1;
            this.btnTimLoai.Text = "Tìm";
            this.btnTimLoai.UseVisualStyleBackColor = true;
            this.btnTimLoai.Click += new System.EventHandler(this.btnTimLoai_Click);
            // 
            // grbTimGia
            // 
            this.grbTimGia.Controls.Add(this.btnTimGia);
            this.grbTimGia.Controls.Add(this.ckb500mns);
            this.grbTimGia.Controls.Add(this.ckb1000pls);
            this.grbTimGia.Controls.Add(this.ckb1000mns);
            this.grbTimGia.Controls.Add(this.ckb500pls);
            this.grbTimGia.Location = new System.Drawing.Point(414, 183);
            this.grbTimGia.Name = "grbTimGia";
            this.grbTimGia.Size = new System.Drawing.Size(318, 93);
            this.grbTimGia.TabIndex = 5;
            this.grbTimGia.TabStop = false;
            this.grbTimGia.Text = "Tìm theo mức giá";
            // 
            // btnTimGia
            // 
            this.btnTimGia.Location = new System.Drawing.Point(233, 55);
            this.btnTimGia.Name = "btnTimGia";
            this.btnTimGia.Size = new System.Drawing.Size(71, 27);
            this.btnTimGia.TabIndex = 4;
            this.btnTimGia.Text = "Tìm";
            this.btnTimGia.UseVisualStyleBackColor = true;
            this.btnTimGia.Click += new System.EventHandler(this.btnTimGia_Click);
            // 
            // ckb500mns
            // 
            this.ckb500mns.AutoSize = true;
            this.ckb500mns.Location = new System.Drawing.Point(23, 61);
            this.ckb500mns.Name = "ckb500mns";
            this.ckb500mns.Size = new System.Drawing.Size(74, 17);
            this.ckb500mns.TabIndex = 3;
            this.ckb500mns.Text = "< 500.000";
            this.ckb500mns.UseVisualStyleBackColor = true;
            this.ckb500mns.Click += new System.EventHandler(this.ckb500mns_Click);
            // 
            // ckb1000pls
            // 
            this.ckb1000pls.AutoSize = true;
            this.ckb1000pls.Location = new System.Drawing.Point(171, 23);
            this.ckb1000pls.Name = "ckb1000pls";
            this.ckb1000pls.Size = new System.Drawing.Size(83, 17);
            this.ckb1000pls.TabIndex = 2;
            this.ckb1000pls.Text = "> 1.000.000";
            this.ckb1000pls.UseVisualStyleBackColor = true;
            this.ckb1000pls.Click += new System.EventHandler(this.ckb1000pls_Click);
            // 
            // ckb1000mns
            // 
            this.ckb1000mns.AutoSize = true;
            this.ckb1000mns.Location = new System.Drawing.Point(132, 61);
            this.ckb1000mns.Name = "ckb1000mns";
            this.ckb1000mns.Size = new System.Drawing.Size(83, 17);
            this.ckb1000mns.TabIndex = 1;
            this.ckb1000mns.Text = "< 1.000.000";
            this.ckb1000mns.UseVisualStyleBackColor = true;
            this.ckb1000mns.Click += new System.EventHandler(this.ckb1000mns_Click);
            // 
            // ckb500pls
            // 
            this.ckb500pls.AutoSize = true;
            this.ckb500pls.Location = new System.Drawing.Point(61, 23);
            this.ckb500pls.Name = "ckb500pls";
            this.ckb500pls.Size = new System.Drawing.Size(74, 17);
            this.ckb500pls.TabIndex = 0;
            this.ckb500pls.Text = "> 500.000";
            this.ckb500pls.UseVisualStyleBackColor = true;
            this.ckb500pls.Click += new System.EventHandler(this.ckb500pls_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(748, 201);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(61, 60);
            this.btnViewAll.TabIndex = 6;
            this.btnViewAll.Text = "Xem Tất cả";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "masp";
            this.Column1.HeaderText = "Mã sản phẩm";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tensp";
            this.Column2.HeaderText = "Tên sản phẩm";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "tenloaisp";
            this.Column3.HeaderText = "Loại sản phẩm";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "gianhap";
            this.Column4.HeaderText = "Giá nhập";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "giaban";
            this.Column5.HeaderText = "Giá bán";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "soluongton";
            this.Column6.HeaderText = "Số lượng tồn";
            this.Column6.Name = "Column6";
            // 
            // frmQLSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(824, 521);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.grbTimGia);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.grbNutBam);
            this.Controls.Add(this.grbDanhMucSP);
            this.Controls.Add(this.grbNhapLieu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQLSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí Sản phẩm";
            this.Load += new System.EventHandler(this.frmQLSanPham_Load);
            this.grbNhapLieu.ResumeLayout(false);
            this.grbNhapLieu.PerformLayout();
            this.grbDanhMucSP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLayMa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).EndInit();
            this.grbNutBam.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbTimGia.ResumeLayout(false);
            this.grbTimGia.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbNhapLieu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbMaLoai;
        private System.Windows.Forms.TextBox txtSoLuongton;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.GroupBox grbDanhMucSP;
        private System.Windows.Forms.DataGridView dgvDanhMuc;
        private System.Windows.Forms.GroupBox grbNutBam;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.DataGridView dgvLayMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbTimLoai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTimLoai;
        private System.Windows.Forms.GroupBox grbTimGia;
        private System.Windows.Forms.CheckBox ckb500mns;
        private System.Windows.Forms.CheckBox ckb1000pls;
        private System.Windows.Forms.CheckBox ckb1000mns;
        private System.Windows.Forms.CheckBox ckb500pls;
        private System.Windows.Forms.Button btnTimGia;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}