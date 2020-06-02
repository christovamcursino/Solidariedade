using System;

namespace Solidariedade.Domain.Entities.Donator
{
    public class DonationItem : TEntity<Guid>
    {
        public Donation Donation { get; set; }
        public int Amount { get; set; }
        public Product Product { get; set; }
    }
}
