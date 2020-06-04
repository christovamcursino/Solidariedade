using Solidariedade.Domain.Entities.Donee;
using Solidariedade.Domain.Interfaces.Repositories;
using Solidariedade.Domain.Interfaces.Services;
using Solidariedade.Domain.Interfaces.UoW;
using Solidariedade.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solidariedade.Domain.Services
{
    public class RequestedProductService : IRequestedProductService
    {
        private IUnitOfWork _uow;
        private IRequestedProductRepository _requestedProductRepository;

        public RequestedProductService(IUnitOfWork uow, IRequestedProductRepository requestedProductRepository)
        {
            _uow = uow;
            _requestedProductRepository = requestedProductRepository;
        }

        public RequestedProduct AddRequestedProduct(RequestedProduct requestedProduct)
        {
            _uow.BeginTransaction();
            requestedProduct.Id = Guid.NewGuid();
            RequestedProduct result = _requestedProductRepository.Insert(requestedProduct);
            _uow.Commit();

            return result;
        }

        public IEnumerable<RequestedProduct> GetAllRequestedProducts()
        {
            return _requestedProductRepository.GetAll();
        }


        public RequestedProduct GetRequestedProduct(Guid id)
        {
            return _requestedProductRepository.GetByID(id);
        }

        public IEnumerable<RequestedProduct> GetRequestedProductsByState(State state)
        {
            return _requestedProductRepository.GetAllRequestedProductOfState(state);
        }

        public IEnumerable<RequestedProduct> GetRequestedProductsOfPerson(DoneePerson doneePerson)
        {
            return _requestedProductRepository.GetAllRequestedProductOfPerson(doneePerson);
        }
    }
}
