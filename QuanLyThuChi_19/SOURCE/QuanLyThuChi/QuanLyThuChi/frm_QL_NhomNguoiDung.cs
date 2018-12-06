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
    public partial class frm_QL_NhomNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        public frm_QL_NhomNguoiDung()
        {
            InitializeComponent();
        }

        private void qL_NHOM_NDBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.qL_NHOM_NDBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLTC_DataSet);

        }

        private void frm_QL_NhomNguoiDung_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTC_DataSet.QL_NHOM_ND' table. You can move, or remove it, as needed.
            this.qL_NHOM_NDTableAdapter.Fill(this.qLTC_DataSet.QL_NHOM_ND);
            btn_Luu.Enabled = false;

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            btn_Luu.Enabled = true;
            btn_them.Enabled = false;
            txt_MaNhom.Text = string.Empty;
            txt_TenNhom.Text = string.Empty;
            txt_chitiet.Text = string.Empty;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (qL_NHOM_NDTableAdapter.KT_KhoaChinh(txt_MaNhom.Text) == 0)
                {
                    qL_NHOM_NDTableAdapter.Insert(txt_MaNhom.Text, txt_TenNhom.Text, txt_chitiet.Text);
                    this.qL_NHOM_NDTableAdapter.Fill(this.qLTC_DataSet.QL_NHOM_ND);
                    btn_them.Enabled = true;
                    btn_Luu.Enabled = false;

                }
                else
                {
                    MessageBox.Show("Mã nhóm người dùng này đã tồn tại!!");
                }
            }
            catch
            {
                MessageBox.Show("Không thể thêm");
            }


        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Bạn có muốn xóa!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.Yes)
                {
                    qL_NHOM_NDTableAdapter.Delete(txt_MaNhom.Text, txt_TenNhom.Text, txt_chitiet.Text);
                    this.qL_NHOM_NDTableAdapter.Fill(this.qLTC_DataSet.QL_NHOM_ND);
                }
            }
            catch
            {
                MessageBox.Show("Không thể xóa nhóm người dùng!");
            }


        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            qL_NHOM_NDTableAdapter.UpdateQuery(txt_TenNhom.Text, txt_chitiet.Text,txt_MaNhom.Text);
            this.qL_NHOM_NDTableAdapter.Fill(this.qLTC_DataSet.QL_NHOM_ND);


        }

        
    }
}