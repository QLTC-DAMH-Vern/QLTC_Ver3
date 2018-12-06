using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinQ;
using System.Data;
namespace LinQ
{
    public class QLChi
    {
        LinQtoSQLDataContext qlc = new LinQtoSQLDataContext();
        
        public QLChi()
        { }
        //load cbo  loại tiền tệ
        public List<TIEN_TE> load_cbo_tiente()
        {
            return qlc.TIEN_TEs.Select(t => t).ToList<TIEN_TE>();
        }
        // load hạng mục chi
        public List<CT_HANG_MUC_CHI> load_cb_cthm(int ma)
        {
            return qlc.CT_HANG_MUC_CHIs.Where(t => t.MA_HM_CHI == ma).ToList<CT_HANG_MUC_CHI>();
        }

        public List<HANG_MUC_CHI> load_cb_hmc()
        {
            return qlc.HANG_MUC_CHIs.Select(t => t).ToList<HANG_MUC_CHI>();
        }

        public List<TAI_KHOAN> load_cb_taikhoan(string manguoidung)
        {
            return qlc.TAI_KHOANs.Where(t => t.MANGUOIDUNG == manguoidung).ToList<TAI_KHOAN>();
        }

        public TIEN_TE get_tigia(string ma)
        {
            //var kq = from tt in qlc.TIEN_TEs where tt.MALOAI == ma select new{tt.TI_GIA};
            return qlc.TIEN_TEs.Where(t => t.MALOAI == ma).FirstOrDefault();
        }

        //thêm
        public int Them_PhieuChi(PHIEU_CHI p)
        {
            try {
                if (KT_KhoaChinh(p.MA_PCHI) == 1)
                    return 0;
                qlc.PHIEU_CHIs.InsertOnSubmit(p);
                qlc.SubmitChanges();
                return 1;
            }
            catch (Exception ex) { return 0; }
        }

        //kiem tra khoa chinh
        public int KT_KhoaChinh(string ma)
        {
            PHIEU_CHI p = qlc.PHIEU_CHIs.Where(t => t.MA_PCHI == ma).FirstOrDefault();
            if (p != null)
                return 1;
            return 0;
        }

        public List<PHIEU_CHI> load_grid()
        {
            return qlc.PHIEU_CHIs.Select(t => t).ToList<PHIEU_CHI>();
        }

