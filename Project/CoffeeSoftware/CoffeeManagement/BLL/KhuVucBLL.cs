using CoffeeManagement.DAL;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CoffeeManagement.BLL
{
    public class KhuVucBLL
    {
        CoffeeDBDataContext dbContext = new CoffeeDBDataContext();

        public IEnumerable<KHU_VUC> LayDanhSachKhuVuc()
        { 
            IEnumerable <KHU_VUC> query = from kv in dbContext.KHU_VUCs select kv;
            return query;
        }

        public void ThemKhuVucMoi(string _tenKhuVuc)
        {            
            KHU_VUC kv = new KHU_VUC();
            kv.Ten_Khu_Vuc = _tenKhuVuc;
            dbContext.KHU_VUCs.InsertOnSubmit(kv);
            dbContext.SubmitChanges();            
        }

        public bool KiemTraTenKhuVucTonTai(string _tenKhuVuc)
        {
            IEnumerable<KHU_VUC> query = from kv in dbContext.KHU_VUCs where kv.Ten_Khu_Vuc == _tenKhuVuc select kv;
            if (query.Count() == 0)
                return false;   
            return true;
        }

        public void CapNhatKhuVuc(KHU_VUC kv)
        {
            KHU_VUC _khuVuc = dbContext.KHU_VUCs.Single<KHU_VUC>(x => x.ID_Khu_Vuc == kv.ID_Khu_Vuc);
            _khuVuc.Ten_Khu_Vuc = kv.Ten_Khu_Vuc;
            // update 
            dbContext.SubmitChanges();
        }

        public void XoaKhuVuc(int _khuVucID)
        {
            KHU_VUC _khuVuc = dbContext.KHU_VUCs.Single<KHU_VUC>(x => x.ID_Khu_Vuc == _khuVucID);
            dbContext.KHU_VUCs.DeleteOnSubmit(_khuVuc);

            dbContext.SubmitChanges();
        }
    }
}
