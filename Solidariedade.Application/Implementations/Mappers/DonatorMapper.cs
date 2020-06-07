using Solidariedade.Application.DTO;
using Solidariedade.Application.Interfaces.Mappers;
using Solidariedade.Domain.Entities.Donator;
using Solidariedade.Domain.Entities.Donee;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solidariedade.Application.Implementations.Mappers
{
    public class DonatorMapper : IDonatorMapper
    {
        private IDonationMapper _donationMapper;
        private IRequestedProductMapper _requestedProductMapper;

        public DonatorMapper(IDonationMapper donationMapper, IRequestedProductMapper requestedProductMapper)
        {
            _donationMapper = donationMapper;
            _requestedProductMapper = requestedProductMapper;
        }

        public DonatorDTO DonatorToDonatorDTO(DonatorPerson donatorPerson, IEnumerable<RequestedProduct> requestedProducts)
        {
            DonatorDTO result = new DonatorDTO();
            List<DonationDTO> lstDonation = new List<DonationDTO>();
            result.Donations = lstDonation;
            foreach (Donation donation in donatorPerson.Donations)
            {
                lstDonation.AddRange(_donationMapper.DonationToDonationDTO(donation));
            }
            result.RequestedProducts = _requestedProductMapper.RequestedProductToRequestedProductDTO(requestedProducts);
            return result;
        }
    }
}
