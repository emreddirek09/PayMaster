using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayMasterProject.EntityLayer.Concrete
{
    public class Block
    {
        public int BlockID { get; set; }
        public string BlockName { get; set; }
        public int BlockSiteID { get; set; }
        public int BlockNumberOfFloors { get; set; }
        public int SiteID { get; set; }
        public Site Site { get; set; }
        public List<Daire> Daires { get; set; }
    }
}
