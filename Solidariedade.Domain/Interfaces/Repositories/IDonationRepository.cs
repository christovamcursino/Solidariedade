using Solidariedade.Domain.Entities.Donator;
using System;
using System.Collections.Generic;

namespace Solidariedade.Domain.Interfaces.Repositories
{
    public interface IDonationRepository
    {
        Donation Insert(Donation Donation);

        IEnumerable<Donation> SelectAll();

        Donation Select(Guid id);

        void Update(Donation Donation);

        void Delete(Guid id);

        void SaveChanges();
    }
}
