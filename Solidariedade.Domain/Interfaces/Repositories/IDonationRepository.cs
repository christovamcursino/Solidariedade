using Solidariedade.Domain.Entities.Donator;
using System;
using System.Collections.Generic;

namespace Solidariedade.Domain.Interfaces.Repositories
{
    public interface IDonationRepository : IRepository<Guid, Donation>
    {
    }
}
