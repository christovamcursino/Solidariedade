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
    public class ProductSqlRepository : IProductRepository
    {
        private DbContext _context;

        public ProductSqlRepository(DbContext context)
        {
            _context = context;
        }

        public Product Insert(Product Product)
        {
            return _context.Set<Product>().Add(Product).Entity;
        }
        public IEnumerable<Product> SelectAll()
        {
            return _context.Set<Product>();
        }

        public Product Select(Guid id)
        {
            return _context.Set<Product>().Find(id);
        }

        public void Update(Product Product)
        {
            _context.Set<Product>().Update(Product);
        }

        public void Delete(Guid id)
        {
            _context.Set<Product>().Remove(Select(id));
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }

    }
}
