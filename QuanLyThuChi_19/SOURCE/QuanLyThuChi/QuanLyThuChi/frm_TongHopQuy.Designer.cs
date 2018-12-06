namespace QuanLyThuChi
{
    partial class frm_TongHopQuy
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_rs = new DevExpress.XtraEditors.SimpleButton();
            this.txt_soduht = new KeThua.NumbericTextbox();
            this.txt_sodubd = new KeThua.NumbericTextbox();
            this.btn_luu = new DevExpress.XtraEditors.SimpleButton();
            this.btn_sua = new DevExpress.XtraEditors.SimpleButton();
            this.btn_them = new DevExpress.XtraEditors.SimpleButton();
            this.btn_xoa = new DevExpress.XtraEditors.SimpleButton();
            this.cbo_loaitk = new System.Windows.Forms.ComboBox();
            this.cbo_tiente = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_chuthich = new DevExpress.XtraEditors.TextEdit();
            this.txt_tentk = new DevExpress.XtraEditors.TextEdit();
            this.txt_matk = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_chuthich.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tentk.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_matk.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.groupControl1);
            this.layoutControl1.Controls.Add(this.label1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(896, 354);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(453, 60);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(431, 282);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView1_SelectionChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.FieldName = "QL_NGUOIDUNG";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "gridColumn2";
            this.gridColumn2.FieldName = "TIEN_TE";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "gridColumn3";
            this.gridColumn3.FieldName = "LOAI_TK";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Mã tk";
            this.gridColumn4.FieldName = "MATK";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Loại tiền tệ";
            this.gridColumn5.FieldName = "MALOAI";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Người dùng";
            this.gridColumn6.FieldName = "MANGUOIDUNG";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Tên tài khoản";
            this.gridColumn7.FieldName = "TENTK";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 3;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Số dư ban đầu";
            this.gridColumn8.FieldName = "SODUBD";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 4;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Số dư hiện tại";
            this.gridColumn9.FieldName = "SODUHT";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 5;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Trạng thái";
            this.gridColumn10.FieldName = "TRANGTHAI";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 6;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Chú thích";
            this.gridColumn11.FieldName = "DIENGIAI";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 7;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Mã loại tài khoản";
            this.gridColumn12.FieldName = "MA_LOAI_TK";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 8;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btn_rs);
            this.groupControl1.Controls.Add(this.txt_soduht);
            this.groupControl1.Controls.Add(this.txt_sodubd);
            this.groupControl1.Controls.Add(this.btn_luu);
            this.groupControl1.Controls.Add(this.btn_sua);
            this.groupControl1.Controls.Add(this.btn_them);
            this.groupControl1.Controls.Add(this.btn_xoa);
            this.groupControl1.Controls.Add(this.cbo_loaitk);
            this.groupControl1.Controls.Add(this.cbo_tiente);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.txt_chuthich);
            this.groupControl1.Controls.Add(this.txt_tentk);
            this.groupControl1.Controls.Add(this.txt_matk);
            this.groupControl1.Location = new System.Drawing.Point(12, 60);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(437, 282);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin tài khoản";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // btn_rs
            // 
            this.btn_rs.ImageOptions.Image = global::QuanLyThuChi.Properties.Resources.revert;
            this.btn_rs.Location = new System.Drawing.Point(346, 217);
            this.btn_rs.Name = "btn_rs";
            this.btn_rs.Size = new System.Drawing.Size(39, 32);
            this.btn_rs.TabIndex = 14;
            this.btn_rs.Text = "Làm mới";
            this.btn_rs.Click += new System.EventHandler(this.btn_rs_Click);
            // 
            // txt_soduht
            // 
            this.txt_soduht.Enabled = false;
            this.txt_soduht.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_soduht.Location = new System.Drawing.Point(124, 154);
            this.txt_soduht.Name = "txt_soduht";
            this.txt_soduht.Size = new System.Drawing.Size(308, 27);
            this.txt_soduht.TabIndex = 13;
            // 
            // txt_sodubd
            // 
            this.txt_sodubd.Enabled = false;
            this.txt_sodubd.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_sodubd.Location = new System.Drawing.Point(124, 121);
            this.txt_sodubd.Name = "txt_sodubd";
            this.txt_sodubd.Size = new System.Drawing.Size(308, 27);
            this.txt_sodubd.TabIndex = 12;
            // 
            // btn_luu
            // 
            this.btn_luu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_luu.Enabled = false;
            this.btn_luu.ImageOptions.Image = global::QuanLyThuChi.Properties.Resources.save2;
            this.btn_luu.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_luu.Location = new System.Drawing.Point(282, 217);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(40, 32);
            this.btn_luu.TabIndex = 9;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackgroundImage = global::QuanLyThuChi.Properties.Resources.Technical_Support_512__1_;
            this.btn_sua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_sua.ImageOptions.Image = global::QuanLyThuChi.Properties.Resources.Technical_Support_512__1_;
            this.btn_sua.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_sua.Location = new System.Drawing.Point(216, 217);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(40, 32);
            this.btn_sua.TabIndex = 10;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_them.Appearance.Options.UseForeColor = true;
            this.btn_them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_them.ImageOptions.Image = global::QuanLyThuChi.Properties.Resources.add;
            this.btn_them.Location = new System.Drawing.Point(83, 217);
            this.btn_them.Name = "btn_them";
            this.btn_them.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btn_them.Size = new System.Drawing.Size(40, 32);
            this.btn_them.TabIndex = 8;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_xoa.ImageOptions.Image = global::QuanLyThuChi.Properties.Resources._010_x_5122;
            this.btn_xoa.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_xoa.Location = new System.Drawing.Point(148, 217);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btn_xoa.Size = new System.Drawing.Size(39, 32);
            this.btn_xoa.TabIndex = 11;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // cbo_loaitk
            // 
            this.cbo_loaitk.Enabled = false;
            this.cbo_loaitk.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cbo_loaitk.FormattingEnabled = true;
            this.cbo_loaitk.Location = new System.Drawing.Point(124, 88);
            this.cbo_loaitk.Name = "cbo_loaitk";
            this.cbo_loaitk.Size = new System.Drawing.Size(308, 27);
            this.cbo_loaitk.TabIndex = 2;
            // 
            // cbo_tiente
            // 
            this.cbo_tiente.Enabled = false;
            this.cbo_tiente.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cbo_tiente.FormattingEnabled = true;
            this.cbo_tiente.Location = new System.Drawing.Point(326, 24);
            this.cbo_tiente.Name = "cbo_tiente";
            this.cbo_tiente.Size = new System.Drawing.Size(106, 27);
            this.cbo_tiente.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label7.Location = new System.Drawing.Point(5, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Loại tài khoản";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label6.Location = new System.Drawing.Point(5, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Số dư ban đầu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label8.Location = new System.Drawing.Point(5, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "Chú thích";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label5.Location = new System.Drawing.Point(5, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Số dư hiện tại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.Location = new System.Drawing.Point(5, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(233, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Loại tiền tệ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(5, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã tài khoản";
            // 
            // txt_chuthich
            // 
            this.txt_chuthich.Enabled = false;
            this.txt_chuthich.Location = new System.Drawing.Point(124, 185);
            this.txt_chuthich.Name = "txt_chuthich";
            this.txt_chuthich.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_chuthich.Properties.Appearance.Options.UseFont = true;
            this.txt_chuthich.Size = new System.Drawing.Size(308, 26);
            this.txt_chuthich.TabIndex = 0;
            // 
            // txt_tentk
            // 
            this.txt_tentk.Enabled = false;
            this.txt_tentk.Location = new System.Drawing.Point(124, 56);
            this.txt_tentk.Name = "txt_tentk";
            this.txt_tentk.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_tentk.Properties.Appearance.Options.UseFont = true;
            this.txt_tentk.Size = new System.Drawing.Size(308, 26);
            this.txt_tentk.TabIndex = 0;
            // 
            // txt_matk
            // 
            this.txt_matk.Enabled = false;
            this.txt_matk.Location = new System.Drawing.Point(124, 24);
            this.txt_matk.Name = "txt_matk";
            this.txt_matk.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_matk.Properties.Appearance.Options.UseFont = true;
            this.txt_matk.Size = new System.Drawing.Size(103, 26);
            this.txt_matk.TabIndex = 0;
            this.txt_matk.Leave += new System.EventHandler(this.txt_matk_Leave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(872, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "ĐĂNG KÝ QUỸ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(896, 354);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.groupControl1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(441, 286);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gridControl1;
            this.layoutControlItem3.Location = new System.Drawing.Point(441, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(435, 286);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.label1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(876, 48);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // frm_TongHopQuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 354);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frm_TongHopQuy";
            this.Text = "frm_TongHopQuy";
            this.Load += new System.EventHandler(this.frm_TongHopQuy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_chuthich.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tentk.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_matk.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txt_tentk;
        private DevExpress.XtraEditors.TextEdit txt_matk;
        private System.Windows.Forms.ComboBox cbo_tiente;
        private System.Windows.Forms.ComboBox cbo_loaitk;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.TextEdit txt_chuthich;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraEditors.SimpleButton btn_luu;
        private DevExpress.XtraEditors.SimpleButton btn_sua;
        private DevExpress.XtraEditors.SimpleButton btn_them;
        private DevExpress.XtraEditors.SimpleButton btn_xoa;
        private KeThua.NumbericTextbox txt_soduht;
        private KeThua.NumbericTextbox txt_sodubd;
        private DevExpress.XtraEditors.SimpleButton btn_rs;
    }
}