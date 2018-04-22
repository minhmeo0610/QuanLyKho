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

        }
        private void cleartxt()
        {
            txtMaLoaiSP.Text = "";
            txtTenLoaiSP.Text = "";
            txtMoTa.Text = "";
        }

        private void HienThiDSLoaiSP()
        {
            dgvLoaiSanPham.DataSource = BUS_LoaiSP.GetData();
        }
        private void frmSanPham_Load(object sender, EventArgs e)
        {
            HienThiDSLoaiSP();
            KhoaDieuKhien(false);
        }

        private void dgvLoaiSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(_clickBtn == true)
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
            if(txtTenLoaiSP.Text=="")
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
                    if(_clickBtn==true)
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
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi !\n "+ex, "Error");
                }
                _clickBtn = false;
                cleartxt();
                KhoaDieuKhien(false);
                HienThiDSLoaiSP();
            }
        }

        private void btnXoaLoaiSP_Click(object sender, EventArgs e)
        {
            if(txtMaLoaiSP.Text=="")
            {
                MessageBox.Show("Chọn loại sản phẩm muốn xóa !","Chú ý");
            }

            else if(MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
    }
}
