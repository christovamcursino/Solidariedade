using System;
using System.Collections.Generic;
using System.Text;

namespace Solidariedade.Domain.Interfaces.Repositories
{
    public interface IRepository<TId, T>
    {
        T Insert(T entity);
        IEnumerable<T> GetAll();
        T GetByID(TId id);
        void Update(T entity);
        void Delete(TId id);
    }
}
