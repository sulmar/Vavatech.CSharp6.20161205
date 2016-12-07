using Networks.Netis.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Networks.Netis.Models;
using AutoMapper;

namespace Networks.Netis.XmlWebServiceClient.Services
{
    class XmlWebServiceSitesService : ISitesService
    {
        public XmlWebServiceSitesService()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<localhost.Site, Site>().ReverseMap();
            });
        }

        public void Add(Site site)
        {
            localhost.NetisService service = new localhost.NetisService();

            var dtoSite = Mapper.Map<Site, localhost.Site>(site);

            service.AddSite(dtoSite);

        }

        public List<Site> Get()
        {
            localhost.NetisService service = new localhost.NetisService();

            var dtoSites = service.GetSites();

            var sites = Mapper.Map<IEnumerable<localhost.Site>, IEnumerable<Site>>(dtoSites);

            return sites.ToList();
        }

        public Site Get(string code)
        {
            localhost.NetisService service = new localhost.NetisService();

            var dtoSite = service.GetSite(code);

            var site = Mapper.Map<localhost.Site, Site>(dtoSite);

            return site;
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
