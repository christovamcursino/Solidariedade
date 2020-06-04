using Solidariedade.Domain.Entities.Donator;
using Solidariedade.Domain.ValueObjects;
using System;
using System.Collections.Generic;

namespace Solidariedade.Domain.Interfaces.Repositories
{
    public interface IDonationProductRepository : IRepository<Guid, DonationProduct>
    {
        IEnumerable<DonationProduct> GetAllDonationProductOfPerson(DonatorPerson donatorPerson);
        IEnumerable<DonationProduct> GetAllDonationProductOfState(State state);
    }
}
