using Solidariedade.Domain.Entities.Donator;
using System;
using System.Collections.Generic;

namespace Solidariedade.Domain.Interfaces.Repositories
{
    public interface IDonationItemRepository : IRepository<Guid, DonationItem>
    {
        IEnumerable<DonationItem> GetByDonation(Donation donation);
    }
}
