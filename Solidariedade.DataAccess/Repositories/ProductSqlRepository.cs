using Microsoft.EntityFrameworkCore;
using Solidariedade.Domain.Entities;
using Solidariedade.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Solidariedade.DataAccess.Repositories
{
    public class ProductSqlRepository : RepositorySqlBase<Guid, Product>, IProductRepository
    {
        public ProductSqlRepository(DbContext context) : base(context) { }

        public IEnumerable<Product> GetProductsLikeName(string name)
        {
            return _context.Set<Product>()
                .Where<Product>(o => o.Name.Contains(name));
        }
    }
}
