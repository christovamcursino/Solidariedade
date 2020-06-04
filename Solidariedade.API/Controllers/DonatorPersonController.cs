using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Solidariedade.Application.Interfaces;
using Solidariedade.Domain.Entities.Donator;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solidariedade.API.Controllers
{
    [ApiVersion("1")]
    [Route("api/[controller]/{version}")]
    [ApiController]
    public class DonatorPersonController : ControllerBase
    {
        private readonly ILogger<DonatorPersonController> _logger;

        private readonly IDonatorPersonApp _donatorPersonApp;

        public DonatorPersonController(ILogger<DonatorPersonController> logger, IDonatorPersonApp donatorPersonApp)
        {
            _logger = logger;
            _donatorPersonApp = donatorPersonApp;
        }

        // GET: api/<DonatorPersonController>
        [HttpGet]
        public IEnumerable<DonatorPerson> Get()
        {
            return _donatorPersonApp.GetAllDonators();
        }

        // GET api/<DonatorPersonController>/5
        [HttpGet("{id}")]
        public DonatorPerson Get(string email)
        {
            return _donatorPersonApp.GetDonatorPersonByEmail(email);
        }

        // POST api/<DonatorPersonController>
        [HttpPost]
        public void Post([FromBody] DonatorPerson donatorPerson)
        {
            _donatorPersonApp.AddDonatorPerson(donatorPerson);
        }
    }
}
