using CoffeeManagement.DAL;
using System.Collections.Generic;
using System.Linq;

namespace CoffeeManagement.BLL
{
    public class LoaiMonBLL
    {
        CoffeeDBDataContext dbContext = new CoffeeDBDataContext();

        public IEnumerable<LOAI_MON> LayDanhSachLoaiMon()
        {
            IEnumerable<LOAI_MON> query = from l in dbContext.LOAI_MONs select l;
            return query;
        }

        public void ThemLoaiMonMoi(string _tenLoaiMon)
        {
            LOAI_MON l = new LOAI_MON();
            l.Ten_Loai_Mon = _tenLoaiMon;
            dbContext.LOAI_MONs.InsertOnSubmit(l);
            dbContext.SubmitChanges();
        }

        public bool KiemTraTenLoaiMonTonTai(string _tenLoaiMon)
        {
            IEnumerable<LOAI_MON> query = from l in dbContext.LOAI_MONs where l.Ten_Loai_Mon == _tenLoaiMon select l;
            if (query.Count() == 0)
                return false;
            return true;
        }

        public void CapNhatLoaiMon(LOAI_MON l)
        {
            LOAI_MON _loaiMon = dbContext.LOAI_MONs.Single<LOAI_MON>(x => x.ID_Loai_Mon == l.ID_Loai_Mon);
            _loaiMon.Ten_Loai_Mon = l.Ten_Loai_Mon;
            // update 
            dbContext.SubmitChanges();
        }

        public void XoaLoaiMon(int _loaiMonID)
        {
            LOAI_MON _loaiMon = dbContext.LOAI_MONs.Single<LOAI_MON>(x => x.ID_Loai_Mon == _loaiMonID);
            dbContext.LOAI_MONs.DeleteOnSubmit(_loaiMon);

            dbContext.SubmitChanges();
        }
    }
}
