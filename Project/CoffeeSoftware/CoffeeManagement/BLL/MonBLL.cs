using CoffeeManagement.DAL;
using System.Collections.Generic;
using System.Linq;

namespace CoffeeManagement.BLL
{
    public class MonBLL
    {
        CoffeeDBDataContext dbContext = new CoffeeDBDataContext();

        public IEnumerable<MON> LayDanhSachMon()
        {
            IEnumerable<MON> query = from m in dbContext.MONs select m;
            return query;
        }

        public void ThemMonMoi(MON _mon)
        {
            dbContext.MONs.InsertOnSubmit(_mon);
            dbContext.SubmitChanges();
        }

        public bool KiemTraTenMonTonTai(string _tenMon, int id = -1)
        {
            IEnumerable<MON> query = from m in dbContext.MONs
                                     where m.Ten_Mon == _tenMon
                                     select m;
            if (query.Count() >= 1)
                return true;
            if (id != -1)
            {
                query = query.Where(m => m.ID_Mon == id);
                if (query.Count() == 1)
                {
                    return false;
                }
            }
            return false;
        }

        public void CapNhatMon(MON m)
        {
            MON _mon = dbContext.MONs.Single<MON>(x => x.ID_Mon == m.ID_Mon);
            _mon.Ten_Mon = m.Ten_Mon;
            _mon.Hinh_Anh = m.Hinh_Anh;            
            _mon.LOAI_MON = dbContext.LOAI_MONs.Single<LOAI_MON>(l => l.ID_Loai_Mon == m.ID_Loai_Mon);
            // update 
            dbContext.SubmitChanges();
        }

        public void XoaMon(int _MonID)
        {
            MON _Mon = dbContext.MONs.Single<MON>(x => x.ID_Mon == _MonID);
            dbContext.MONs.DeleteOnSubmit(_Mon);

            dbContext.SubmitChanges();
        }

    }
}
