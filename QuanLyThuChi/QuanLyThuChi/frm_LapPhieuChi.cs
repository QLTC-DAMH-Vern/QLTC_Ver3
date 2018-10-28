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
    public partial class frm_LapPhieuChi : DevExpress.XtraEditors.XtraForm
    {
        public frm_LapPhieuChi()
        {
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            XtraForm1 frm = new XtraForm1();
            frm.Show();
        }

        
    }
}