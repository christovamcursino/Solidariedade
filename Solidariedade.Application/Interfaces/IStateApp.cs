using Solidariedade.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solidariedade.Application.Interfaces
{
    public interface IStateApp
    {
        IEnumerable<State> GetAllStates();
    }
}
