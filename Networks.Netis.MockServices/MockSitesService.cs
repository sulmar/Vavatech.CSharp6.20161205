using Networks.Netis.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Networks.Netis.Models;

namespace Networks.Netis.MockServices
{
    public class MockSitesService : ISitesService
    {
        private static List<Site> _Sites = new List<Site>
        {
            new Site { SiteId = 1, Code = "1100", Name = "Olesinska 2G", MachineName = "BTS 1100" },
            new Site { SiteId = 2, Code = "1200", Name = "Dworzec Centralny 2G", MachineName = "BTS 1200" },
            new Site { SiteId = 3, Code = "1400", Name = "Palac Kultury", MachineName = "BTS 1400" },
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

        public Site GetByMachineName(string machineName)
        {

            foreach (var site in _Sites)
            {
                if (site.MachineName == machineName)
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
