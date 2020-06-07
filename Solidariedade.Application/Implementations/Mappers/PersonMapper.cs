using Solidariedade.Application.DTO;
using Solidariedade.Application.Interfaces.Mappers;
using Solidariedade.Domain.Entities;
using Solidariedade.Domain.Entities.Donator;
using Solidariedade.Domain.Entities.Donee;
using Solidariedade.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using System.Text;

namespace Solidariedade.Application.Implementations.Mappers
{
    public class PersonMapper : IPersonMapper
    {
        public Person PersonDtoToDomainPerson(PersonDTO person)
        {
            Person result;
            if (person.TipoPessoa == TipoPessoaEnum.Donator)
            {
                result = new DonatorPerson();
            } else {
                result = new DoneePerson();
            }
            result.Email = person.Email;
            result.Name = person.Name;
            result.Address = person.Address;
            result.City = person.City;
            result.State = new State{UF = person.UF};
            return result;
        }

        public PersonDTO PersonToPersonDTO(Person person)
        {
            PersonDTO dto = new PersonDTO
            {
                Name = person.Name,
                City = person.City,
                Email = person.Email,
                UF = person.State.UF
            };
            return dto;
        }
    }
}
