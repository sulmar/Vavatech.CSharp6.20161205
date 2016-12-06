using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Networks.Netis.Models
{
    public abstract class Site : Base
    {
        public int SiteId { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }

        public string MachineName { get; set; }
    }
}
