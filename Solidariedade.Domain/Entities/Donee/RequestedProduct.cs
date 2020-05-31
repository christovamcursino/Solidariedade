using System;

namespace Solidariedade.Domain.Entities.Donee
{
    public class RequestedProduct
    {
        public Guid Id { get; set; }
        public int Amount { get; set; }
        public Product Product { get; set; }
    }
}
