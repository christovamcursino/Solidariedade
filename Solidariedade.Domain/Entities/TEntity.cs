using System;
using System.Collections.Generic;
using System.Text;

namespace Solidariedade.Domain.Entities
{
    public abstract class TEntity<TId>
    {
        public TId Id { get; set; }
    }
}
