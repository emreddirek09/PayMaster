using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayMasterProject.EntityLayer.Concrete
{
    public class ApartmentDebts
    {
        public int ApartmentDebtsID { get; set; }
        public int DebtDaireID { get; set; }
        public decimal DebtAmount { get; set; }
        public DateTime DebtDueDate { get; set; }
        public int DebtCreatedByAdminId { get; set; }
        public string DebtDescription { get; set; }
        public Daire Daire { get; set; }
        public User CreatedByAdmin { get; set; }

    }
}
