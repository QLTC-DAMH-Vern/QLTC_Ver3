using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinQ;
namespace LinQ
{

    public class QLTienTe
    {
        LinQtoSQLDataContext qltt = new LinQtoSQLDataContext();
        public QLTienTe()
        { }

        public List<TIEN_TE> load_grid_tiente()
        {
            return qltt.TIEN_TEs.Select(t => t).ToList<TIEN_TE>();
        }

        public int KT_KhoaChinh(string ma) 
        {
            TIEN_TE tt = qltt.TIEN_TEs.Where(t => t.MALOAI == ma).FirstOrDefault();
            if (tt != null)
                return 1;
            return 0;
        }

        public int Them_tiente(TIEN_TE p)
        {
            if (KT_KhoaChinh(p.MALOAI) > 0)
                return 1;// trùng mã
            try
            {
                qltt.TIEN_TEs.InsertOnSubmit(p);
                qltt.SubmitChanges();
                return 0;
            }
            catch (Exception ex)
            {
                return 2;//lỗi
            }
        }

        public int Sua_tiente(string macu,string mamoi, string ten, decimal tigia)
        {
            TIEN_TE tt = qltt.TIEN_TEs.Where(t => t.MALOAI == macu).FirstOrDefault();
            if (tt != null)
            {
                tt.MALOAI = mamoi;
                tt.TENLOAI = ten;
                tt.TI_GIA = tigia;
                qltt.SubmitChanges();
                return 1;// thành công
            }
            return 0;
        }

        public int Xoa_tiente(string ma)
        {
            if (KT_KhoaNgoai(ma) == 1)
                return 2 ; //có khóa ngoại
            TIEN_TE tt = qltt.TIEN_TEs.Where(t => t.MALOAI == ma).FirstOrDefault();
            if (tt != null)
            {
                qltt.TIEN_TEs.DeleteOnSubmit(tt);
                qltt.SubmitChanges();
                return 1;// thành công
            }
            return 0;

        }
        //kiểm tra khóa ngoại
        public int KT_KhoaNgoai(string ma)
        {
            TAI_KHOAN a = qltt.TAI_KHOANs.Where(t => t.MALOAI == ma).FirstOrDefault();
            if (a != null)//
                return 1;
            return 0;
        }

    }
}
