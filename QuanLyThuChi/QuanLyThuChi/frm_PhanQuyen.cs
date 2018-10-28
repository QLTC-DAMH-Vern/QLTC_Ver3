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
    public partial class frm_PhanQuyen : DevExpress.XtraEditors.XtraForm
    {
        public frm_PhanQuyen()
        {
            InitializeComponent();
        }

        private void qL_NHOM_NDBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.qL_NHOM_NDBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLTC_DataSet);

        }

        private void frm_PhanQuyen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTC_DataSet.QL_PHANQUYEN' table. You can move, or remove it, as needed.
            this.qL_PHANQUYENTableAdapter.Fill(this.qLTC_DataSet.QL_PHANQUYEN);
            // TODO: This line of code loads data into the 'qLTC_DataSet.DM_MANHINH' table. You can move, or remove it, as needed.
            this.dM_MANHINHTableAdapter.Fill(this.qLTC_DataSet.DM_MANHINH);
            // TODO: This line of code loads data into the 'qLTC_DataSet.QL_NHOM_ND' table. You can move, or remove it, as needed.
            this.qL_NHOM_NDTableAdapter.Fill(this.qLTC_DataSet.QL_NHOM_ND);

        }

        public void LoadDataCondition()
        {
            this.qL_GetPhanQuyenTableAdapter.Fill(this.qLTC_DataSet.QL_GetPhanQuyen, qL_NHOM_NDDataGridView.CurrentRow.Cells[0].Value.ToString());
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.qL_GetPhanQuyenTableAdapter.Fill(this.qLTC_DataSet.QL_GetPhanQuyen, maToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        
        private void qL_NHOM_NDDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            LoadDataCondition();
        }

        private void btb_Luu_Click(object sender, EventArgs e)
        {
            string _NhomNguoiDung = qL_NHOM_NDDataGridView.CurrentRow.Cells[0].Value.ToString();
            
            foreach (DataGridViewRow item in qL_GetPhanQuyenDataGridView.Rows)
            {
                if ((item.Cells[0].Value) == null)
                    return;
                if (qL_GetPhanQuyenTableAdapter.KiemTraKhoaChinhPhanQuyen(_NhomNguoiDung, (int)(item.Cells[0].Value)) == null)
                {
                    try
                    {
                        qL_PHANQUYENTableAdapter.Insert(_NhomNguoiDung, (int)(item.Cells[0].Value), (bool)(item.Cells[2].Value));
                    }
                    catch
                    {
                        qL_PHANQUYENTableAdapter.Insert(_NhomNguoiDung, (int)(item.Cells[0].Value), false);
                    }
                }
                else
                {
                    qL_PHANQUYENTableAdapter.UpdateQuery((item.Cells[2]==null)?false:(bool)(item.Cells[2].Value),_NhomNguoiDung,(int)(item.Cells[0].Value));
                }
            }
        }

        

        

        


    }
}