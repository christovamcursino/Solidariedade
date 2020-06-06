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
        private IProductService _productService;
        private IDoneePersonService _doneePersonService;

        public RequestedProductService(IUnitOfWork uow, IRequestedProductRepository requestedProductRepository, IProductService productService, IDoneePersonService doneePersonService)
        {
            _uow = uow;
            _requestedProductRepository = requestedProductRepository;
            _productService = productService;
            _doneePersonService = doneePersonService;
        }

        public RequestedProduct AddRequestedProduct(RequestedProduct requestedProduct)
        {
            _uow.BeginTransaction();
            requestedProduct.Id = Guid.NewGuid();
            requestedProduct.Product = _productService.GetProductByID(requestedProduct.Product.Id);
            requestedProduct.DoneePerson = _doneePersonService.GetDoneePersonByID(requestedProduct.DoneePerson.Id);
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

        public void CheckOutRequestedProducts(IEnumerable<RequestedProduct> requestedProducts)
        {
            foreach(RequestedProduct req in requestedProducts)
            {
                RequestedProduct reqDB = GetRequestedProduct(req.Id);
                reqDB.Amount -= (reqDB.Amount - req.Amount < 0 ? 0 : req.Amount);
                _requestedProductRepository.Update(reqDB);
            }
        }
    }
}
