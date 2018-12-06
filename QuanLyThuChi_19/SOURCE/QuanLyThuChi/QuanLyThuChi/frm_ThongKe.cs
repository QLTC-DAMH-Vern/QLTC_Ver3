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
using DevExpress.XtraCharts;
using BLL;
namespace QuanLyThuChi
{
    public partial class frm_ThongKe : DevExpress.XtraEditors.XtraForm
    {
        KhoanChiBLL bll = new KhoanChiBLL();
        QLTC_DataSet data = new QLTC_DataSet();
        
        public frm_ThongKe()
        {
            InitializeComponent();
        }

        private void frm_ThongKe_Load(object sender, EventArgs e)
        {
            Series series = new Series("Thống kê chi", ViewType.Pie);
            //DataTable dt = new DataTable();
            //dt = pHIEU_CHITableAdapter1.GetData();


            dataTable2DataGridView.DataSource = dataTable2TableAdapter.GetData(LogIn.GetUserName.userNAME);

            foreach (DataGridViewRow row in dataTable2DataGridView.Rows)
            {
                try
                {
                    series.Points.Add(new SeriesPoint(row.Cells[0].Value.ToString(), double.Parse(row.Cells[2].Value.ToString())));
                }
                catch (Exception ex)
                { }
            }


            chartControl1.Series.Add(series);

            series.Label.TextPattern = "{A}: {VP:p0}";

            ((PieSeriesLabel)series.Label).Position = PieSeriesLabelPosition.TwoColumns;

            ((PieSeriesLabel)series.Label).ResolveOverlappingMode = ResolveOverlappingMode.Default;

            PieSeriesView view = (PieSeriesView)series.View;

            //chartControl1.Dock = DockStyle.Fill;
            this.Controls.Add(chartControl1);
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataTable2TableAdapter.Fill(this.qLTC_DataSet.DataTable2, maToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.dataTable2TableAdapter.Fill(this.qLTC_DataSet.DataTable2, maToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataTable2DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}