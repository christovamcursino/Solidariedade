using Solidariedade.Application.Interfaces;
using Solidariedade.Domain.Interfaces.Services;
using Solidariedade.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solidariedade.Application.Implementations
{
    public class StateApp : IStateApp
    {
        private IStateService _stateService;

        public StateApp(IStateService stateService)
        {
            _stateService = stateService;
        }

        public IEnumerable<State> GetAllStates()
        {
            return _stateService.GetAllStates();
        }
    }
}
