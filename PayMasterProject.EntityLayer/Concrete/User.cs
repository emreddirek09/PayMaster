using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayMasterProject.EntityLayer.Concrete
{
    public class User : IdentityUser<int>
    { 
        public string UserFullName { get; set; }
        public int Role { get; set; }
        public Daire Daire { get; set; }
        public ICollection<ApartmentDebts> CreatedBorclar { get; set; }

    }
}
