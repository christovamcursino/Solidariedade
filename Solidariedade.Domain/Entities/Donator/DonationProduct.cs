using System;

namespace Solidariedade.Domain.Entities.Donator
{
    public class DonationProduct : TEntity<Guid>
    {
        public DonatorPerson DonatorPerson { get; set; }
        public int Amount { get; set; }
        public Product Product { get; set; }
    }
}
