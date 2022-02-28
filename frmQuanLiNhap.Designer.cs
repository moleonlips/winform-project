namespace GUI_PhuKienTheThao
{
    partial class frmQuanLiNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLiNhap));
            this.grbText = new System.Windows.Forms.GroupBox();
            this.txtNVnhap = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNCC = new System.Windows.Forms.ComboBox();
            this.txtNgayTao2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNgayTao = new System.Windows.Forms.MaskedTextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbButton = new System.Windows.Forms.GroupBox();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.grbDulieu = new System.Windows.Forms.GroupBox();
            this.dgvLayMa = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBangDL = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnCTHDxuat = new System.Windows.Forms.Button();
            this.grbTimNcc = new System.Windows.Forms.GroupBox();
            this.btnTimNcc = new System.Windows.Forms.Button();
            this.cbbTimNcc = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimGia = new System.Windows.Forms.Button();
            this.ckb5to10 = new System.Windows.Forms.CheckBox();
            this.ckb50pls = new System.Windows.Forms.CheckBox();
            this.ckb10to50 = new System.Windows.Forms.CheckBox();
            this.ckb1to5 = new System.Windows.Forms.CheckBox();
            this.ckb1mns = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUpDateBill = new System.Windows.Forms.Button();
            this.grbText.SuspendLayout();
            this.grbButton.SuspendLayout();
            this.grbDulieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLayMa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangDL)).BeginInit();
            this.grbTimNcc.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbText
            // 
            this.grbText.BackColor = System.Drawing.Color.Transparent;
            this.grbText.Controls.Add(this.txtNVnhap);
            this.grbText.Controls.Add(this.label5);
            this.grbText.Controls.Add(this.txtNCC);
            this.grbText.Controls.Add(this.txtNgayTao2);
            this.grbText.Controls.Add(this.label4);
            this.grbText.Controls.Add(this.txtNgayTao);
            this.grbText.Controls.Add(this.txtMaHD);
            this.grbText.Controls.Add(this.label3);
            this.grbText.Controls.Add(this.label2);
            this.grbText.Controls.Add(this.label1);
            this.grbText.Location = new System.Drawing.Point(3, 4);
            this.grbText.Name = "grbText";
            this.grbText.Size = new System.Drawing.Size(847, 81);
            this.grbText.TabIndex = 0;
            this.grbText.TabStop = false;
            this.grbText.Text = "Nhập dữ liệu";
            // 
            // txtNVnhap
            // 
            this.txtNVnhap.FormattingEnabled = true;
            this.txtNVnhap.Location = new System.Drawing.Point(604, 19);
            this.txtNVnhap.Name = "txtNVnhap";
            this.txtNVnhap.Size = new System.Drawing.Size(161, 21);
            this.txtNVnhap.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(493, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nhân viên nhập";
            // 
            // txtNCC
            // 
            this.txtNCC.FormattingEnabled = true;
            this.txtNCC.Location = new System.Drawing.Point(194, 50);
            this.txtNCC.Name = "txtNCC";
            this.txtNCC.Size = new System.Drawing.Size(161, 21);
            this.txtNCC.TabIndex = 7;
            this.txtNCC.Click += new System.EventHandler(this.txtNCC_Click);
            // 
            // txtNgayTao2
            // 
            this.txtNgayTao2.Location = new System.Drawing.Point(604, 50);
            this.txtNgayTao2.Name = "txtNgayTao2";
            this.txtNgayTao2.Size = new System.Drawing.Size(161, 20);
            this.txtNgayTao2.TabIndex = 6;
            this.txtNgayTao2.Click += new System.EventHandler(this.txtNgayTao2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(487, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "(tháng / ngày / năm)";
            // 
            // txtNgayTao
            // 
            this.txtNgayTao.Location = new System.Drawing.Point(604, 50);
            this.txtNgayTao.Mask = "00-00-0000";
            this.txtNgayTao.Name = "txtNgayTao";
            this.txtNgayTao.Size = new System.Drawing.Size(161, 20);
            this.txtNgayTao.TabIndex = 4;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(194, 20);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(161, 20);
            this.txtMaHD.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(493, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã nhà cung cấp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn";
            // 
            // grbButton
            // 
            this.grbButton.BackColor = System.Drawing.Color.Transparent;
            this.grbButton.Controls.Add(this.btnHuyBo);
            this.grbButton.Controls.Add(this.btnSua);
            this.grbButton.Controls.Add(this.btnThemMoi);
            this.grbButton.Controls.Add(this.btnXoa);
            this.grbButton.Controls.Add(this.btnLuu);
            this.grbButton.Location = new System.Drawing.Point(3, 87);
            this.grbButton.Name = "grbButton";
            this.grbButton.Size = new System.Drawing.Size(296, 117);
            this.grbButton.TabIndex = 1;
            this.grbButton.TabStop = false;
            this.grbButton.Text = "Tiện ích";
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuyBo.Location = new System.Drawing.Point(203, 67);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(75, 27);
            this.btnHuyBo.TabIndex = 7;
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.UseVisualStyleBackColor = true;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnSua
            // 
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.Location = new System.Drawing.Point(119, 66);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 28);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemMoi.Location = new System.Drawing.Point(27, 28);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(78, 66);
            this.btnThemMoi.TabIndex = 3;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Location = new System.Drawing.Point(119, 28);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 30);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.Location = new System.Drawing.Point(203, 28);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 29);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // grbDulieu
            // 
            this.grbDulieu.BackColor = System.Drawing.Color.Transparent;
            this.grbDulieu.Controls.Add(this.dgvLayMa);
            this.grbDulieu.Controls.Add(this.dgvBangDL);
            this.grbDulieu.Location = new System.Drawing.Point(4, 208);
            this.grbDulieu.Name = "grbDulieu";
            this.grbDulieu.Size = new System.Drawing.Size(846, 217);
            this.grbDulieu.TabIndex = 2;
            this.grbDulieu.TabStop = false;
            this.grbDulieu.Text = "Bảng dữ liệu";
            // 
            // dgvLayMa
            // 
            this.dgvLayMa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLayMa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4});
            this.dgvLayMa.Location = new System.Drawing.Point(681, 99);
            this.dgvLayMa.Name = "dgvLayMa";
            this.dgvLayMa.Size = new System.Drawing.Size(145, 102);
            this.dgvLayMa.TabIndex = 1;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "mahdn";
            this.Column4.HeaderText = "mahdn";
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
            this.dgvBangDL.Size = new System.Drawing.Size(840, 198);
            this.dgvBangDL.TabIndex = 0;
            this.dgvBangDL.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBangDL_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "mahdn";
            this.Column1.HeaderText = "Mã hóa đơn";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "mancc";
            this.Column2.HeaderText = "Mã NCC";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ngaynhap";
            this.Column3.HeaderText = "Ngày tạo";
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "tennv";
            this.Column5.HeaderText = "Nhân viên nhập kho";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "giatrihoadon";
            this.Column6.HeaderText = "Giá trị hóa đơn";
            this.Column6.Name = "Column6";
            // 
            // btnOut
            // 
            this.btnOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOut.Location = new System.Drawing.Point(15, 432);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(96, 36);
            this.btnOut.TabIndex = 5;
            this.btnOut.Text = "Ra sảnh";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnCTHDxuat
            // 
            this.btnCTHDxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCTHDxuat.Location = new System.Drawing.Point(690, 427);
            this.btnCTHDxuat.Name = "btnCTHDxuat";
            this.btnCTHDxuat.Size = new System.Drawing.Size(150, 47);
            this.btnCTHDxuat.TabIndex = 11;
            this.btnCTHDxuat.Text = "Xem Chi Tiết";
            this.btnCTHDxuat.UseVisualStyleBackColor = true;
            this.btnCTHDxuat.Click += new System.EventHandler(this.btnCTHDxuat_Click);
            // 
            // grbTimNcc
            // 
            this.grbTimNcc.Controls.Add(this.btnTimNcc);
            this.grbTimNcc.Controls.Add(this.cbbTimNcc);
            this.grbTimNcc.Controls.Add(this.label6);
            this.grbTimNcc.Location = new System.Drawing.Point(305, 91);
            this.grbTimNcc.Name = "grbTimNcc";
            this.grbTimNcc.Size = new System.Drawing.Size(454, 51);
            this.grbTimNcc.TabIndex = 12;
            this.grbTimNcc.TabStop = false;
            this.grbTimNcc.Text = "Tìm theo Nhà cung cấp";
            // 
            // btnTimNcc
            // 
            this.btnTimNcc.Location = new System.Drawing.Point(372, 10);
            this.btnTimNcc.Name = "btnTimNcc";
            this.btnTimNcc.Size = new System.Drawing.Size(49, 35);
            this.btnTimNcc.TabIndex = 2;
            this.btnTimNcc.Text = "Tìm";
            this.btnTimNcc.UseVisualStyleBackColor = true;
            this.btnTimNcc.Click += new System.EventHandler(this.btnTimNcc_Click);
            // 
            // cbbTimNcc
            // 
            this.cbbTimNcc.FormattingEnabled = true;
            this.cbbTimNcc.Location = new System.Drawing.Point(166, 17);
            this.cbbTimNcc.Name = "cbbTimNcc";
            this.cbbTimNcc.Size = new System.Drawing.Size(190, 21);
            this.cbbTimNcc.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Chọn nhà cung cấp";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTimGia);
            this.groupBox1.Controls.Add(this.ckb5to10);
            this.groupBox1.Controls.Add(this.ckb50pls);
            this.groupBox1.Controls.Add(this.ckb10to50);
            this.groupBox1.Controls.Add(this.ckb1to5);
            this.groupBox1.Controls.Add(this.ckb1mns);
            this.groupBox1.Location = new System.Drawing.Point(305, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 57);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm theo giá trị hóa đơn";
            // 
            // btnTimGia
            // 
            this.btnTimGia.Location = new System.Drawing.Point(460, 13);
            this.btnTimGia.Name = "btnTimGia";
            this.btnTimGia.Size = new System.Drawing.Size(50, 35);
            this.btnTimGia.TabIndex = 18;
            this.btnTimGia.Text = "Tìm";
            this.btnTimGia.UseVisualStyleBackColor = true;
            this.btnTimGia.Click += new System.EventHandler(this.btnTimGia_Click);
            // 
            // ckb5to10
            // 
            this.ckb5to10.AutoSize = true;
            this.ckb5to10.Location = new System.Drawing.Point(183, 21);
            this.ckb5to10.Name = "ckb5to10";
            this.ckb5to10.Size = new System.Drawing.Size(76, 17);
            this.ckb5to10.TabIndex = 17;
            this.ckb5to10.Text = "5 - 10 triệu";
            this.ckb5to10.UseVisualStyleBackColor = true;
            this.ckb5to10.Click += new System.EventHandler(this.ckb5to10_Click);
            // 
            // ckb50pls
            // 
            this.ckb50pls.AutoSize = true;
            this.ckb50pls.Location = new System.Drawing.Point(381, 21);
            this.ckb50pls.Name = "ckb50pls";
            this.ckb50pls.Size = new System.Drawing.Size(70, 17);
            this.ckb50pls.TabIndex = 16;
            this.ckb50pls.Text = "> 50 triệu";
            this.ckb50pls.UseVisualStyleBackColor = true;
            this.ckb50pls.Click += new System.EventHandler(this.ckb50pls_Click);
            // 
            // ckb10to50
            // 
            this.ckb10to50.AutoSize = true;
            this.ckb10to50.Location = new System.Drawing.Point(279, 21);
            this.ckb10to50.Name = "ckb10to50";
            this.ckb10to50.Size = new System.Drawing.Size(82, 17);
            this.ckb10to50.TabIndex = 15;
            this.ckb10to50.Text = "10 - 50 triệu";
            this.ckb10to50.UseVisualStyleBackColor = true;
            this.ckb10to50.Click += new System.EventHandler(this.ckb10to50_Click);
            // 
            // ckb1to5
            // 
            this.ckb1to5.AutoSize = true;
            this.ckb1to5.Location = new System.Drawing.Point(92, 22);
            this.ckb1to5.Name = "ckb1to5";
            this.ckb1to5.Size = new System.Drawing.Size(70, 17);
            this.ckb1to5.TabIndex = 14;
            this.ckb1to5.Text = "1 - 5 triệu";
            this.ckb1to5.UseVisualStyleBackColor = true;
            this.ckb1to5.Click += new System.EventHandler(this.ckb1to5_Click);
            // 
            // ckb1mns
            // 
            this.ckb1mns.AutoSize = true;
            this.ckb1mns.Location = new System.Drawing.Point(6, 21);
            this.ckb1mns.Name = "ckb1mns";
            this.ckb1mns.Size = new System.Drawing.Size(64, 17);
            this.ckb1mns.TabIndex = 13;
            this.ckb1mns.Text = "< 1 triệu";
            this.ckb1mns.UseVisualStyleBackColor = true;
            this.ckb1mns.Click += new System.EventHandler(this.ckb1mns_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(765, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 50);
            this.button1.TabIndex = 19;
            this.button1.Text = "Xem tất cả";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpDateBill
            // 
            this.btnUpDateBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpDateBill.Location = new System.Drawing.Point(494, 432);
            this.btnUpDateBill.Name = "btnUpDateBill";
            this.btnUpDateBill.Size = new System.Drawing.Size(132, 36);
            this.btnUpDateBill.TabIndex = 20;
            this.btnUpDateBill.Text = "Cập nhật hóa đơn";
            this.btnUpDateBill.UseVisualStyleBackColor = true;
            this.btnUpDateBill.Click += new System.EventHandler(this.btnUpDateBill_Click);
            // 
            // frmQuanLiNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 477);
            this.Controls.Add(this.btnUpDateBill);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbTimNcc);
            this.Controls.Add(this.btnCTHDxuat);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.grbDulieu);
            this.Controls.Add(this.grbButton);
            this.Controls.Add(this.grbText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQuanLiNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí nhập";
            this.Load += new System.EventHandler(this.frmQuanLiNhap_Load);
            this.grbText.ResumeLayout(false);
            this.grbText.PerformLayout();
            this.grbButton.ResumeLayout(false);
            this.grbDulieu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLayMa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangDL)).EndInit();
            this.grbTimNcc.ResumeLayout(false);
            this.grbTimNcc.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbText;
        private System.Windows.Forms.GroupBox grbButton;
        private System.Windows.Forms.GroupBox grbDulieu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridView dgvBangDL;
        private System.Windows.Forms.MaskedTextBox txtNgayTao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNgayTao2;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.ComboBox txtNCC;
        private System.Windows.Forms.Button btnCTHDxuat;
        private System.Windows.Forms.DataGridView dgvLayMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ComboBox txtNVnhap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.GroupBox grbTimNcc;
        private System.Windows.Forms.Button btnTimNcc;
        private System.Windows.Forms.ComboBox cbbTimNcc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTimGia;
        private System.Windows.Forms.CheckBox ckb5to10;
        private System.Windows.Forms.CheckBox ckb50pls;
        private System.Windows.Forms.CheckBox ckb10to50;
        private System.Windows.Forms.CheckBox ckb1to5;
        private System.Windows.Forms.CheckBox ckb1mns;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUpDateBill;
    }
}