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
            this.tabLoaiSanPham = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvLoaiSanPham = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaLoaiSP = new System.Windows.Forms.TextBox();
            this.txtTenLoaiSP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHuyLoaiSP = new System.Windows.Forms.Button();
            this.btnLuuLoaiSP = new System.Windows.Forms.Button();
            this.btnThoatLoaiSP = new System.Windows.Forms.Button();
            this.btnXoaLoaiSP = new System.Windows.Forms.Button();
            this.btnSuaLoaiSP = new System.Windows.Forms.Button();
            this.btnThemLoaiSP = new System.Windows.Forms.Button();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoaiSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabLoaiSanPham.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSanPham)).BeginInit();
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
            this.tabSanPham.Location = new System.Drawing.Point(4, 29);
            this.tabSanPham.Name = "tabSanPham";
            this.tabSanPham.Padding = new System.Windows.Forms.Padding(3);
            this.tabSanPham.Size = new System.Drawing.Size(973, 560);
            this.tabSanPham.TabIndex = 0;
            this.tabSanPham.Text = "Sản Phẩm";
            this.tabSanPham.UseVisualStyleBackColor = true;
            // 
            // tabLoaiSanPham
            // 
            this.tabLoaiSanPham.Controls.Add(this.dgvLoaiSanPham);
            this.tabLoaiSanPham.Controls.Add(this.groupBox1);
            this.tabLoaiSanPham.Location = new System.Drawing.Point(4, 29);
            this.tabLoaiSanPham.Name = "tabLoaiSanPham";
            this.tabLoaiSanPham.Padding = new System.Windows.Forms.Padding(3);
            this.tabLoaiSanPham.Size = new System.Drawing.Size(973, 560);
            this.tabLoaiSanPham.TabIndex = 1;
            this.tabLoaiSanPham.Text = "Loại Sản Phẩm";
            this.tabLoaiSanPham.UseVisualStyleBackColor = true;
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
            this.dgvLoaiSanPham.Size = new System.Drawing.Size(967, 330);
            this.dgvLoaiSanPham.TabIndex = 1;
            this.dgvLoaiSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiSanPham_CellClick);
            this.dgvLoaiSanPham.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvLoaiSanPham_RowPrePaint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại sản phẩm :";
            // 
            // txtMaLoaiSP
            // 
            this.txtMaLoaiSP.Location = new System.Drawing.Point(187, 36);
            this.txtMaLoaiSP.Name = "txtMaLoaiSP";
            this.txtMaLoaiSP.Size = new System.Drawing.Size(251, 28);
            this.txtMaLoaiSP.TabIndex = 1;
            // 
            // txtTenLoaiSP
            // 
            this.txtTenLoaiSP.Location = new System.Drawing.Point(187, 75);
            this.txtTenLoaiSP.Name = "txtTenLoaiSP";
            this.txtTenLoaiSP.Size = new System.Drawing.Size(251, 28);
            this.txtTenLoaiSP.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên loại sản phẩm :";
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
            this.label3.Size = new System.Drawing.Size(63, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mô tả :";
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
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 74;
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
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(981, 593);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmSanPham";
            this.Text = "Quản Lý Sản Phẩm";
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabLoaiSanPham.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSanPham)).EndInit();
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
    }
}