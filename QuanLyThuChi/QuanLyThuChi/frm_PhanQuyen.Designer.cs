namespace QuanLyThuChi
{
    partial class frm_PhanQuyen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.qLTC_DataSet = new QuanLyThuChi.QLTC_DataSet();
            this.qL_NHOM_NDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NHOM_NDTableAdapter = new QuanLyThuChi.QLTC_DataSetTableAdapters.QL_NHOM_NDTableAdapter();
            this.tableAdapterManager = new QuanLyThuChi.QLTC_DataSetTableAdapters.TableAdapterManager();
            this.dM_MANHINHTableAdapter = new QuanLyThuChi.QLTC_DataSetTableAdapters.DM_MANHINHTableAdapter();
            this.qL_PHANQUYENTableAdapter = new QuanLyThuChi.QLTC_DataSetTableAdapters.QL_PHANQUYENTableAdapter();
            this.dM_MANHINHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.qL_NHOM_NDDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qL_GetPhanQuyenDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.qL_GetPhanQuyenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btb_Luu = new DevExpress.XtraEditors.SimpleButton();
            this.qL_PHANQUYENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.qL_GetPhanQuyenTableAdapter = new QuanLyThuChi.QLTC_DataSetTableAdapters.QL_GetPhanQuyenTableAdapter();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.maToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.maToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.qLTC_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHOM_NDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dM_MANHINHBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHOM_NDDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_GetPhanQuyenDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_GetPhanQuyenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_PHANQUYENBindingSource)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // qLTC_DataSet
            // 
            this.qLTC_DataSet.DataSetName = "QLTC_DataSet";
            this.qLTC_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qL_NHOM_NDBindingSource
            // 
            this.qL_NHOM_NDBindingSource.DataMember = "QL_NHOM_ND";
            this.qL_NHOM_NDBindingSource.DataSource = this.qLTC_DataSet;
            // 
            // qL_NHOM_NDTableAdapter
            // 
            this.qL_NHOM_NDTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_HANG_MUC_CHITableAdapter = null;
            this.tableAdapterManager.DM_MANHINHTableAdapter = this.dM_MANHINHTableAdapter;
            this.tableAdapterManager.HANG_MUC_CHITableAdapter = null;
            this.tableAdapterManager.HANG_MUC_THUTableAdapter = null;
            this.tableAdapterManager.PHIEU_CHITableAdapter = null;
            this.tableAdapterManager.PHIEU_THUTableAdapter = null;
            this.tableAdapterManager.QL_NGUOI_DUNGTableAdapter = null;
            this.tableAdapterManager.QL_NGUOIDUNG_NHOMNGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.QL_NHOM_NDTableAdapter = this.qL_NHOM_NDTableAdapter;
            this.tableAdapterManager.QL_PHANQUYENTableAdapter = this.qL_PHANQUYENTableAdapter;
            this.tableAdapterManager.TAI_KHOANTableAdapter = null;
            this.tableAdapterManager.TIEN_TETableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyThuChi.QLTC_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dM_MANHINHTableAdapter
            // 
            this.dM_MANHINHTableAdapter.ClearBeforeFill = true;
            // 
            // qL_PHANQUYENTableAdapter
            // 
            this.qL_PHANQUYENTableAdapter.ClearBeforeFill = true;
            // 
            // dM_MANHINHBindingSource
            // 
            this.dM_MANHINHBindingSource.DataMember = "DM_MANHINH";
            this.dM_MANHINHBindingSource.DataSource = this.qLTC_DataSet;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.qL_NHOM_NDDataGridView);
            this.groupBox1.Controls.Add(this.qL_GetPhanQuyenDataGridView);
            this.groupBox1.Controls.Add(this.btb_Luu);
            this.groupBox1.Location = new System.Drawing.Point(340, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 429);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // qL_NHOM_NDDataGridView
            // 
            this.qL_NHOM_NDDataGridView.AutoGenerateColumns = false;
            this.qL_NHOM_NDDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.qL_NHOM_NDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qL_NHOM_NDDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.qL_NHOM_NDDataGridView.DataSource = this.qL_NHOM_NDBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.qL_NHOM_NDDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.qL_NHOM_NDDataGridView.Location = new System.Drawing.Point(17, 65);
            this.qL_NHOM_NDDataGridView.Name = "qL_NHOM_NDDataGridView";
            this.qL_NHOM_NDDataGridView.Size = new System.Drawing.Size(345, 220);
            this.qL_NHOM_NDDataGridView.TabIndex = 4;
            this.qL_NHOM_NDDataGridView.SelectionChanged += new System.EventHandler(this.qL_NHOM_NDDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MA_NHOM";
            this.dataGridViewTextBoxColumn3.HeaderText = "MA_NHOM";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TEN_NHOM";
            this.dataGridViewTextBoxColumn4.HeaderText = "TEN_NHOM";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CHITIET";
            this.dataGridViewTextBoxColumn5.HeaderText = "CHITIET";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // qL_GetPhanQuyenDataGridView
            // 
            this.qL_GetPhanQuyenDataGridView.AutoGenerateColumns = false;
            this.qL_GetPhanQuyenDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.qL_GetPhanQuyenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qL_GetPhanQuyenDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1});
            this.qL_GetPhanQuyenDataGridView.DataSource = this.qL_GetPhanQuyenBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.qL_GetPhanQuyenDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.qL_GetPhanQuyenDataGridView.Location = new System.Drawing.Point(378, 65);
            this.qL_GetPhanQuyenDataGridView.Name = "qL_GetPhanQuyenDataGridView";
            this.qL_GetPhanQuyenDataGridView.Size = new System.Drawing.Size(343, 348);
            this.qL_GetPhanQuyenDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MA_MANHINH";
            this.dataGridViewTextBoxColumn1.HeaderText = "MA_MANHINH";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TEN_MANHINH";
            this.dataGridViewTextBoxColumn2.HeaderText = "TEN_MANHINH";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "COQUYEN";
            this.dataGridViewCheckBoxColumn1.HeaderText = "COQUYEN";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // qL_GetPhanQuyenBindingSource
            // 
            this.qL_GetPhanQuyenBindingSource.DataMember = "QL_GetPhanQuyen";
            this.qL_GetPhanQuyenBindingSource.DataSource = this.qLTC_DataSet;
            // 
            // btb_Luu
            // 
            this.btb_Luu.ImageOptions.Image = global::QuanLyThuChi.Properties.Resources.save1;
            this.btb_Luu.Location = new System.Drawing.Point(17, 20);
            this.btb_Luu.Name = "btb_Luu";
            this.btb_Luu.Size = new System.Drawing.Size(75, 39);
            this.btb_Luu.TabIndex = 4;
            this.btb_Luu.Text = "Lưu";
            this.btb_Luu.Click += new System.EventHandler(this.btb_Luu_Click);
            // 
            // qL_PHANQUYENBindingSource
            // 
            this.qL_PHANQUYENBindingSource.DataMember = "QL_PHANQUYEN";
            this.qL_PHANQUYENBindingSource.DataSource = this.qLTC_DataSet;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.labelControl1.Location = new System.Drawing.Point(380, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(534, 35);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "BẢNG PHÂN QUYỀN CHO NGƯỜI DÙNG";
            // 
            // qL_GetPhanQuyenTableAdapter
            // 
            this.qL_GetPhanQuyenTableAdapter.ClearBeforeFill = true;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maToolStripLabel,
            this.maToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(1123, 25);
            this.fillToolStrip.TabIndex = 2;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // maToolStripLabel
            // 
            this.maToolStripLabel.Name = "maToolStripLabel";
            this.maToolStripLabel.Size = new System.Drawing.Size(27, 22);
            this.maToolStripLabel.Text = "ma:";
            // 
            // maToolStripTextBox
            // 
            this.maToolStripTextBox.Name = "maToolStripTextBox";
            this.maToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(26, 22);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // frm_PhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 528);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_PhanQuyen";
            this.Text = "frm_PhanQuyen";
            this.Load += new System.EventHandler(this.frm_PhanQuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLTC_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHOM_NDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dM_MANHINHBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHOM_NDDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_GetPhanQuyenDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_GetPhanQuyenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_PHANQUYENBindingSource)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLTC_DataSet qLTC_DataSet;
        private System.Windows.Forms.BindingSource qL_NHOM_NDBindingSource;
        private QLTC_DataSetTableAdapters.QL_NHOM_NDTableAdapter qL_NHOM_NDTableAdapter;
        private QLTC_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private QLTC_DataSetTableAdapters.DM_MANHINHTableAdapter dM_MANHINHTableAdapter;
        private System.Windows.Forms.BindingSource dM_MANHINHBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btb_Luu;
        private QLTC_DataSetTableAdapters.QL_PHANQUYENTableAdapter qL_PHANQUYENTableAdapter;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource qL_PHANQUYENBindingSource;
        private System.Windows.Forms.BindingSource qL_GetPhanQuyenBindingSource;
        private QLTC_DataSetTableAdapters.QL_GetPhanQuyenTableAdapter qL_GetPhanQuyenTableAdapter;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel maToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox maToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.DataGridView qL_NHOM_NDDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridView qL_GetPhanQuyenDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}