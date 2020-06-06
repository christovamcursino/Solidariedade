using Solidariedade.Application.Interfaces;
using Solidariedade.Domain.Entities;
using Solidariedade.Domain.Interfaces.Services;
using Solidariedade.Domain.Services;
using System.Collections.Generic;

namespace Solidariedade.Application.Implementations
{
    public class ProductApp : IProductApp
    {
        private IProductService _productService;

        public ProductApp(IProductService productService)
        {
            _productService = productService;
        }

        public Product AddProduct(Product product)
        {
            return _productService.AddProduct(product);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _productService.GetAllProducts();
        }

        public IEnumerable<Product> GetProductsByName(string name)
        {
            return _productService.GetProductsByName(name);
        }
    }
}
