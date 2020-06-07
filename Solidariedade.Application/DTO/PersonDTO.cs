using System;
using System.Collections.Generic;
using System.Text;

namespace Solidariedade.Application.DTO
{
    public class PersonDTO
    {
        public String Email { get; set; }
        public String Name { get; set; }
        public String Address { get; set; }
        public String City { get; set; }
        public String UF { get; set; }
        public TipoPessoaEnum TipoPessoa { get; set; }
    }

    public enum TipoPessoaEnum
    {
        Donator = 1,
        Donee
    }
}
