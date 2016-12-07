using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Networks.Netis.Interfaces;
using Networks.Netis.MockServices;

namespace Networks.Netis.UnitTests
{
    [TestClass]
    public class SitesServiceUnitTest
    {
        [TestMethod]
        public void GetSitesTest()
        {

            var machineName = "BTS";

            ISitesService sitesService = new MockSitesService();

            var sites = sitesService.GetSites(machineName);

            Assert.IsNotNull(sites);

        }


        [TestMethod]
        public void GetTest()
        {
            ISitesService sitesService = new MockSitesService();

            var sites = sitesService.Get();

            Assert.IsNotNull(sites);

        }

        [TestMethod]
        public void GetByCodeTest()
        {
            var code = "1100";

            ISitesService sitesService = new MockSitesService();

            var site = sitesService.Get(code);

            Assert.IsNotNull(site);

            Assert.AreEqual(code, site.Code);

        }

        [TestMethod]
        public void GetByCode2Test()
        {
            var code = "1200";

            ISitesService sitesService = new MockSitesService();

            var site = sitesService.Get(code);

            Assert.IsNotNull(site);

            Assert.AreEqual(code, site.Code);

        }


        [TestMethod]
        public void GetByCodeNotFoundTest()
        {
            var code = "9999";

            ISitesService sitesService = new MockSitesService();

            var site = sitesService.Get(code);

            Assert.IsNull(site);
        }

    }
}
