using Solidariedade.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solidariedade.Domain.Interfaces.Services
{
    public interface IProductService
    {
        Product AddProduct(Product product);
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetProductsByName(string name);
    }
}
