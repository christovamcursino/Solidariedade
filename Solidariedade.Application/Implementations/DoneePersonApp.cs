using Solidariedade.Application.Interfaces;
using Solidariedade.Domain.Entities;
using Solidariedade.Domain.Entities.Donee;
using Solidariedade.Domain.Interfaces.Repositories;
using Solidariedade.Domain.Interfaces.Services;
using Solidariedade.Domain.Interfaces.UoW;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solidariedade.Domain.Services
{
    public class DoneePersonApp : IDoneePersonApp
    {
        private IDoneePersonService _donnePersonService;

        public DoneePersonApp(IDoneePersonService donnePersonService)
        {
            _donnePersonService = donnePersonService;
        }

        public Person AddDoneePerson(DoneePerson doneePerson)
        {
            return _donnePersonService.AddDoneePerson(doneePerson);
        }

        public IEnumerable<DoneePerson> GetAllDonee()
        {
            return _donnePersonService.GetAllDonee();
        }

        public DoneePerson GetDoneePersonByEmail(string email)
        {
            return _donnePersonService.GetDoneePersonByEmail(email);
        }
    }
}
