using Solidariedade.Application.DTO;
using Solidariedade.Application.Interfaces;
using Solidariedade.Application.Interfaces.Facades;
using Solidariedade.Application.Interfaces.Mappers;
using Solidariedade.Domain.Entities;
using Solidariedade.Domain.Entities.Donator;
using Solidariedade.Domain.Entities.Donee;

namespace Solidariedade.Application.Implementations.Facades
{
    public class PersonFacade : IPersonFacade
    {
        private IDonatorPersonApp _donatorPersonApp;
        private IDoneePersonApp _doneePersonApp;
        private IPersonMapper _personMapper;

        public PersonFacade(IDonatorPersonApp donatorPersonApp, IDoneePersonApp doneePersonApp, IPersonMapper personMapper)
        {
            _donatorPersonApp = donatorPersonApp;
            _doneePersonApp = doneePersonApp;
            _personMapper = personMapper;
        }

        public void CreatePerson(PersonDTO personDto)
        {
            Person person = _personMapper.PersonDtoToDomainPerson(personDto);
            if (person is DonatorPerson)
                _donatorPersonApp.AddDonatorPerson((DonatorPerson)person);
            if (person is DoneePerson)
                _doneePersonApp.AddDoneePerson((DoneePerson)person);
        }
    }
}
