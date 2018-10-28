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

    }
}
