﻿using ASP.NetCore_AngularWeb.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NetCore_AngularWeb.Persistence
{
    public static class ServiceRegistration 
    {
        public static void AddPersistenceRegistration(this IServiceCollection services)
        {
            services.AddDbContext<EmarketingContextDb_>(options => options.UseSqlServer("data source=localhost ; initial catalog =DbEmarketingData ; integrated security = true ;"));
        }
    }
}
