using Solidariedade.Domain.Entities.Donator;
using Solidariedade.Domain.Interfaces.Repositories;
using Solidariedade.Domain.Interfaces.Services;
using Solidariedade.Domain.Interfaces.UoW;
using System;
using System.Collections.Generic;

namespace Solidariedade.Domain.Services
{
    public class DonatorPersonService : IDonatorPersonService
    {
        private IUnitOfWork _uow;
        private IDonatorPersonRepository _donatorPersonRepository;
        private IStateService _stateService;

        public DonatorPersonService(IUnitOfWork uow, IDonatorPersonRepository donatorPersonRepository, IStateService stateService)
        {
            _uow = uow;
            _donatorPersonRepository = donatorPersonRepository;
            _stateService = stateService;
        }

        //INCLUIR A VALIDACAO
        public DonatorPerson AddDonatorPerson(DonatorPerson donatorPerson)
        {
            _uow.BeginTransaction();
            donatorPerson.Id = Guid.NewGuid();
            donatorPerson.State = _stateService.GetByUF(donatorPerson.State.UF);
            DonatorPerson result = _donatorPersonRepository.Insert(donatorPerson);
            _uow.Commit();

            return result;
        }

        public IEnumerable<DonatorPerson> GetAllDonators()
        {
            return _donatorPersonRepository.GetAll();
        }

        public DonatorPerson GetDonatorPersonByEmail(string email)
        {
            return _donatorPersonRepository.GetByEmail(email);
        }

        public DonatorPerson GetDonatorPersonByID(Guid id)
        {
            return _donatorPersonRepository.GetByID(id);
        }
    }
}
