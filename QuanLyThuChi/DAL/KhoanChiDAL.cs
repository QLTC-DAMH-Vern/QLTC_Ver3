using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DatasetDALTableAdapters;
namespace DAL
{
    public class KhoanChiDAL
    {
        HANG_MUC_CHITableAdapter hmchi = new HANG_MUC_CHITableAdapter();
        CT_HANG_MUC_CHITableAdapter cthmchi = new CT_HANG_MUC_CHITableAdapter();
        public DataTable _load_grid()
        {
            return cthmchi.GetData();
        }
        public DataTable _load_grid_hangmuccha()
        {
            return hmchi.GetData();
        }

        //load dữ liệu ct hạng mục
        public DataTable _load_grid_hangmuccon(int mahm)
        {
            return cthmchi._load_cthm(mahm);
        }

        //thêm ct hạng mục
        public int _them_ct_hm(int macthm , string tencthm, string ghichu, int? mahm)
        {
            return cthmchi._them_cthm(macthm,tencthm, ghichu, mahm);
        }

        // lấy mã ct hạng mục lớn nhất
        public int? _get_macthm()
        {
            return cthmchi._get_macthm_max();
        }

        //xóa ct hạng mục
        public int _xoa_cthm(int macthm)
        {
            return cthmchi._delete_cthm(macthm);
        }

        //sửa ct hạng mục
        public int _sua_cthm(int macthm,string tencthm,string ghichu)
        {
            return cthmchi._update_cthm(tencthm, ghichu, macthm);
        }

        //lấy mã hạng mục chi
        public int _get_mahm()
        {
            return (int)hmchi._get_mahmchi_max();
        }
        //thêm hạng mục chi
        public int _them_hmchi(int ma,string ten,string ghichu)
        {
            return hmchi._them_hmchi(ma, ten, ghichu);
        }
        //sửa hạng mục
        public int _sua_hmchi(string ten,string chuthich,int ma)
        {
            return hmchi._update_hmchi(ten, chuthich, ma);
        }
        //xoa hạng mục chi
        public int _xoa_hmchi(int ma)
        {
            return hmchi._delete_hmchi(ma);
        }
        
        //kiem tra khoa ngoai ct hạng mục
        public int _kt_cthm(int ma)
        {
            return (int)cthmchi._kt_khoangoaicthm(ma);
        }

        //kiem tra khoa ngoại hạng mục chi
        public int _kt_hm(int ma)
        {
            return (int)hmchi._kt_khoangoai_hmchi(ma);
        }

    }
}

