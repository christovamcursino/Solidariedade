using Solidariedade.Application.DTO;
using Solidariedade.Application.Interfaces.Mappers;
using Solidariedade.Domain.Entities.Donator;
using System.Collections.Generic;

namespace Solidariedade.Application.Implementations.Mappers
{
    public class DonationMapper : IDonationMapper
    {
        private readonly IPersonMapper _personMapper;

        public DonationMapper(IPersonMapper personMapper)
        {
            _personMapper = personMapper;
        }

        public IEnumerable<DonationDTO> DonationToDonationDTO(Donation donation)
        {
            PersonDTO donator = _personMapper.PersonToPersonDTO(donation.DonatorPerson);
            PersonDTO donee = _personMapper.PersonToPersonDTO(donation.DoneePerson);
            List<DonationDTO> result = new List<DonationDTO>();
            foreach (DonationItem item in donation.Items)
            {
                DonationDTO dto = new DonationDTO
                {
                    donator = donator,
                    donee = donee,
                    amount = item.Amount,
                    product = item.Product
                };
                result.Add(dto);
            }
            return result;
        }
    }
}
