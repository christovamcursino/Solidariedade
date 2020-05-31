using System.Collections.Generic;

namespace Solidariedade.Domain.Entities.Donator
{
    /// <summary>
    /// Pessoa que ira efetuar a doacao
    /// </summary>
    public class DonatorPerson : Person
    {
        /// <summary>
        /// Lista de produtos a serem doados
        /// </summary>
        public List<DonationProduct> DonationProducts { get; set; }
        /// <summary>
        /// Lista de doacoes efetuadas
        /// </summary>
        public List<Donation> Donations { get; set; }
    }
}
