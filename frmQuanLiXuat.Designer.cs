namespace GUI_PhuKienTheThao
{
    partial class frmQuanLiXuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLiXuat));
            this.btnOut = new System.Windows.Forms.Button();
            this.grbDulieu = new System.Windows.Forms.GroupBox();
            this.dgvLayMa = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBangDL = new System.Windows.Forms.DataGridView();
            this.grbButton = new System.Windows.Forms.GroupBox();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.grbText = new System.Windows.Forms.GroupBox();
            this.btnNewCustom = new System.Windows.Forms.Button();
            this.txtNVxuat = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.ComboBox();
            this.txtNgayTao2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNgayTao = new System.Windows.Forms.MaskedTextBox();
            this.txtMaHDX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCTHDxuat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grbTimKH = new System.Windows.Forms.GroupBox();
            this.cbbTimKH = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTimKH = new System.Windows.Forms.Button();
            this.grbTimGia = new System.Windows.Forms.GroupBox();
            this.ckbhon50 = new System.Windows.Forms.CheckBox();
            this.ckb10to500 = new System.Windows.Forms.CheckBox();
            this.ckb5to10 = new System.Windows.Forms.CheckBox();
            this.ckb1to5 = new System.Windows.Forms.CheckBox();
            this.ckbnho1 = new System.Windows.Forms.CheckBox();
            this.btnTimGia = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbDulieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLayMa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangDL)).BeginInit();
            this.grbButton.SuspendLayout();
            this.grbText.SuspendLayout();
            this.grbTimKH.SuspendLayout();
            this.grbTimGia.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOut
            // 
            this.btnOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOut.Location = new System.Drawing.Point(12, 425);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(96, 47);
            this.btnOut.TabIndex = 9;
            this.btnOut.Text = "Ra sảnh";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // grbDulieu
            // 
            this.grbDulieu.BackColor = System.Drawing.Color.Transparent;
            this.grbDulieu.Controls.Add(this.dgvLayMa);
            this.grbDulieu.Controls.Add(this.dgvBangDL);
            this.grbDulieu.Location = new System.Drawing.Point(7, 234);
            this.grbDulieu.Name = "grbDulieu";
            this.grbDulieu.Size = new System.Drawing.Size(882, 191);
            this.grbDulieu.TabIndex = 8;
            this.grbDulieu.TabStop = false;
            this.grbDulieu.Text = "Bảng dữ liệu";
            // 
            // dgvLayMa
            // 
            this.dgvLayMa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLayMa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4});
            this.dgvLayMa.Location = new System.Drawing.Point(414, 196);
            this.dgvLayMa.Name = "dgvLayMa";
            this.dgvLayMa.Size = new System.Drawing.Size(152, 76);
            this.dgvLayMa.TabIndex = 11;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "mahdx";
            this.Column4.HeaderText = "mahoadon";
            this.Column4.Name = "Column4";
            // 
            // dgvBangDL
            // 
            this.dgvBangDL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBangDL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangDL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column6});
            this.dgvBangDL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBangDL.Location = new System.Drawing.Point(3, 16);
            this.dgvBangDL.Name = "dgvBangDL";
            this.dgvBangDL.Size = new System.Drawing.Size(876, 172);
            this.dgvBangDL.TabIndex = 0;
            this.dgvBangDL.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBangDL_CellClick);
            // 
            // grbButton
            // 
            this.grbButton.BackColor = System.Drawing.Color.Transparent;
            this.grbButton.Controls.Add(this.btnHuyBo);
            this.grbButton.Controls.Add(this.btnSua);
            this.grbButton.Controls.Add(this.btnThemMoi);
            this.grbButton.Controls.Add(this.btnXoa);
            this.grbButton.Controls.Add(this.btnLuu);
            this.grbButton.Location = new System.Drawing.Point(7, 84);
            this.grbButton.Name = "grbButton";
            this.grbButton.Size = new System.Drawing.Size(288, 144);
            this.grbButton.TabIndex = 7;
            this.grbButton.TabStop = false;
            this.grbButton.Text = "Tiện ích";
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuyBo.Location = new System.Drawing.Point(194, 78);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(75, 29);
            this.btnHuyBo.TabIndex = 7;
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.UseVisualStyleBackColor = true;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnSua
            // 
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.Location = new System.Drawing.Point(194, 43);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 29);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemMoi.Location = new System.Drawing.Point(23, 43);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(75, 63);
            this.btnThemMoi.TabIndex = 3;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Location = new System.Drawing.Point(111, 78);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 29);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.Location = new System.Drawing.Point(111, 43);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 29);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // grbText
            // 
            this.grbText.BackColor = System.Drawing.Color.Transparent;
            this.grbText.Controls.Add(this.btnNewCustom);
            this.grbText.Controls.Add(this.txtNVxuat);
            this.grbText.Controls.Add(this.label5);
            this.grbText.Controls.Add(this.txtMaKH);
            this.grbText.Controls.Add(this.txtNgayTao2);
            this.grbText.Controls.Add(this.label4);
            this.grbText.Controls.Add(this.txtNgayTao);
            this.grbText.Controls.Add(this.txtMaHDX);
            this.grbText.Controls.Add(this.label3);
            this.grbText.Controls.Add(this.label2);
            this.grbText.Controls.Add(this.label1);
            this.grbText.Location = new System.Drawing.Point(100, 2);
            this.grbText.Name = "grbText";
            this.grbText.Size = new System.Drawing.Size(786, 79);
            this.grbText.TabIndex = 6;
            this.grbText.TabStop = false;
            this.grbText.Text = "Nhập dữ liệu";
            // 
            // btnNewCustom
            // 
            this.btnNewCustom.Location = new System.Drawing.Point(229, 46);
            this.btnNewCustom.Name = "btnNewCustom";
            this.btnNewCustom.Size = new System.Drawing.Size(72, 23);
            this.btnNewCustom.TabIndex = 10;
            this.btnNewCustom.Text = "Khách mới";
            this.btnNewCustom.UseVisualStyleBackColor = true;
            this.btnNewCustom.Click += new System.EventHandler(this.btnNewCustom_Click);
            // 
            // txtNVxuat
            // 
            this.txtNVxuat.FormattingEnabled = true;
            this.txtNVxuat.Location = new System.Drawing.Point(602, 11);
            this.txtNVxuat.Name = "txtNVxuat";
            this.txtNVxuat.Size = new System.Drawing.Size(161, 21);
            this.txtNVxuat.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(491, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nhân viên xuất";
            // 
            // txtMaKH
            // 
            this.txtMaKH.FormattingEnabled = true;
            this.txtMaKH.Location = new System.Drawing.Point(88, 47);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(135, 21);
            this.txtMaKH.TabIndex = 7;
            this.txtMaKH.Click += new System.EventHandler(this.txtMaKH_Click);
            // 
            // txtNgayTao2
            // 
            this.txtNgayTao2.Location = new System.Drawing.Point(602, 47);
            this.txtNgayTao2.Name = "txtNgayTao2";
            this.txtNgayTao2.Size = new System.Drawing.Size(161, 20);
            this.txtNgayTao2.TabIndex = 6;
            this.txtNgayTao2.Click += new System.EventHandler(this.txtNgayTao2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(485, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "(tháng / ngày / năm)";
            // 
            // txtNgayTao
            // 
            this.txtNgayTao.Location = new System.Drawing.Point(602, 47);
            this.txtNgayTao.Mask = "00-00-0000";
            this.txtNgayTao.Name = "txtNgayTao";
            this.txtNgayTao.Size = new System.Drawing.Size(161, 20);
            this.txtNgayTao.TabIndex = 4;
            // 
            // txtMaHDX
            // 
            this.txtMaHDX.Location = new System.Drawing.Point(88, 16);
            this.txtMaHDX.Name = "txtMaHDX";
            this.txtMaHDX.Size = new System.Drawing.Size(213, 20);
            this.txtMaHDX.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(491, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày Xuất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn";
            // 
            // btnCTHDxuat
            // 
            this.btnCTHDxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCTHDxuat.Location = new System.Drawing.Point(735, 425);
            this.btnCTHDxuat.Name = "btnCTHDxuat";
            this.btnCTHDxuat.Size = new System.Drawing.Size(150, 47);
            this.btnCTHDxuat.TabIndex = 10;
            this.btnCTHDxuat.Text = "Xem chi tiết";
            this.btnCTHDxuat.UseVisualStyleBackColor = true;
            this.btnCTHDxuat.Click += new System.EventHandler(this.btnCTHDxuat_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 63);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cập nhật";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grbTimKH
            // 
            this.grbTimKH.Controls.Add(this.cbbTimKH);
            this.grbTimKH.Controls.Add(this.label6);
            this.grbTimKH.Controls.Add(this.btnTimKH);
            this.grbTimKH.Location = new System.Drawing.Point(302, 84);
            this.grbTimKH.Name = "grbTimKH";
            this.grbTimKH.Size = new System.Drawing.Size(449, 59);
            this.grbTimKH.TabIndex = 11;
            this.grbTimKH.TabStop = false;
            this.grbTimKH.Text = "Tìm theo khách hàng";
            // 
            // cbbTimKH
            // 
            this.cbbTimKH.FormattingEnabled = true;
            this.cbbTimKH.Location = new System.Drawing.Point(125, 22);
            this.cbbTimKH.Name = "cbbTimKH";
            this.cbbTimKH.Size = new System.Drawing.Size(239, 21);
            this.cbbTimKH.TabIndex = 15;
            this.cbbTimKH.SelectedIndexChanged += new System.EventHandler(this.cbbTimKH_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Khách hàng";
            // 
            // btnTimKH
            // 
            this.btnTimKH.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKH.Image")));
            this.btnTimKH.Location = new System.Drawing.Point(399, 15);
            this.btnTimKH.Name = "btnTimKH";
            this.btnTimKH.Size = new System.Drawing.Size(40, 34);
            this.btnTimKH.TabIndex = 13;
            this.btnTimKH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKH.UseVisualStyleBackColor = true;
            this.btnTimKH.Click += new System.EventHandler(this.btnTimKH_Click);
            // 
            // grbTimGia
            // 
            this.grbTimGia.Controls.Add(this.ckbhon50);
            this.grbTimGia.Controls.Add(this.ckb10to500);
            this.grbTimGia.Controls.Add(this.ckb5to10);
            this.grbTimGia.Controls.Add(this.ckb1to5);
            this.grbTimGia.Controls.Add(this.ckbnho1);
            this.grbTimGia.Controls.Add(this.btnTimGia);
            this.grbTimGia.Location = new System.Drawing.Point(302, 149);
            this.grbTimGia.Name = "grbTimGia";
            this.grbTimGia.Size = new System.Drawing.Size(567, 79);
            this.grbTimGia.TabIndex = 12;
            this.grbTimGia.TabStop = false;
            this.grbTimGia.Text = "Tìm theo giá trị hóa đơn";
            // 
            // ckbhon50
            // 
            this.ckbhon50.AutoSize = true;
            this.ckbhon50.Location = new System.Drawing.Point(412, 34);
            this.ckbhon50.Name = "ckbhon50";
            this.ckbhon50.Size = new System.Drawing.Size(70, 17);
            this.ckbhon50.TabIndex = 19;
            this.ckbhon50.Text = "> 50 triệu";
            this.ckbhon50.UseVisualStyleBackColor = true;
            this.ckbhon50.Click += new System.EventHandler(this.ckbhon50_Click);
            // 
            // ckb10to500
            // 
            this.ckb10to500.AutoSize = true;
            this.ckb10to500.Location = new System.Drawing.Point(305, 34);
            this.ckb10to500.Name = "ckb10to500";
            this.ckb10to500.Size = new System.Drawing.Size(82, 17);
            this.ckb10to500.TabIndex = 18;
            this.ckb10to500.Text = "10 - 50 triệu";
            this.ckb10to500.UseVisualStyleBackColor = true;
            this.ckb10to500.Click += new System.EventHandler(this.ckb10to500_Click);
            // 
            // ckb5to10
            // 
            this.ckb5to10.AutoSize = true;
            this.ckb5to10.Location = new System.Drawing.Point(199, 34);
            this.ckb5to10.Name = "ckb5to10";
            this.ckb5to10.Size = new System.Drawing.Size(76, 17);
            this.ckb5to10.TabIndex = 17;
            this.ckb5to10.Text = "5 - 10 triệu";
            this.ckb5to10.UseVisualStyleBackColor = true;
            this.ckb5to10.Click += new System.EventHandler(this.ckb5to10_Click);
            // 
            // ckb1to5
            // 
            this.ckb1to5.AutoSize = true;
            this.ckb1to5.Location = new System.Drawing.Point(102, 34);
            this.ckb1to5.Name = "ckb1to5";
            this.ckb1to5.Size = new System.Drawing.Size(70, 17);
            this.ckb1to5.TabIndex = 16;
            this.ckb1to5.Text = "1 - 5 triệu";
            this.ckb1to5.UseVisualStyleBackColor = true;
            this.ckb1to5.Click += new System.EventHandler(this.ckb1to5_Click);
            // 
            // ckbnho1
            // 
            this.ckbnho1.AutoSize = true;
            this.ckbnho1.Location = new System.Drawing.Point(14, 34);
            this.ckbnho1.Name = "ckbnho1";
            this.ckbnho1.Size = new System.Drawing.Size(64, 17);
            this.ckbnho1.TabIndex = 15;
            this.ckbnho1.Text = "< 1 triệu";
            this.ckbnho1.UseVisualStyleBackColor = true;
            this.ckbnho1.Click += new System.EventHandler(this.ckbnho1_Click);
            // 
            // btnTimGia
            // 
            this.btnTimGia.Image = ((System.Drawing.Image)(resources.GetObject("btnTimGia.Image")));
            this.btnTimGia.Location = new System.Drawing.Point(506, 20);
            this.btnTimGia.Name = "btnTimGia";
            this.btnTimGia.Size = new System.Drawing.Size(50, 43);
            this.btnTimGia.TabIndex = 14;
            this.btnTimGia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimGia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimGia.UseVisualStyleBackColor = true;
            this.btnTimGia.Click += new System.EventHandler(this.btnTimGia_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAll.Location = new System.Drawing.Point(769, 93);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(100, 46);
            this.btnViewAll.TabIndex = 14;
            this.btnViewAll.Text = "View all";
            this.btnViewAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "mahdx";
            this.Column1.HeaderText = "Mã hóa đơn";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tenkh";
            this.Column2.HeaderText = "Tên khách hàng";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ngayxuat";
            this.Column3.HeaderText = "Ngày tạo";
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "tennv";
            this.Column5.HeaderText = "Nhân viên xuất";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "giatrihoadon";
            this.Column6.HeaderText = "Giá trị đơn hàng";
            this.Column6.Name = "Column6";
            // 
            // frmQuanLiXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 475);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.grbTimGia);
            this.Controls.Add(this.grbTimKH);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCTHDxuat);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.grbButton);
            this.Controls.Add(this.grbDulieu);
            this.Controls.Add(this.grbText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQuanLiXuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí xuất";
            this.Load += new System.EventHandler(this.frmQuanLiXuat_Load);
            this.grbDulieu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLayMa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangDL)).EndInit();
            this.grbButton.ResumeLayout(false);
            this.grbText.ResumeLayout(false);
            this.grbText.PerformLayout();
            this.grbTimKH.ResumeLayout(false);
            this.grbTimKH.PerformLayout();
            this.grbTimGia.ResumeLayout(false);
            this.grbTimGia.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.GroupBox grbDulieu;
        private System.Windows.Forms.DataGridView dgvBangDL;
        private System.Windows.Forms.GroupBox grbButton;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.GroupBox grbText;
        private System.Windows.Forms.ComboBox txtMaKH;
        private System.Windows.Forms.TextBox txtNgayTao2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtNgayTao;
        private System.Windows.Forms.TextBox txtMaHDX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCTHDxuat;
        private System.Windows.Forms.DataGridView dgvLayMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ComboBox txtNVxuat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grbTimKH;
        private System.Windows.Forms.ComboBox cbbTimKH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTimKH;
        private System.Windows.Forms.GroupBox grbTimGia;
        private System.Windows.Forms.CheckBox ckbhon50;
        private System.Windows.Forms.CheckBox ckb10to500;
        private System.Windows.Forms.CheckBox ckb5to10;
        private System.Windows.Forms.CheckBox ckb1to5;
        private System.Windows.Forms.CheckBox ckbnho1;
        private System.Windows.Forms.Button btnTimGia;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Button btnNewCustom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}