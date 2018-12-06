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
using DevExpress.XtraGrid.Views.Grid;
namespace QuanLyThuChi
{
    public partial class frm_DangKyKhoanChi : DevExpress.XtraEditors.XtraForm
    {
        KhoanChiBLL hangmucchi = new KhoanChiBLL();
        public frm_DangKyKhoanChi()
        {
            InitializeComponent();
        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            try
            {
                string ma_hm = gridView1.GetFocusedRowCellValue("MA_CTHM_CHI").ToString();
                string ten_hm = gridView1.GetFocusedRowCellValue("TEN_CTHM_CHI").ToString();
                string chuthich = gridView1.GetFocusedRowCellValue("GHI_CHU").ToString();
                txt_mahm.Text = ma_hm;
                txt_tenhm.Text = ten_hm;
                txt_chuthich.Text = chuthich;
            }
            catch (Exception ex)
            { }

        }

        private void DangKyKhoanChi_Load(object sender, EventArgs e)
        {
            //gridView1.DataSource = hangmucchi.Load_HangMucChi();

            Load_DATA();
            btn_luu.Enabled = false;
          
        }
        public void Load_DATA()
        {
            gridControl2.DataSource = hangmucchi.Load_HangMucChiCha();
        }

        private void gridView2_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            try
            {
                int mahm = int.Parse(gridView2.GetFocusedRowCellValue("MA_HM_CHI").ToString());
                gridControl1.DataSource = hangmucchi.Load_CTHangMuc(mahm);
            }
            catch (Exception ex)
            { }
        }

        public void Load_Grid_CTHM()
        {
            int mahm = int.Parse(gridView2.GetFocusedRowCellValue("MA_HM_CHI").ToString());
            gridControl1.DataSource = hangmucchi.Load_CTHangMuc(mahm);
        }

        private void simpleButton5_Click(object sender, EventArgs e)
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
                txt_mahm.Text = (hangmucchi.Get_macthm() + 1).ToString();
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
                    int mahm = int.Parse(gridView2.GetFocusedRowCellValue("MA_HM_CHI").ToString());
                    int? macthm = hangmucchi.Get_macthm();
                    macthm++;
                    hangmucchi.Them_CTHM((int)macthm,txt_tenhm.Text.ToString(), txt_chuthich.Text.ToString(), mahm);
                    Load_DATA();
                    btn_luu.Enabled = false;
                    btn_sua.Enabled = btn_xoa.Enabled = true;
                    txt_tenhm.Enabled = txt_chuthich.Enabled = false;
                    MessageBox.Show("Thêm thành công");

                }
                if (simpleButton5.Enabled == false) //đang sửa
                {
                    hangmucchi.Sua_cthm(ten, ghichu, ma);
                    txt_tenhm.Enabled = txt_chuthich.Enabled = btn_luu.Enabled = false;
                    btn_xoa.Enabled = simpleButton5.Enabled = true;
                    Load_Grid_CTHM();
                    MessageBox.Show("Sửa thành công");
                    
                }

              

            }
            catch (Exception ex)
            {
 
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn muốn xóa?","Xóa",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                int kq =  hangmucchi.Xoa_cthm(int.Parse(txt_mahm.Text));
                if (kq == 0)
                {
                    MessageBox.Show("Hạng mục này đang được sử dụng không thể xóa");
                    return;
                }
                Load_Grid_CTHM();
            }
               
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (btn_luu.Enabled == false) // dang sua
            {
                txt_tenhm.Enabled = txt_chuthich.Enabled = btn_luu.Enabled = true;
                btn_xoa.Enabled = simpleButton5.Enabled = false;


            }
            else
            {
                txt_tenhm.Enabled = txt_chuthich.Enabled = btn_luu.Enabled = false;
                btn_xoa.Enabled = simpleButton5.Enabled = true ;

            }

        }

        private void btn_add_hm_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridView2.RowCount; i++)
            {
 
            }
        }

        private void gridView2_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            try
            {
                GridView view = sender as GridView;
                if (view.IsNewItemRow(e.RowHandle))
                {
                    int ma = hangmucchi.get_mahmchi();
                    string ten = view.GetRowCellValue(e.RowHandle, view.Columns[1]).ToString();
                    string ghichu = view.GetRowCellValue(e.RowHandle, view.Columns[2]).ToString();
                    hangmucchi.Them_HMChi(ma + 1, ten, ghichu);
                    Load_DATA();

                }
                else
                {
                    int ma = int.Parse(view.GetRowCellValue(e.RowHandle, view.Columns[0]).ToString());
                    string ten = view.GetRowCellValue(e.RowHandle, view.Columns[1]).ToString();
                    string ghichu = view.GetRowCellValue(e.RowHandle, view.Columns[2]).ToString();
                    hangmucchi.Sua_HMChi(ma, ten, ghichu);
                    Load_DATA();
                }
            }
            catch (Exception ex)
            { 
            }
        }

        private void btn_xoahm_Click(object sender, EventArgs e)
        {
            DialogResult r;

            r = MessageBox.Show("Bạn muốn xóa?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            try
            {
                

                if (r == DialogResult.Yes)
                {


                    int ma = int.Parse(gridView2.GetRowCellValue(gridView2.FocusedRowHandle, gridView2.Columns[0]).ToString());
                    int kq = hangmucchi.Xoa_HMChi(ma);
                    if (kq == 0)
                    {
                        MessageBox.Show("Hạng mục này đang được sử dụng");
                        return;
                    }              
                    Load_DATA();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại");
            }
        }




    }
}