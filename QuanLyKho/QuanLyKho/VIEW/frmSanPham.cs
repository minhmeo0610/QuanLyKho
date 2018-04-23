using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKho.BUS;
using QuanLyKho.ENTITY;
namespace QuanLyKho.VIEW
{
    public partial class frmSanPham : Form
    {
        LoaiSanPham loaiSP = new LoaiSanPham();
        LoaiSanPhamBUS BUS_LoaiSP = new LoaiSanPhamBUS();
        SanPham sp = new SanPham();
        SanPhamBUS bus = new SanPhamBUS();
        private bool _clickBtn = false;
        public frmSanPham()
        {
            InitializeComponent();
        }
        private void KhoaDieuKhien(bool e)
        {
            btnThemLoaiSP.Enabled = !e;
            btnXoaLoaiSP.Enabled = !e;
            btnSuaLoaiSP.Enabled = !e;
            btnLuuLoaiSP.Enabled = e;
            btnHuyLoaiSP.Enabled = e;
            txtTenLoaiSP.Enabled = e;
            txtMaLoaiSP.Enabled = e;
            txtMoTa.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            txtMaSP.Enabled = e;
            txtTenSP.Enabled = e;
            txtMaLSP.Enabled = e;
            txtSoLuong.Enabled = e;
            txtGia.Enabled = e;
            txtGhiChu.Enabled = e;
            dtpNgay.Enabled = e;
        }
        private void cleartxt()
        {
            txtMaLoaiSP.Text = "";
            txtTenLoaiSP.Text = "";
            txtMoTa.Text = "";
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtMaLSP.Text = "";
            txtSoLuong.Text = "";
            txtGia.Text = "";
            txtGhiChu.Text = "";

        }

        private void HienThiDSLoaiSP()
        {
            dgvLoaiSanPham.DataSource = BUS_LoaiSP.GetData();
        }

        private void HienThiSP()
        {
            dgvSP.DataSource = bus.GetData();
        }
        private void frmSanPham_Load(object sender, EventArgs e)
        {
            HienThiDSLoaiSP();
            KhoaDieuKhien(false);

            HienThiSP();
            KhoaDieuKhien(false);
        }

