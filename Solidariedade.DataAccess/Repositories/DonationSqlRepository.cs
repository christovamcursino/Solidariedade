using Microsoft.EntityFrameworkCore;
using Solidariedade.Domain.Entities.Donator;
using Solidariedade.Domain.Entities.Donee;
using Solidariedade.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solidariedade.DataAccess.Repositories
{
    public class DonationSqlRepository : RepositorySqlBase<Guid, Donation>, IDonationRepository
    {
        public DonationSqlRepository(DbContext context) : base(context) { }

        public override IEnumerable<Donation> GetAll()
        {
            return _context.Set<Donation>()
                .Include(o => o.DonatorPerson)
                .Include(o => o.DoneePerson)
                .Include(o => o.Items)
                    .ThenInclude(p => p.Product);
        }
    }
}
