using Networks.Netis.Interfaces;
using Networks.Netis.MockServices;
using Networks.Netis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Networks.Netis.WebApiService.Controllers
{
    public class SitesController : ApiController
    {
        private ISitesService sitesService;

        public SitesController(ISitesService sitesService)
        {
            this.sitesService = sitesService;
        }

        public SitesController()
            : this(new MockSitesService())
        {
        }

        public List<Site> Get()
        {
            var sites = sitesService.Get();

            return sites;
        }

        public Site Get(string id)
        {
            var site = sitesService.Get(id);

            return site;

        }

        public Site GetByMachineName(string machinename)
        {
            var site = sitesService.GetByMachineName(machinename);

            return site;
        }

        [HttpPost]
        public void Add(Site site)
        {
            sitesService.Add(site);
        }

        [HttpDelete]
        public void Remove(int id)
        {
            ISitesService sitesService = new MockSitesService();

            sitesService.Remove(id);
        }
    }
}