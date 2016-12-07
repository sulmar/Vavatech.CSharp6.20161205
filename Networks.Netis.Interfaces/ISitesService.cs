using Networks.Netis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Networks.Netis.Interfaces
{
    public interface ISitesService
    {

        List<Site> Get();

        Site Get(string code);

        Site GetByMachineName(string machineName);


        void Add(Site site);

        void Update(Site site);

        void Remove(int siteId);


    }
}
