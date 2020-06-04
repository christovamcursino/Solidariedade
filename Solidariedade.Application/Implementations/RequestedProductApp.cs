using Solidariedade.Application.Interfaces;
using Solidariedade.Domain.Entities.Donee;
using Solidariedade.Domain.Interfaces.Services;
using Solidariedade.Domain.ValueObjects;
using System;
using System.Collections.Generic;

namespace Solidariedade.Domain.Services
{
    public class RequestedProductApp : IRequestedProductApp
    {
        private IRequestedProductService _requestedProductService;

        public RequestedProductApp(IRequestedProductService requestedProductService)
        {
            _requestedProductService = requestedProductService;
        }

        public RequestedProduct AddRequestedProduct(RequestedProduct requestedProduct)
        {
            return _requestedProductService.AddRequestedProduct(requestedProduct);
        }

        public IEnumerable<RequestedProduct> GetAllRequestedProducts()
        {
            return _requestedProductService.GetAllRequestedProducts();
        }

        public RequestedProduct GetRequestedProduct(Guid id)
        {
            return _requestedProductService.GetRequestedProduct(id);
        }

        public IEnumerable<RequestedProduct> GetRequestedProductsByState(String strUf)
        {
            State state = new State();
            state.UF = strUf;
            return _requestedProductService.GetRequestedProductsByState(state);
        }
    }
}
