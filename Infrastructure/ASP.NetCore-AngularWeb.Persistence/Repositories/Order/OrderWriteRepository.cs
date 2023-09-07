﻿using ASP.NetCore_AngularWeb.Application.Repositories;
using ASP.NetCore_AngularWeb.Domain.Entities;
using ASP.NetCore_AngularWeb.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NetCore_AngularWeb.Persistence.Repositories
{
    public class OrderWriteRepository : WriteRepository<Order>, IOrderWriteRepository
    {
        public OrderWriteRepository(EmarketingContextDb_ context) : base(context)
        {
        }
    }
}
