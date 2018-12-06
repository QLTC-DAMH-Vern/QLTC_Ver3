using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
namespace BLL
{
    public class KhoanThuBLL
    {
        KhoanThuDAL hmthu = new KhoanThuDAL();
        public KhoanThuBLL()
        { }

        //load grid hạng mục
        public DataTable Load_Grid_HM()
        {
             return hmthu._load_grid_hmthu();
        }

        //lấy mã max
        public int Get_MaHM()
        {
            return hmthu._get_mahm_max();
        }

        //thêm
        public int Them_HMThu(int ma, string ten, string gc)
        {
            return hmthu._them_hmthu(ma, ten, gc);
        }

        //xoa
        public int Xoa_HMThu(int ma)
        {
            return hmthu._xoa_hmthu(ma);
        }
        //sua
        public int Sua_HMThu(int ma, string ten, string gc)
        {
            return hmthu._sua_hmthu(ten, gc, ma);
        }

        

        
    }
}
