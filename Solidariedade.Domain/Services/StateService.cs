using Solidariedade.Domain.Interfaces.Repositories;
using Solidariedade.Domain.Interfaces.Services;
using Solidariedade.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solidariedade.Domain.Services
{
    public class StateService : IStateService
    {
        private IStateRepository _stateRepository;

        public StateService(IStateRepository stateRepository)
        {
            _stateRepository = stateRepository;
        }

        public IEnumerable<State> GetAllStates()
        {
            return _stateRepository.GetAll();
        }

        public State GetByUF(string uf)
        {
            return _stateRepository.getByUF(uf);
        }
    }
}
