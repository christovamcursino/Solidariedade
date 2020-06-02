using Microsoft.EntityFrameworkCore;
using Solidariedade.Domain.Entities;
using Solidariedade.Domain.Entities.Donator;
using Solidariedade.Domain.Entities.Donee;
using Solidariedade.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solidariedade.DataAccess.Repositories
{
    public class ProductSqlRepository : RepositorySqlBase<Guid, Product>, IProductRepository
    {
        public ProductSqlRepository(DbContext context) : base(context) { }
    }
}
