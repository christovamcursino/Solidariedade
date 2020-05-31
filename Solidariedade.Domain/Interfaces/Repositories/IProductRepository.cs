using Solidariedade.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Solidariedade.Domain.Interfaces.Repositories
{
    public interface IProductRepository
    {
        Product Insert(Product Product);

        IEnumerable<Product> SelectAll();

        Product Select(Guid id);

        void Update(Product Product);

        void Delete(Guid id);

        void SaveChanges();
    }
}
