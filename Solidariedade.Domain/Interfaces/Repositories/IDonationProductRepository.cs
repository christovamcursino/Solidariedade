using Solidariedade.Domain.Entities.Donator;
using Solidariedade.Domain.ValueObjects;
using System;
using System.Collections.Generic;

namespace Solidariedade.Domain.Interfaces.Repositories
{
    public interface IDonationProductProductRepository
    {
        DonationProduct Insert(DonationProduct DonationProduct);

        IEnumerable<DonationProduct> SelectAll();

        IEnumerable<DonationProduct> SelectAllByPerson(DonatorPerson DonatorPerson);
        IEnumerable<DonationProduct> SelectAllByState(State state);

        DonationProduct Select(Guid id);

        void Update(DonationProduct DonationProduct);

        void Delete(Guid id);

        void SaveChanges();
    }
}
