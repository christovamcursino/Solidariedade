using Solidariedade.Domain.Entities.Donator;
using Solidariedade.Domain.Entities.Donee;
using Solidariedade.Domain.ValueObjects;
using System;
using System.Collections.Generic;

namespace Solidariedade.Domain.Interfaces.Repositories
{
    public interface IRequestedProductRepository
    {
        RequestedProduct Insert(RequestedProduct RequestedProduct);

        IEnumerable<RequestedProduct> SelectAll();

        IEnumerable<RequestedProduct> SelectAllByPerson(DoneePerson DoneePerson);
        IEnumerable<RequestedProduct> SelectAllByState(State state);

        RequestedProduct Select(Guid id);

        void Update(RequestedProduct RequestedProduct);

        void Delete(Guid id);

        void SaveChanges();
    }
}
