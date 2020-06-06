using Microsoft.EntityFrameworkCore;
using Solidariedade.Domain.Entities;
using Solidariedade.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Solidariedade.DataAccess.Repositories
{
    public abstract class PersonSqlRepository<TId, T> : RepositorySqlBase<Guid, T>, IPersonRepository<Guid, T> where T : Person
    {
        public PersonSqlRepository(DbContext context) : base(context) { }

        public override IEnumerable<T> GetAll()
        {
            return _context.Set<T>()
                .Include(o => o.State);
        }
        public virtual T GetByEmail(string email)
        {
            return _context.Set<T>()
                .Include(o => o.State)
                .Where(o => o.Email == email)
                .FirstOrDefault<T>();
        }
    }
}
