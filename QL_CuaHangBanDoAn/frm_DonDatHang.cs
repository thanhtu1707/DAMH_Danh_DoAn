using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DAL;
using System.Xml.Linq;

namespace QL_CuaHangBanDoAn
{
    public partial class frm_DonDatHang : DevExpress.XtraEditors.XtraForm
    {
        QuanLy ql = new QuanLy();
        public frm_DonDatHang()
        {
            InitializeComponent();
        }

        private void frm_DonDatHang_Load(object sender, EventArgs e)
        {
            loadcbo_NCC();
        }
        private void loadcbo_NCC()
        {
            //  cboNCC.Properties.DataSor
            look_NCC.Properties.DataSource = ql.loadCboNCC();
            look_NCC.Properties.DisplayMember = "TenNCC";
            look_NCC.Properties.ValueMember = "MaNCC";
        }
    }
}