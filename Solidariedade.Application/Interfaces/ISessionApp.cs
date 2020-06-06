using Solidariedade.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solidariedade.Application.Interfaces
{
    public interface ISessionApp
    {
        Person GetPersonFromSession();

        //mocked
        Person GetDoneePerson();
        Person GetDonatorPerson();
    }
}