        // cập nhật tiền
        public int update_tien(string matk, decimal tien)
        {
            try
            {
                TAI_KHOAN tk = qlc.TAI_KHOANs.Where(t => t.MATK == matk).FirstOrDefault();
                tk.SODUHT = tk.SODUHT - tien;
                qlc.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            { return 0; }
        }


        //load grid 
        public DataTable Load_Grid(string mang)
        {
            var kq = from pc in qlc.PHIEU_CHIs
                     join cthm in qlc.CT_HANG_MUC_CHIs
                     on pc.MA_CTHM_CHI equals cthm.MA_CTHM_CHI
                     join hm in qlc.HANG_MUC_CHIs
                     on cthm.MA_HM_CHI equals hm.MA_HM_CHI
                     join tk in qlc.TAI_KHOANs 
                     on pc.MATK equals tk.MATK
                     where tk.MANGUOIDUNG == mang
                     select new
                     {
                         MaPhieuChi = pc.MA_PCHI,
                         TenHangMucChi = cthm.TEN_CTHM_CHI,
                         TenTaiKhoan = tk.TENTK,
                         NgayLap = pc.NGAY_LAP,
                         SoTien = pc.SO_TIEN,
                         ChuThich = pc.CHU_THICH,
                         ChiCho = pc.CHI_CHO_AI,
                         MaHangMucChi = cthm.MA_CTHM_CHI,
                         MaTaiKhoan = tk.MATK,
                         MaHMChi = hm.MA_HM_CHI,
                         MaTienTe = tk.MALOAI
                         


                     };
            var dt = new DataTable();
            dt.Columns.Add(new DataColumn("MA_PHIEU_CHI"));
            dt.Columns.Add(new DataColumn("TEN_HM_CHI"));
            dt.Columns.Add(new DataColumn("TEN_TAI_KHOAN"));
            dt.Columns.Add(new DataColumn("NGAY_LAP"));
            dt.Columns.Add(new DataColumn("SO_TIEN"));
            dt.Columns.Add(new DataColumn("CHU_THICH"));
            dt.Columns.Add(new DataColumn("CHI_CHO"));
            dt.Columns.Add(new DataColumn("MA_CTHM_CHI"));
            dt.Columns.Add(new DataColumn("MA_TK"));
            dt.Columns.Add(new DataColumn("MA_HM_CHI"));
            dt.Columns.Add(new DataColumn("MA_LOAI"));
            foreach (var item in kq.ToList())
            {
                dt.LoadDataRow(new object[]
                {
                    item.MaPhieuChi,
                    item.TenHangMucChi,
                    item.TenTaiKhoan,
                    DateTime.Parse(item.NgayLap.ToString()).ToShortDateString(),
                    item.SoTien,
                    item.ChuThich,
                    item.ChiCho,
                    item.MaHangMucChi,
                    item.MaTaiKhoan,
                    item.MaHMChi,
                    item.MaTienTe
                }, true);
            }
            return dt;
        }

        //sửa
        public int Sua_PhieuChi(string ma, PHIEU_CHI pc)
        {
            PHIEU_CHI p = qlc.PHIEU_CHIs.Where(t => t.MA_PCHI == ma).FirstOrDefault();
            p.MA_CTHM_CHI = pc.MA_CTHM_CHI;
            update_tien_lan2(pc.MATK, p.SO_TIEN, pc.SO_TIEN);
            p.SO_TIEN = pc.SO_TIEN;
           
            p.NGAY_LAP = pc.NGAY_LAP;
            p.CHU_THICH = pc.CHU_THICH;
            p.CHI_CHO_AI = pc.CHI_CHO_AI;
            
            
            qlc.SubmitChanges();
            return 0;
        }
        //câp nhật khi sửa
        public int update_tien_lan2(string matk, decimal? tiencu, decimal? tienmoi)
        {
            try
            {
                TAI_KHOAN tk = qlc.TAI_KHOANs.Where(t => t.MATK == matk).FirstOrDefault();
                tk.SODUHT = tk.SODUHT + tiencu -tienmoi;
                qlc.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            { return 0; }
        }

        //xóa phiếu chi
        public int Xoa_PhieuChi(string ma)
        {
            try
            {
                PHIEU_CHI p = qlc.PHIEU_CHIs.Where(t => t.MA_PCHI == ma).FirstOrDefault();
                TAI_KHOAN tk = qlc.TAI_KHOANs.Where(t => t.MATK == p.MATK).FirstOrDefault();
                tk.SODUHT += p.SO_TIEN;
                qlc.PHIEU_CHIs.DeleteOnSubmit(p);
                qlc.SubmitChanges();
                return 0;
            }
            catch (Exception ex) { return 1; }

        }

        //tìm kiếm
        public List<PHIEU_CHI> Load_TimKiem(DateTime ngaybd, DateTime ngaykt)
        {
            return qlc.PHIEU_CHIs.Where(t => t.NGAY_LAP >= ngaybd && t.NGAY_LAP <= ngaykt).ToList<PHIEU_CHI>();
        }
        public DataTable Load_Grid_TimKiem(string mang, DateTime ngaybd, DateTime ngaykt)
        {
            var kq = from pc in qlc.PHIEU_CHIs where( pc.NGAY_LAP >=ngaybd && pc.NGAY_LAP<=ngaykt)
                     join cthm in qlc.CT_HANG_MUC_CHIs
                     on pc.MA_CTHM_CHI equals cthm.MA_CTHM_CHI
                     join hm in qlc.HANG_MUC_CHIs
                     on cthm.MA_HM_CHI equals hm.MA_HM_CHI
                     join tk in qlc.TAI_KHOANs
                     on pc.MATK equals tk.MATK
                     where tk.MANGUOIDUNG == mang
                    
                     select new
                     {
                         MaPhieuChi = pc.MA_PCHI,
                         TenHangMucChi = cthm.TEN_CTHM_CHI,
                         TenTaiKhoan = tk.TENTK,
                         NgayLap = pc.NGAY_LAP,
                         SoTien = pc.SO_TIEN,
                         ChuThich = pc.CHU_THICH,
                         ChiCho = pc.CHI_CHO_AI,
                         MaHangMucChi = cthm.MA_CTHM_CHI,
                         MaTaiKhoan = tk.MATK,
                         MaHMChi = hm.MA_HM_CHI,
                         MaTienTe = tk.MALOAI



                     };
            var dt = new DataTable();
            dt.Columns.Add(new DataColumn("MA_PHIEU_CHI"));
            dt.Columns.Add(new DataColumn("TEN_HM_CHI"));
            dt.Columns.Add(new DataColumn("TEN_TAI_KHOAN"));
            dt.Columns.Add(new DataColumn("NGAY_LAP"));
            dt.Columns.Add(new DataColumn("SO_TIEN"));
            dt.Columns.Add(new DataColumn("CHU_THICH"));
            dt.Columns.Add(new DataColumn("CHI_CHO"));
            dt.Columns.Add(new DataColumn("MA_CTHM_CHI"));
            dt.Columns.Add(new DataColumn("MA_TK"));
            dt.Columns.Add(new DataColumn("MA_HM_CHI"));
            dt.Columns.Add(new DataColumn("MA_LOAI"));
            foreach (var item in kq.ToList())
            {
                dt.LoadDataRow(new object[]
                {
                    item.MaPhieuChi,
                    item.TenHangMucChi,
                    item.TenTaiKhoan,
                    item.NgayLap,item.SoTien,
                    item.ChuThich,
                    item.ChiCho,
                    item.MaHangMucChi,
                    item.MaTaiKhoan,
                    item.MaHMChi,
                    item.MaTienTe
                }, true);
            }
            return dt;
        }
    }
}
