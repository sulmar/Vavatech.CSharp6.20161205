using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Networks.Netis.Models
{
    [XmlInclude(typeof(Site2G))]
    public abstract class Site : Base
    {
        public int SiteId { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }

        public string MachineName { get; set; }
    }
}
