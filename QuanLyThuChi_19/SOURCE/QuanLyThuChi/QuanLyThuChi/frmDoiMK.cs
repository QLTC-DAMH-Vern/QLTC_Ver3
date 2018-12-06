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
    public partial class frmDoiMK : DevExpress.XtraEditors.XtraForm
    {
        LoginResult CauHinh = new LoginResult();
        

        public frmDoiMK()
        {
            InitializeComponent();
        }

        private void frmDoiMK_Load(object sender, EventArgs e)
        {
            txt_TenDN.Text = LogIn.GetUserName.userNAME;
        }

        private void btn_Luu_Click_1(object sender, EventArgs e)
        {
            if (txt_MKcu.Text == "" || txt_MKmoi.Text == "" || txt_xacnhanMK.Text == "")
                MessageBox.Show("Không được để trống thông tin!!");
            else
            {
                if (txt_MKcu.Text != Program.pass && txt_MKcu.Text == string.Empty)
                    MessageBox.Show("Mật khẩu cũ không chính xác!");
                else
                {
                    CauHinh.Doi_MK(txt_TenDN.Text, txt_MKmoi.Text);
                    MessageBox.Show("Thành công!!!");
                    Program.pass = txt_MKmoi.Text;
                    btn_nhaplai_Click_1(sender, e);
                    return;
                }
            }
        }

        private void btn_nhaplai_Click_1(object sender, EventArgs e)
        {
            txt_MKcu.Clear();
            txt_MKmoi.Clear();
            txt_xacnhanMK.Clear();
            txt_MKcu.Focus();
        }

        private void btn_Thoát_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_showPass_Click_1(object sender, EventArgs e)
        {
            if (txt_MKcu.UseSystemPasswordChar == true)
            {
                txt_MKcu.UseSystemPasswordChar = false;
                btn_showPass.ImageOptions.Image = QuanLyThuChi.Properties.Resources.eyee;
            }
            else
            {
                txt_MKcu.UseSystemPasswordChar = true;
                btn_showPass.ImageOptions.Image = QuanLyThuChi.Properties.Resources.eye;
            }
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            if (txt_MKmoi.UseSystemPasswordChar == true)
            {
                txt_MKmoi.UseSystemPasswordChar = false;
                simpleButton1.ImageOptions.Image = QuanLyThuChi.Properties.Resources.eyee;
            }
            else
            {
                txt_MKmoi.UseSystemPasswordChar = true;
                simpleButton1.ImageOptions.Image = QuanLyThuChi.Properties.Resources.eye;
            }
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            if (txt_xacnhanMK.UseSystemPasswordChar == true)
            {
                txt_xacnhanMK.UseSystemPasswordChar = false;
                simpleButton2.ImageOptions.Image = QuanLyThuChi.Properties.Resources.eyee;
            }
            else
            {
                txt_xacnhanMK.UseSystemPasswordChar = true;
                simpleButton2.ImageOptions.Image = QuanLyThuChi.Properties.Resources.eye;
            }
        }




    }
}