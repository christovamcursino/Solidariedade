﻿using Solidariedade.Domain.ValueObjects;
using System;

namespace Solidariedade.Domain.Entities
{
    public abstract class Person : TEntity<Guid>
    {
        public String Email { get; set; }
        public String Name { get; set; }
        public String Address { get; set; }
        public String City { get; set; }
        public State State { get; set; }
    }
}
