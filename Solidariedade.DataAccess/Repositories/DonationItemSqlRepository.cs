using Microsoft.EntityFrameworkCore;
using Solidariedade.Domain.Entities.Donator;
using Solidariedade.Domain.Entities.Donee;
using Solidariedade.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Solidariedade.DataAccess.Repositories
{
    public class DonationItemSqlRepository : RepositorySqlBase<Guid, DonationItem>, IDonationItemRepository
    {
        public DonationItemSqlRepository(DbContext context) : base(context) { }
        public IEnumerable<DonationItem> GetByDonation(Donation donation)
        {
            return _context.Set<DonationItem>()
                .Where<DonationItem>(o => o.Donation.Id.Equals(donation.Id));
        }
    }
}
