namespace QuanLyThuChi
{
    partial class frm_QL_NhomNguoiDung
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
            System.Windows.Forms.Label mA_NHOMLabel;
            System.Windows.Forms.Label tEN_NHOMLabel;
            System.Windows.Forms.Label cHITIETLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QL_NhomNguoiDung));
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
            this.txt_MaNhom = new DevExpress.XtraEditors.TextEdit();
            this.txt_TenNhom = new DevExpress.XtraEditors.TextEdit();
            this.txt_chitiet = new DevExpress.XtraEditors.TextEdit();
            this.qL_NHOM_NDGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_sua = new DevExpress.XtraEditors.SimpleButton();
            this.btn_xoa = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Luu = new DevExpress.XtraEditors.SimpleButton();
            this.btn_them = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            mA_NHOMLabel = new System.Windows.Forms.Label();
            tEN_NHOMLabel = new System.Windows.Forms.Label();
            cHITIETLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLTC_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHOM_NDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHOM_NDBindingNavigator)).BeginInit();
            this.qL_NHOM_NDBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaNhom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenNhom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_chitiet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHOM_NDGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mA_NHOMLabel
            // 
            mA_NHOMLabel.AutoSize = true;
            mA_NHOMLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mA_NHOMLabel.Location = new System.Drawing.Point(329, 40);
            mA_NHOMLabel.Name = "mA_NHOMLabel";
            mA_NHOMLabel.Size = new System.Drawing.Size(64, 14);
            mA_NHOMLabel.TabIndex = 1;
            mA_NHOMLabel.Text = "Mã nhóm";
            // 
            // tEN_NHOMLabel
            // 
            tEN_NHOMLabel.AutoSize = true;
            tEN_NHOMLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tEN_NHOMLabel.Location = new System.Drawing.Point(329, 66);
            tEN_NHOMLabel.Name = "tEN_NHOMLabel";
            tEN_NHOMLabel.Size = new System.Drawing.Size(68, 14);
            tEN_NHOMLabel.TabIndex = 3;
            tEN_NHOMLabel.Text = "Tên nhóm";
            // 
            // cHITIETLabel
            // 
            cHITIETLabel.AutoSize = true;
            cHITIETLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cHITIETLabel.Location = new System.Drawing.Point(329, 92);
            cHITIETLabel.Name = "cHITIETLabel";
            cHITIETLabel.Size = new System.Drawing.Size(52, 14);
            cHITIETLabel.TabIndex = 5;
            cHITIETLabel.Text = "Chi tiết";
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
            this.qL_NHOM_NDBindingNavigator.Size = new System.Drawing.Size(1017, 25);
            this.qL_NHOM_NDBindingNavigator.TabIndex = 0;
            this.qL_NHOM_NDBindingNavigator.Text = "bindingNavigator1";
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
            // txt_MaNhom
            // 
            this.txt_MaNhom.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.qL_NHOM_NDBindingSource, "MA_NHOM", true));
            this.txt_MaNhom.Location = new System.Drawing.Point(409, 38);
            this.txt_MaNhom.Name = "txt_MaNhom";
            this.txt_MaNhom.Size = new System.Drawing.Size(188, 20);
            this.txt_MaNhom.TabIndex = 2;
            // 
            // txt_TenNhom
            // 
            this.txt_TenNhom.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.qL_NHOM_NDBindingSource, "TEN_NHOM", true));
            this.txt_TenNhom.Location = new System.Drawing.Point(409, 64);
            this.txt_TenNhom.Name = "txt_TenNhom";
            this.txt_TenNhom.Size = new System.Drawing.Size(188, 20);
            this.txt_TenNhom.TabIndex = 4;
            // 
            // txt_chitiet
            // 
            this.txt_chitiet.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.qL_NHOM_NDBindingSource, "CHITIET", true));
            this.txt_chitiet.Location = new System.Drawing.Point(409, 90);
            this.txt_chitiet.Name = "txt_chitiet";
            this.txt_chitiet.Size = new System.Drawing.Size(188, 20);
            this.txt_chitiet.TabIndex = 6;
            // 
            // qL_NHOM_NDGridControl
            // 
            this.qL_NHOM_NDGridControl.DataSource = this.qL_NHOM_NDBindingSource;
            this.qL_NHOM_NDGridControl.Location = new System.Drawing.Point(109, 136);
            this.qL_NHOM_NDGridControl.MainView = this.gridView1;
            this.qL_NHOM_NDGridControl.Name = "qL_NHOM_NDGridControl";
            this.qL_NHOM_NDGridControl.Size = new System.Drawing.Size(565, 285);
            this.qL_NHOM_NDGridControl.TabIndex = 7;
            this.qL_NHOM_NDGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.qL_NHOM_NDGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.simpleButton5);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.btn_Luu);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txt_MaNhom);
            this.groupBox1.Controls.Add(this.qL_NHOM_NDGridControl);
            this.groupBox1.Controls.Add(this.txt_chitiet);
            this.groupBox1.Controls.Add(mA_NHOMLabel);
            this.groupBox1.Controls.Add(cHITIETLabel);
            this.groupBox1.Controls.Add(this.txt_TenNhom);
            this.groupBox1.Controls.Add(tEN_NHOMLabel);
            this.groupBox1.Location = new System.Drawing.Point(327, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 436);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // simpleButton5
            // 
            this.simpleButton5.ImageOptions.Image = global::QuanLyThuChi.Properties.Resources.exit1;
            this.simpleButton5.Location = new System.Drawing.Point(15, 381);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(75, 40);
            this.simpleButton5.TabIndex = 23;
            this.simpleButton5.Text = "Thoát";
            // 
            // btn_sua
            // 
            this.btn_sua.ImageOptions.Image = global::QuanLyThuChi.Properties.Resources.revert;
            this.btn_sua.Location = new System.Drawing.Point(15, 322);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 40);
            this.btn_sua.TabIndex = 24;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.ImageOptions.Image = global::QuanLyThuChi.Properties.Resources._010_trash_2_128;
            this.btn_xoa.Location = new System.Drawing.Point(15, 260);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 40);
            this.btn_xoa.TabIndex = 25;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.ImageOptions.Image = global::QuanLyThuChi.Properties.Resources.save1;
            this.btn_Luu.Location = new System.Drawing.Point(15, 199);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(75, 40);
            this.btn_Luu.TabIndex = 26;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_them
            // 
            this.btn_them.ImageOptions.Image = global::QuanLyThuChi.Properties.Resources.them;
            this.btn_them.Location = new System.Drawing.Point(15, 136);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 40);
            this.btn_them.TabIndex = 27;
            this.btn_them.Text = "Thêm";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyThuChi.Properties.Resources.nhom5;
            this.pictureBox1.Location = new System.Drawing.Point(178, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 117);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // frm_QL_NhomNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 490);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.qL_NHOM_NDBindingNavigator);
            this.Name = "frm_QL_NhomNguoiDung";
            this.Text = "frm_QL_NhomNguoiDung";
            this.Load += new System.EventHandler(this.frm_QL_NhomNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLTC_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHOM_NDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHOM_NDBindingNavigator)).EndInit();
            this.qL_NHOM_NDBindingNavigator.ResumeLayout(false);
            this.qL_NHOM_NDBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaNhom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenNhom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_chitiet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHOM_NDGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit txt_MaNhom;
        private DevExpress.XtraEditors.TextEdit txt_TenNhom;
        private DevExpress.XtraEditors.TextEdit txt_chitiet;
        private DevExpress.XtraGrid.GridControl qL_NHOM_NDGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton btn_sua;
        private DevExpress.XtraEditors.SimpleButton btn_xoa;
        private DevExpress.XtraEditors.SimpleButton btn_Luu;
        private DevExpress.XtraEditors.SimpleButton btn_them;
    }
}