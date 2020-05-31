using Solidariedade.Domain.Entities.Donator;
using System;
using System.Collections.Generic;

namespace Solidariedade.Domain.Interfaces.Repositories
{
    public interface IDonationItemRepository
    {
        DonationItem Insert(DonationItem DonationItem);

        IEnumerable<DonationItem> SelectAll();

        IEnumerable<DonationItem> SelectByDonation(Donation donation);

        DonationItem Select(Guid id);

        void Update(DonationItem DonationItem);

        void Delete(Guid id);

        void SaveChanges();
    }
}
