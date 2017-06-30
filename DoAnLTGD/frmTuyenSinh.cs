using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DoAnLTGD
{
    public partial class frmTuyenSinh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmTuyenSinh()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frmDangNhap = new frmDangNhap();
            frmDangNhap.Show();
        }

        private void frmTuyenSinh_Load(object sender, EventArgs e)
        {

        }

        private void barBtnHuongDan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
      

        private void barBtnDanhSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frmQuanLy = new frmQuanLy();
            frmQuanLy.Show();
            
        }

        private void barBtnDoiTuong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frmDoiTuong = new frmDoiTuongcs();
            frmDoiTuong.Show();
        }

        private void barBtnToHopMon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frmToHopMon = new frmToHopMon();
            frmToHopMon.Show();
        }

        private void barBtnNganh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frmNganh = new frmNganh();
            frmNganh.Show();
        }

        private void barBtnMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frmMon = new frmMon();
            frmMon.Show();
        }

        private void barBtnTruong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frmTruong = new frmTruongcs();
            frmTruong.Show();
        }

        private void barBtnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông Báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) != DialogResult.Yes) {
                Form frmQuanLy = new frmQuanLy();
                frmQuanLy.Show();
            }
        }

        private void barBtnDangKy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frmDangKy = new frmDangKy();
            frmDangKy.Show();
        }
    }
}
