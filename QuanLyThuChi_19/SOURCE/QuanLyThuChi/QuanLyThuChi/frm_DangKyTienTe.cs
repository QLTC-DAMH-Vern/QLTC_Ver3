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

        private void btn_them_Click(object sender, EventArgs e)
        {
            try{
            if (btn_luu.Enabled == true) //đang thêm và nhấp để hủy
                {
                    btn_xoa.Enabled = btn_sua.Enabled = true;
                    btn_luu.Enabled = false;
                }
                else
                {

                    btn_luu.Enabled = true;
                    btn_xoa.Enabled = btn_sua.Enabled = false;
                    txt_ten.Enabled = txt_tigia.Enabled=txt_matt.Enabled = true;
                    txt_tigia.Text = txt_matt.Text = txt_ten.Text = string.Empty;
                   
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
                    int kq = qltt.Xoa_tiente(txt_matt.Text);
                    if (kq == 2)
                    {
                        MessageBox.Show("Hạng mục này đang được sử dụng không thể xóa");
                        return;
                    }
                    if (kq == 1)
                        MessageBox.Show("Xóa thành công");
                    LOAD_DATA();
                }
            }
            catch (Exception ex)
            { }
        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            try
            {
                txt_matt.Text = gridView1.GetFocusedRowCellValue("MALOAI").ToString();
                txt_ten.Text = gridView1.GetFocusedRowCellValue("TENLOAI").ToString();
                txt_tigia.Text = gridView1.GetFocusedRowCellValue("TI_GIA").ToString();
            }
            catch (Exception ex)
            { }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {

            if (btn_luu.Enabled == false) // dang sua
            {
                txt_ten.Enabled = txt_tigia.Enabled=txt_matt.Enabled = btn_luu.Enabled = true;
                btn_xoa.Enabled = btn_them.Enabled = false;


            }
            else
            {
                txt_ten.Enabled = txt_tigia.Enabled = txt_matt.Enabled = btn_luu.Enabled = false;
                btn_xoa.Enabled = btn_them.Enabled = true;

            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = txt_matt.Text;
                string ten = txt_ten.Text;
                string tigia = txt_tigia.Text;
                 if (txt_tigia.Text == string.Empty || txt_matt.Text == string.Empty || txt_tigia.Text == string.Empty)
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
       
                        return;
                    }
                    if(txt_matt.Text.Length>5 || txt_ten.Text.Length>5)
                    {
                        MessageBox.Show("Vui lòng nhập tên hoặc mã dưới 6 ký tự");
                        return;
                    }
                if (btn_sua.Enabled == false)  //đang thêm
                {
                   

                    TIEN_TE tt = new TIEN_TE();
                    tt.MALOAI = ma;
                    tt.TENLOAI = ten;
                    tt.TI_GIA =  decimal.Parse(tigia);
                    int kq = qltt.Them_tiente(tt);
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
                    txt_ten.Enabled = txt_tigia.Enabled=txt_matt.Enabled = false;
                    
                    

                }
                if (btn_them.Enabled == false) //đang sửa
                {
                    int kq = qltt.Sua_tiente(gridView1.GetFocusedRowCellValue("MALOAI").ToString(),txt_matt.Text,txt_ten.Text,decimal.Parse(txt_tigia.Text));
                    txt_ten.Enabled = txt_tigia.Enabled = btn_luu.Enabled =txt_matt.Enabled= false;
                    btn_xoa.Enabled = btn_them.Enabled = true;
                    if(kq == 1)
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