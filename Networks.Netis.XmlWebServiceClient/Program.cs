using Networks.Netis.Interfaces;
using Networks.Netis.XmlWebServiceClient.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Networks.Netis.XmlWebServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {

            GetSitesTest();

            GetSiteTest();


            Console.WriteLine("Press any key to exit.");


            Console.ReadKey();
        }

        private static void GetSitesTest()
        {
            ISitesService sitesService = new XmlWebServiceSitesService();

            var sites = sitesService.Get();

            foreach (var site in sites)
            {
                Console.WriteLine(site.Code);
            }
        }

        private static void GetSiteTest()
        {
            Console.WriteLine("Podaj kod stacji");

            var code = Console.ReadLine();

            ISitesService sitesService = new XmlWebServiceSitesService();

            var site = sitesService.Get(code);

            if (site!=null)
            {
                Console.WriteLine($"Znaleziono stację {site.Name}");
            }
            else
            {
                Console.WriteLine("Stacja nieznaleziona");
            }


        }

    }
}
