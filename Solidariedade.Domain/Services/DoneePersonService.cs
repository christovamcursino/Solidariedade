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

        public DoneePersonService(IUnitOfWork uow, IDoneePersonRepository donnePersonRepository)
        {
            _uow = uow;
            _donnePersonRepository = donnePersonRepository;
        }

        public Person AddDoneePerson(DoneePerson doneePerson)
        {
            _uow.BeginTransaction();
            doneePerson.Id = Guid.NewGuid();
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
        //INCLUIR A VALIDACAO
    }
}
