namespace QuanLyKho.VIEW
{
    partial class frmSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSanPham));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSanPham = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvSP = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cbTimKiem = new System.Windows.Forms.ComboBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbVND = new System.Windows.Forms.Label();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtMaLSP = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.lbNgay = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.lbGhiChu = new System.Windows.Forms.Label();
            this.lbGia = new System.Windows.Forms.Label();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.MaLSP = new System.Windows.Forms.Label();
            this.lbTenSP = new System.Windows.Forms.Label();
            this.lbMaSP = new System.Windows.Forms.Label();
            this.tabLoaiSanPham = new System.Windows.Forms.TabPage();
            this.dgvLoaiSanPham = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoaiSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHuyLoaiSP = new System.Windows.Forms.Button();
            this.btnLuuLoaiSP = new System.Windows.Forms.Button();
            this.btnThoatLoaiSP = new System.Windows.Forms.Button();
            this.btnXoaLoaiSP = new System.Windows.Forms.Button();
            this.btnSuaLoaiSP = new System.Windows.Forms.Button();
            this.btnThemLoaiSP = new System.Windows.Forms.Button();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenLoaiSP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaLoaiSP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.STT1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabSanPham.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabLoaiSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSanPham)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSanPham);
            this.tabControl1.Controls.Add(this.tabLoaiSanPham);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(981, 593);
            this.tabControl1.TabIndex = 0;
            // 
            // tabSanPham
            // 
            this.tabSanPham.Controls.Add(this.groupBox4);
            this.tabSanPham.Controls.Add(this.groupBox3);
            this.tabSanPham.Controls.Add(this.groupBox2);
            this.tabSanPham.Location = new System.Drawing.Point(4, 25);
            this.tabSanPham.Name = "tabSanPham";
            this.tabSanPham.Padding = new System.Windows.Forms.Padding(3);
            this.tabSanPham.Size = new System.Drawing.Size(973, 564);
            this.tabSanPham.TabIndex = 0;
            this.tabSanPham.Text = "Sản Phẩm";
            this.tabSanPham.UseVisualStyleBackColor = true;
            this.tabSanPham.Click += new System.EventHandler(this.tabSanPham_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvSP);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(3, 214);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(970, 354);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách sản phẩm";
            // 
            // dgvSP
            // 
            this.dgvSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT1,
            this.MaSP,
            this.TenSP,
            this.SoLuong,
            this.Gia,
            this.GhiChu,
            this.Ngay});
            this.dgvSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSP.Location = new System.Drawing.Point(3, 21);
            this.dgvSP.Name = "dgvSP";
            this.dgvSP.Size = new System.Drawing.Size(964, 330);
            this.dgvSP.TabIndex = 0;
            this.dgvSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSP_CellClick);
            this.dgvSP.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvSP_RowPrePaint);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTimKiem);
            this.groupBox3.Controls.Add(this.cbTimKiem);
            this.groupBox3.Controls.Add(this.btnLamMoi);
            this.groupBox3.Controls.Add(this.btnTimKiem);
            this.groupBox3.Controls.Add(this.btnHuy);
            this.groupBox3.Controls.Add(this.btnLuu);
            this.groupBox3.Controls.Add(this.btnThoat);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.btnSua);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 108);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(967, 100);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(704, 15);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(233, 26);
            this.txtTimKiem.TabIndex = 27;
            // 
            // cbTimKiem
            // 
            this.cbTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTimKiem.FormattingEnabled = true;
            this.cbTimKiem.Items.AddRange(new object[] {
            "Theo Mã Sản Phẩm",
            "Theo Tên Sản Phẩm",
            "Theo Mã Loại Sản Phẩm",
            "Theo Số Lượng",
            "Theo Giá",
            "Theo Ghi Chú",
            "Theo Ngày"});
            this.cbTimKiem.Location = new System.Drawing.Point(704, 53);
            this.cbTimKiem.Name = "cbTimKiem";
            this.cbTimKiem.Size = new System.Drawing.Size(233, 27);
            this.cbTimKiem.TabIndex = 28;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.Image")));
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.Location = new System.Drawing.Point(597, 53);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(99, 29);
            this.btnLamMoi.TabIndex = 26;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(597, 13);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(99, 28);
            this.btnTimKiem.TabIndex = 25;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Enabled = false;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHuy.Location = new System.Drawing.Point(396, 25);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(80, 54);
            this.btnHuy.TabIndex = 24;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Enabled = false;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLuu.Location = new System.Drawing.Point(297, 25);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(85, 54);
            this.btnLuu.TabIndex = 23;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThoat.Location = new System.Drawing.Point(489, 25);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(79, 54);
            this.btnThoat.TabIndex = 22;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoa.Location = new System.Drawing.Point(208, 25);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(79, 54);
            this.btnXoa.TabIndex = 21;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSua.Location = new System.Drawing.Point(113, 25);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 54);
            this.btnSua.TabIndex = 20;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThem.Location = new System.Drawing.Point(6, 25);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 54);
            this.btnThem.TabIndex = 19;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbVND);
            this.groupBox2.Controls.Add(this.dtpNgay);
            this.groupBox2.Controls.Add(this.txtGhiChu);
            this.groupBox2.Controls.Add(this.txtGia);
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Controls.Add(this.txtMaLSP);
            this.groupBox2.Controls.Add(this.txtTenSP);
            this.groupBox2.Controls.Add(this.lbNgay);
            this.groupBox2.Controls.Add(this.txtMaSP);
            this.groupBox2.Controls.Add(this.lbGhiChu);
            this.groupBox2.Controls.Add(this.lbGia);
            this.groupBox2.Controls.Add(this.lbSoLuong);
            this.groupBox2.Controls.Add(this.MaLSP);
            this.groupBox2.Controls.Add(this.lbTenSP);
            this.groupBox2.Controls.Add(this.lbMaSP);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(973, 102);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sản phẩm";
            // 
            // lbVND
            // 
            this.lbVND.AutoSize = true;
            this.lbVND.Location = new System.Drawing.Point(641, 28);
            this.lbVND.Name = "lbVND";
            this.lbVND.Size = new System.Drawing.Size(58, 17);
            this.lbVND.TabIndex = 3;
            this.lbVND.Text = "( VNĐ )";
            // 
            // dtpNgay
            // 
            this.dtpNgay.Location = new System.Drawing.Point(765, 22);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(200, 25);
            this.dtpNgay.TabIndex = 2;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(525, 56);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(100, 25);
            this.txtGhiChu.TabIndex = 1;
            this.txtGhiChu.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(525, 22);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(100, 25);
            this.txtGia.TabIndex = 1;
            this.txtGia.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(305, 61);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(100, 25);
            this.txtSoLuong.TabIndex = 1;
            // 
            // txtMaLSP
            // 
            this.txtMaLSP.Location = new System.Drawing.Point(305, 25);
            this.txtMaLSP.Name = "txtMaLSP";
            this.txtMaLSP.Size = new System.Drawing.Size(100, 25);
            this.txtMaLSP.TabIndex = 1;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(116, 58);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(100, 25);
            this.txtTenSP.TabIndex = 1;
            // 
            // lbNgay
            // 
            this.lbNgay.AutoSize = true;
            this.lbNgay.Location = new System.Drawing.Point(704, 28);
            this.lbNgay.Name = "lbNgay";
            this.lbNgay.Size = new System.Drawing.Size(41, 17);
            this.lbNgay.TabIndex = 0;
            this.lbNgay.Text = "Ngày";
            this.lbNgay.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(116, 24);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(100, 25);
            this.txtMaSP.TabIndex = 1;
            // 
            // lbGhiChu
            // 
            this.lbGhiChu.AutoSize = true;
            this.lbGhiChu.Location = new System.Drawing.Point(450, 64);
            this.lbGhiChu.Name = "lbGhiChu";
            this.lbGhiChu.Size = new System.Drawing.Size(58, 17);
            this.lbGhiChu.TabIndex = 0;
            this.lbGhiChu.Text = "Ghi chú";
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Location = new System.Drawing.Point(450, 28);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(30, 17);
            this.lbGia.TabIndex = 0;
            this.lbGia.Text = "Giá";
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Location = new System.Drawing.Point(235, 61);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(65, 17);
            this.lbSoLuong.TabIndex = 0;
            this.lbSoLuong.Text = "Số lượng";
            // 
            // MaLSP
            // 
            this.MaLSP.AutoSize = true;
            this.MaLSP.Location = new System.Drawing.Point(235, 25);
            this.MaLSP.Name = "MaLSP";
            this.MaLSP.Size = new System.Drawing.Size(61, 17);
            this.MaLSP.TabIndex = 0;
            this.MaLSP.Text = "Mã LSP";
            // 
            // lbTenSP
            // 
            this.lbTenSP.AutoSize = true;
            this.lbTenSP.Location = new System.Drawing.Point(8, 59);
            this.lbTenSP.Name = "lbTenSP";
            this.lbTenSP.Size = new System.Drawing.Size(99, 17);
            this.lbTenSP.TabIndex = 0;
            this.lbTenSP.Text = "Tên sản phẩm";
            // 
            // lbMaSP
            // 
            this.lbMaSP.AutoSize = true;
            this.lbMaSP.Location = new System.Drawing.Point(8, 27);
            this.lbMaSP.Name = "lbMaSP";
            this.lbMaSP.Size = new System.Drawing.Size(95, 17);
            this.lbMaSP.TabIndex = 0;
            this.lbMaSP.Text = "Mã sản phẩm";
            this.lbMaSP.Click += new System.EventHandler(this.label4_Click);
            // 
            // tabLoaiSanPham
            // 
            this.tabLoaiSanPham.Controls.Add(this.dgvLoaiSanPham);
            this.tabLoaiSanPham.Controls.Add(this.groupBox1);
            this.tabLoaiSanPham.Location = new System.Drawing.Point(4, 25);
            this.tabLoaiSanPham.Name = "tabLoaiSanPham";
            this.tabLoaiSanPham.Padding = new System.Windows.Forms.Padding(3);
            this.tabLoaiSanPham.Size = new System.Drawing.Size(973, 564);
            this.tabLoaiSanPham.TabIndex = 1;
            this.tabLoaiSanPham.Text = "Loại Sản Phẩm";
            this.tabLoaiSanPham.UseVisualStyleBackColor = true;
            // 
            // dgvLoaiSanPham
            // 
            this.dgvLoaiSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaLoaiSanPham,
            this.TenLoaiSanPham,
            this.MoTa});
            this.dgvLoaiSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLoaiSanPham.Location = new System.Drawing.Point(3, 227);
            this.dgvLoaiSanPham.Name = "dgvLoaiSanPham";
            this.dgvLoaiSanPham.RowTemplate.Height = 24;
            this.dgvLoaiSanPham.Size = new System.Drawing.Size(967, 334);
            this.dgvLoaiSanPham.TabIndex = 1;
            this.dgvLoaiSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiSanPham_CellClick);
            this.dgvLoaiSanPham.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvLoaiSanPham_RowPrePaint);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 59;
            // 
            // MaLoaiSanPham
            // 
            this.MaLoaiSanPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaLoaiSanPham.DataPropertyName = "MaLoaiSP";
            this.MaLoaiSanPham.HeaderText = "Mã Loại Sản Phẩm";
            this.MaLoaiSanPham.Name = "MaLoaiSanPham";
            // 
            // TenLoaiSanPham
            // 
            this.TenLoaiSanPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenLoaiSanPham.DataPropertyName = "TenLoaiSP";
            this.TenLoaiSanPham.HeaderText = "Tên Loại Sản Phẩm";
            this.TenLoaiSanPham.Name = "TenLoaiSanPham";
            // 
            // MoTa
            // 
            this.MoTa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MoTa.DataPropertyName = "MoTa";
            this.MoTa.HeaderText = "Mô Tả";
            this.MoTa.Name = "MoTa";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHuyLoaiSP);
            this.groupBox1.Controls.Add(this.btnLuuLoaiSP);
            this.groupBox1.Controls.Add(this.btnThoatLoaiSP);
            this.groupBox1.Controls.Add(this.btnXoaLoaiSP);
            this.groupBox1.Controls.Add(this.btnSuaLoaiSP);
            this.groupBox1.Controls.Add(this.btnThemLoaiSP);
            this.groupBox1.Controls.Add(this.txtMoTa);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenLoaiSP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaLoaiSP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(967, 224);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại Sản Phẩm";
            // 
            // btnHuyLoaiSP
            // 
            this.btnHuyLoaiSP.Enabled = false;
            this.btnHuyLoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyLoaiSP.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnHuyLoaiSP.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyLoaiSP.Image")));
            this.btnHuyLoaiSP.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHuyLoaiSP.Location = new System.Drawing.Point(577, 154);
            this.btnHuyLoaiSP.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuyLoaiSP.Name = "btnHuyLoaiSP";
            this.btnHuyLoaiSP.Size = new System.Drawing.Size(80, 54);
            this.btnHuyLoaiSP.TabIndex = 18;
            this.btnHuyLoaiSP.Text = "Hủy";
            this.btnHuyLoaiSP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHuyLoaiSP.UseVisualStyleBackColor = true;
            this.btnHuyLoaiSP.Click += new System.EventHandler(this.btnHuyLoaiSP_Click);
            // 
            // btnLuuLoaiSP
            // 
            this.btnLuuLoaiSP.Enabled = false;
            this.btnLuuLoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuLoaiSP.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLuuLoaiSP.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuLoaiSP.Image")));
            this.btnLuuLoaiSP.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLuuLoaiSP.Location = new System.Drawing.Point(478, 154);
            this.btnLuuLoaiSP.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuuLoaiSP.Name = "btnLuuLoaiSP";
            this.btnLuuLoaiSP.Size = new System.Drawing.Size(85, 54);
            this.btnLuuLoaiSP.TabIndex = 17;
            this.btnLuuLoaiSP.Text = "Lưu";
            this.btnLuuLoaiSP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLuuLoaiSP.UseVisualStyleBackColor = true;
            this.btnLuuLoaiSP.Click += new System.EventHandler(this.btnLuuLoaiSP_Click);
            // 
            // btnThoatLoaiSP
            // 
            this.btnThoatLoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatLoaiSP.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnThoatLoaiSP.Image = ((System.Drawing.Image)(resources.GetObject("btnThoatLoaiSP.Image")));
            this.btnThoatLoaiSP.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThoatLoaiSP.Location = new System.Drawing.Point(670, 154);
            this.btnThoatLoaiSP.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoatLoaiSP.Name = "btnThoatLoaiSP";
            this.btnThoatLoaiSP.Size = new System.Drawing.Size(79, 54);
            this.btnThoatLoaiSP.TabIndex = 16;
            this.btnThoatLoaiSP.Text = "Thoát";
            this.btnThoatLoaiSP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThoatLoaiSP.UseVisualStyleBackColor = true;
            this.btnThoatLoaiSP.Click += new System.EventHandler(this.btnThoatLoaiSP_Click);
            // 
            // btnXoaLoaiSP
            // 
            this.btnXoaLoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLoaiSP.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnXoaLoaiSP.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaLoaiSP.Image")));
            this.btnXoaLoaiSP.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoaLoaiSP.Location = new System.Drawing.Point(389, 154);
            this.btnXoaLoaiSP.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaLoaiSP.Name = "btnXoaLoaiSP";
            this.btnXoaLoaiSP.Size = new System.Drawing.Size(79, 54);
            this.btnXoaLoaiSP.TabIndex = 15;
            this.btnXoaLoaiSP.Text = "Xóa";
            this.btnXoaLoaiSP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoaLoaiSP.UseVisualStyleBackColor = true;
            this.btnXoaLoaiSP.Click += new System.EventHandler(this.btnXoaLoaiSP_Click);
            // 
            // btnSuaLoaiSP
            // 
            this.btnSuaLoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaLoaiSP.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSuaLoaiSP.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaLoaiSP.Image")));
            this.btnSuaLoaiSP.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSuaLoaiSP.Location = new System.Drawing.Point(294, 154);
            this.btnSuaLoaiSP.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuaLoaiSP.Name = "btnSuaLoaiSP";
            this.btnSuaLoaiSP.Size = new System.Drawing.Size(80, 54);
            this.btnSuaLoaiSP.TabIndex = 14;
            this.btnSuaLoaiSP.Text = "Sửa";
            this.btnSuaLoaiSP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSuaLoaiSP.UseVisualStyleBackColor = true;
            this.btnSuaLoaiSP.Click += new System.EventHandler(this.btnSuaLoaiSP_Click);
            // 
            // btnThemLoaiSP
            // 
            this.btnThemLoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLoaiSP.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnThemLoaiSP.Image = ((System.Drawing.Image)(resources.GetObject("btnThemLoaiSP.Image")));
            this.btnThemLoaiSP.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThemLoaiSP.Location = new System.Drawing.Point(187, 154);
            this.btnThemLoaiSP.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemLoaiSP.Name = "btnThemLoaiSP";
            this.btnThemLoaiSP.Size = new System.Drawing.Size(85, 54);
            this.btnThemLoaiSP.TabIndex = 13;
            this.btnThemLoaiSP.Text = "Thêm";
            this.btnThemLoaiSP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThemLoaiSP.UseVisualStyleBackColor = true;
            this.btnThemLoaiSP.Click += new System.EventHandler(this.btnThemLoaiSP_Click);
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(557, 32);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(257, 71);
            this.txtMoTa.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(474, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mô tả :";
            // 
            // txtTenLoaiSP
            // 
            this.txtTenLoaiSP.Location = new System.Drawing.Point(187, 75);
            this.txtTenLoaiSP.Name = "txtTenLoaiSP";
            this.txtTenLoaiSP.Size = new System.Drawing.Size(251, 24);
            this.txtTenLoaiSP.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên loại sản phẩm :";
            // 
            // txtMaLoaiSP
            // 
            this.txtMaLoaiSP.Location = new System.Drawing.Point(187, 36);
            this.txtMaLoaiSP.Name = "txtMaLoaiSP";
            this.txtMaLoaiSP.Size = new System.Drawing.Size(251, 24);
            this.txtMaLoaiSP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại sản phẩm :";
            // 
            // STT1
            // 
            this.STT1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.STT1.HeaderText = "STT";
            this.STT1.Name = "STT1";
            // 
            // MaSP
            // 
            this.MaSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã Sản Phẩm";
            this.MaSP.Name = "MaSP";
            // 
            // TenSP
            // 
            this.TenSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên Sản Phẩm";
            this.TenSP.Name = "TenSP";
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // Gia
            // 
            this.Gia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá";
            this.Gia.Name = "Gia";
            // 
            // GhiChu
            // 
            this.GhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi Chú";
            this.GhiChu.Name = "GhiChu";
            // 
            // Ngay
            // 
            this.Ngay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ngay.DataPropertyName = "Ngay";
            this.Ngay.HeaderText = "Ngày";
            this.Ngay.Name = "Ngay";
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(981, 593);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Sản Phẩm";
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabSanPham.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabLoaiSanPham.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSanPham)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSanPham;
        private System.Windows.Forms.TabPage tabLoaiSanPham;
        private System.Windows.Forms.DataGridView dgvLoaiSanPham;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenLoaiSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaLoaiSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHuyLoaiSP;
        private System.Windows.Forms.Button btnLuuLoaiSP;
        private System.Windows.Forms.Button btnThoatLoaiSP;
        private System.Windows.Forms.Button btnXoaLoaiSP;
        private System.Windows.Forms.Button btnSuaLoaiSP;
        private System.Windows.Forms.Button btnThemLoaiSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtMaLSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label lbGhiChu;
        private System.Windows.Forms.Label lbGia;
        private System.Windows.Forms.Label lbSoLuong;
        private System.Windows.Forms.Label MaLSP;
        private System.Windows.Forms.Label lbTenSP;
        private System.Windows.Forms.Label lbMaSP;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label lbNgay;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.Label lbVND;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cbTimKiem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
    }
}