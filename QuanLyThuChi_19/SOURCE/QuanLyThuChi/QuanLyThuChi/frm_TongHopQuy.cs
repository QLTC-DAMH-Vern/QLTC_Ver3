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
    public partial class frm_TongHopQuy : DevExpress.XtraEditors.XtraForm
    {
        LogIn Login = new LogIn();
        string manguoidung = LogIn.GetUserName.userNAME;
        QLQuy qlq = new QLQuy();
        public frm_TongHopQuy()
        {
            InitializeComponent();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void Load_DATA()
        {
            cbo_loaitk.DisplayMember="TEN_TK";
            cbo_loaitk.ValueMember = "MA_LOAI_TK";
            cbo_loaitk.DataSource = qlq.load_cbo_loaitk();

            cbo_tiente.DisplayMember="TENLOAI";
            cbo_tiente.ValueMember="MALOAI";
            cbo_tiente.DataSource = qlq.load_cbo_tiente();

            gridControl1.DataSource = qlq.load_grid(manguoidung);
        }

        private void frm_TongHopQuy_Load(object sender, EventArgs e)
        {
            Load_DATA();
        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            
            try
            {
                
                txt_matk.Text = gridView1.GetFocusedRowCellValue("MATK").ToString();
                txt_tentk.Text = gridView1.GetFocusedRowCellValue("TENTK").ToString();
                txt_sodubd.Text = (gridView1.GetFocusedRowCellValue("SODUBD") ==null ? "" : gridView1.GetFocusedRowCellValue("SODUBD").ToString());
                txt_soduht.Text = (gridView1.GetFocusedRowCellValue("SODUHT") == null ? "" : gridView1.GetFocusedRowCellValue("SODUHT").ToString());
                cbo_tiente.SelectedValue = gridView1.GetFocusedRowCellValue("MALOAI").ToString();
                cbo_loaitk.SelectedValue = int.Parse(gridView1.GetFocusedRowCellValue("MA_LOAI_TK").ToString());
                cbo_loaitk.SelectedValue.ToString();
                txt_chuthich.Text = (gridView1.GetFocusedRowCellValue("DIENGIAI")== null ? "" : gridView1.GetFocusedRowCellValue("DIENGIAI").ToString());
                
            }
            catch (Exception ex)
            { }
        }

        private void txt_matk_Leave(object sender, EventArgs e)
        {
            if (txt_matk.SelectionLength > 5)
            {
                MessageBox.Show("Mã không được quá 5 ký tự");
                txt_matk.Focus();
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
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
                    txt_matk.Enabled = txt_sodubd.Enabled = txt_tentk.Enabled=cbo_loaitk.Enabled=cbo_tiente.Enabled = txt_chuthich.Enabled = true;
                    txt_chuthich.Text = txt_chuthich.Text = txt_matk.Text = txt_sodubd.Text = txt_soduht.Text=txt_tentk.Text = string.Empty;
                    
                }
            }
            catch (Exception ex)
            { }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            try
            {

                if (btn_sua.Enabled == false)  //đang thêm
                {
                    if (txt_matk.Text == string.Empty)
                    {
                        MessageBox.Show("Vui lòng nhập mã tài khoản");
                        txt_matk.Focus();
                        return;
                    }
                    TAI_KHOAN tk = new TAI_KHOAN();
                    tk.MATK = txt_matk.Text;
                    tk.TENTK = txt_tentk.Text;
                    tk.MALOAI = cbo_tiente.SelectedValue.ToString();
                    tk.MANGUOIDUNG = manguoidung;
                    tk.SODUBD = (txt_sodubd.Text == null ? 0 : decimal.Parse(txt_sodubd.Text));
                    tk.SODUHT = tk.SODUBD;
                    tk.TRANGTHAI = true;
                    tk.DIENGIAI = txt_chuthich.Text;
                    tk.MA_LOAI_TK = int.Parse(cbo_loaitk.SelectedValue.ToString());

                    int kq = qlq.Them_TK(tk);
                    Load_DATA();
                    btn_luu.Enabled = false;
                    btn_sua.Enabled = btn_xoa.Enabled = true;
                    txt_matk.Enabled = txt_sodubd.Enabled = txt_soduht.Enabled = txt_tentk.Enabled = cbo_loaitk.Enabled = cbo_tiente.Enabled = txt_chuthich.Enabled = false;
                    if (kq == 0)
                        MessageBox.Show("Thêm thành công");
                    else
                        MessageBox.Show("Thêm thất bại");

                }
                if (btn_them.Enabled == false) //đang sửa
                {
                    qlq.Sua_TK(txt_matk.Text, txt_tentk.Text, cbo_tiente.SelectedValue.ToString(), int.Parse(cbo_loaitk.SelectedValue.ToString()), decimal.Parse(txt_sodubd.Text), txt_chuthich.Text);
                    txt_matk.Enabled = txt_sodubd.Enabled = txt_soduht.Enabled = txt_tentk.Enabled = cbo_loaitk.Enabled = cbo_tiente.Enabled = txt_chuthich.Enabled = btn_luu.Enabled = false;
                    btn_xoa.Enabled = btn_them.Enabled = true;
                    Load_DATA();
                    MessageBox.Show("Sửa thành công");

                }



            }
            catch (Exception ex)
            {

            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult r;
                r = MessageBox.Show("Bạn muốn xóa?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.Yes)
                {
                    int kq = qlq.Xoa_Tk(txt_matk.Text);
                    if (kq == 1)
                    {
                        MessageBox.Show("Hạng mục này đang được sử dụng không thể xóa");
                        return;
                    }
                    Load_DATA();
                }
            }
            catch (Exception ex)
            { }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (btn_luu.Enabled == false) // dang sua
            {
                txt_matk.Enabled = txt_sodubd.Enabled = txt_tentk.Enabled = cbo_loaitk.Enabled = cbo_tiente.Enabled = txt_chuthich.Enabled = btn_luu.Enabled= true;
                btn_xoa.Enabled = btn_them.Enabled = false;


            }
            else
            {
                txt_matk.Enabled = txt_sodubd.Enabled = txt_tentk.Enabled = cbo_loaitk.Enabled = cbo_tiente.Enabled = txt_chuthich.Enabled = btn_luu.Enabled = false;
                btn_xoa.Enabled = btn_them.Enabled = true;

            }
        }

        private void btn_rs_Click(object sender, EventArgs e)
        {
            Load_DATA();
        }
    }
}