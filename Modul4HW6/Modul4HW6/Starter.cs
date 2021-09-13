using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Proxies;
using Modul4HW6.DataAccess;
using Modul4HW6.Entities;
using Modul4HW6;

namespace Modul4HW6
{
    public class Starter
    {
        private AppConfigService _appConfig = new AppConfigService();

        public void Run()
        {
            var dbContext = new DbContextOptionsBuilder<ApplicationContext>();
            dbContext.UseSqlServer(_appConfig.ConnectionString);
            dbContext.UseLazyLoadingProxies();

            using (var db = new ApplicationContext(dbContext.Options))
            {
            }

            Console.WriteLine("End");
        }
    }
}
