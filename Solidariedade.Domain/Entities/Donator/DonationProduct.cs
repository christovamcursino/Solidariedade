﻿using System;

namespace Solidariedade.Domain.Entities.Donator
{
    public class DonationProduct
    {
        public Guid Id { get; set; }
        public int Amount { get; set; }
        public Product Product { get; set; }
    }
}
