using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace QL_CuaHangBanDoAn
{
    public partial class frm_Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_Order px = new frm_Order();
            px.MdiParent = this;
            px.Show();
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_PhieuXuat px = new frm_PhieuXuat();
            px.MdiParent = this;
            px.Show();
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_DTTheoNgay px = new frm_DTTheoNgay();
            px.MdiParent = this;
            px.Show();
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_DonDatHang1 px = new frm_DonDatHang1();
            px.MdiParent = this;
            px.Show();
        }

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            DS_DonDatHang px = new DS_DonDatHang();
            px.MdiParent = this;
            px.Show();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_QLLoai px = new frm_QLLoai();
            px.MdiParent = this;
            px.Show();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_QLMonAn px = new frm_QLMonAn();
            px.MdiParent = this;
            px.Show();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_QLNguyenLieu px = new frm_QLNguyenLieu();
            px.MdiParent = this;
            px.Show();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_QLNCC px = new frm_QLNCC();
            px.MdiParent = this;
            px.Show();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_NhanVien px = new frm_NhanVien();
            px.MdiParent = this;
            px.Show();
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_DS_TaiKhoan px = new frm_DS_TaiKhoan();
            px.MdiParent = this;
            px.Show();
        }
    }
}