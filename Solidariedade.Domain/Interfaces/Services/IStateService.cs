using Solidariedade.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solidariedade.Domain.Interfaces.Services
{
    public interface IStateService
    {
        State GetByUF(String uf);
        IEnumerable<State> GetAllStates();
    }
}
