using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinQ;
namespace LinQ
{
    public class QLLoai_TK
    {
        LinQtoSQLDataContext qlltk = new LinQtoSQLDataContext();
        public QLLoai_TK()
        { }

        //load grid
        public List<LOAI_TK> load_grid()
        {
            return qlltk.LOAI_TKs.Select(t=>t).ToList<LOAI_TK>();
        }

        public int Them_LoaiTK(LOAI_TK tk)
        {
            try
            {
                qlltk.LOAI_TKs.InsertOnSubmit(tk);
                qlltk.SubmitChanges();
                return 0;
            }
            catch (Exception ex) { return 1; }
        }

        public int Xoa_LoaiTK(int ma)
        {
            if (KT_KhoaNgoai(ma) == 1)
                return 1;// dính khóa ngoại
            LOAI_TK tk = qlltk.LOAI_TKs.Where(t => t.MA_LOAI_TK == ma).FirstOrDefault();
            qlltk.LOAI_TKs.DeleteOnSubmit(tk);
            qlltk.SubmitChanges();
            return 0;
        }
        public int KT_KhoaNgoai(int ma)
        {
            TAI_KHOAN tk = qlltk.TAI_KHOANs.Where(t => t.MA_LOAI_TK == ma).FirstOrDefault();
            if (tk != null)
                return 1;
            return 0;
        }
        public int Sua_LoaiTK(int ma, string ten)
        {
            LOAI_TK tk = qlltk.LOAI_TKs.Where(t=>t.MA_LOAI_TK == ma).FirstOrDefault();
            if(tk != null)
            {
                tk.TEN_TK = ten;
                qlltk.SubmitChanges();
                return 1;
            }
            return 0;

        }
    }
}
