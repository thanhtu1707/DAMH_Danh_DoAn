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
namespace QL_CuaHangBanDoAn
{
    public partial class frm_DonDatHang1 : DevExpress.XtraEditors.XtraForm
    {
        loadDAL dl = new loadDAL();
        public frm_DonDatHang1()
        {
            InitializeComponent();
        }

        private void frm_DonDatHang1_Load(object sender, EventArgs e)
        {
            load_cboNCC();
        }
        public void load_cboNCC()
        {
            look_NCC.Properties.DataSource = dl.load_TenNCC();
            look_NCC.Properties.DisplayMember = "TenNCC";
            look_NCC.Properties.ValueMember = "MaNCC";
        }
    }
}