namespace GUI_PhuKienTheThao
{
    partial class frmLogin
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
    System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
    this.pnlDangNhap = new System.Windows.Forms.Panel();
    this.btnHuyBodnh = new System.Windows.Forms.Button();
    this.btnDangNhap2 = new System.Windows.Forms.Button();
    this.txtPassdnh = new System.Windows.Forms.TextBox();
    this.txtIDdnh = new System.Windows.Forms.TextBox();
    this.label3 = new System.Windows.Forms.Label();
    this.label2 = new System.Windows.Forms.Label();
    this.label1 = new System.Windows.Forms.Label();
    this.btnDangNhap1 = new System.Windows.Forms.Button();
    this.btnDangKi1 = new System.Windows.Forms.Button();
    this.pnlDangKi = new System.Windows.Forms.Panel();
    this.btnHuyBodki = new System.Windows.Forms.Button();
    this.btnDangKi2 = new System.Windows.Forms.Button();
    this.txtPassdki2 = new System.Windows.Forms.TextBox();
    this.txtPassdki1 = new System.Windows.Forms.TextBox();
    this.txtIDdki = new System.Windows.Forms.TextBox();
    this.label4 = new System.Windows.Forms.Label();
    this.label5 = new System.Windows.Forms.Label();
    this.label6 = new System.Windows.Forms.Label();
    this.pnlDangNhap.SuspendLayout();
    this.pnlDangKi.SuspendLayout();
    this.SuspendLayout();
    // 
    // pnlDangNhap
    // 
    this.pnlDangNhap.BackColor = System.Drawing.Color.Transparent;
    this.pnlDangNhap.Controls.Add(this.btnHuyBodnh);
    this.pnlDangNhap.Controls.Add(this.btnDangNhap2);
    this.pnlDangNhap.Controls.Add(this.txtPassdnh);
    this.pnlDangNhap.Controls.Add(this.txtIDdnh);
    this.pnlDangNhap.Controls.Add(this.label3);
    this.pnlDangNhap.Controls.Add(this.label2);
    this.pnlDangNhap.Location = new System.Drawing.Point(111, 66);
    this.pnlDangNhap.Name = "pnlDangNhap";
    this.pnlDangNhap.Size = new System.Drawing.Size(233, 149);
    this.pnlDangNhap.TabIndex = 0;
    // 
    // btnHuyBodnh
    // 
    this.btnHuyBodnh.BackColor = System.Drawing.Color.DimGray;
    this.btnHuyBodnh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
    this.btnHuyBodnh.Location = new System.Drawing.Point(134, 97);
    this.btnHuyBodnh.Name = "btnHuyBodnh";
    this.btnHuyBodnh.Size = new System.Drawing.Size(71, 40);
    this.btnHuyBodnh.TabIndex = 6;
    this.btnHuyBodnh.Text = "Hủy bỏ";
    this.btnHuyBodnh.UseVisualStyleBackColor = false;
    this.btnHuyBodnh.Click += new System.EventHandler(this.btnHuyBodnh_Click);
    // 
    // btnDangNhap2
    // 
    this.btnDangNhap2.BackColor = System.Drawing.Color.DimGray;
    this.btnDangNhap2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
    this.btnDangNhap2.Location = new System.Drawing.Point(36, 97);
    this.btnDangNhap2.Name = "btnDangNhap2";
    this.btnDangNhap2.Size = new System.Drawing.Size(74, 40);
    this.btnDangNhap2.TabIndex = 5;
    this.btnDangNhap2.Text = "Đăng nhập";
    this.btnDangNhap2.UseVisualStyleBackColor = false;
    this.btnDangNhap2.Click += new System.EventHandler(this.btnDangNhap2_Click);
    // 
    // txtPassdnh
    // 
    this.txtPassdnh.Location = new System.Drawing.Point(107, 59);
    this.txtPassdnh.Name = "txtPassdnh";
    this.txtPassdnh.PasswordChar = '*';
    this.txtPassdnh.Size = new System.Drawing.Size(111, 20);
    this.txtPassdnh.TabIndex = 4;
    // 
    // txtIDdnh
    // 
    this.txtIDdnh.Location = new System.Drawing.Point(107, 29);
    this.txtIDdnh.Name = "txtIDdnh";
    this.txtIDdnh.Size = new System.Drawing.Size(111, 20);
    this.txtIDdnh.TabIndex = 3;
    // 
    // label3
    // 
    this.label3.AutoSize = true;
    this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
    this.label3.Location = new System.Drawing.Point(32, 60);
    this.label3.Name = "label3";
    this.label3.Size = new System.Drawing.Size(69, 15);
    this.label3.TabIndex = 2;
    this.label3.Text = "Password";
    // 
    // label2
    // 
    this.label2.AutoSize = true;
    this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
    this.label2.Location = new System.Drawing.Point(32, 30);
    this.label2.Name = "label2";
    this.label2.Size = new System.Drawing.Size(21, 15);
    this.label2.TabIndex = 1;
    this.label2.Text = "ID";
    // 
    // label1
    // 
    this.label1.AutoSize = true;
    this.label1.BackColor = System.Drawing.Color.Transparent;
    this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
    this.label1.Location = new System.Drawing.Point(105, 26);
    this.label1.Name = "label1";
    this.label1.Size = new System.Drawing.Size(243, 18);
    this.label1.TabIndex = 0;
    this.label1.Text = "Phụ kiện thể thao - Thành Long";
    // 
    // btnDangNhap1
    // 
    this.btnDangNhap1.Location = new System.Drawing.Point(269, 246);
    this.btnDangNhap1.Name = "btnDangNhap1";
    this.btnDangNhap1.Size = new System.Drawing.Size(75, 41);
    this.btnDangNhap1.TabIndex = 7;
    this.btnDangNhap1.Text = "Đăng nhập";
    this.btnDangNhap1.UseVisualStyleBackColor = true;
    this.btnDangNhap1.Click += new System.EventHandler(this.btnDangNhap1_Click);
    // 
    // btnDangKi1
    // 
    this.btnDangKi1.Location = new System.Drawing.Point(350, 246);
    this.btnDangKi1.Name = "btnDangKi1";
    this.btnDangKi1.Size = new System.Drawing.Size(75, 41);
    this.btnDangKi1.TabIndex = 8;
    this.btnDangKi1.Text = "Đăng kí";
    this.btnDangKi1.UseVisualStyleBackColor = true;
    this.btnDangKi1.Click += new System.EventHandler(this.btnDangKi1_Click);
    // 
    // pnlDangKi
    // 
    this.pnlDangKi.BackColor = System.Drawing.Color.Transparent;
    this.pnlDangKi.Controls.Add(this.btnHuyBodki);
    this.pnlDangKi.Controls.Add(this.btnDangKi2);
    this.pnlDangKi.Controls.Add(this.txtPassdki2);
    this.pnlDangKi.Controls.Add(this.txtPassdki1);
    this.pnlDangKi.Controls.Add(this.txtIDdki);
    this.pnlDangKi.Controls.Add(this.label4);
    this.pnlDangKi.Controls.Add(this.label5);
    this.pnlDangKi.Controls.Add(this.label6);
    this.pnlDangKi.Location = new System.Drawing.Point(105, 62);
    this.pnlDangKi.Name = "pnlDangKi";
    this.pnlDangKi.Size = new System.Drawing.Size(240, 153);
    this.pnlDangKi.TabIndex = 9;
    // 
    // btnHuyBodki
    // 
    this.btnHuyBodki.BackColor = System.Drawing.Color.DimGray;
    this.btnHuyBodki.ForeColor = System.Drawing.SystemColors.Control;
    this.btnHuyBodki.Location = new System.Drawing.Point(133, 107);
    this.btnHuyBodki.Name = "btnHuyBodki";
    this.btnHuyBodki.Size = new System.Drawing.Size(75, 37);
    this.btnHuyBodki.TabIndex = 17;
    this.btnHuyBodki.Text = "Hủy bỏ";
    this.btnHuyBodki.UseVisualStyleBackColor = false;
    this.btnHuyBodki.Click += new System.EventHandler(this.btnHuyBodki_Click);
    // 
    // btnDangKi2
    // 
    this.btnDangKi2.BackColor = System.Drawing.Color.DimGray;
    this.btnDangKi2.ForeColor = System.Drawing.SystemColors.Control;
    this.btnDangKi2.Location = new System.Drawing.Point(35, 107);
    this.btnDangKi2.Name = "btnDangKi2";
    this.btnDangKi2.Size = new System.Drawing.Size(75, 37);
    this.btnDangKi2.TabIndex = 16;
    this.btnDangKi2.Text = "Đăng kí";
    this.btnDangKi2.UseVisualStyleBackColor = false;
    this.btnDangKi2.Click += new System.EventHandler(this.btnDangKi2_Click);
    // 
    // txtPassdki2
    // 
    this.txtPassdki2.Location = new System.Drawing.Point(113, 79);
    this.txtPassdki2.Name = "txtPassdki2";
    this.txtPassdki2.PasswordChar = '*';
    this.txtPassdki2.Size = new System.Drawing.Size(115, 20);
    this.txtPassdki2.TabIndex = 15;
    // 
    // txtPassdki1
    // 
    this.txtPassdki1.Location = new System.Drawing.Point(113, 53);
    this.txtPassdki1.Name = "txtPassdki1";
    this.txtPassdki1.PasswordChar = '*';
    this.txtPassdki1.Size = new System.Drawing.Size(115, 20);
    this.txtPassdki1.TabIndex = 14;
    // 
    // txtIDdki
    // 
    this.txtIDdki.Location = new System.Drawing.Point(113, 27);
    this.txtIDdki.Name = "txtIDdki";
    this.txtIDdki.Size = new System.Drawing.Size(115, 20);
    this.txtIDdki.TabIndex = 13;
    // 
    // label4
    // 
    this.label4.AutoSize = true;
    this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.label4.ForeColor = System.Drawing.Color.White;
    this.label4.Location = new System.Drawing.Point(22, 30);
    this.label4.Name = "label4";
    this.label4.Size = new System.Drawing.Size(21, 15);
    this.label4.TabIndex = 10;
    this.label4.Text = "ID";
    // 
    // label5
    // 
    this.label5.AutoSize = true;
    this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.label5.ForeColor = System.Drawing.Color.White;
    this.label5.Location = new System.Drawing.Point(22, 56);
    this.label5.Name = "label5";
    this.label5.Size = new System.Drawing.Size(38, 15);
    this.label5.TabIndex = 11;
    this.label5.Text = "Pass";
    // 
    // label6
    // 
    this.label6.AutoSize = true;
    this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.label6.ForeColor = System.Drawing.Color.White;
    this.label6.Location = new System.Drawing.Point(22, 82);
    this.label6.Name = "label6";
    this.label6.Size = new System.Drawing.Size(88, 15);
    this.label6.TabIndex = 12;
    this.label6.Text = "Rebeat Pass";
    // 
    // frmLogin
    // 
    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
    this.ClientSize = new System.Drawing.Size(449, 299);
    this.Controls.Add(this.pnlDangKi);
    this.Controls.Add(this.btnDangNhap1);
    this.Controls.Add(this.btnDangKi1);
    this.Controls.Add(this.label1);
    this.Controls.Add(this.pnlDangNhap);
    this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
    this.Name = "frmLogin";
    this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
    this.Text = "Login";
    this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
    this.Load += new System.EventHandler(this.frmLogin_Load);
    this.pnlDangNhap.ResumeLayout(false);
    this.pnlDangNhap.PerformLayout();
    this.pnlDangKi.ResumeLayout(false);
    this.pnlDangKi.PerformLayout();
    this.ResumeLayout(false);
    this.PerformLayout();

}

#endregion

private System.Windows.Forms.Panel pnlDangNhap;
private System.Windows.Forms.Button btnHuyBodnh;
private System.Windows.Forms.Button btnDangNhap2;
private System.Windows.Forms.TextBox txtPassdnh;
private System.Windows.Forms.TextBox txtIDdnh;
private System.Windows.Forms.Label label3;
private System.Windows.Forms.Label label2;
private System.Windows.Forms.Label label1;
private System.Windows.Forms.Button btnDangNhap1;
private System.Windows.Forms.Button btnDangKi1;
private System.Windows.Forms.Panel pnlDangKi;
private System.Windows.Forms.Button btnHuyBodki;
private System.Windows.Forms.Button btnDangKi2;
private System.Windows.Forms.TextBox txtPassdki2;
private System.Windows.Forms.TextBox txtPassdki1;
private System.Windows.Forms.TextBox txtIDdki;
private System.Windows.Forms.Label label4;
private System.Windows.Forms.Label label5;
private System.Windows.Forms.Label label6;
    }
}

