using System;

namespace Solidariedade.Domain.Entities
{
    /// <summary>
    /// Produtos que podem ser doados ou solicitados para doacao
    /// </summary>
    public class Product : TEntity<Guid>
    {
        public String Name { get; set; }
    }
}
