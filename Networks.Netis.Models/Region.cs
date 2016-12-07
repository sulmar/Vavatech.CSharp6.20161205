using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Networks.Netis.Models
{
    public class Region : Base
    {
        public int RegionId { get; set; }

        public string Name { get; set; }


        public List<Site> Sites { get; set; }
    }
}