        private void dgvLoaiSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_clickBtn == true)
            {
                txtTenLoaiSP.Text = Convert.ToString(dgvLoaiSanPham.CurrentRow.Cells["TenLoaiSanPham"].Value);
                txtMoTa.Text = Convert.ToString(dgvLoaiSanPham.CurrentRow.Cells["MoTa"].Value);

            }
            else if (_clickBtn == false)
            {
                txtMaLoaiSP.Text = Convert.ToString(dgvLoaiSanPham.CurrentRow.Cells["MaLoaiSanPham"].Value);
                txtTenLoaiSP.Text = Convert.ToString(dgvLoaiSanPham.CurrentRow.Cells["TenLoaiSanPham"].Value);
                txtMoTa.Text = Convert.ToString(dgvLoaiSanPham.CurrentRow.Cells["MoTa"].Value);
            }
        }

        private void dgvLoaiSanPham_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvLoaiSanPham.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void btnThoatLoaiSP_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else
                HienThiDSLoaiSP();
        }

        private void btnHuyLoaiSP_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                cleartxt();
                HienThiDSLoaiSP();
                KhoaDieuKhien(false);
                _clickBtn = true;

            }
            else
                return;
        }

        private void btnLuuLoaiSP_Click(object sender, EventArgs e)
        {
            if (txtTenLoaiSP.Text == "")
            {
                MessageBox.Show("Điền đầy đủ thông tin !", "Chú ý");
            }
            else
            {
                loaiSP.MaLoaiSP = txtMaLoaiSP.Text;
                loaiSP.TenLoaiSP = txtTenLoaiSP.Text;
                loaiSP.MoTa = txtMoTa.Text;
                try
                {
                    if (_clickBtn == true)
                    {
                        BUS_LoaiSP.InsertData(loaiSP);
                        MessageBox.Show("Đã thêm!", "Chú ý");
                    }
                    else
                    {
                        BUS_LoaiSP.UpdateData(loaiSP);
                        MessageBox.Show("Đã sửa!", "Chú ý");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi !\n " + ex, "Error");
                }
                _clickBtn = false;
                cleartxt();
                KhoaDieuKhien(false);
                HienThiDSLoaiSP();
            }
        }

        private void btnXoaLoaiSP_Click(object sender, EventArgs e)
        {
            if (txtMaLoaiSP.Text == "")
            {
                MessageBox.Show("Chọn loại sản phẩm muốn xóa !", "Chú ý");
            }

            else if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    BUS_LoaiSP.DeleteData(txtMaLoaiSP.Text);
                    MessageBox.Show("Xóa thành công!");
                    cleartxt();
                    KhoaDieuKhien(false);
                    HienThiDSLoaiSP();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message);
                }
            }
        }

        private void btnSuaLoaiSP_Click(object sender, EventArgs e)
        {
            _clickBtn = false;
            KhoaDieuKhien(true);
            txtMaLoaiSP.Enabled = false;

        }

        private void btnThemLoaiSP_Click(object sender, EventArgs e)
        {
            txtMaLoaiSP.Text = BUS_LoaiSP.TangMa();
            _clickBtn = true;
            KhoaDieuKhien(true);
            txtMaLoaiSP.Enabled = false;

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void tabSanPham_Click(object sender, EventArgs e)
        {

        }

        private void dgvSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_clickBtn == true)
            {
                txtTenSP.Text = Convert.ToString(dgvSP.CurrentRow.Cells["TenSP"].Value);
                //txtMaLSP.Text = Convert.ToString(dgvSP.CurrentRow.Cells["MaLSP1"].Value);
                txtSoLuong.Text = Convert.ToString(dgvSP.CurrentRow.Cells["SoLuong"].Value);
                txtGia.Text = Convert.ToString(dgvSP.CurrentRow.Cells["Gia"].Value);
                txtGhiChu.Text = Convert.ToString(dgvSP.CurrentRow.Cells["GhiChu"].Value);
                dtpNgay.Text = Convert.ToString(dgvSP.CurrentRow.Cells["Ngay"].Value);

            }
            else if (_clickBtn == false)
            {
                txtMaSP.Text = Convert.ToString(dgvSP.CurrentRow.Cells["MaSP"].Value);
                txtTenSP.Text = Convert.ToString(dgvSP.CurrentRow.Cells["TenSP"].Value);
                //txtMaLSP.Text = Convert.ToString(dgvSP.CurrentRow.Cells["MaLSP1"].Value);
                txtSoLuong.Text = Convert.ToString(dgvSP.CurrentRow.Cells["SoLuong"].Value);
                txtGia.Text = Convert.ToString(dgvSP.CurrentRow.Cells["Gia"].Value);
                txtGhiChu.Text = Convert.ToString(dgvSP.CurrentRow.Cells["GhiChu"].Value);
                dtpNgay.Text = Convert.ToString(dgvSP.CurrentRow.Cells["Ngay"].Value);
            }
        }

        private void dgvSP_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvSP.Rows[e.RowIndex].Cells["STT1"].Value = e.RowIndex + 1;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else
                HienThiSP();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                cleartxt();
                HienThiSP();
                KhoaDieuKhien(false);
                _clickBtn = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaSP.Text = bus.TangMa();
            _clickBtn = true;
            KhoaDieuKhien(true);
            txtMaSP.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            _clickBtn = false;
            KhoaDieuKhien(true);
            txtMaSP.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (txtMaSP.Text == "")
            {
                MessageBox.Show("Chọn sản phẩm muốn xóa !", "Chú ý");
            }

            else if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    bus.DeleteData(txtMaSP.Text);
                    MessageBox.Show("Xóa thành công!");
                    cleartxt();
                    KhoaDieuKhien(false);
                    HienThiSP();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenSP.Text == "")
            {
                MessageBox.Show("Điền đầy đủ thông tin !", "Chú ý");
            }
            else
            {
                sp.MaSP = txtMaSP.Text;
                sp.TenSP = txtTenSP.Text;
                sp.MaLSP = txtMaLSP.Text;
                sp.SoLuong = Convert.ToInt32(txtSoLuong.Text);
                sp.Gia = Convert.ToInt32(txtGia.Text);
                sp.GhiChu = txtGhiChu.Text;
                sp.Ngay = dtpNgay.Value;
                try
                {
                    if (_clickBtn == true)
                    {
                        bus.InsertData(sp);
                        MessageBox.Show("Đã thêm!", "Chú ý");
                    }
                    else
                    {
                        bus.UpdateData(sp);
                        MessageBox.Show("Đã sửa!", "Chú ý");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi !\n " + ex, "Error");
                }
                _clickBtn = false;
                cleartxt();
                KhoaDieuKhien(false);
                HienThiSP();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            HienThiSP();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbTimKiem.Text == "Theo Mã Sản Phẩm")
            {
                dgvSP.DataSource = bus.TimKiemSP("SELECT * from SanPham Where MaSP LIKE '%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbTimKiem.Text == "Theo Tên Sản Phẩm")
            {
                dgvSP.DataSource = bus.TimKiemSP("SELECT * from SanPham Where TenSP LIKE '%" + txtTimKiem.Text.Trim() + "%'");
            }

            if (cbTimKiem.Text == "Mã Loại Sản Phẩm")
            {
                dgvSP.DataSource = bus.TimKiemSP("SELECT * from SanPham Where MaLSP LIKE '%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbTimKiem.Text == "Số Lượng")
            {
                dgvSP.DataSource = bus.TimKiemSP("SELECT * from SanPham Where SoLuong LIKE '%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbTimKiem.Text == "Giá")
            {
                dgvSP.DataSource = bus.TimKiemSP("SELECT * from SanPham Where Gia LIKE '%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbTimKiem.Text == "Ghi Chú")
            {
                dgvSP.DataSource = bus.TimKiemSP("SELECT * from SanPham Where GhiChu LIKE '%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbTimKiem.Text == "Ngày")
            {
                dgvSP.DataSource = bus.TimKiemSP("SELECT * from SanPham Where Ngay LIKE '%" + txtTimKiem.Text.Trim() + "%'");
            }
        }
    }
}
