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
            var site = _Sites.Where(s => s.Code == code).SingleOrDefault();

            return site;
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

        public List<Site> GetSites(string machineName)
        {
            var expression = _Sites
                .Where(site => site.MachineName.StartsWith(machineName))
                .OrderByDescending(s => s.Code);
            //  .Select( s => new { Kod = s.Code, Nazwa = s.Name})


            var query3 = _Sites
                .Where(s => s.Region.Name == "WAR")
                .OrderBy(s => s.Code)
                .ToList();


            var query = from s in _Sites
                        where s.MachineName.StartsWith(machineName)
                        orderby s.Code descending
                        select s;

            var query2 = from s in _Sites
                        where s.Region.Name == "WAR"
                        orderby s.Code descending
                        select s;



            var sites = expression.ToList();
           
            return sites;
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
