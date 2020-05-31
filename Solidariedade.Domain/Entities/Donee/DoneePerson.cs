using Solidariedade.Domain.Entities.Donator;
using System.Collections.Generic;

namespace Solidariedade.Domain.Entities.Donee
{
    /// <summary>
    /// Pessoa que recebera a doacao
    /// </summary>
    public class DoneePerson : Person
    {
        /// <summary>
        /// Lista de produtos que a pessoa esta precisando
        /// </summary>
        public List<RequestedProduct> RequestedProducts { get; set; }
        /// <summary>
        /// Lista de doacoes recebidas
        /// </summary>
        public List<Donation> Donations { get; set; }
    }
}
