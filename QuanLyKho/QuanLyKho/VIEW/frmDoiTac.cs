using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKho.ENTITY;
using QuanLyKho.BUS;
namespace QuanLyKho.VIEW
{
    public partial class frmDoiTac : Form
    {
        DoiTac doitac = new DoiTac();
        DoiTacBUS doitacbus = new DoiTacBUS();
        private int fluu = 1;
        private void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            txtMaDoiTac.Enabled = e;
            txtTenDoiTac.Enabled = e;
            txtDiaChi.Enabled = e;
            txtSDT.Enabled = e;
            txtEmail.Enabled = e;
            txtGhiChu.Enabled = e;
            txtKieuDoiTac.Enabled = e;
        }
        private void clearData()
        {
            txtMaDoiTac.Text = "";
            txtTenDoiTac.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            txtGhiChu.Text = "";
            txtKieuDoiTac.Text = "";
        }
        private void HienThi()
        {
            dgvDoiTac.DataSource = doitacbus.XemThongTinDoiTac();
        }

        public frmDoiTac()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác Nhận ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                frmMain main = new frmMain();
                main.Show();
                this.Close();
            }
            else
            {
                HienThi();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                HienThi();
                DisEnl(false);
            }
            else
                return;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fluu = 0;
            clearData();
            txtMaDoiTac.Text = doitacbus.TangMa();
            DisEnl(true);
            txtMaDoiTac.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            fluu = 1;
            DisEnl(true);
            txtMaDoiTac.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    doitacbus.XoaDoiTac(txtMaDoiTac.Text);
                    MessageBox.Show("Xóa thành công!");
                    HienThi();
                    clearData();
                    DisEnl(false);
                    
                }
                catch
                {
                    MessageBox.Show("Xóa không thành công");
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            doitac.MaDoiTac = txtMaDoiTac.Text;
            doitac.TenDoiTac = txtTenDoiTac.Text;
            doitac.DiaChi = txtDiaChi.Text;
            doitac.SoDT = txtSDT.Text;
            doitac.Emaill = txtEmail.Text;
            doitac.GhiChu = txtGhiChu.Text;
            doitac.KieuDoiTac = txtKieuDoiTac.Text;
            if (fluu == 0)
            {
                doitacbus.ThemDoiTac(doitac);
                MessageBox.Show("Thêm thành công!");
                HienThi();
                clearData();
                DisEnl(false);
            }
            else
            {
                doitacbus.SuaDoiTac(doitac);
                MessageBox.Show("Sửa Thành Công ! ");
                HienThi();
                clearData();
                DisEnl(false);
            }
        }

        private void dgvDoiTac_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvDoiTac.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void dgvDoiTac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (fluu == 0)
            {
                txtMaDoiTac.Text = Convert.ToString(dgvDoiTac.CurrentRow.Cells["MaDoiTac"].Value);
                txtTenDoiTac.Text = Convert.ToString(dgvDoiTac.CurrentRow.Cells["TenDoiTac"].Value);
                txtDiaChi.Text = Convert.ToString(dgvDoiTac.CurrentRow.Cells["DiaChi"].Value);
                txtSDT.Text = Convert.ToString(dgvDoiTac.CurrentRow.Cells["SoDT"].Value);
                txtEmail.Text = Convert.ToString(dgvDoiTac.CurrentRow.Cells["Email"].Value);
                txtGhiChu.Text = Convert.ToString(dgvDoiTac.CurrentRow.Cells["GhiChu"].Value);
                txtKieuDoiTac.Text = Convert.ToString(dgvDoiTac.CurrentRow.Cells["KieuDoiTac"].Value);
            }
            else
            {
                txtMaDoiTac.Text = Convert.ToString(dgvDoiTac.CurrentRow.Cells["MaDoiTac"].Value);
                txtTenDoiTac.Text = Convert.ToString(dgvDoiTac.CurrentRow.Cells["TenDoiTac"].Value);
                txtDiaChi.Text = Convert.ToString(dgvDoiTac.CurrentRow.Cells["DiaChi"].Value);
                txtSDT.Text = Convert.ToString(dgvDoiTac.CurrentRow.Cells["SoDT"].Value);
                txtEmail.Text = Convert.ToString(dgvDoiTac.CurrentRow.Cells["Email"].Value);
                txtGhiChu.Text = Convert.ToString(dgvDoiTac.CurrentRow.Cells["GhiChu"].Value);
                txtKieuDoiTac.Text = Convert.ToString(dgvDoiTac.CurrentRow.Cells["KieuDoiTac"].Value);
            }
        }

        private void frmDoiTac_Load(object sender, EventArgs e)
        {
            HienThi();
            DisEnl(false);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbTimKiem.Text== "Theo Mã Đối Tác")
            {
                dgvDoiTac.DataSource = doitacbus.TimKiemDoiTac("select * from DoiTac where MaDoiTac like '%" + txtTimKiem.Text + "%'");
            }
            if (cbTimKiem.Text == "Theo Tên Đối Tác")
            {
                dgvDoiTac.DataSource = doitacbus.TimKiemDoiTac("select * from DoiTac where TenDoiTac like '%" + txtTimKiem.Text + "%'");
            }
            if (cbTimKiem.Text == "Theo Địa Chỉ")
            {
                dgvDoiTac.DataSource = doitacbus.TimKiemDoiTac("select * from DoiTac where DiaChi like '%" + txtTimKiem.Text + "%'");
            }
            if (cbTimKiem.Text == "Theo Email")
            {
                dgvDoiTac.DataSource = doitacbus.TimKiemDoiTac("select * from DoiTac where Email like '%" + txtTimKiem.Text + "%'");
            }
            if (cbTimKiem.Text == "Theo Kiểu Đối Tác")
            {
                dgvDoiTac.DataSource = doitacbus.TimKiemDoiTac("select * from DoiTac where KieuDoiTac like '%" + txtTimKiem.Text + "%'");
            }
        }
    }
}
