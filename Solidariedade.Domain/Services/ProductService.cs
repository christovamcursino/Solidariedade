using Solidariedade.Domain.Entities;
using Solidariedade.Domain.Interfaces.Repositories;
using Solidariedade.Domain.Interfaces.Services;
using Solidariedade.Domain.Interfaces.UoW;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solidariedade.Domain.Services
{
    public class ProductService : IProductService
    {
        private IUnitOfWork _uow;
        private IProductRepository _productRepository;

        public ProductService(IUnitOfWork uow, IProductRepository productRepository)
        {
            _uow = uow;
            _productRepository = productRepository;
        }

        public Product AddProduct(Product product)
        {
            _uow.BeginTransaction();
            product.Id = Guid.NewGuid();
            Product result = _productRepository.Insert(product);
            _uow.Commit();

            return result;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _productRepository.GetAll();
        }

        public Product GetProductByID(Guid id)
        {
            return _productRepository.GetByID(id);
        }

        public IEnumerable<Product> GetProductsByName(string name)
        {
            return _productRepository.GetProductsLikeName(name);
        }
    }
}
