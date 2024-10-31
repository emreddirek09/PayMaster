using PayMasterProject.BusinessLayer.Abstract;
using PayMasterProject.DataAccessLayer.Abstract;
using PayMasterProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayMasterProject.BusinessLayer.Concrete
{
    public class SiteManager:ISiteService
    {
        private readonly ISiteDal _siteDal;

        public SiteManager(ISiteDal siteDal)
        {
            _siteDal = siteDal;
        }

        public void TDelete(Site t)
        {
            _siteDal.Delete(t);
        }

        public List<Site> TGetAll()
        {
            return _siteDal.GetAll();
        }

        public Site TGetById(int id)
        {
            return _siteDal.GetById(id);
        }

        public void TInsert(Site t)
        {
            _siteDal.Insert(t);
        }

        public void TUpdate(Site t)
        {
            _siteDal.Update(t);
        }
    }
}
