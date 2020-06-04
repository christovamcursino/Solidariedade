using Solidariedade.Domain.Entities.Donee;
using Solidariedade.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solidariedade.Application.Interfaces
{
    public interface IRequestedProductApp
    {
        RequestedProduct AddRequestedProduct(RequestedProduct requestedProduct);
        IEnumerable<RequestedProduct> GetAllRequestedProducts();
        RequestedProduct GetRequestedProduct(Guid id);
        IEnumerable<RequestedProduct> GetRequestedProductsByState(String strUf);
    }
}
