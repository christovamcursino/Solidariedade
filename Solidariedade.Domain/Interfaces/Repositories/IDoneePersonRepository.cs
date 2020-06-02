using Solidariedade.Domain.Entities.Donee;
using System;
using System.Collections.Generic;

namespace Solidariedade.Domain.Interfaces.Repositories
{
    public interface IDoneePersonRepository : IPersonRepository<Guid, DoneePerson>
    {
    }
}
