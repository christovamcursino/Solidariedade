using System;

namespace Solidariedade.Domain.Entities
{
    /// <summary>
    /// Produtos que podem ser doados ou solicitados para doacao
    /// </summary>
    public class Product
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
    }
}
