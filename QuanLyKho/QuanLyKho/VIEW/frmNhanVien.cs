﻿using QuanLyKho.BUS;
using QuanLyKho.ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKho.VIEW
{
    public partial class frmNhanVien : Form
    {
        NhanVienEntity obj = new NhanVienEntity();
        NhanVienBUS Bus = new NhanVienBUS();
        private int fluu = 1;
        public frmNhanVien()
        {
            InitializeComponent();
        }
        private void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            dtNgaySinh.Enabled = e;         
            txtTenNV.Enabled = e;
            txtMaNV.Enabled = e;
            txtDiaChi.Enabled = e;
            txtSDT.Enabled = e;
            radNam.Enabled = e;
            radNu.Enabled = e;
        }
        private void clearData()
        {
            txtMaNV.Text = "";           
            txtTenNV.Text = "";
            radNam.Checked = false;
            radNu.Checked = false;
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            dtNgaySinh.Value = DateTime.Parse("1/1/1997");
        }
        private void HienThi()
        {
            dgvNhanVien.DataSource = Bus.GetData();
            dgvNhanVien.AutoResizeColumns();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (fluu == 0)
            {
                txtTenNV.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["TenNV"].Value);
                txtSDT.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["SoDT"].Value);
                txtDiaChi.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["DiaChi"].Value);
                dtNgaySinh.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["NgaySinh"].Value);                
                if (dgvNhanVien.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString() == "Nam") radNam.Checked = true;
                else radNu.Checked = true;
            }
            else
            {
                txtMaNV.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["MaNV"].Value);
                txtTenNV.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["TenNV"].Value);
                txtSDT.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["SoDT"].Value);
                txtDiaChi.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["DiaChi"].Value);
                dtNgaySinh.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["NgaySinh"].Value);
                if (dgvNhanVien.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString() == "Nam") radNam.Checked = true;
                else radNu.Checked = true;
            }
        }

        private void dgvNhanVien_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvNhanVien.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fluu = 0;
            txtMaNV.Text = Bus.TangMa();
            DisEnl(true);
            txtMaNV.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            fluu = 1;
            DisEnl(true);
            txtMaNV.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Bus.DeleteData(txtMaNV.Text);
                    MessageBox.Show("Xóa thành công!");
                    clearData();
                    DisEnl(false);
                    HienThi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtTenNV.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (txtSDT.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập SĐT nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
            if (radNam.Checked == false && radNu.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn giới tính của nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            obj.MaNV = txtMaNV.Text;
            obj.TenNV = txtTenNV.Text;
            obj.DiaChi = txtDiaChi.Text;            
            obj.SoDT = txtSDT.Text;
            obj.NgaySinh = dtNgaySinh.Value;
           
            string gt;
            if (radNam.Checked)
            {
                gt = "Nam";
            }
            else gt = "Nữ";

            obj.GioiTinh = gt;
            if (txtMaNV.Text != "" && txtTenNV.Text != "" && txtDiaChi.Text != "" && txtSDT.Text != ""  && radNam.Checked == false || radNu.Checked == false && fluu == 0)
            {
                try
                {
                    Bus.InsertData(obj);                 
                    MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    frmNhanVien_Load(sender, e);
                    clearData();
                    DisEnl(false);
                    fluu = 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message);
                }
            }
            else if (txtMaNV.Text != "" && txtTenNV.Text != "" && txtDiaChi.Text != "" && txtSDT.Text != "" && radNam.Checked == false || radNu.Checked == false && fluu != 0)
            {
                try
                {
                    Bus.UpdateData(obj);
                    MessageBox.Show("Sửa Thành Công ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    frmNhanVien_Load(sender, e);
                    clearData();
                    DisEnl(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                HienThi();
                DisEnl(false);
                fluu = 1;

            }
            else
                return;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn thoát không?", "Xác nhận không", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                frmMain m = new frmMain();
                m.Show();
                this.Close();
            }
            else
                HienThi();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbTimKiem.Text == "Mã Nhân Viên")
            {
                dgvNhanVien.DataSource = Bus.TimKiemNV("SELECT * from NhanVien Where MaNV LIKE '%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbTimKiem.Text == "Tên Nhân Viên")
            {
                dgvNhanVien.DataSource = Bus.TimKiemNV("SELECT * from NhanVien Where  TenNV LIKE N'%" + txtTimKiem.Text.Trim() + "%'");
            }
          
            if (cbTimKiem.Text == "Giới Tính")
            {
                dgvNhanVien.DataSource = Bus.TimKiemNV("SELECT * from NhanVien Where GioiTinh LIKE N'%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbTimKiem.Text == "SĐT")
            {
                dgvNhanVien.DataSource = Bus.TimKiemNV("SELECT * from NhanVien Where SoDT LIKE  '%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbTimKiem.Text == "Địa Chỉ")
            {
                dgvNhanVien.DataSource = Bus.TimKiemNV("SELECT * from NhanVien Where DiaChi LIKE N'%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbTimKiem.Text == "Ngày Sinh(năm-tháng-ngày)")
            {
                dgvNhanVien.DataSource = Bus.TimKiemNV("SELECT * from NhanVien Where NgaySinh LIKE  '%" + txtTimKiem.Text.Trim() + "%'");
            }
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            HienThi();
            DisEnl(false);
        }
    }
}
