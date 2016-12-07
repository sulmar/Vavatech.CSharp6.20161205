using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Networks.Netis.Models
{
    public class SiteSearchCriteria : Base
    {
        public string Region { get; set; }

        public string Type { get; set; }

        public int Distance { get; set; }
    }
}
