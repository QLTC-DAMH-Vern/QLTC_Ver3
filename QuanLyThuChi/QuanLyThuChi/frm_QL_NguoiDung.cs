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
    public partial class frm_QL_NguoiDung : DevExpress.XtraEditors.XtraForm
    {
        
        private PictureBox pictureBox1;
        private QLTC_DataSet qLTC_DataSet;
        private BindingSource qL_NGUOI_DUNGBindingSource;
        private IContainer components;
        private QLTC_DataSetTableAdapters.QL_NGUOI_DUNGTableAdapter qL_NGUOI_DUNGTableAdapter;
        private QLTC_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BindingNavigator qL_NGUOI_DUNGBindingNavigator;
        private ToolStripButton bindingNavigatorAddNewItem;
        private ToolStripLabel bindingNavigatorCountItem;
        private ToolStripButton bindingNavigatorDeleteItem;
        private ToolStripButton bindingNavigatorMoveFirstItem;
        private ToolStripButton bindingNavigatorMovePreviousItem;
        private ToolStripSeparator bindingNavigatorSeparator;
        private ToolStripTextBox bindingNavigatorPositionItem;
        private ToolStripSeparator bindingNavigatorSeparator1;
        private ToolStripButton bindingNavigatorMoveNextItem;
        private ToolStripButton bindingNavigatorMoveLastItem;
        private ToolStripSeparator bindingNavigatorSeparator2;
        private ToolStripButton qL_NGUOI_DUNGBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl qL_NGUOI_DUNGGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private TextEdit txt_tenDN;
        private TextEdit txt_MK;
        private CheckEdit hd_check;
        private SimpleButton simpleButton5;
        private SimpleButton btn_sua;
        private SimpleButton btn_xoa;
        private SimpleButton btn_Luu;
        private SimpleButton btn_them;
        private GroupBox groupBox1;

        public frm_QL_NguoiDung()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label mANGUOIDUNGLabel;
            System.Windows.Forms.Label mATKHAULabel;
            System.Windows.Forms.Label hOATDONGLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QL_NguoiDung));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_sua = new DevExpress.XtraEditors.SimpleButton();
            this.btn_xoa = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Luu = new DevExpress.XtraEditors.SimpleButton();
            this.btn_them = new DevExpress.XtraEditors.SimpleButton();
            this.qL_NGUOI_DUNGGridControl = new DevExpress.XtraGrid.GridControl();
            this.qL_NGUOI_DUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLTC_DataSet = new QuanLyThuChi.QLTC_DataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txt_tenDN = new DevExpress.XtraEditors.TextEdit();
            this.txt_MK = new DevExpress.XtraEditors.TextEdit();
            this.hd_check = new DevExpress.XtraEditors.CheckEdit();
            this.qL_NGUOI_DUNGTableAdapter = new QuanLyThuChi.QLTC_DataSetTableAdapters.QL_NGUOI_DUNGTableAdapter();
            this.tableAdapterManager = new QuanLyThuChi.QLTC_DataSetTableAdapters.TableAdapterManager();
            this.qL_NGUOI_DUNGBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.qL_NGUOI_DUNGBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            mANGUOIDUNGLabel = new System.Windows.Forms.Label();
            mATKHAULabel = new System.Windows.Forms.Label();
            hOATDONGLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NGUOI_DUNGGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NGUOI_DUNGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTC_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tenDN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hd_check.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NGUOI_DUNGBindingNavigator)).BeginInit();
            this.qL_NGUOI_DUNGBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // mANGUOIDUNGLabel
            // 
            mANGUOIDUNGLabel.AutoSize = true;
            mANGUOIDUNGLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mANGUOIDUNGLabel.Location = new System.Drawing.Point(360, 44);
            mANGUOIDUNGLabel.Name = "mANGUOIDUNGLabel";
            mANGUOIDUNGLabel.Size = new System.Drawing.Size(103, 16);
            mANGUOIDUNGLabel.TabIndex = 16;
            mANGUOIDUNGLabel.Text = "Tên đăng nhập";
            // 
            // mATKHAULabel
            // 
            mATKHAULabel.AutoSize = true;
            mATKHAULabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mATKHAULabel.Location = new System.Drawing.Point(360, 70);
            mATKHAULabel.Name = "mATKHAULabel";
            mATKHAULabel.Size = new System.Drawing.Size(68, 16);
            mATKHAULabel.TabIndex = 18;
            mATKHAULabel.Text = "Mật khẩu";
            // 
            // hOATDONGLabel
            // 
            hOATDONGLabel.AutoSize = true;
            hOATDONGLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOATDONGLabel.Location = new System.Drawing.Point(360, 96);
            hOATDONGLabel.Name = "hOATDONGLabel";
            hOATDONGLabel.Size = new System.Drawing.Size(75, 16);
            hOATDONGLabel.TabIndex = 20;
            hOATDONGLabel.Text = "Hoạt động";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyThuChi.Properties.Resources.mem___Copy;
            this.pictureBox1.Location = new System.Drawing.Point(210, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 126);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.simpleButton5);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.btn_Luu);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.qL_NGUOI_DUNGGridControl);
            this.groupBox1.Controls.Add(mANGUOIDUNGLabel);
            this.groupBox1.Controls.Add(this.txt_tenDN);
            this.groupBox1.Controls.Add(mATKHAULabel);
            this.groupBox1.Controls.Add(this.txt_MK);
            this.groupBox1.Controls.Add(hOATDONGLabel);
            this.groupBox1.Controls.Add(this.hd_check);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(303, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(803, 454);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // simpleButton5
            // 
            this.simpleButton5.ImageOptions.Image = global::QuanLyThuChi.Properties.Resources.exit1;
            this.simpleButton5.Location = new System.Drawing.Point(15, 397);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(75, 40);
            this.simpleButton5.TabIndex = 22;
            this.simpleButton5.Text = "Thoát";
            // 
            // btn_sua
            // 
            this.btn_sua.ImageOptions.Image = global::QuanLyThuChi.Properties.Resources.revert;
            this.btn_sua.Location = new System.Drawing.Point(15, 338);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 40);
            this.btn_sua.TabIndex = 22;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.ImageOptions.Image = global::QuanLyThuChi.Properties.Resources._010_trash_2_128;
            this.btn_xoa.Location = new System.Drawing.Point(15, 276);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 40);
            this.btn_xoa.TabIndex = 22;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.ImageOptions.Image = global::QuanLyThuChi.Properties.Resources.save1;
            this.btn_Luu.Location = new System.Drawing.Point(15, 215);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(75, 40);
            this.btn_Luu.TabIndex = 22;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_them
            // 
            this.btn_them.ImageOptions.Image = global::QuanLyThuChi.Properties.Resources.them;
            this.btn_them.Location = new System.Drawing.Point(15, 152);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 40);
            this.btn_them.TabIndex = 22;
            this.btn_them.Text = "Thêm";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // qL_NGUOI_DUNGGridControl
            // 
            this.qL_NGUOI_DUNGGridControl.DataSource = this.qL_NGUOI_DUNGBindingSource;
            this.qL_NGUOI_DUNGGridControl.Location = new System.Drawing.Point(129, 152);
            this.qL_NGUOI_DUNGGridControl.MainView = this.gridView1;
            this.qL_NGUOI_DUNGGridControl.Name = "qL_NGUOI_DUNGGridControl";
            this.qL_NGUOI_DUNGGridControl.Size = new System.Drawing.Size(665, 285);
            this.qL_NGUOI_DUNGGridControl.TabIndex = 21;
            this.qL_NGUOI_DUNGGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // qL_NGUOI_DUNGBindingSource
            // 
            this.qL_NGUOI_DUNGBindingSource.DataMember = "QL_NGUOI_DUNG";
            this.qL_NGUOI_DUNGBindingSource.DataSource = this.qLTC_DataSet;
            // 
            // qLTC_DataSet
            // 
            this.qLTC_DataSet.DataSetName = "QLTC_DataSet";
            this.qLTC_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.qL_NGUOI_DUNGGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // txt_tenDN
            // 
            this.txt_tenDN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.qL_NGUOI_DUNGBindingSource, "MANGUOIDUNG", true));
            this.txt_tenDN.Location = new System.Drawing.Point(471, 43);
            this.txt_tenDN.Name = "txt_tenDN";
            this.txt_tenDN.Size = new System.Drawing.Size(209, 20);
            this.txt_tenDN.TabIndex = 17;
            // 
            // txt_MK
            // 
            this.txt_MK.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.qL_NGUOI_DUNGBindingSource, "MATKHAU", true));
            this.txt_MK.Location = new System.Drawing.Point(471, 69);
            this.txt_MK.Name = "txt_MK";
            this.txt_MK.Size = new System.Drawing.Size(209, 20);
            this.txt_MK.TabIndex = 19;
            // 
            // hd_check
            // 
            this.hd_check.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.qL_NGUOI_DUNGBindingSource, "HOATDONG", true));
            this.hd_check.Location = new System.Drawing.Point(471, 95);
            this.hd_check.Name = "hd_check";
            this.hd_check.Properties.Caption = "Có hoạt động?";
            this.hd_check.Size = new System.Drawing.Size(209, 19);
            this.hd_check.TabIndex = 21;
            // 
            // qL_NGUOI_DUNGTableAdapter
            // 
            this.qL_NGUOI_DUNGTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.QL_NGUOI_DUNGTableAdapter = this.qL_NGUOI_DUNGTableAdapter;
            this.tableAdapterManager.QL_NGUOIDUNG_NHOMNGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.QL_NHOM_NDTableAdapter = null;
            this.tableAdapterManager.QL_PHANQUYENTableAdapter = null;
            this.tableAdapterManager.TAI_KHOANTableAdapter = null;
            this.tableAdapterManager.TIEN_TETableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyThuChi.QLTC_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // qL_NGUOI_DUNGBindingNavigator
            // 
            this.qL_NGUOI_DUNGBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.qL_NGUOI_DUNGBindingNavigator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.qL_NGUOI_DUNGBindingNavigator.BindingSource = this.qL_NGUOI_DUNGBindingSource;
            this.qL_NGUOI_DUNGBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.qL_NGUOI_DUNGBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.qL_NGUOI_DUNGBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.qL_NGUOI_DUNGBindingNavigatorSaveItem});
            this.qL_NGUOI_DUNGBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.qL_NGUOI_DUNGBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.qL_NGUOI_DUNGBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.qL_NGUOI_DUNGBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.qL_NGUOI_DUNGBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.qL_NGUOI_DUNGBindingNavigator.Name = "qL_NGUOI_DUNGBindingNavigator";
            this.qL_NGUOI_DUNGBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.qL_NGUOI_DUNGBindingNavigator.Size = new System.Drawing.Size(1118, 25);
            this.qL_NGUOI_DUNGBindingNavigator.TabIndex = 18;
            this.qL_NGUOI_DUNGBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = global::QuanLyThuChi.Properties.Resources.add;
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
            this.bindingNavigatorDeleteItem.Image = global::QuanLyThuChi.Properties.Resources.exit11;
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
            // qL_NGUOI_DUNGBindingNavigatorSaveItem
            // 
            this.qL_NGUOI_DUNGBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.qL_NGUOI_DUNGBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("qL_NGUOI_DUNGBindingNavigatorSaveItem.Image")));
            this.qL_NGUOI_DUNGBindingNavigatorSaveItem.Name = "qL_NGUOI_DUNGBindingNavigatorSaveItem";
            this.qL_NGUOI_DUNGBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.qL_NGUOI_DUNGBindingNavigatorSaveItem.Text = "Save Data";
            this.qL_NGUOI_DUNGBindingNavigatorSaveItem.Click += new System.EventHandler(this.qL_NGUOI_DUNGBindingNavigatorSaveItem_Click);
            // 
            // frm_QL_NguoiDung
            // 
            this.ClientSize = new System.Drawing.Size(1118, 493);
            this.Controls.Add(this.qL_NGUOI_DUNGBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_QL_NguoiDung";
            this.Load += new System.EventHandler(this.frm_QL_NguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NGUOI_DUNGGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NGUOI_DUNGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTC_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tenDN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hd_check.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NGUOI_DUNGBindingNavigator)).EndInit();
            this.qL_NGUOI_DUNGBindingNavigator.ResumeLayout(false);
            this.qL_NGUOI_DUNGBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void qL_NGUOI_DUNGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.qL_NGUOI_DUNGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLTC_DataSet);

        }

        private void frm_QL_NguoiDung_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTC_DataSet.QL_NGUOI_DUNG' table. You can move, or remove it, as needed.
            this.qL_NGUOI_DUNGTableAdapter.Fill(this.qLTC_DataSet.QL_NGUOI_DUNG);
            
            btn_Luu.Enabled = false;


        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            txt_tenDN.Enabled = true;
            txt_MK.Enabled = true;
            btn_them.Enabled = false;
            btn_Luu.Enabled = true;
            txt_tenDN.Focus();
            txt_tenDN.Text = string.Empty;
            txt_MK.Text = string.Empty;



        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {


            try
            {
                string mk = txt_MK.Text;
                bool hoatdong = hd_check.Checked ? true : false;
                if (qL_NGUOI_DUNGTableAdapter.KT_KHoaChinh(txt_tenDN.Text) == 0)
                {
                    qL_NGUOI_DUNGTableAdapter.Insert(txt_tenDN.Text, txt_MK.Text, hoatdong);
                    this.qL_NGUOI_DUNGTableAdapter.Fill(this.qLTC_DataSet.QL_NGUOI_DUNG);
                    btn_them.Enabled = true;
                    txt_tenDN.Enabled = false;
                    txt_MK.Enabled = false;
                    btn_Luu.Enabled = false;
                    MessageBox.Show("Thêm người dùng thành công!");
                    txt_tenDN.Text = string.Empty;
                    txt_MK.Text = string.Empty;

                    //qL_NGUOI_DUNGGridControl.DataSource = qL_NGUOI_DUNGTableAdapter.GetData();
                }
                else
                {
                    MessageBox.Show("Người dùng đã tồn tại!!");
                    txt_tenDN.Text = string.Empty;
                    txt_tenDN.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Không thể thêm người dùng mới!!!! ");
            }

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn xóa!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            try
            {
                if (r == DialogResult.Yes)
                {
                    bool hoatdong = hd_check.Checked ? true : false;
                    qL_NGUOI_DUNGTableAdapter.Delete(txt_tenDN.Text, txt_MK.Text, hoatdong);
                    this.qL_NGUOI_DUNGTableAdapter.Fill(this.qLTC_DataSet.QL_NGUOI_DUNG);
                }
            }
            catch
            {
                XtraMessageBox.Show("Tài khoản đang được sử dụng");
            }

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            
            btn_Luu.Enabled = true;
            bool hoatdong = hd_check.Checked ? true : false;
            qL_NGUOI_DUNGTableAdapter.UpdateQuery(txt_tenDN.Text, txt_MK.Text, hoatdong,txt_tenDN.Text);
            this.qL_NGUOI_DUNGTableAdapter.Fill(this.qLTC_DataSet.QL_NGUOI_DUNG);
        }

        
    }
}