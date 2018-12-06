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
using DevExpress.UserSkins;
using DevExpress.Skins;
using LinQ;
namespace QuanLyThuChi
{
    public partial class frm_PhieuThu : DevExpress.XtraEditors.XtraForm
    {
        QLThu qlt = new QLThu();
        public frm_PhieuThu()
        {
            InitializeComponent();
            DevExpress.UserSkins.BonusSkins.Register();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (btn_luu.Enabled == true) //đang thêm và nhấp để hủy
                {
                    btn_xoa.Enabled = btn_sua.Enabled = true;
                    btn_luu.Enabled = false;
                }
                else
                {

                    btn_luu.Enabled = true;
                    btn_xoa.Enabled = btn_sua.Enabled = false;
                   txt_maphieuthu.Enabled = txt_tien.Enabled = cbo_ngaylap.Enabled = cbo_taikhoan.Enabled = cbo_tiente.Enabled =cbo_hangmucthu.Enabled = txt_chuthich.Enabled = true;
                    txt_chuthich.Text = txt_maphieuthu.Text = txt_thanhtien.Text  = string.Empty;
                    txt_tien.Text = "0";
                   
                }
            }
            catch (Exception ex)
            { }

        }

        private void frm_PhieuThu_Load(object sender, EventArgs e)
        {

            cbo_ngaylap.EditValue = DateTime.Now;
            LOAD_DATA();
        }
        public void LOAD_DATA()
        {
            cbo_hangmucthu.DisplayMember = "TEN_HM_THU";
            cbo_hangmucthu.ValueMember = "MA_HM_THU";
            cbo_hangmucthu.DataSource = qlt.load_cb_hmc();

            cbo_tiente.DisplayMember = "TENLOAI";
            cbo_tiente.ValueMember = "MALOAI";
            cbo_tiente.DataSource = qlt.load_cbo_tiente();

            cbo_taikhoan.DisplayMember = "TENTK";
            cbo_taikhoan.ValueMember = "MATK";
            cbo_taikhoan.DataSource = qlt.load_cb_taikhoan(LogIn.GetUserName.userNAME);

            gridControl1.DataSource = qlt.Load_Grid(LogIn.GetUserName.userNAME);
            TongThu();
        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            try
            {
                txt_maphieuthu.Text = gridView1.GetFocusedRowCellValue("MA_PHIEU_THU").ToString();
                cbo_taikhoan.SelectedValue = gridView1.GetFocusedRowCellValue("MA_TK").ToString();
                cbo_tiente.SelectedValue = gridView1.GetFocusedRowCellValue("MA_LOAI");
                cbo_ngaylap.EditValue = DateTime.Parse (gridView1.GetFocusedRowCellValue("NGAY_LAP").ToString()).ToShortDateString();
                txt_tien.Text = gridView1.GetFocusedRowCellValue("SO_TIEN").ToString();
                txt_chuthich.Text = gridView1.GetFocusedRowCellValue("CHU_THICH").ToString();
            }
            catch (Exception ex) { }

        }

