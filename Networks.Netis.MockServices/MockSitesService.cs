using Networks.Netis.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Networks.Netis.Models;

namespace Networks.Netis.MockServices
{
    public class MockSitesService : ISitesService
    {
        private static List<Site> _Sites = new List<Site>
        {
            new Site2G { SiteId = 1, Code = "1100", Name = "Olesińska 2G", MachineName = "BTS 1100" },
            new Site2G { SiteId = 2, Code = "1200", Name = "Dworzec Centralny 2G", MachineName = "BTS 1200" },
            new Site2G { SiteId = 3, Code = "1400", Name = "Pałac Kultury", MachineName = "BTS 1400" },
        };

        public void Add(Site site)
        {
            _Sites.Add(site);
        }

        public List<Site> Get()
        {
            return _Sites;
        }

        public Site Get(string code)
        {
            foreach (var site in _Sites)
            {
                if (site.Code == code)
                {
                    return site;
                }
            }

            return null;
        }

        public void Remove(int siteId)
        {
            throw new NotImplementedException();
        }

        public void Update(Site site)
        {
            throw new NotImplementedException();
        }
    }
}
