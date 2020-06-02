using Solidariedade.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Solidariedade.Domain.Interfaces.Repositories
{
    public interface IPersonRepository<TId, T> : IRepository<TId, T> where T: Person
    {
        T GetByEmail(String email);
    }
}
