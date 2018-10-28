using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
namespace BLL
{
    
    public class KhoanChiBLL
    {
        KhoanChiDAL hangmucchi = new KhoanChiDAL();
       
        public KhoanChiBLL()
        { 

        }

        public DataTable Load_HangMucChi()
        {
            return hangmucchi._load_grid();
        }
        public DataTable Load_HangMucChiCha()
        {
            return hangmucchi._load_grid_hangmuccha();
        }

        public DataTable Load_CTHangMuc(int mahm)
        {
            return hangmucchi._load_grid_hangmuccon(mahm);
        }

        public int Them_CTHM(int macthm, string tencthm, string ghichu, int mahm)
        {
            return hangmucchi._them_ct_hm(macthm, tencthm, ghichu, mahm);
        }
        public int? Get_macthm()
        {
            return hangmucchi._get_macthm();
        }

        public int Xoa_cthm(int macthm)
        {
            if (hangmucchi._kt_cthm(macthm) > 0)
                return 0;
            return hangmucchi._xoa_cthm(macthm);
        }
        public int Sua_cthm(string ten, string ghichu, int ma)
        {
            return hangmucchi._sua_cthm(ma, ten, ghichu);
        }

        //lấy mã max hmchi
        public int get_mahmchi()
        {
            return hangmucchi._get_mahm();
        }

        //thêm hạng mục chi
        public int Them_HMChi(int ma, string ten, string ghichu)
        {
            return hangmucchi._them_hmchi(ma, ten, ghichu);
        }

        //sửa hạng mục chi
        public int Sua_HMChi(int ma, string ten, string gc)
        {
            return hangmucchi._sua_hmchi(ten, gc, ma);
        }
        //xoa hạng mục chi
        public int Xoa_HMChi(int ma)
        {
            if (hangmucchi._kt_hm(ma) > 0)
                return 0;
            return hangmucchi._xoa_hmchi(ma);
        }
        //kiểm tra khóa ngoại cthm
        public int KT_CTHM(int ma)
        {
            return hangmucchi._kt_cthm(ma);

        }
        //kiem tra khóa ngọa hạng mục chi
        public int KT_HM(int ma)
        {
            return hangmucchi._kt_hm(ma);
        }








       
    }
}
