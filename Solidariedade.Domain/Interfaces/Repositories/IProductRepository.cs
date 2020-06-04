using Solidariedade.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Solidariedade.Domain.Interfaces.Repositories
{
    public interface IProductRepository : IRepository<Guid, Product>
    {
        /// <summary>
        /// Retorna os produtos que contenham o nome especificado
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        IEnumerable<Product> GetProductsLikeName(string name);
    }
}
