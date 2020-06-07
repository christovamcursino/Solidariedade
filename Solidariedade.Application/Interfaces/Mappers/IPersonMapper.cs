using Solidariedade.Application.DTO;
using Solidariedade.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solidariedade.Application.Interfaces.Mappers
{
    public interface IPersonMapper
    {
        Person PersonDtoToDomainPerson(PersonDTO person);
        PersonDTO PersonToPersonDTO(Person person);
    }
}
