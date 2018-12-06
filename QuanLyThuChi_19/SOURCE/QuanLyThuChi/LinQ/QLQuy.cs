using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinQ;
namespace LinQ
{
    public class QLQuy
    {
        LinQtoSQLDataContext qlq = new LinQtoSQLDataContext();
        public QLQuy()
        { }
        
        //load cbo  loại tiền tệ
        public List<TIEN_TE> load_cbo_tiente()
        {
            return qlq.TIEN_TEs.Select(t => t).ToList<TIEN_TE>();
        }
        //load cbo loại tài khoản
        public List<TAI_KHOAN> load_grid(string manguoidung)
        {
            var lst = (from tk in qlq.TAI_KHOANs where tk.MANGUOIDUNG == manguoidung
                       join tt in qlq.TIEN_TEs on tk.MALOAI equals tt.MALOAI
                       join ltk in qlq.LOAI_TKs on tk.MA_LOAI_TK equals ltk.MA_LOAI_TK
                       select new { tk.MATK, tk.MALOAI, tk.MANGUOIDUNG, tk.TENTK, tk.SODUBD, tk.SODUHT, tk.TRANGTHAI, tk.DIENGIAI, tk.MA_LOAI_TK }
                           ).Distinct();
            var kq = lst.ToList().ConvertAll(t => new TAI_KHOAN()
                {
                    MATK = t.MATK,
                    MALOAI = t.MALOAI,
                    MANGUOIDUNG = t.MANGUOIDUNG,
                    TENTK = t.TENTK,
                    SODUBD = t.SODUBD,
                    SODUHT = t.SODUHT,
                    TRANGTHAI = t.TRANGTHAI,
                    DIENGIAI = t.DIENGIAI,
                    MA_LOAI_TK = t.MA_LOAI_TK
            
                });
            return kq.ToList<TAI_KHOAN>();
        }
        //load grid tài khoản
        public List<LOAI_TK> load_cbo_loaitk()
        {
            return qlq.LOAI_TKs.Select(t => t).ToList<LOAI_TK>();
        }

        // kiểm tra trùng khóa chính
        public int KT_KhoaChinh(string ma)
        {
            TAI_KHOAN tk = qlq.TAI_KHOANs.Where(t => t.MATK == ma).FirstOrDefault();
            if (tk != null)
                return 1;// trùng mã
            return 0;
        }

        public int Them_TK(TAI_KHOAN tk)
        {
            try 
            {
                qlq.TAI_KHOANs.InsertOnSubmit(tk);
                qlq.SubmitChanges();
                return 0;
            }
            catch (Exception ex) { return 1; }
        }

        //xóa tài khoản
        public int Xoa_Tk(string ma)
        {
            TAI_KHOAN tk = qlq.TAI_KHOANs.Where(t=>t.MATK == ma).FirstOrDefault();
            if (KT_KhoaNgoai(ma) == 1)
                return 1;
            try 
            {
                qlq.TAI_KHOANs.DeleteOnSubmit(tk);
                qlq.SubmitChanges();
                return 0;
            }
            catch (Exception ex)
            { return 1; }
        }


        //kiểm tra khóa ngoại
        public int KT_KhoaNgoai(string matk)
        {
            PHIEU_CHI pc = qlq.PHIEU_CHIs.Where(t => t.MATK == matk).FirstOrDefault();
            PHIEU_THU pt = qlq.PHIEU_THUs.Where(t => t.MATK == matk).FirstOrDefault();
            if (pc != null || pt != null)
                return 1;
            return 0;

        }

        // cập nhật tài khoản


        public int Sua_TK(string ma, string ten, string maloai, int maloaitk, decimal sodubd, string chuthich)
        {
            TAI_KHOAN tk = qlq.TAI_KHOANs.Where(t => t.MATK == ma).FirstOrDefault();

            tk.MATK = ma;
            tk.TENTK = ten;
            tk.MALOAI = maloai;
            tk.MA_LOAI_TK = maloaitk;
            tk.SODUBD = sodubd;
            tk.SODUHT = sodubd + TienThu(ma) - TienChi(ma);
            tk.DIENGIAI = chuthich;
            qlq.SubmitChanges();
            return 0;
          
        }
        //cap nhat số tiền thu
        public decimal TienThu(string ma) 
        {
            decimal? pt = qlq.PHIEU_THUs.Where(t => t.MATK == ma).Sum(t => t.TIEN);
            if (pt == null)
                return 0;
            return (decimal)pt;
        }
        //cap nhat số tiền chi
        public decimal TienChi(string ma)
        {
            decimal? pc = qlq.PHIEU_CHIs.Where(t => t.MATK == ma).Sum(t => t.SO_TIEN);
            if (pc == null)
                return 0;
            return (decimal)pc;
        }

        
    }
}
