using Solidariedade.Application.DTO;
using Solidariedade.Domain.Entities.Donator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solidariedade.Application.Interfaces.Mappers
{
    public interface IDonationMapper
    {
        IEnumerable<DonationDTO> DonationToDonationDTO(Donation donation);
    }
}
