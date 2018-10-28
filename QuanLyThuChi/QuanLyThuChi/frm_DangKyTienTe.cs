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
using LinQ;
namespace QuanLyThuChi
{
    public partial class frm_DangKyTienTe : DevExpress.XtraEditors.XtraForm
    {
        QLTienTe qltt = new QLTienTe();
        public frm_DangKyTienTe()
        {
            InitializeComponent();
        }
        public void LOAD_DATA()
        {
            gridControl1.DataSource = qltt.load_grid_tiente();
        }

        private void frm_DangKyTienTe_Load(object sender, EventArgs e)
        {
            LOAD_DATA();
        }
    }
}