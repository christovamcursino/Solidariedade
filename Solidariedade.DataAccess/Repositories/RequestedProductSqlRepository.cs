using Microsoft.EntityFrameworkCore;
using Solidariedade.Domain.Entities.Donee;
using Solidariedade.Domain.Interfaces.Repositories;
using Solidariedade.Domain.ValueObjects;
using System;
using System.Collections.Generic;

namespace Solidariedade.DataAccess.Repositories
{
    public class RequestedProductSqlRepository : IRequestedProductRepository
    {
        private DbContext _context;

        public RequestedProductSqlRepository(DbContext context)
        {
            _context = context;
        }

        public RequestedProduct Insert(RequestedProduct RequestedProduct)
        {
            return _context.Set<RequestedProduct>().Add(RequestedProduct).Entity;
        }
        public IEnumerable<RequestedProduct> SelectAll()
        {
            return _context.Set<RequestedProduct>();
        }

        public RequestedProduct Select(Guid id)
        {
            return _context.Set<RequestedProduct>().Find(id);
        }

        public void Update(RequestedProduct RequestedProduct)
        {
            _context.Set<RequestedProduct>().Update(RequestedProduct);
        }

        public void Delete(Guid id)
        {
            _context.Set<RequestedProduct>().Remove(Select(id));
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public IEnumerable<RequestedProduct> SelectAllByPerson(DoneePerson DoneePerson)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RequestedProduct> SelectAllByState(State state)
        {
            throw new NotImplementedException();
        }
    }
}
