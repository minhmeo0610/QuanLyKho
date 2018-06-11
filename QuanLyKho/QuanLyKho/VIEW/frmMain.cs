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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private int i = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbchuchay.Location = new Point(lbchuchay.Location.X - i, lbchuchay.Location.Y);

            if (lbchuchay.Location.X <= -510 || lbchuchay.Location.Y <= 0)
            {
                lbchuchay.Location = new Point(lbchuchay.Location.X + 1300, lbchuchay.Location.Y);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangNhap dn = new frmDangNhap();
            dn.Show();
            this.Hide();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void quảnLýMượnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiTac dt = new frmDoiTac();
            dt.Show();
            this.Hide();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien dt = new frmNhanVien();
            dt.Show();
            this.Hide();
        }

        private void quảnLýDinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSanPham dt = new frmSanPham();
            dt.Show();
            this.Hide();
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmhuongdan h = new frmhuongdan();
            h.Show();
        }

        private void ttNhanVientoolStripButton_Click(object sender, EventArgs e)
        {
            frmNhanVien dt = new frmNhanVien();
            dt.Show();
            this.Hide();
        }

        private void btnDoiTac_Click(object sender, EventArgs e)
        {
            frmDoiTac dt = new frmDoiTac();
            dt.Show();
            this.Hide();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            frmSanPham dt = new frmSanPham();
            dt.Show();
            this.Hide();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            frmHoaDon_CTHD dt = new frmHoaDon_CTHD();
            dt.Show();
            this.Hide();
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDon_CTHD dt = new frmHoaDon_CTHD();
            dt.Show();
            this.Hide();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn thoát không?", "Xác nhận không", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
                return ;
          
        }
    }
}
