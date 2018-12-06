using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinQ;
using System.Data;
namespace LinQ
{
    public class QLThu
    {
        LinQtoSQLDataContext qlt = new LinQtoSQLDataContext();
        //load grid phiếu thu
        public DataTable Load_Grid(string mang)
        {
            var kq = from pt in qlt.PHIEU_THUs
                     join hmt in qlt.HANG_MUC_THUs
                     on pt.MA_HM_THU equals hmt.MA_HM_THU
                     join tk in qlt.TAI_KHOANs
                     on pt.MATK equals tk.MATK
                     where tk.MANGUOIDUNG == mang
                     select new
                     {
                         MaPhieuThu = pt.MAPTHU,
                         TenHangMucThu = hmt.TEN_HM_THU,
                         TenTaiKhoan = tk.TENTK,
                         NgayLap = pt.NGAY_LAP,
                         SoTien = pt.TIEN,
                         ChuThich = pt.GHICHU,
                         ThuTu = pt.THU_TU_AI,
                         MaHangMucThu = pt.MA_HM_THU,
                         MaTaiKhoan = tk.MATK,
                         MaTienTe = tk.MALOAI



                     };
            var dt = new DataTable();
            dt.Columns.Add(new DataColumn("MA_PHIEU_THU"));
            dt.Columns.Add(new DataColumn("TEN_HM_THU"));
            dt.Columns.Add(new DataColumn("TEN_TAI_KHOAN"));
            dt.Columns.Add(new DataColumn("NGAY_LAP"));
            dt.Columns.Add(new DataColumn("SO_TIEN"));
            dt.Columns.Add(new DataColumn("CHU_THICH"));
            dt.Columns.Add(new DataColumn("THU_TU"));
            dt.Columns.Add(new DataColumn("MA_HM_THU"));
            dt.Columns.Add(new DataColumn("MA_TK"));
            dt.Columns.Add(new DataColumn("MA_LOAI"));
            foreach (var item in kq.ToList())
            {
                dt.LoadDataRow(new object[]
                {
                    item.MaPhieuThu,
                    item.TenHangMucThu,
                    item.TenTaiKhoan,
                    DateTime.Parse(item.NgayLap.ToString()).ToShortDateString(),
                    item.SoTien,
                    item.ChuThich,
                    item.ThuTu,
                    item.MaHangMucThu,
                    item.MaTaiKhoan,
                    item.MaTienTe
                }, true);
            }
            return dt;
        }

        //load cbo tài khoản
        public List<TAI_KHOAN> load_cb_taikhoan(string manguoidung)
        {
            return qlt.TAI_KHOANs.Where(t => t.MANGUOIDUNG == manguoidung).ToList<TAI_KHOAN>();
        }
        //load cbo hạng mục thu
        public List<HANG_MUC_THU> load_cb_hmc()
        {
            return qlt.HANG_MUC_THUs.Select(t => t).ToList<HANG_MUC_THU>();
        }
        //load cbo tiền tệ
        public List<TIEN_TE> load_cbo_tiente()
        {
            return qlt.TIEN_TEs.Select(t => t).ToList<TIEN_TE>();
        }

        // load cb hạng mục thu
        public List<HANG_MUC_THU> load_cb_cthm(int ma)
        {
            return qlt.HANG_MUC_THUs.Where(t => t.MA_HM_THU == ma).ToList<HANG_MUC_THU>();
        }
        //get tỉ giá
        public TIEN_TE get_tigia(string ma)
        {
            //var kq = from tt in qlc.TIEN_TEs where tt.MALOAI == ma select new{tt.TI_GIA};
            return qlt.TIEN_TEs.Where(t => t.MALOAI == ma).FirstOrDefault();
        }


        //thêm phiếu thu
        public int Them_PT(PHIEU_THU p)
        {
            if (KT_KhoaChinh(p.MAPTHU) == 1)
                return 1;
            qlt.PHIEU_THUs.InsertOnSubmit(p);
            update_tien_them(p);
            qlt.SubmitChanges();
            return 0;
        }
        //int kiểm tra khóa chinh
        public int KT_KhoaChinh(string ma)
        {
            PHIEU_THU p = qlt.PHIEU_THUs.Where(t => t.MAPTHU == ma).FirstOrDefault();
            if (p != null)
                return 1;
            return 0;
        }

