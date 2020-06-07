using Solidariedade.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solidariedade.Application.DTO
{
    public class DonationDTO
    {
        public PersonDTO donator { get; set; }
        public PersonDTO donee { get; set; }
        public Product product { get; set; }
        public int amount { get; set; }
    }
}
