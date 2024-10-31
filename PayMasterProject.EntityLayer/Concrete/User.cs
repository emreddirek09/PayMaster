using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayMasterProject.EntityLayer.Concrete
{
    public class User
    {
        public int UserID { get; set; }
        public int UserDaireID { get; set; }
        public string UserFullName { get; set; }
        public string UserEmail { get; set; }
        public string UserPhoneNumber { get; set; }
        public int Role { get; set; }
    }
}
