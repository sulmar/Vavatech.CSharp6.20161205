﻿using Networks.Netis.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Networks.Netis.Models;

namespace Networks.Netis.XmlWebServiceClient.Services
{
    class XmlWebServiceSitesService : ISitesService
    {
        public void Add(Site site)
        {
            localhost.NetisService service = new localhost.NetisService();

            var dtoSite = Map(site);

            service.AddSite(dtoSite);

        }

        public List<Site> Get()
        {
            localhost.NetisService service = new localhost.NetisService();

            var dtoSites = service.GetSites();

            var sites = new List<Site>();

            foreach (var dtoSite in dtoSites)
            {
                sites.Add(Map(dtoSite));
            }

            return sites.ToList();
        }

        /// <summary>
        /// Konwersja DTO -> Model
        /// </summary>
        /// <param name="dtoSite"></param>
        /// <returns></returns>
        private Site Map(localhost.Site dtoSite)
        {
            var site = new Site
            {
                SiteId = dtoSite.SiteId,
                Code = dtoSite.Code,
                MachineName = dtoSite.MachineName,
                Name = dtoSite.Name,
            };

            return site;
        }

        private localhost.Site Map(Site site)
        {
            var sitedtoSite = new localhost.Site
            {
                SiteId = site.SiteId,
                Code = site.Code,
                MachineName = site.MachineName,
                Name = site.Name,
            };

            return sitedtoSite;

        }

        public Site Get(string code)
        {
            localhost.NetisService service = new localhost.NetisService();

            var dtoSite = service.GetSite(code);

            var site = Map(dtoSite);

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
