using Microsoft.EntityFrameworkCore;
using Solidariedade.Domain.Entities.Donee;
using Solidariedade.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Solidariedade.DataAccess.Repositories
{
    public class DoneePersonSqlRepository : IDoneePersonRepository
    {
        private DbContext _context;

        public DoneePersonSqlRepository(DbContext context)
        {
            _context = context;
        }

        public DoneePerson Insert(DoneePerson DoneePerson)
        {
            return _context.Set<DoneePerson>().Add(DoneePerson).Entity;
        }
        public IEnumerable<DoneePerson> SelectAll()
        {
            return _context.Set<DoneePerson>();
        }

        public DoneePerson Select(Guid id)
        {
            return _context.Set<DoneePerson>().Find(id);
        }

        public void Update(DoneePerson DoneePerson)
        {
            _context.Set<DoneePerson>().Update(DoneePerson);
        }

        public void Delete(Guid id)
        {
            _context.Set<DoneePerson>().Remove(Select(id));
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public DoneePerson SelectByEmail(string email)
        {
            return _context.Set<DoneePerson>()
                .Where(o => o.Email == email)
                .FirstOrDefault<DoneePerson>();
        }
    }
}
