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
        IEnumerable<RequestedProduct> GetRequestedProductsByState(State state);
    }
}
