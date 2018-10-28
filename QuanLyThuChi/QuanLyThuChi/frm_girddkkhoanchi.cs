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

namespace QuanLyThuChi
{
    public partial class frm_girddkkhoanchi : DevExpress.XtraEditors.XtraForm
    {
        public frm_girddkkhoanchi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDkKhoanChi frm = new frmDkKhoanChi();
            frm.Show();
        }

      
    }
}