using System;
using System.Collections;
using System.Collections.Generic;

namespace Solidariedade.Domain.Entities.Donator
{
    public class Donation : TEntity<Guid>
    {
        public DateTime DonationDate { get; set; }
        /// <summary>
        /// Tipo de entrega da doacao
        /// </summary>
        public DonationDeliveryTypeEnum DonationDeliveryType { get; set; }
        /// <summary>
        /// Itens desta doacao
        /// </summary>
        public IEnumerable<DonationItem> Items { get; set; }
    }

    /// <summary>
    /// Objeto de valor Tipo de Entrega da Doacao
    /// </summary>
    public enum DonationDeliveryTypeEnum
    {
        PegarNoLocal = 1,
        LevoAteVoce
    }
}
