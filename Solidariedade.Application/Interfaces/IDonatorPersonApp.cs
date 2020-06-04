using Solidariedade.Domain.Entities;
using Solidariedade.Domain.Entities.Donator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solidariedade.Application.Interfaces
{
    public interface IDonatorPersonApp
    {
        DonatorPerson AddDonatorPerson(DonatorPerson donatorPerson);
        IEnumerable<DonatorPerson> GetAllDonators();
        DonatorPerson GetDonatorPersonByEmail(String email);
    }
}
