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
using DevExpress.XtraBars;
using System.ComponentModel.DataAnnotations;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Collections;
using DevExpress.XtraBars.Ribbon;
namespace QuanLyThuChi
{

    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        LoginResult NguoiDung = new LoginResult();

        public MainForm()
        {
            InitializeComponent();
           
            BindingList<Customer> dataSource = GetDataSource();
            bsiRecordsCount.Caption = "RECORDS : " + dataSource.Count;

        }
   
        public BindingList<Customer> GetDataSource()
        {
            BindingList<Customer> result = new BindingList<Customer>();
            result.Add(new Customer()
            {
                ID = 1,
                Name = "ACME",
                Address = "2525 E El Segundo Blvd",
                City = "El Segundo",
                State = "CA",
                ZipCode = "90245",
                Phone = "(310) 536-0611"
            });
            result.Add(new Customer()
            {
                ID = 2,
                Name = "Electronics Depot",
                Address = "2455 Paces Ferry Road NW",
                City = "Atlanta",
                State = "GA",
                ZipCode = "30339",
                Phone = "(800) 595-3232"
            });
            return result;
        }
        public class Customer
        {
            [Key, Display(AutoGenerateField = false)]
            public int ID { get; set; }
            [Required]
            public string Name { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            [Display(Name = "Zip Code")]
            public string ZipCode { get; set; }
            public string Phone { get; set; }
        }

        private void gridControl_Click(object sender, EventArgs e)
        {

        }
        string _TenDangNhap = LogIn.GetUserName.userNAME;

        private void MainForm_Load(object sender, EventArgs e)
        {
            DevExpress.UserSkins.BonusSkins.Register();
            List<string> nhomND = NguoiDung.GetMaNhomNguoiDung(_TenDangNhap);

            foreach (string item in nhomND)
            {
                DataTable dsQuyen = NguoiDung.GetMaManHinh(item);
                foreach (DataRow mh in dsQuyen.Rows)
                {
                    FindMenuPhanQuyen(ribbonControl, mh[1].ToString(), Convert.ToBoolean(mh[2].ToString()));

                }
            }
        }

        private void FindMenuPhanQuyen(RibbonControl ribControl, string pScreen, bool pEnable)
        {
            foreach (RibbonPage ribPage in ribbonControl.Pages)
            {
                foreach (RibbonPageGroup ribGroup in ribPage.Groups)
                {
                    foreach (BarItemLink barItem in ribGroup.ItemLinks)
                    {
                        object kq = barItem.Item.Tag;
                        if (kq != null)
                        {
                            if (barItem.Item.Tag.ToString().CompareTo(pScreen) == 0 && pEnable == false)
                                barItem.Item.Visibility = BarItemVisibility.Never;
                        }
                    }
                }
            }
        }

        //private void VisibleMenu(ArrayList Roles, RibbonControl ribControl)
        //{
        //    foreach (RibbonPage ribPage in ribControl.Pages)
        //    {
        //        int PageGroup = 0;
        //        foreach (RibbonPageGroup ribPageGroup in ribPage.Groups)
        //        {
        //            int CountBarItem = 0;
        //            foreach (BarItemLink barItem in ribPageGroup.ItemLinks)
        //            {
        //                if (barItem.GetType() == typeof(BarSubItemLink))
        //                {
        //                    BarSubItemLink bsi = (BarSubItemLink)(barItem);
        //                    foreach (BarItemLink barItemLink in bsi.VisibleLinks)
        //                    {
        //                        foreach (String strValue in barItemLink.Item.Tag.ToString().Split('|'))
        //                        {
        //                            if (Roles.Contains(strValue))
        //                            {
        //                                barItemLink.Item.Visibility = BarItemVisibility.Always;
        //                                PageGroup = 1;
        //                                CountBarItem = 1;

        //                            }
        //                        }
        //                    }
        //                    if (CountBarItem == 1)
        //                    {
        //                        barItem.Item.Visibility = BarItemVisibility.Always;
        //                        PageGroup = 1;
        //                    }


        //                }
        //                else
        //                {
        //                    if (Roles.Contains(barItem.Item.Tag))
        //                    {
        //                        barItem.Item.Visibility = BarItemVisibility.Always;
        //                        PageGroup = 1;
        //                    }
        //                }
        //            }
        //            if (PageGroup == 1)
        //            {
        //                ribPage.Visible = true;
        //                ribPageGroup.Visible = true;
        //            }
        //        }
        //    }
        //}


        private void btnphieuthu_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_PhieuThu f = new frm_PhieuThu();
            if (ExistForm(f))
                return;
            f.MdiParent = this;
            f.Show();
        }

        private void btndkhangmucchi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Page_DKkhoanthu pg = new Page_DKkhoanthu();
            if (ExistForm(pg))
                return;
            pg.MdiParent = this;
            pg.Show();
        }

        private void btndkhangmucthu_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_DangKyKhoanChi frm = new frm_DangKyKhoanChi();
            if (ExistForm(frm))
                return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnPhieuChi_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_LapPhieuChi frm = new frm_LapPhieuChi();
            if (ExistForm(frm))
                return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDoiMK frm= new frmDoiMK();
            if (ExistForm(frm))
                return;
            //frmdoimk.ShowDialog();
            frm.MdiParent = this;
            frm.Show();
        }

       

        private void btnDangNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_QL_NguoiDung frm = new frm_QL_NguoiDung();
            if (ExistForm(frm))
                return;
            frm.MdiParent = this;
            frm.Show();
            StartPosition = FormStartPosition.CenterParent;
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_PhanQuyen frm = new frm_PhanQuyen();
            if (ExistForm(frm))
                return;
            frm.MdiParent = this;
            frm.Show();
            StartPosition = FormStartPosition.CenterParent;
        }

        private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_QL_NhomNguoiDung frm = new frm_QL_NhomNguoiDung();
            if (ExistForm(frm))
                return;
            frm.MdiParent = this;
            frm.Show();
            StartPosition = FormStartPosition.CenterParent;
        }

        private void barButtonItem20_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmQL_NguoiDung_NhomNguoiDung frm = new frmQL_NguoiDung_NhomNguoiDung();
            if (ExistForm(frm))
                return;
            frm.MdiParent = this;
            frm.Show();
            StartPosition = FormStartPosition.CenterParent;
        }


        private bool ExistForm(Form a)
        {
            foreach (Form child in MdiChildren)
            {
                if (child.Name == a.Name)
                {
                    child.Activate();
                    return true;
                }
            }
            return false;
        }
        
    }
}