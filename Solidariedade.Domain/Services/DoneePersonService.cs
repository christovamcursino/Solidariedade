using Solidariedade.Domain.Entities;
using Solidariedade.Domain.Entities.Donee;
using Solidariedade.Domain.Interfaces.Repositories;
using Solidariedade.Domain.Interfaces.Services;
using Solidariedade.Domain.Interfaces.UoW;
using System;
using System.Collections.Generic;

namespace Solidariedade.Domain.Services
{
    public class DoneePersonService : IDoneePersonService
    {
        private IUnitOfWork _uow;
        private IDoneePersonRepository _donnePersonRepository;
        private IStateService _stateService;

        public DoneePersonService(IUnitOfWork uow, IDoneePersonRepository donnePersonRepository, IStateService stateService)
        {
            _uow = uow;
            _donnePersonRepository = donnePersonRepository;
            _stateService = stateService;
        }

        public Person AddDoneePerson(DoneePerson doneePerson)
        {
            _uow.BeginTransaction();
            doneePerson.Id = Guid.NewGuid();
            doneePerson.State = _stateService.GetByUF(doneePerson.State.UF);
            DoneePerson result = _donnePersonRepository.Insert(doneePerson);
            _uow.Commit();

            return result;
        }

        public IEnumerable<DoneePerson> GetAllDonee()
        {
            return _donnePersonRepository.GetAll();
        }

        public DoneePerson GetDoneePersonByEmail(string email)
        {
            return _donnePersonRepository.GetByEmail(email);
        }

        public DoneePerson GetDoneePersonByID(Guid id)
        {
            return _donnePersonRepository.GetByID(id);
        }
        //INCLUIR A VALIDACAO
    }
}
