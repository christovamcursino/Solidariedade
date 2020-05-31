using Microsoft.EntityFrameworkCore;
using Solidariedade.Domain.Entities.Donator;
using Solidariedade.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solidariedade.DataAccess.Repositories
{
    public class DonationSqlRepository : IDonationRepository
    {
        private DbContext _context;

        public DonationSqlRepository(DbContext context)
        {
            _context = context;
        }

        public Donation Insert(Donation Donation)
        {
            return _context.Set<Donation>().Add(Donation).Entity;
        }
        public IEnumerable<Donation> SelectAll()
        {
            return _context.Set<Donation>();
        }

        public Donation Select(Guid id)
        {
            return _context.Set<Donation>().Find(id);
        }

        public void Update(Donation Donation)
        {
            _context.Set<Donation>().Update(Donation);
        }

        public void Delete(Guid id)
        {
            _context.Set<Donation>().Remove(Select(id));
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }

    }
}
