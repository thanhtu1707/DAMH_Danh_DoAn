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

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_DonDatHang ddh = new frm_DonDatHang();
            ddh.MdiParent = this;
            ddh.Show();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_QLMonAn frm = new frm_QLMonAn();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_QLNCC frm = new frm_QLNCC();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_QLNguyenLieu frm = new frm_QLNguyenLieu();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_QLLoai frm = new frm_QLLoai();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_Order frm = new frm_Order();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}