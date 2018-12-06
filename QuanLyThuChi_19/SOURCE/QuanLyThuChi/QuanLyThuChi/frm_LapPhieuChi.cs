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
    public partial class frm_LapPhieuChi : DevExpress.XtraEditors.XtraForm
    {
        QLChi qlc = new QLChi();
        public frm_LapPhieuChi()
        {
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            XtraForm1 frm = new XtraForm1();
            frm.Show();
        }

        public void LOAD_DATA()
        {
            gridControl1.DataSource = qlc.Load_Grid(LogIn.GetUserName.userNAME);
            TongThu();
        }
        private void frm_LapPhieuChi_Load(object sender, EventArgs e)
        {
            //gridControl1.DataSource =  qlc.load_grid();
            gridControl1.DataSource = qlc.Load_Grid(LogIn.GetUserName.userNAME);
            TongThu();
        }

        private void frm_LapPhieuChi_Activated(object sender, EventArgs e)
        {
            //gridControl1.DataSource = qlc.load_grid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_rs_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = qlc.Load_Grid(LogIn.GetUserName.userNAME);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            int flag = 1;
            PHIEU_CHI pc = new PHIEU_CHI();
            //txt_maphieuchi.Text = pc.MA_PCHI;
            //txt_chuthich.Text = pc.CHU_THICH;
            //txt_tien.Text = pc.SO_TIEN.ToString();
            //cb_date.DateTime = (DateTime)pc.NGAY_LAP;
            //cbo_tk.SelectedValue = pc.MATK;
            //cb_cthm.SelectedValue = pc.MA_CTHM_CHI;
            //txt_chicho.Text = pc.CHI_CHO_AI;
            try
            {
                pc.MA_PCHI = gridView1.GetFocusedRowCellValue("MA_PHIEU_CHI").ToString();
                pc.MATK = gridView1.GetFocusedRowCellValue("MA_TK").ToString();
                pc.MA_CTHM_CHI = int.Parse(gridView1.GetFocusedRowCellValue("MA_CTHM_CHI").ToString());
                pc.NGAY_LAP = DateTime.Parse(gridView1.GetFocusedRowCellValue("NGAY_LAP").ToString());
                pc.SO_TIEN = decimal.Parse(gridView1.GetFocusedRowCellValue("SO_TIEN").ToString());
                pc.CHU_THICH = gridView1.GetFocusedRowCellValue("CHU_THICH").ToString() + "";
                pc.CHI_CHO_AI = (gridView1.GetFocusedRowCellValue("CHI_CHO_AI") == null ? "" : gridView1.GetFocusedRowCellValue("CHI_CHO_AI").ToString());
                int mahmchi = int.Parse(gridView1.GetFocusedRowCellValue("MA_HM_CHI").ToString());
                string matiente = gridView1.GetFocusedRowCellValue("MA_LOAI").ToString();
                XtraForm1 frm = new XtraForm1(pc,mahmchi,matiente);
                frm.ShowDialog();
            }
            catch (Exception ex) { } 
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult r;
                r = MessageBox.Show("Bạn muốn xóa?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.Yes)
                {
                    int kq = qlc.Xoa_PhieuChi(gridView1.GetFocusedRowCellValue("MA_PHIEU_CHI").ToString());
                    if (kq == 1)
                    {
                        MessageBox.Show("Hạng mục này đang được sử dụng không thể xóa");
                        return;
                    }
                    
                }
                LOAD_DATA();
            }
            catch (Exception ex)
            { }
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            if(cbo_ngaybd.EditValue !=null && cbo_ngaykt.EditValue != null)
                gridControl1.DataSource =  qlc.Load_Grid_TimKiem(LogIn.GetUserName.userNAME, DateTime.Parse(cbo_ngaybd.EditValue.ToString()), DateTime.Parse(cbo_ngaykt.EditValue.ToString()));
        }

        public void TongThu()
        {
            decimal s = 0;
            for (int i = 0; i < gridView1.RowCount; i++)
            {

                s += decimal.Parse(gridView1.GetRowCellValue(i, "SO_TIEN").ToString());
            }
            txt_tong.Text = "Tổng chi : " + s;
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            if (cb_ngaybd.EditValue.ToString() != string.Empty && cb_ngaykt.EditValue.ToString() != string.Empty)
                gridControl1.DataSource = qlc.Load_Grid_TimKiem(LogIn.GetUserName.userNAME, DateTime.Parse(cb_ngaybd.EditValue.ToString()), DateTime.Parse(cb_ngaykt.EditValue.ToString()));
        }
        
    }
}