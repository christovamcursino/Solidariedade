using Microsoft.EntityFrameworkCore;
using Solidariedade.Domain.Entities.Donator;
using Solidariedade.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Solidariedade.DataAccess.Repositories
{
    public class DonatorPersonSqlRepository : IDonatorPersonRepository
    {
        private DbContext _context;

        public DonatorPersonSqlRepository(DbContext context)
        {
            _context = context;
        }

        public DonatorPerson Insert(DonatorPerson DonatorPerson)
        {
            return _context.Set<DonatorPerson>().Add(DonatorPerson).Entity;
        }
        public IEnumerable<DonatorPerson> SelectAll()
        {
            return _context.Set<DonatorPerson>();
        }

        public DonatorPerson Select(Guid id)
        {
            return _context.Set<DonatorPerson>().Find(id);
        }

        public void Update(DonatorPerson DonatorPerson)
        {
            _context.Set<DonatorPerson>().Update(DonatorPerson);
        }

        public void Delete(Guid id)
        {
            _context.Set<DonatorPerson>().Remove(Select(id));
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public DonatorPerson SelectByEmail(string email)
        {
            return _context.Set<DonatorPerson>()
                .Where(o => o.Email == email)
                .FirstOrDefault<DonatorPerson>();
        }
    }
}
