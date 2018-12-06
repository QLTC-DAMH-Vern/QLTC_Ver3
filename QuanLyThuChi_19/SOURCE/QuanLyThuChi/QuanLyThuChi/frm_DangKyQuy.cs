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
    public partial class frm_DangKyQuy : DevExpress.XtraEditors.XtraForm
    {
        QLLoai_TK qlltk = new QLLoai_TK();
        public frm_DangKyQuy()
        {
            InitializeComponent();
        }

        private void frm_DangKyQuy_Load(object sender, EventArgs e)
        {
            LOAD_DATA();
        }
        public void LOAD_DATA()
        {
            gridControl1.DataSource = qlltk.load_grid();
        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            try
            {
                txt_maloaitk.Text = gridView1.GetFocusedRowCellValue("MA_LOAI_TK").ToString();
                txt_tenloaitk.Text = gridView1.GetFocusedRowCellValue("TEN_TK").ToString();
            }
            catch (Exception ex) { }
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
                    txt_tenloaitk.Enabled  = true;
                    txt_tenloaitk.Text = txt_maloaitk.Text = string.Empty;

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
                    int kq = qlltk.Xoa_LoaiTK(int.Parse(gridView1.GetFocusedRowCellValue("MA_LOAI_TK").ToString()));
                    if (kq == 1)
                    {
                        MessageBox.Show("Hạng mục này đang được sử dụng không thể xóa");
                        return;
                    }
                    if (kq == 0)
                        MessageBox.Show("Xóa thành công");
                    LOAD_DATA();
                }
            }
            catch (Exception ex) { }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {

            if (btn_luu.Enabled == false) // dang sua
            {
                txt_tenloaitk.Enabled = txt_maloaitk.Enabled = btn_luu.Enabled = true;
                btn_xoa.Enabled = btn_them.Enabled = false;


            }
            else
            {
                txt_tenloaitk.Enabled = txt_maloaitk.Enabled = btn_luu.Enabled = false;
                btn_xoa.Enabled = btn_them.Enabled = true;

            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = txt_maloaitk.Text;
                string ten = txt_tenloaitk.Text;

                if (txt_tenloaitk.Text == string.Empty )
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");

                    return;
                }
    
                if (btn_sua.Enabled == false)  //đang thêm
                {


                    LOAI_TK tk = new LOAI_TK();
                    tk.TEN_TK = txt_tenloaitk.Text;
                    int kq = qlltk.Them_LoaiTK(tk);
                    if (kq == 1)
                    {
                        MessageBox.Show("Trùng mã khóa chính");
                        return;
                    }
                    else if (kq == 0)
                        MessageBox.Show("Thêm thành công");
                    else
                        MessageBox.Show("Thêm thất bại");

                    btn_luu.Enabled = false;
                    btn_sua.Enabled = btn_xoa.Enabled = true;
                    txt_tenloaitk.Enabled= false;



                }
                if (btn_them.Enabled == false) //đang sửa
                {
                    int kq = qlltk.Sua_LoaiTK(int.Parse(txt_maloaitk.Text), txt_tenloaitk.Text);
                    txt_tenloaitk.Enabled = txt_maloaitk.Enabled = btn_luu.Enabled  = false;
                    btn_xoa.Enabled = btn_them.Enabled = true;
                    if (kq == 1)
                        MessageBox.Show("Sửa thành công");
                    else
                        MessageBox.Show("Sửa thất bại");

                }
                LOAD_DATA();


            }
            catch (Exception ex)
            {

            }
        }
    }
}