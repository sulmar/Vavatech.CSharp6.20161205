﻿using Networks.Netis.Interfaces;
using Networks.Netis.Models;
using Networks.Netis.WebApiClient.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Networks.Netis.WebApiClient
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

        private static void GetSiteTest()
        {
            ISitesService sitesService = new WebApiSitesService();

            var site = sitesService.Get("1100");

            Console.WriteLine(site.Name);
        }

        private static void GetSitesTest()
        {
            ISitesService sitesService = new WebApiSitesService();

            var sites = sitesService.Get();

            foreach (var site in sites)
            {
                Console.WriteLine(site.Name);
            }

        }
    }
}
