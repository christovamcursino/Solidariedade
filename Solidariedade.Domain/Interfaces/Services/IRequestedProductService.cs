using Solidariedade.Domain.Entities.Donee;
using Solidariedade.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solidariedade.Domain.Interfaces.Services
{
    public interface IRequestedProductService
    {
        RequestedProduct AddRequestedProduct(RequestedProduct requestedProduct);
        IEnumerable<RequestedProduct> GetAllRequestedProducts();
        RequestedProduct GetRequestedProduct(Guid id);
        IEnumerable<RequestedProduct> GetRequestedProductsByState(State state);
        IEnumerable<RequestedProduct> GetRequestedProductsOfPerson(DoneePerson doneePerson);
        void CheckOutRequestedProducts(IEnumerable<RequestedProduct> requestedProducts);
    }
}
