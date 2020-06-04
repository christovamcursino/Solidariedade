﻿using Solidariedade.Domain.Entities;
using Solidariedade.Domain.Entities.Donator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solidariedade.Domain.Interfaces.Services
{
    public interface IDonatorPersonService
    {
        DonatorPerson AddDonatorPerson(DonatorPerson donatorPerson);
        DonatorPerson GetDonatorPersonByEmail(String email);
        IEnumerable<DonatorPerson> GetAllDonators();
    }
}
