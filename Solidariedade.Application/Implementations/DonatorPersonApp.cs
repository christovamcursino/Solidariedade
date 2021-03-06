﻿using Solidariedade.Application.Interfaces;
using Solidariedade.Domain.Entities.Donator;
using Solidariedade.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace Solidariedade.Application.Implementations
{
    public class DonatorPersonApp : IDonatorPersonApp
    {
        private IDonatorPersonService _donatorPersonService;

        public DonatorPersonApp(IDonatorPersonService donatorPersonService)
        {
            _donatorPersonService = donatorPersonService;
        }

        public DonatorPerson AddDonatorPerson(DonatorPerson donatorPerson)
        {
            return _donatorPersonService.AddDonatorPerson(donatorPerson);
        }

        public IEnumerable<DonatorPerson> GetAllDonators()
        {
            return _donatorPersonService.GetAllDonators();
        }

        public DonatorPerson GetDonatorPersonByEmail(string email)
        {
            return _donatorPersonService.GetDonatorPersonByEmail(email);
        }
    }
}
