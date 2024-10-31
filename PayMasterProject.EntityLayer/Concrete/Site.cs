using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayMasterProject.EntityLayer.Concrete
{
    public class Site
    {
        public int SiteID { get; set; }
        public string SiteName { get; set; }
        public string SiteAddress { get; set; }
        public bool SiteIsApartment { get; set; }
    }
}
