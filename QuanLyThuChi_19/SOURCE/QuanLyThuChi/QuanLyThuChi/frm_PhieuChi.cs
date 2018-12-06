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
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        QLChi qlc = new QLChi();
        PHIEU_CHI pc;
        int mahmchi,flag = 0;
        string maloai;
        public XtraForm1()
        {
            InitializeComponent();
        }
        public XtraForm1(PHIEU_CHI pc1,int mahm,string matiente)
        {
            pc = pc1;
            mahmchi = mahm;
            maloai = matiente;
            this.flag = 1;
            InitializeComponent();
            //pcn.MA_PCHI = pc.MA_PCHI.ToString().Trim() ;
            //txt_chuthich.Text = pc.CHU_THICH;
            //txt_tien.Text = pc.SO_TIEN.ToString();
            //cb_date.DateTime = (DateTime)pc.NGAY_LAP;
            //cbo_tk.SelectedValue = pc.MATK;
            //cb_cthm.SelectedValue = pc.MA_CTHM_CHI;
            //txt_chicho.Text = pc.CHI_CHO_AI;
            
        }
        private void XtraForm1_Load(object sender, EventArgs e)
        {
            Load_DATA();

            if (pc != null)
            {
                txt_maphieuchi.Enabled = cbo_tk.Enabled = false;
                txt_maphieuchi.Text = pc.MA_PCHI.ToString().Trim();
                txt_chuthich.Text = pc.CHU_THICH;
                
                cb_date.DateTime = (DateTime)pc.NGAY_LAP;
                cb_hm.SelectedValue = mahmchi;
                cbo_tk.SelectedValue = pc.MATK;
                cb_cthm.SelectedValue = pc.MA_CTHM_CHI;
                cb_tiente.SelectedValue = maloai;
                txt_chicho.Text = pc.CHI_CHO_AI;
                txt_tien.Text = pc.SO_TIEN.ToString();
                
               
            }

            
        }


        public string get_maphieu()
        {
            string day = DateTime.Now.Day.ToString();
            string gio = DateTime.Now.Hour.ToString();
            string phut = DateTime.Now.Minute.ToString();
            string giay = DateTime.Now.Second.ToString();
            return day + gio + phut + giay;
        }
        public void Load_DATA()
        {
            cb_hm.DisplayMember = "TEN_HM_CHI";
            cb_hm.ValueMember = "MA_HM_CHI";
            cb_hm.DataSource = qlc.load_cb_hmc();

            cb_tiente.DisplayMember = "TENLOAI";
            cb_tiente.ValueMember = "MALOAI";
            cb_tiente.DataSource = qlc.load_cbo_tiente();

            cbo_tk.DisplayMember = "TENTK";
            cbo_tk.ValueMember = "MATK";
            cbo_tk.DataSource = qlc.load_cb_taikhoan(LogIn.GetUserName.userNAME);
        }

        private void cb_hm_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cb_cthm.DisplayMember = "TEN_CTHM_CHI";
                cb_cthm.ValueMember = "MA_CTHM_CHI";
                cb_cthm.DataSource = qlc.load_cb_cthm(int.Parse(cb_hm.SelectedValue.ToString()));
            }
            catch (Exception ex) { }
        }

        private void cb_tiente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TIEN_TE tt = new TIEN_TE();
                tt = qlc.get_tigia(cb_tiente.SelectedValue.ToString());
                txt_tigia.Text = tt.TI_GIA.ToString();
            }
            catch (Exception ex) { }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                
                PHIEU_CHI p = new PHIEU_CHI();
                if (txt_maphieuchi.Text.Trim() == string.Empty)
                    txt_maphieuchi.Text = get_maphieu();
                p.MA_PCHI = txt_maphieuchi.Text;
                p.MATK = cbo_tk.SelectedValue.ToString();
                if (txt_tien.Text.Trim() == string.Empty)
                    txt_tien.Text = 0+"";
                p.SO_TIEN = (decimal.Parse(txt_tien.Text) * decimal.Parse(txt_tigia.Text));
                p.MA_CTHM_CHI = int.Parse(cb_cthm.SelectedValue.ToString());
                if (cb_date.SelectedText == null)
                {
                    MessageBox.Show("Chưa chọn ngày");
                return;}
                p.NGAY_LAP = DateTime.Parse(cb_date.EditValue.ToString());
                p.CHU_THICH = txt_chuthich.Text;
                p.CHI_CHO_AI = string.Empty;

                if (flag != 1)  //thêm mới
                {
                    int kq = qlc.Them_PhieuChi(p);
                    if (kq == 1)
                    {
                        MessageBox.Show("Thêm thành công");
                        int update = qlc.update_tien(p.MATK, (decimal)p.SO_TIEN);
                        qlc.load_grid();
                        this.Close();
                    }
                    else
                        MessageBox.Show("Lỗi"); 
                }
                else //sửa
                {
                    int kq = qlc.Sua_PhieuChi(pc.MA_PCHI,p);
                    if (kq == 0)
                    {
                        MessageBox.Show("Sửa thành công");
                    }
                }

              
            }
            catch (Exception ex) { }


        }

        private void txt_tien_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string tien = (decimal.Parse(txt_tien.Text) * decimal.Parse(txt_tigia.Text)).ToString();
                txt_thanhtien.Text = ReadNumber.ByWords(decimal.Parse(tien));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Số tiền không hợp lệ");
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_themhm_Click(object sender, EventArgs e)
        {
            frm_DangKyKhoanChi frm = new frm_DangKyKhoanChi();
            frm.ShowDialog();
        }

        private void XtraForm1_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
    }
}