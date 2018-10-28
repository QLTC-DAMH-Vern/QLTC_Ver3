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
using BLL;  
namespace QuanLyThuChi
{
    public partial class frm_DangKyHangMucThu : DevExpress.XtraEditors.XtraForm
    {
        KhoanThuBLL hangmucthu = new KhoanThuBLL();
        public frm_DangKyHangMucThu()
        {
            InitializeComponent();
        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            try
            {
                string ma_hm = gridView1.GetFocusedRowCellValue("MA_HM_THU").ToString();
                string ten_hm = gridView1.GetFocusedRowCellValue("TEN_HM_THU").ToString();
                string chuthich = gridView1.GetFocusedRowCellValue("NOTE").ToString();
                txt_mahm.Text = ma_hm;
                txt_tenhm.Text = ten_hm;
                txt_chuthich.Text = chuthich;
            }
            catch (Exception ex)
            { }
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
                    txt_tenhm.Enabled = txt_chuthich.Enabled = true;
                    txt_chuthich.Text = txt_mahm.Text = txt_tenhm.Text = string.Empty;
                    txt_mahm.Text = (hangmucthu.Get_MaHM() + 1).ToString();
                }
            }
            catch (Exception ex)
            { }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r;
                r = MessageBox.Show("Bạn muốn xóa?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.Yes)
                {
                    int kq = hangmucthu.Xoa_HMThu(int.Parse(txt_mahm.Text));
                    if (kq == 0)
                    {
                        MessageBox.Show("Hạng mục này đang được sử dụng không thể xóa");
                        return;
                    }
                    Load_Grid_HM();
                }
            }
            catch (Exception ex)
            { }
        }

        private void Load_Grid_HM()
        {
           gridControl1.DataSource = hangmucthu.Load_Grid_HM();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (btn_luu.Enabled == false) // dang sua
            {
                txt_tenhm.Enabled = txt_chuthich.Enabled = btn_luu.Enabled = true;
                btn_xoa.Enabled = btn_them.Enabled = false;


            }
            else
            {
                txt_tenhm.Enabled = txt_chuthich.Enabled = btn_luu.Enabled = false;
                btn_xoa.Enabled = btn_them.Enabled = true;

            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {

            try
            {
                int ma = int.Parse(txt_mahm.Text);
                string ten = txt_tenhm.Text;
                string ghichu = txt_chuthich.Text;
                if (btn_sua.Enabled == false)  //đang thêm
                {
                    if (txt_tenhm.Text == string.Empty)
                    {
                        MessageBox.Show("Vui lòng nhập tên hạng mục");
                        txt_tenhm.Focus();
                        return;
                    }
                    
                    int mahm = hangmucthu.Get_MaHM();
                    mahm++;
                    hangmucthu.Them_HMThu(mahm, txt_tenhm.Text.ToString(), txt_chuthich.Text.ToString());
                    Load_Grid_HM();
                    btn_luu.Enabled = false;
                    btn_sua.Enabled = btn_xoa.Enabled = true;
                    txt_tenhm.Enabled = txt_chuthich.Enabled = false;
                    MessageBox.Show("Thêm thành công");

                }
                if (btn_them.Enabled == false) //đang sửa
                {
                    hangmucthu.Sua_HMThu (ma, ten, ghichu);
                    txt_tenhm.Enabled = txt_chuthich.Enabled = btn_luu.Enabled = false;
                    btn_xoa.Enabled = btn_them.Enabled = true;
                    Load_Grid_HM();
                    MessageBox.Show("Sửa thành công");

                }



            }
            catch (Exception ex)
            {

            }
        }

        private void frm_DangKyHangMucThu_Load(object sender, EventArgs e)
        {
            Load_Grid_HM();
        }
    }
}