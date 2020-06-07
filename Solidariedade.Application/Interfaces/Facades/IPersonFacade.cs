using Solidariedade.Application.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solidariedade.Application.Interfaces.Facades
{
    public interface IPersonFacade
    {
        void CreatePerson(PersonDTO personDto);
    }
}
