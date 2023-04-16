namespace BTL_HSK
{
    partial class FormNhanVien
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
            this.grbThuoc = new System.Windows.Forms.GroupBox();
            this.pnlGioiTinh = new System.Windows.Forms.Panel();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.txbPhuCap = new System.Windows.Forms.TextBox();
            this.txbLuongCoBan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbDiaChi = new System.Windows.Forms.TextBox();
            this.txbSDT = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbTenNV = new System.Windows.Forms.TextBox();
            this.txbMaNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtgvNhanVien = new System.Windows.Forms.DataGridView();
            this.grbThuoc.SuspendLayout();
            this.pnlGioiTinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // grbThuoc
            // 
            this.grbThuoc.Controls.Add(this.pnlGioiTinh);
            this.grbThuoc.Controls.Add(this.txbPhuCap);
            this.grbThuoc.Controls.Add(this.txbLuongCoBan);
            this.grbThuoc.Controls.Add(this.label8);
            this.grbThuoc.Controls.Add(this.label1);
            this.grbThuoc.Controls.Add(this.txbDiaChi);
            this.grbThuoc.Controls.Add(this.txbSDT);
            this.grbThuoc.Controls.Add(this.dtpNgaySinh);
            this.grbThuoc.Controls.Add(this.label7);
            this.grbThuoc.Controls.Add(this.label6);
            this.grbThuoc.Controls.Add(this.label5);
            this.grbThuoc.Controls.Add(this.txbTenNV);
            this.grbThuoc.Controls.Add(this.txbMaNV);
            this.grbThuoc.Controls.Add(this.label4);
            this.grbThuoc.Controls.Add(this.label3);
            this.grbThuoc.Controls.Add(this.label2);
            this.grbThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThuoc.Location = new System.Drawing.Point(12, 12);
            this.grbThuoc.Name = "grbThuoc";
            this.grbThuoc.Size = new System.Drawing.Size(1271, 260);
            this.grbThuoc.TabIndex = 10;
            this.grbThuoc.TabStop = false;
            this.grbThuoc.Text = "Quản lý nhân viên";
            // 
            // pnlGioiTinh
            // 
            this.pnlGioiTinh.Controls.Add(this.rbNu);
            this.pnlGioiTinh.Controls.Add(this.rbNam);
            this.pnlGioiTinh.Location = new System.Drawing.Point(217, 148);
            this.pnlGioiTinh.Name = "pnlGioiTinh";
            this.pnlGioiTinh.Size = new System.Drawing.Size(260, 42);
            this.pnlGioiTinh.TabIndex = 30;
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbNu.Location = new System.Drawing.Point(166, 7);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(62, 29);
            this.rbNu.TabIndex = 25;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Checked = true;
            this.rbNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbNam.Location = new System.Drawing.Point(7, 5);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(78, 29);
            this.rbNam.TabIndex = 24;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // txbPhuCap
            // 
            this.txbPhuCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txbPhuCap.Location = new System.Drawing.Point(812, 214);
            this.txbPhuCap.Name = "txbPhuCap";
            this.txbPhuCap.Size = new System.Drawing.Size(250, 30);
            this.txbPhuCap.TabIndex = 29;
            this.txbPhuCap.TextChanged += new System.EventHandler(this.txbMaNV_TextChanged);
            this.txbPhuCap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPhuCap_KeyPress);
            // 
            // txbLuongCoBan
            // 
            this.txbLuongCoBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txbLuongCoBan.Location = new System.Drawing.Point(217, 212);
            this.txbLuongCoBan.Name = "txbLuongCoBan";
            this.txbLuongCoBan.Size = new System.Drawing.Size(287, 30);
            this.txbLuongCoBan.TabIndex = 28;
            this.txbLuongCoBan.TextChanged += new System.EventHandler(this.txbMaNV_TextChanged);
            this.txbLuongCoBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbLuongCoBan_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(640, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 25);
            this.label8.TabIndex = 27;
            this.label8.Text = "Phụ cấp :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Lương cơ bản :";
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txbDiaChi.Location = new System.Drawing.Point(812, 46);
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.Size = new System.Drawing.Size(250, 30);
            this.txbDiaChi.TabIndex = 23;
            this.txbDiaChi.TextChanged += new System.EventHandler(this.txbMaNV_TextChanged);
            // 
            // txbSDT
            // 
            this.txbSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txbSDT.Location = new System.Drawing.Point(812, 106);
            this.txbSDT.Name = "txbSDT";
            this.txbSDT.Size = new System.Drawing.Size(250, 30);
            this.txbSDT.TabIndex = 22;
            this.txbSDT.TextChanged += new System.EventHandler(this.txbMaNV_TextChanged);
            this.txbSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSDT_KeyPress);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Location = new System.Drawing.Point(812, 159);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(236, 26);
            this.dtpNgaySinh.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(643, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "Ngày sinh :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(640, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Số điện thoại :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(643, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Địa chỉ :";
            // 
            // txbTenNV
            // 
            this.txbTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txbTenNV.Location = new System.Drawing.Point(217, 104);
            this.txbTenNV.Name = "txbTenNV";
            this.txbTenNV.Size = new System.Drawing.Size(287, 30);
            this.txbTenNV.TabIndex = 16;
            this.txbTenNV.TextChanged += new System.EventHandler(this.txbMaNV_TextChanged);
            // 
            // txbMaNV
            // 
            this.txbMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txbMaNV.Location = new System.Drawing.Point(217, 50);
            this.txbMaNV.Name = "txbMaNV";
            this.txbMaNV.Size = new System.Drawing.Size(287, 30);
            this.txbMaNV.TabIndex = 15;
            this.txbMaNV.TextChanged += new System.EventHandler(this.txbMaNV_TextChanged);
            this.txbMaNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMaNV_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Giới tính :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tên nhân viên :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mã nhân viên :";
            // 
            // btnXem
            // 
            this.btnXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnXem.Location = new System.Drawing.Point(12, 299);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(108, 43);
            this.btnXem.TabIndex = 29;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnXoa.Location = new System.Drawing.Point(440, 299);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(108, 43);
            this.btnXoa.TabIndex = 28;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSua.Location = new System.Drawing.Point(291, 299);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(108, 43);
            this.btnSua.TabIndex = 27;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnThem.Location = new System.Drawing.Point(151, 299);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(108, 43);
            this.btnThem.TabIndex = 26;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dtgvNhanVien
            // 
            this.dtgvNhanVien.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvNhanVien.Location = new System.Drawing.Point(12, 348);
            this.dtgvNhanVien.Name = "dtgvNhanVien";
            this.dtgvNhanVien.ReadOnly = true;
            this.dtgvNhanVien.RowHeadersWidth = 62;
            this.dtgvNhanVien.RowTemplate.Height = 28;
            this.dtgvNhanVien.Size = new System.Drawing.Size(1271, 260);
            this.dtgvNhanVien.TabIndex = 32;
            this.dtgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvNhanVien_CellClick);
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 620);
            this.Controls.Add(this.dtgvNhanVien);
            this.Controls.Add(this.grbThuoc);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Name = "FormNhanVien";
            this.Text = "FormNhanVien";
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            this.grbThuoc.ResumeLayout(false);
            this.grbThuoc.PerformLayout();
            this.pnlGioiTinh.ResumeLayout(false);
            this.pnlGioiTinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbThuoc;
        private System.Windows.Forms.TextBox txbDiaChi;
        private System.Windows.Forms.TextBox txbSDT;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbTenNV;
        private System.Windows.Forms.TextBox txbMaNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.TextBox txbPhuCap;
        private System.Windows.Forms.TextBox txbLuongCoBan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvNhanVien;
        private System.Windows.Forms.Panel pnlGioiTinh;
    }
}