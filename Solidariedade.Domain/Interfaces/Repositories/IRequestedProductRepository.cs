using Solidariedade.Domain.Entities.Donator;
using Solidariedade.Domain.Entities.Donee;
using Solidariedade.Domain.ValueObjects;
using System;
using System.Collections.Generic;

namespace Solidariedade.Domain.Interfaces.Repositories
{
    public interface IRequestedProductRepository: IRepository<Guid, RequestedProduct>
    {
        IEnumerable<RequestedProduct> GetAllRequestedProductOfPerson(DoneePerson DoneePerson);
        IEnumerable<RequestedProduct> GetAllRequestedProductOfState(State state);
    }
}
