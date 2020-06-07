using Microsoft.EntityFrameworkCore;
using Solidariedade.Domain.Entities.Donee;
using Solidariedade.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Solidariedade.DataAccess.Repositories
{
    public class DoneePersonSqlRepository : PersonSqlRepository<Guid, DoneePerson>, IDoneePersonRepository
    {
        public DoneePersonSqlRepository(DbContext context) : base(context) {}
        public override DoneePerson GetByEmail(string email)
        {
            return _context.Set<DoneePerson>()
                .Include(o => o.State)
                .Include(o => o.RequestedProducts)
                .Include(o => o.Donations)
                    .ThenInclude(d => d.DonatorPerson)
                .Include(o => o.Donations)
                    .ThenInclude(d => d.Items).ThenInclude(i=>i.Product)
                .Where(o => o.Email == email)
                .FirstOrDefault<DoneePerson>();
        }
    }
}