       //cập nhật tiền khi thêm
        public void update_tien_them(PHIEU_THU p)
        {
            TAI_KHOAN tk = qlt.TAI_KHOANs.Where(t => t.MATK == p.MATK).FirstOrDefault();
            tk.SODUHT += p.TIEN;
            qlt.SubmitChanges();
        }

        //sửa
        public int Sua_PhieuThu(PHIEU_THU pc)
        {
            try
            {
                PHIEU_THU p = qlt.PHIEU_THUs.Where(t => t.MAPTHU == pc.MAPTHU).FirstOrDefault();
                p.MA_HM_THU = pc.MA_HM_THU;
                update_tien_lan2(pc.MATK, p.TIEN, pc.TIEN);
                p.TIEN = pc.TIEN;

                p.NGAY_LAP = pc.NGAY_LAP;
                p.GHICHU = pc.GHICHU;
                p.THU_TU_AI = pc.THU_TU_AI;


                qlt.SubmitChanges();
                return 0;
            }
            catch (Exception ex) { return 1; }
        }
        //update tien khi cap nhat
        public int update_tien_lan2(string matk, decimal? tiencu, decimal? tienmoi)
        {
            try
            {
                TAI_KHOAN tk = qlt.TAI_KHOANs.Where(t => t.MATK == matk).FirstOrDefault();
                tk.SODUHT = tk.SODUHT - tiencu + tienmoi;
                qlt.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            { return 0; }
        }

        //xóa phiếu chi
        public int Xoa_PhieuThu(string ma)
        {
            try
            {
                PHIEU_THU p = qlt.PHIEU_THUs.Where(t => t.MAPTHU == ma).FirstOrDefault();
                TAI_KHOAN tk = qlt.TAI_KHOANs.Where(t => t.MATK == p.MATK).FirstOrDefault();
                tk.SODUHT -= p.TIEN;
                qlt.PHIEU_THUs.DeleteOnSubmit(p);
                qlt.SubmitChanges();
                return 0;
            }
            catch (Exception ex) { return 1; }

        }
        public DataTable Load_Grid_TimKiem(string mang, DateTime ngaybd, DateTime ngaykt)
        {
            var kq = from pt in qlt.PHIEU_THUs
                     where (pt.NGAY_LAP >= ngaybd && pt.NGAY_LAP <= ngaykt)
                     join hmt in qlt.HANG_MUC_THUs
                     on pt.MA_HM_THU equals hmt.MA_HM_THU
                     join tk in qlt.TAI_KHOANs
                     on pt.MATK equals tk.MATK
                     where tk.MANGUOIDUNG == mang
                     select new
                     {
                         MaPhieuThu = pt.MAPTHU,
                         TenHangMucThu = hmt.TEN_HM_THU,
                         TenTaiKhoan = tk.TENTK,
                         NgayLap = pt.NGAY_LAP,
                         SoTien = pt.TIEN,
                         ChuThich = pt.GHICHU,
                         ThuTu = pt.THU_TU_AI,
                         MaHangMucThu = pt.MA_HM_THU,
                         MaTaiKhoan = tk.MATK,
                         MaTienTe = tk.MALOAI



                     };
            var dt = new DataTable();
            dt.Columns.Add(new DataColumn("MA_PHIEU_THU"));
            dt.Columns.Add(new DataColumn("TEN_HM_THU"));
            dt.Columns.Add(new DataColumn("TEN_TAI_KHOAN"));
            dt.Columns.Add(new DataColumn("NGAY_LAP"));
            dt.Columns.Add(new DataColumn("SO_TIEN"));
            dt.Columns.Add(new DataColumn("CHU_THICH"));
            dt.Columns.Add(new DataColumn("THU_TU"));
            dt.Columns.Add(new DataColumn("MA_HM_THU"));
            dt.Columns.Add(new DataColumn("MA_TK"));
            dt.Columns.Add(new DataColumn("MA_LOAI"));
            foreach (var item in kq.ToList())
            {
                dt.LoadDataRow(new object[]
                {
                    item.MaPhieuThu,
                    item.TenHangMucThu,
                    item.TenTaiKhoan,
                    DateTime.Parse(item.NgayLap.ToString()).ToShortDateString(),
                    item.SoTien,
                    item.ChuThich,
                    item.ThuTu,
                    item.MaHangMucThu,
                    item.MaTaiKhoan,
                    item.MaTienTe
                }, true);
            }
            return dt;
        }

        //cap nhat tong thu
       

    }
}
