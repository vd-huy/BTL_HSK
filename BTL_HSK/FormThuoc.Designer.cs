namespace BTL_HSK
{
    partial class FormThuoc
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
            this.components = new System.ComponentModel.Container();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.grbThuoc = new System.Windows.Forms.GroupBox();
            this.txbDonGia = new System.Windows.Forms.TextBox();
            this.txbSoLuong = new System.Windows.Forms.TextBox();
            this.dtpHSD = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbMaNCC = new System.Windows.Forms.ComboBox();
            this.txbTenThuoc = new System.Windows.Forms.TextBox();
            this.txbMaThuoc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgvThuoc = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnInDS = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbMaThuocSearch = new System.Windows.Forms.TextBox();
            this.txbTenThuocSearch = new System.Windows.Forms.TextBox();
            this.cbMaNCCSearch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.grbThuoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnThem.Location = new System.Drawing.Point(139, 276);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(108, 43);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSua.Location = new System.Drawing.Point(253, 276);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(108, 43);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnXoa.Location = new System.Drawing.Point(367, 276);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(108, 43);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnXem
            // 
            this.btnXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnXem.Location = new System.Drawing.Point(25, 276);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(108, 43);
            this.btnXem.TabIndex = 8;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // grbThuoc
            // 
            this.grbThuoc.Controls.Add(this.txbDonGia);
            this.grbThuoc.Controls.Add(this.txbSoLuong);
            this.grbThuoc.Controls.Add(this.dtpHSD);
            this.grbThuoc.Controls.Add(this.label7);
            this.grbThuoc.Controls.Add(this.label6);
            this.grbThuoc.Controls.Add(this.label5);
            this.grbThuoc.Controls.Add(this.cbMaNCC);
            this.grbThuoc.Controls.Add(this.txbTenThuoc);
            this.grbThuoc.Controls.Add(this.txbMaThuoc);
            this.grbThuoc.Controls.Add(this.label4);
            this.grbThuoc.Controls.Add(this.label3);
            this.grbThuoc.Controls.Add(this.label2);
            this.grbThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThuoc.Location = new System.Drawing.Point(12, 12);
            this.grbThuoc.Name = "grbThuoc";
            this.grbThuoc.Size = new System.Drawing.Size(1068, 254);
            this.grbThuoc.TabIndex = 9;
            this.grbThuoc.TabStop = false;
            this.grbThuoc.Text = "Quản lý thuốc";
            // 
            // txbDonGia
            // 
            this.txbDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txbDonGia.Location = new System.Drawing.Point(783, 49);
            this.txbDonGia.Name = "txbDonGia";
            this.txbDonGia.Size = new System.Drawing.Size(250, 30);
            this.txbDonGia.TabIndex = 23;
            this.txbDonGia.TextChanged += new System.EventHandler(this.txbMaThuoc_TextChanged);
            this.txbDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbDonGia_KeyPress);
            // 
            // txbSoLuong
            // 
            this.txbSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txbSoLuong.Location = new System.Drawing.Point(783, 108);
            this.txbSoLuong.Name = "txbSoLuong";
            this.txbSoLuong.Size = new System.Drawing.Size(250, 30);
            this.txbSoLuong.TabIndex = 22;
            this.txbSoLuong.TextChanged += new System.EventHandler(this.txbMaThuoc_TextChanged);
            this.txbSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSoLuong_KeyPress);
            // 
            // dtpHSD
            // 
            this.dtpHSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHSD.Location = new System.Drawing.Point(783, 175);
            this.dtpHSD.Name = "dtpHSD";
            this.dtpHSD.Size = new System.Drawing.Size(236, 26);
            this.dtpHSD.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(643, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "Hạn sử dụng :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(643, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Số lượng :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(643, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Đơn giá :";
            // 
            // cbMaNCC
            // 
            this.cbMaNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbMaNCC.FormattingEnabled = true;
            this.cbMaNCC.Location = new System.Drawing.Point(217, 177);
            this.cbMaNCC.Name = "cbMaNCC";
            this.cbMaNCC.Size = new System.Drawing.Size(220, 33);
            this.cbMaNCC.TabIndex = 17;
            // 
            // txbTenThuoc
            // 
            this.txbTenThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txbTenThuoc.Location = new System.Drawing.Point(217, 110);
            this.txbTenThuoc.Name = "txbTenThuoc";
            this.txbTenThuoc.Size = new System.Drawing.Size(287, 30);
            this.txbTenThuoc.TabIndex = 16;
            this.txbTenThuoc.TextChanged += new System.EventHandler(this.txbMaThuoc_TextChanged);
            this.txbTenThuoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTenThuoc_KeyPress);
            // 
            // txbMaThuoc
            // 
            this.txbMaThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txbMaThuoc.Location = new System.Drawing.Point(217, 50);
            this.txbMaThuoc.Name = "txbMaThuoc";
            this.txbMaThuoc.Size = new System.Drawing.Size(287, 30);
            this.txbMaThuoc.TabIndex = 15;
            this.txbMaThuoc.TextChanged += new System.EventHandler(this.txbMaThuoc_TextChanged);
            this.txbMaThuoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMaThuoc_KeyPress);
            this.txbMaThuoc.Validating += new System.ComponentModel.CancelEventHandler(this.txbMaThuoc_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Mã nhà cung cấp :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tên thuốc :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mã thuốc :";
            // 
            // dtgvThuoc
            // 
            this.dtgvThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvThuoc.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgvThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvThuoc.Location = new System.Drawing.Point(12, 325);
            this.dtgvThuoc.Name = "dtgvThuoc";
            this.dtgvThuoc.ReadOnly = true;
            this.dtgvThuoc.RowHeadersWidth = 62;
            this.dtgvThuoc.RowTemplate.Height = 28;
            this.dtgvThuoc.Size = new System.Drawing.Size(1398, 226);
            this.dtgvThuoc.TabIndex = 16;
            this.dtgvThuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvThuoc_CellClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTimKiem.Location = new System.Drawing.Point(1289, 276);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(121, 43);
            this.btnTimKiem.TabIndex = 17;
            this.btnTimKiem.Text = "Tìm kiếm ";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnInDS
            // 
            this.btnInDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnInDS.Location = new System.Drawing.Point(722, 276);
            this.btnInDS.Name = "btnInDS";
            this.btnInDS.Size = new System.Drawing.Size(358, 43);
            this.btnInDS.TabIndex = 18;
            this.btnInDS.Text = "In tất cả thông tin thuốc";
            this.btnInDS.UseVisualStyleBackColor = true;
            this.btnInDS.Click += new System.EventHandler(this.btnInDS_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbMaThuocSearch);
            this.groupBox1.Controls.Add(this.txbTenThuocSearch);
            this.groupBox1.Controls.Add(this.cbMaNCCSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBox1.Location = new System.Drawing.Point(1087, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 230);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // txbMaThuocSearch
            // 
            this.txbMaThuocSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txbMaThuocSearch.Location = new System.Drawing.Point(130, 42);
            this.txbMaThuocSearch.Name = "txbMaThuocSearch";
            this.txbMaThuocSearch.Size = new System.Drawing.Size(187, 30);
            this.txbMaThuocSearch.TabIndex = 27;
            // 
            // txbTenThuocSearch
            // 
            this.txbTenThuocSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txbTenThuocSearch.Location = new System.Drawing.Point(130, 100);
            this.txbTenThuocSearch.Name = "txbTenThuocSearch";
            this.txbTenThuocSearch.Size = new System.Drawing.Size(187, 30);
            this.txbTenThuocSearch.TabIndex = 24;
            // 
            // cbMaNCCSearch
            // 
            this.cbMaNCCSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaNCCSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbMaNCCSearch.FormattingEnabled = true;
            this.cbMaNCCSearch.Items.AddRange(new object[] {
            " "});
            this.cbMaNCCSearch.Location = new System.Drawing.Point(176, 170);
            this.cbMaNCCSearch.Name = "cbMaNCCSearch";
            this.cbMaNCCSearch.Size = new System.Drawing.Size(141, 33);
            this.cbMaNCCSearch.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Mã nhà cung cấp :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 25);
            this.label8.TabIndex = 25;
            this.label8.Text = "Tên thuốc :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 25);
            this.label9.TabIndex = 24;
            this.label9.Text = "Mã thuốc :";
            // 
            // FormThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1422, 563);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnInDS);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dtgvThuoc);
            this.Controls.Add(this.grbThuoc);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Name = "FormThuoc";
            this.Text = "Quản lý thuốc";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbThuoc.ResumeLayout(false);
            this.grbThuoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.GroupBox grbThuoc;
        private System.Windows.Forms.TextBox txbDonGia;
        private System.Windows.Forms.TextBox txbSoLuong;
        private System.Windows.Forms.DateTimePicker dtpHSD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbMaNCC;
        private System.Windows.Forms.TextBox txbTenThuoc;
        private System.Windows.Forms.TextBox txbMaThuoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgvThuoc;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnInDS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbMaThuocSearch;
        private System.Windows.Forms.TextBox txbTenThuocSearch;
        private System.Windows.Forms.ComboBox cbMaNCCSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

