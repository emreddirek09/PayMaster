using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayMasterProject.EntityLayer.Concrete
{
    public class Daire
    {
        public int DaireID { get; set; }
        public int DaireBlockID { get; set; }
        public int DaireFloorNumber { get; set; }
        public int DaireApartmentNumber { get; set; }
        public int BlockId { get; set; }
        public Block Block { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public ICollection<ApartmentDebts> Debts { get; set; }

    }
}
