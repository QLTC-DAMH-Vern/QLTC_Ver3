using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DatasetDALTableAdapters;
using System.Data;
namespace DAL
{
    public class KhoanThuDAL
    {
        HANG_MUC_THUTableAdapter hmthu = new HANG_MUC_THUTableAdapter();
        public KhoanThuDAL()
        { }


        //load grid hạng mục thu
        public DataTable _load_grid_hmthu()
        {
           return hmthu.GetData();
        }
        //lấy mã max
        public int _get_mahm_max()
        {
            return (int)hmthu._get_mahmthu_max();
        }

        //thêm hạng mục thu
        public int _them_hmthu(int ma, string ten, string gc)
        {
            return hmthu._insert_hmthu(ma, ten, gc);
        }
        //sửa hạng mục thu
        public int _sua_hmthu(string ten,string gc,int ma)
        {
            return hmthu._update_hmthu(ten, gc, ma);
        }
        //xóa hạng mục thu
        public int _xoa_hmthu(int ma)
        {
            if (hmthu._kt_khoangoai_hmthu(ma) > 0)
                return 0;
            return hmthu._delete_hmthu(ma);
        }
        //kiểm tra khóa ngoại
        public int _kt_khoangoai(int ma)
        {
            return (int)hmthu._kt_khoangoai_hmthu(ma);
        }

    }
}
