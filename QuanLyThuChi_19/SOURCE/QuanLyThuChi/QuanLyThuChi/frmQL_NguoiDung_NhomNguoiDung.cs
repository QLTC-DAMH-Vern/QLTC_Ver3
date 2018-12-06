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
    public partial class frmQL_NguoiDung_NhomNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        public frmQL_NguoiDung_NhomNguoiDung()
        {
            InitializeComponent();
        }

        private void qL_NHOM_NDBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.qL_NHOM_NDBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLTC_DataSet);

        }

        private void frmQL_NguoiDung_NhomNguoiDung_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTC_DataSet.QL_NGUOIDUNG_NHOMNGUOIDUNG' table. You can move, or remove it, as needed.
            this.qL_NGUOIDUNG_NHOMNGUOIDUNGTableAdapter.Fill(this.qLTC_DataSet.QL_NGUOIDUNG_NHOMNGUOIDUNG);
            // TODO: This line of code loads data into the 'qLTC_DataSet.DataTable1' table. You can move, or remove it, as needed.
            //this.dataTable1TableAdapter.Fill(this.qLTC_DataSet.DataTable1,qL_NHOM_NDComboBox.SelectedValue.ToString());
            // TODO: This line of code loads data into the 'qLTC_DataSet.QL_NGUOI_DUNG' table. You can move, or remove it, as needed.
            this.qL_NGUOI_DUNGTableAdapter.Fill(this.qLTC_DataSet.QL_NGUOI_DUNG);
            // TODO: This line of code loads data into the 'qLTC_DataSet.QL_NHOM_ND' table. You can move, or remove it, as needed.
            this.qL_NHOM_NDTableAdapter.Fill(this.qLTC_DataSet.QL_NHOM_ND);

            

            //qL_NHOM_NDComboBox_SelectedIndexChanged(sender, e);

        }

        private void qL_NHOM_NDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //this.dataTable1TableAdapter.Fill(this.qLTC_DataSet.DataTable1, qL_NHOM_NDComboBox.SelectedValue.ToString());

                this.qL_NGUOIDUNG_NHOMNGUOIDUNGTableAdapter.ScalarQuery(qL_NHOM_NDComboBox.SelectedValue.ToString());
                
            }
            catch(System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        

        private void btn_xoa_Click_1(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn thật sự muốn xóa?", "Thông báo", MessageBoxButtons.YesNo);

            try
            {
                if (r == DialogResult.Yes)
                {
                    //string _tenDN = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MANGUOIDUNG").ToString();
                    //string _maNhom = qL_NHOM_NDComboBox.SelectedValue.ToString();
                    string tenDN = gridView3.GetRowCellValue(gridView3.FocusedRowHandle, "MANGUOIDUNG").ToString();
                    string manhom = gridView3.GetRowCellValue(gridView3.FocusedRowHandle, "MA_NHOM").ToString();

                    qL_NGUOIDUNG_NHOMNGUOIDUNGTableAdapter.Delete(manhom, tenDN, null);
                    //qL_NGUOIDUNG_NHOMNGUOIDUNGTableAdapter.Delete(_maNhom, _tenDN, null);
                    qL_NHOM_NDComboBox_SelectedIndexChanged(sender, e);
                    this.qL_NGUOIDUNG_NHOMNGUOIDUNGTableAdapter.Fill(this.qLTC_DataSet.QL_NGUOIDUNG_NHOMNGUOIDUNG);
                    MessageBox.Show("Xóa thành công ròi nha!");
                }
            }
            catch
            {
                MessageBox.Show("Tài khoản không tồn tại trong nhóm");
            }
        }

        private void btn_them_Click_1(object sender, EventArgs e)
        {
            try
            {
                string _tenDN = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MANGUOIDUNG").ToString();
                string _maNhom = qL_NHOM_NDComboBox.SelectedValue.ToString();
                qL_NGUOIDUNG_NHOMNGUOIDUNGTableAdapter.Insert(_maNhom, _tenDN, null);
                qL_NHOM_NDComboBox_SelectedIndexChanged(sender, e);
                this.qL_NGUOIDUNG_NHOMNGUOIDUNGTableAdapter.Fill(this.qLTC_DataSet.QL_NGUOIDUNG_NHOMNGUOIDUNG);
                MessageBox.Show("Thêm thành công ròi nha!");
            }
            catch
            {
                MessageBox.Show("Tài khoản đã thêm vào nhóm");
            }
        }

       

        

        
        
    }
}