        private void cbo_tiente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TIEN_TE tt = new TIEN_TE();
                tt = qlt.get_tigia(cbo_tiente.SelectedValue.ToString());
                txt_tigia.Text = tt.TI_GIA.ToString();
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

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (btn_luu.Enabled == false) // dang sua
            {
                btn_luu.Enabled  = txt_tien.Enabled = cbo_ngaylap.Enabled = cbo_tiente.Enabled = cbo_hangmucthu.Enabled = txt_chuthich.Enabled = true;
                btn_xoa.Enabled = btn_them.Enabled = false;


            }
            else
            {
                btn_luu.Enabled = txt_tien.Enabled = cbo_ngaylap.Enabled = cbo_tiente.Enabled = cbo_hangmucthu.Enabled = txt_chuthich.Enabled = false;
                btn_xoa.Enabled = btn_them.Enabled = true;

            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            try
            {

                if (btn_sua.Enabled == false)  //đang thêm
                {
                    PHIEU_THU p = new PHIEU_THU();

                    if (txt_maphieuthu.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show("Vui lòng nhập mã phiếu");
                        return;
                    }
                    p.MAPTHU = txt_maphieuthu.Text;
                    p.MA_HM_THU = int.Parse(cbo_hangmucthu.SelectedValue.ToString());
                    p.MATK = cbo_taikhoan.SelectedValue.ToString();
                    if (txt_tien.Text.Trim() == string.Empty)
                        txt_tien.Text = 0 + "";
                    p.TIEN = (decimal.Parse(txt_tien.Text) * decimal.Parse(txt_tigia.Text));
                    p.GHICHU = txt_chuthich.Text;
                    p.THU_TU_AI = txt_thutu.Text;
                    if (cbo_ngaylap.SelectedText == null)
                    {
                        MessageBox.Show("Chưa chọn ngày");
                        return;
                    }
                    p.NGAY_LAP =DateTime.Parse( cbo_ngaylap.EditValue.ToString());
                    int kq = qlt.Them_PT(p);
                    if (kq == 0)
                    {
                        MessageBox.Show("Thêm thành công");
                        btn_luu.Enabled = false;
                        btn_xoa.Enabled = btn_sua.Enabled = true;
                        txt_maphieuthu.Enabled = txt_tien.Enabled = cbo_ngaylap.Enabled = cbo_taikhoan.Enabled = cbo_tiente.Enabled = cbo_hangmucthu.Enabled = txt_chuthich.Enabled = false;

                    }
                    else
                        MessageBox.Show("Mã phiếu này đã tồn tại");

                }
                if (btn_them.Enabled == false) //đang sửa
                {
                    try
                    {
                        PHIEU_THU p = new PHIEU_THU();
                        p.MAPTHU = txt_maphieuthu.Text;
                        p.MATK = cbo_taikhoan.SelectedValue.ToString();
                        p.MA_HM_THU = int.Parse(cbo_hangmucthu.SelectedValue.ToString());
                        p.TIEN = (decimal.Parse(txt_tien.Text) * decimal.Parse(txt_tigia.Text));
                        p.GHICHU = txt_chuthich.Text;
                        p.THU_TU_AI = txt_thutu.Text;
                        p.NGAY_LAP = DateTime.Parse(cbo_ngaylap.EditValue.ToString());
                        int kq = qlt.Sua_PhieuThu(p);
                        if (kq == 0)
                        {
                            MessageBox.Show("Sửa thành công");
                            btn_luu.Enabled = txt_tien.Enabled = cbo_ngaylap.Enabled = cbo_tiente.Enabled = cbo_hangmucthu.Enabled = txt_chuthich.Enabled = false;
                            btn_xoa.Enabled = btn_them.Enabled = true;
                        }
                        else { MessageBox.Show("Sửa thất bại"); }
                    }
                    catch (Exception ex)
                    { }
                    
                }
                LOAD_DATA();



            }
            catch (Exception ex)
            {

            }
        }





        public string get_maphieu()
        {
            string day = DateTime.Now.Day.ToString();
            string thang = DateTime.Now.Month.ToString();
            string gio = DateTime.Now.Hour.ToString();
            string phut = DateTime.Now.Minute.ToString();
            string giay = DateTime.Now.Second.ToString();
            return day +thang + gio + phut + giay;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r;
                r = MessageBox.Show("Bạn muốn xóa?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.Yes)
                {
                    int kq = qlt.Xoa_PhieuThu(txt_maphieuthu.Text);
                    if (kq == 0)
                        MessageBox.Show("Xóa thành công");
                    else
                        MessageBox.Show("Xóa thất bại");
                    LOAD_DATA();
                }
            }
            catch (Exception ex)
            { }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            if (cbo_ngaybd.EditValue != null && cbo_ngaykt.EditValue != null)
                gridControl1.DataSource = qlt.Load_Grid_TimKiem(LogIn.GetUserName.userNAME, DateTime.Parse(cbo_ngaybd.EditValue.ToString()), DateTime.Parse(cbo_ngaykt.EditValue.ToString()));
        }


        //cap nhat label tongthu
        public void TongThu()
        {
            decimal s = 0;
            for (int i = 0; i < gridView1.RowCount; i++)
            {

                s += decimal.Parse(gridView1.GetRowCellValue(i, "SO_TIEN").ToString());
            }
            txt_tong.Text = "Tổng thu : " + s;
        }
    }
}