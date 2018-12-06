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

namespace QuanLyThuChi
{
    public partial class frm_ThongKeThu : DevExpress.XtraEditors.XtraForm
    {
        public frm_ThongKeThu()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataTable3TableAdapter.Fill(this.qLTC_DataSet.DataTable3, maToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void frm_ThongKeThu_Load(object sender, EventArgs e)
        {
            Series series = new Series("Thống kê chi", ViewType.Pie);
            //DataTable dt = new DataTable();
            //dt = pHIEU_CHITableAdapter1.GetData();


            dataTable3DataGridView.DataSource = dataTable3TableAdapter.GetData(LogIn.GetUserName.userNAME);

            foreach (DataGridViewRow row in dataTable3DataGridView.Rows)
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
    }
}