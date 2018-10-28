namespace QuanLyThuChi
{
    partial class frmQL_NguoiDung_NhomNguoiDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQL_NguoiDung_NhomNguoiDung));
            this.qLTC_DataSet = new QuanLyThuChi.QLTC_DataSet();
            this.qL_NHOM_NDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NHOM_NDTableAdapter = new QuanLyThuChi.QLTC_DataSetTableAdapters.QL_NHOM_NDTableAdapter();
            this.tableAdapterManager = new QuanLyThuChi.QLTC_DataSetTableAdapters.TableAdapterManager();
            this.qL_NHOM_NDBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.qL_NHOM_NDBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.qL_NGUOI_DUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NGUOI_DUNGTableAdapter = new QuanLyThuChi.QLTC_DataSetTableAdapters.QL_NGUOI_DUNGTableAdapter();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter = new QuanLyThuChi.QLTC_DataSetTableAdapters.DataTable1TableAdapter();
            this.qL_NGUOIDUNG_NHOMNGUOIDUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NGUOIDUNG_NHOMNGUOIDUNGTableAdapter = new QuanLyThuChi.QLTC_DataSetTableAdapters.QL_NGUOIDUNG_NHOMNGUOIDUNGTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.qL_NGUOIDUNG_NHOMNGUOIDUNGGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btn_xoa = new DevExpress.XtraEditors.SimpleButton();
            this.btn_them = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.qL_NGUOI_DUNGGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.qL_NHOM_NDComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.qLTC_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHOM_NDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHOM_NDBindingNavigator)).BeginInit();
            this.qL_NHOM_NDBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NGUOI_DUNGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NGUOIDUNG_NHOMNGUOIDUNGBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NGUOIDUNG_NHOMNGUOIDUNGGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NGUOI_DUNGGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
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
            this.tableAdapterManager.DM_MANHINHTableAdapter = null;
            this.tableAdapterManager.HANG_MUC_CHITableAdapter = null;
            this.tableAdapterManager.HANG_MUC_THUTableAdapter = null;
            this.tableAdapterManager.PHIEU_CHITableAdapter = null;
            this.tableAdapterManager.PHIEU_THUTableAdapter = null;
            this.tableAdapterManager.QL_NGUOI_DUNGTableAdapter = null;
            this.tableAdapterManager.QL_NGUOIDUNG_NHOMNGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.QL_NHOM_NDTableAdapter = this.qL_NHOM_NDTableAdapter;
            this.tableAdapterManager.QL_PHANQUYENTableAdapter = null;
            this.tableAdapterManager.TAI_KHOANTableAdapter = null;
            this.tableAdapterManager.TIEN_TETableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyThuChi.QLTC_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // qL_NHOM_NDBindingNavigator
            // 
            this.qL_NHOM_NDBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.qL_NHOM_NDBindingNavigator.BindingSource = this.qL_NHOM_NDBindingSource;
            this.qL_NHOM_NDBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.qL_NHOM_NDBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.qL_NHOM_NDBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.qL_NHOM_NDBindingNavigatorSaveItem});
            this.qL_NHOM_NDBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.qL_NHOM_NDBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.qL_NHOM_NDBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.qL_NHOM_NDBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.qL_NHOM_NDBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.qL_NHOM_NDBindingNavigator.Name = "qL_NHOM_NDBindingNavigator";
            this.qL_NHOM_NDBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.qL_NHOM_NDBindingNavigator.Size = new System.Drawing.Size(1221, 25);
            this.qL_NHOM_NDBindingNavigator.TabIndex = 0;
            this.qL_NHOM_NDBindingNavigator.Text = "bindingNavigator1";
            this.qL_NHOM_NDBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // qL_NHOM_NDBindingNavigatorSaveItem
            // 
            this.qL_NHOM_NDBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.qL_NHOM_NDBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("qL_NHOM_NDBindingNavigatorSaveItem.Image")));
            this.qL_NHOM_NDBindingNavigatorSaveItem.Name = "qL_NHOM_NDBindingNavigatorSaveItem";
            this.qL_NHOM_NDBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.qL_NHOM_NDBindingNavigatorSaveItem.Text = "Save Data";
            this.qL_NHOM_NDBindingNavigatorSaveItem.Click += new System.EventHandler(this.qL_NHOM_NDBindingNavigatorSaveItem_Click);
            // 
            // qL_NGUOI_DUNGBindingSource
            // 
            this.qL_NGUOI_DUNGBindingSource.DataMember = "QL_NGUOI_DUNG";
            this.qL_NGUOI_DUNGBindingSource.DataSource = this.qLTC_DataSet;
            // 
            // qL_NGUOI_DUNGTableAdapter
            // 
            this.qL_NGUOI_DUNGTableAdapter.ClearBeforeFill = true;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.qLTC_DataSet;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // qL_NGUOIDUNG_NHOMNGUOIDUNGBindingSource
            // 
            this.qL_NGUOIDUNG_NHOMNGUOIDUNGBindingSource.DataMember = "QL_NGUOIDUNG_NHOMNGUOIDUNG";
            this.qL_NGUOIDUNG_NHOMNGUOIDUNGBindingSource.DataSource = this.qLTC_DataSet;
            // 
            // qL_NGUOIDUNG_NHOMNGUOIDUNGTableAdapter
            // 
            this.qL_NGUOIDUNG_NHOMNGUOIDUNGTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.qL_NGUOIDUNG_NHOMNGUOIDUNGGridControl);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.qL_NGUOI_DUNGGridControl);
            this.groupBox1.Controls.Add(this.qL_NHOM_NDComboBox);
            this.groupBox1.Location = new System.Drawing.Point(132, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1077, 426);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // qL_NGUOIDUNG_NHOMNGUOIDUNGGridControl
            // 
            this.qL_NGUOIDUNG_NHOMNGUOIDUNGGridControl.DataSource = this.qL_NGUOIDUNG_NHOMNGUOIDUNGBindingSource;
            this.qL_NGUOIDUNG_NHOMNGUOIDUNGGridControl.Location = new System.Drawing.Point(531, 50);
            this.qL_NGUOIDUNG_NHOMNGUOIDUNGGridControl.MainView = this.gridView3;
            this.qL_NGUOIDUNG_NHOMNGUOIDUNGGridControl.Name = "qL_NGUOIDUNG_NHOMNGUOIDUNGGridControl";
            this.qL_NGUOIDUNG_NHOMNGUOIDUNGGridControl.Size = new System.Drawing.Size(535, 363);
            this.qL_NGUOIDUNG_NHOMNGUOIDUNGGridControl.TabIndex = 13;
            this.qL_NGUOIDUNG_NHOMNGUOIDUNGGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.qL_NGUOIDUNG_NHOMNGUOIDUNGGridControl;
            this.gridView3.Name = "gridView3";
            // 
            // btn_xoa
            // 
            this.btn_xoa.ImageOptions.Image = global::QuanLyThuChi.Properties.Resources.delete;
            this.btn_xoa.Location = new System.Drawing.Point(433, 279);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 46);
            this.btn_xoa.TabIndex = 11;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click_1);
            // 
            // btn_them
            // 
            this.btn_them.ImageOptions.Image = global::QuanLyThuChi.Properties.Resources.them;
            this.btn_them.Location = new System.Drawing.Point(433, 131);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 46);
            this.btn_them.TabIndex = 12;
            this.btn_them.Text = "Thêm";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click_1);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(557, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(111, 14);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Nhóm người dùng";
            // 
            // qL_NGUOI_DUNGGridControl
            // 
            this.qL_NGUOI_DUNGGridControl.DataSource = this.qL_NGUOI_DUNGBindingSource;
            this.qL_NGUOI_DUNGGridControl.Location = new System.Drawing.Point(10, 50);
            this.qL_NGUOI_DUNGGridControl.MainView = this.gridView2;
            this.qL_NGUOI_DUNGGridControl.Name = "qL_NGUOI_DUNGGridControl";
            this.qL_NGUOI_DUNGGridControl.Size = new System.Drawing.Size(402, 363);
            this.qL_NGUOI_DUNGGridControl.TabIndex = 9;
            this.qL_NGUOI_DUNGGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.qL_NGUOI_DUNGGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.MultiSelect = true;
            // 
            // qL_NHOM_NDComboBox
            // 
            this.qL_NHOM_NDComboBox.DataSource = this.qL_NHOM_NDBindingSource;
            this.qL_NHOM_NDComboBox.DisplayMember = "TEN_NHOM";
            this.qL_NHOM_NDComboBox.FormattingEnabled = true;
            this.qL_NHOM_NDComboBox.Location = new System.Drawing.Point(694, 14);
            this.qL_NHOM_NDComboBox.Name = "qL_NHOM_NDComboBox";
            this.qL_NHOM_NDComboBox.Size = new System.Drawing.Size(300, 21);
            this.qL_NHOM_NDComboBox.TabIndex = 8;
            this.qL_NHOM_NDComboBox.ValueMember = "MA_NHOM";
            
            // 
            // frmQL_NguoiDung_NhomNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 509);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.qL_NHOM_NDBindingNavigator);
            this.Name = "frmQL_NguoiDung_NhomNguoiDung";
            this.Text = "frmQL_NguoiDung_NhomNguoiDung";
            this.Load += new System.EventHandler(this.frmQL_NguoiDung_NhomNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLTC_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHOM_NDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHOM_NDBindingNavigator)).EndInit();
            this.qL_NHOM_NDBindingNavigator.ResumeLayout(false);
            this.qL_NHOM_NDBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NGUOI_DUNGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NGUOIDUNG_NHOMNGUOIDUNGBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NGUOIDUNG_NHOMNGUOIDUNGGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NGUOI_DUNGGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLTC_DataSet qLTC_DataSet;
        private System.Windows.Forms.BindingSource qL_NHOM_NDBindingSource;
        private QLTC_DataSetTableAdapters.QL_NHOM_NDTableAdapter qL_NHOM_NDTableAdapter;
        private QLTC_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator qL_NHOM_NDBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton qL_NHOM_NDBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource qL_NGUOI_DUNGBindingSource;
        private QLTC_DataSetTableAdapters.QL_NGUOI_DUNGTableAdapter qL_NGUOI_DUNGTableAdapter;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private QLTC_DataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.BindingSource qL_NGUOIDUNG_NHOMNGUOIDUNGBindingSource;
        private QLTC_DataSetTableAdapters.QL_NGUOIDUNG_NHOMNGUOIDUNGTableAdapter qL_NGUOIDUNG_NHOMNGUOIDUNGTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl qL_NGUOIDUNG_NHOMNGUOIDUNGGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.SimpleButton btn_xoa;
        private DevExpress.XtraEditors.SimpleButton btn_them;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl qL_NGUOI_DUNGGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.ComboBox qL_NHOM_NDComboBox;
    }
}