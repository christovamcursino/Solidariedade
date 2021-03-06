﻿using System;

namespace Solidariedade.Domain.Entities.Donee
{
    public class RequestedProduct : TEntity<Guid>
    {
        public DoneePerson DoneePerson { get; set; }
        public int Amount { get; set; }
        public Product Product { get; set; }
    }
}
