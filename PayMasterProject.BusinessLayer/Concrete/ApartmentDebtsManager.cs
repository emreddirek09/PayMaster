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
    public class ApartmentDebtsManager : IApartmentDebtsService
    {
        private readonly IApartmentDebtsDal _apartmentDebtsDal;

        public ApartmentDebtsManager(IApartmentDebtsDal apartmentDebtsDal)
        {
            _apartmentDebtsDal = apartmentDebtsDal;
        }

        public void TDelete(ApartmentDebts t)
        {
            _apartmentDebtsDal.Delete(t);
        }

        public List<ApartmentDebts> TGetAll()
        {
            return _apartmentDebtsDal.GetAll();

        }

        public ApartmentDebts TGetById(int id)
        {
            return _apartmentDebtsDal.GetById(id);
        }

        public void TInsert(ApartmentDebts t)
        {
            _apartmentDebtsDal.Insert(t);
        }

        public void TUpdate(ApartmentDebts t)
        {
            _apartmentDebtsDal.Update(t);
        }
    }
}
