using Microsoft.EntityFrameworkCore;
using Solidariedade.Domain.Entities.Donator;
using Solidariedade.Domain.Interfaces.Repositories;
using Solidariedade.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solidariedade.DataAccess.Repositories
{
    public class DonationProductSqlRepository : IDonationProductProductRepository
    {
        private DbContext _context;

        public DonationProductSqlRepository(DbContext context)
        {
            _context = context;
        }

        public DonationProduct Insert(DonationProduct DonationProduct)
        {
            return _context.Set<DonationProduct>().Add(DonationProduct).Entity;
        }
        public IEnumerable<DonationProduct> SelectAll()
        {
            return _context.Set<DonationProduct>();
        }

        public DonationProduct Select(Guid id)
        {
            return _context.Set<DonationProduct>().Find(id);
        }

        public void Update(DonationProduct DonationProduct)
        {
            _context.Set<DonationProduct>().Update(DonationProduct);
        }

        public void Delete(Guid id)
        {
            _context.Set<DonationProduct>().Remove(Select(id));
        }

        public IEnumerable<DonationProduct> SelectAllByPerson(DonatorPerson DonatorPerson)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DonationProduct> SelectAllByState(State state)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}