using Microsoft.EntityFrameworkCore;
using Solidariedade.Domain.Entities.Donator;
using Solidariedade.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solidariedade.DataAccess.Repositories
{
    public class DonationItemSqlRepository : IDonationItemRepository
    {
        private DbContext _context;

        public DonationItemSqlRepository(DbContext context)
        {
            _context = context;
        }

        public DonationItem Insert(DonationItem DonationItem)
        {
            return _context.Set<DonationItem>().Add(DonationItem).Entity;
        }
        public IEnumerable<DonationItem> SelectAll()
        {
            return _context.Set<DonationItem>();
        }

        public DonationItem Select(Guid id)
        {
            return _context.Set<DonationItem>().Find(id);
        }

        public void Update(DonationItem DonationItem)
        {
            _context.Set<DonationItem>().Update(DonationItem);
        }

        public void Delete(Guid id)
        {
            _context.Set<DonationItem>().Remove(Select(id));
        }

        public IEnumerable<DonationItem> SelectByDonation(Donation donation)
        {
            throw new NotImplementedException();
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }

    }
}
