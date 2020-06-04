using Solidariedade.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solidariedade.Application.Interfaces
{
    public interface IProductApp
    {
        Product AddProduct(Product product);
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetProductsByName(string name);
    }
}
