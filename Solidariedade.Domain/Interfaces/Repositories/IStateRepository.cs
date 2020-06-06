using Solidariedade.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solidariedade.Domain.Interfaces.Repositories
{
    public interface IStateRepository
    {
        IEnumerable<State> GetAll();
        State getByUF(String uf);
    }
}
