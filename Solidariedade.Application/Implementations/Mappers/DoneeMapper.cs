using Solidariedade.Application.DTO;
using Solidariedade.Application.Interfaces.Mappers;
using Solidariedade.Domain.Entities.Donator;
using Solidariedade.Domain.Entities.Donee;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solidariedade.Application.Implementations.Mappers
{
    public class DoneeMapper : IDoneeMapper
    {
        private IDonationMapper _donationMapper;

        public DoneeMapper(IDonationMapper donationMapper)
        {
            _donationMapper = donationMapper;
        }

        public DoneeDTO DoneeToDoneeDTO(DoneePerson doneePerson)
        {
            DoneeDTO result = new DoneeDTO();
            result.requestedProducts = doneePerson.RequestedProducts;
            List<DonationDTO> lstDonation = new List<DonationDTO>();
            result.donations = lstDonation;
            foreach(Donation donation in doneePerson.Donations) {
                lstDonation.AddRange(_donationMapper.DonationToDonationDTO(donation));
            }

            return result;
        }
    }
}
