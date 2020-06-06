using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Solidariedade.Application.Interfaces;
using Solidariedade.Domain.Entities.Donator;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solidariedade.API.Controllers
{
    [ApiVersion("1")]
    [Route("api/[controller]")]
    [ApiController]
    public class DonationController : ControllerBase
    {
        private readonly ILogger<DonationController> _logger;

        private readonly IDonationApp _donationApp;

        public DonationController(ILogger<DonationController> logger, IDonationApp donationApp)
        {
            _logger = logger;
            _donationApp = donationApp;
        }

        // GET: api/<DonationController>
        [HttpGet]
        public IEnumerable<Donation> Get()
        {
            return _donationApp.GetAllDonations();
        }

        //// GET api/<DonationController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<DonationController>
        [HttpPost]
        public void Post([FromBody] Donation donation)
        {
            _donationApp.AddDonation(donation);
        }

        [HttpPost("/requested/")]
        public void PostRequested([FromBody] Donation donation)
        {
            _donationApp.AddDonation(donation);
        }
    }
}
