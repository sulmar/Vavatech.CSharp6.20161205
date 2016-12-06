using Networks.Netis.Interfaces;
using Networks.Netis.MockServices;
using Networks.Netis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml.Serialization;

namespace Networks.Netis.XmlWebService
{
    /// <summary>
    /// Summary description for NetisService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class NetisService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string Hello(string code)
        {
            return $"Hello {code} !";
        }


        [WebMethod]
        public List<Site> GetSites()
        {
            ISitesService sitesService = new MockSitesService();

            var sites = sitesService.Get();

            return sites;
        }

        [WebMethod]
        public Site GetSite(string code)
        {
            ISitesService sitesService = new MockSitesService();

            var site = sitesService.Get(code);

            return site;
        }

        [WebMethod]
        public void AddSite(Site site)
        {
            ISitesService sitesService = new MockSitesService();

            sitesService.Add(site);
        }
    }
}
