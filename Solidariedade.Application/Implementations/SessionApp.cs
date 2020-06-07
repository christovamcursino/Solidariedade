using Solidariedade.Application.Interfaces;
using Solidariedade.Domain.Entities;
using Solidariedade.Domain.Entities.Donator;
using Solidariedade.Domain.Entities.Donee;
using Solidariedade.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solidariedade.Application.Implementations
{
    public class SessionApp : ISessionApp
    {
        private IDonatorPersonService _donatorPersonService;
        private IDoneePersonService _doneePersonService;
        public SessionApp(IDonatorPersonService donatorPersonService, IDoneePersonService doneePersonService)
        {
            _donatorPersonService = donatorPersonService;
            _doneePersonService = doneePersonService;
        }

        public Person GetLoggedPerson()
        {
            return _person;
        }

        public bool IsCurrentUserADonator()
        {
            return (_person is DonatorPerson);
        }

        public bool IsCurrentUserADonee()
        {
            return (_person is DoneePerson);
        }

        public bool IsNewUser()
        {
            return _person == null;
        }

        //Scoped variable
        private string _email;
        private Person _person;
        public void SetSessionUser(string email)
        {
            this._email = email;
            this._person = _donatorPersonService.GetDonatorPersonByEmail(email);
            if (this._person == null)
            {
                this._person = _doneePersonService.GetDoneePersonByEmail(email);
            }
        }

        public string GetNameLoggedPerson()
        {
            if (IsNewUser())
                return _email;
            return _person.Name;
        }

        public string GetEmail()
        {
            return _email;
        }
    }
}
