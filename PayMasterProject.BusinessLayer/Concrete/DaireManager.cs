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
    public class DaireManager:IDaireService
    {
        private readonly IDaireDal _daireDal;
        public DaireManager(IDaireDal daireDal)
        {
            _daireDal = daireDal;
        }

        public void TDelete(Daire t)
        {
            _daireDal.Delete(t);
        }

        public List<Daire> TGetAll()
        {
            return _daireDal.GetAll();
        }

        public Daire TGetById(int id)
        {
            return _daireDal.GetById(id);
        }

        public void TInsert(Daire t)
        {
            _daireDal.Insert(t);
        }

        public void TUpdate(Daire t)
        {
            _daireDal.Update(t);
        }
    }
}
