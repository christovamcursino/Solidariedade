using Solidariedade.Domain.Entities;
using Solidariedade.Domain.Entities.Donator;
using Solidariedade.Domain.Entities.Donee;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solidariedade.Domain.Interfaces.Services
{
    public interface IDoneePersonService
    {
        Person AddDoneePerson(DoneePerson doneePerson);
        DoneePerson GetDoneePersonByID(Guid id);
        DoneePerson GetDoneePersonByEmail(String email);
        IEnumerable<DoneePerson> GetAllDonee();
    }
}
