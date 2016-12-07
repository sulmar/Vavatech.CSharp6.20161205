using Networks.Netis.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Networks.Netis.Models;
using System.Net.Http;
using System.Web;

namespace Networks.Netis.WebApiClient.Services
{
    class WebApiSitesService : ISitesService
    {
        private string baseUri = "http://localhost:61876";

        public WebApiSitesService()
        {

        }

        public WebApiSitesService(string baseUri)
            : this()
        {
            this.baseUri = baseUri;
        }

        public void Add(Site site)
        {
            var client = new HttpClient();

            string request = $"{baseUri}/api/sites";

            var response = client.PostAsJsonAsync(request, site).Result;


        }

        public List<Site> Get()
        {
            var client = new HttpClient();

            string request = $"{baseUri}/api/sites";

            var response = client.GetAsync(request).Result;

            var sites = response.Content.ReadAsAsync<List<Site>>().Result;

            return sites;
        }

        public Site Get(string code)
        {
            var client = new HttpClient();

            string request = $"{baseUri}/api/sites/{code}";

            var response = client.GetAsync(request).Result;

            var site = response.Content.ReadAsAsync<Site>().Result;

            return site;
        }

        public Site GetByMachineName(string machineName)
        {
            var client = new HttpClient();

            string request = $"{baseUri}/api/sites?machinename={machineName}";

            var response = client.GetAsync(request).Result;

            var site = response.Content.ReadAsAsync<Site>().Result;

            return site;
        }

        public void Remove(int siteId)
        {
            var client = new HttpClient();

            string request = $"{baseUri}/api/sites/{siteId}";

            var response = client.DeleteAsync(request).Result;

        }

        public void Update(Site site) 
        {
            var client = new HttpClient();

            string request = $"{baseUri}/api/sites/{site.SiteId}";

            var response = client.PutAsJsonAsync(request, site).Result;
        }
    }
}
