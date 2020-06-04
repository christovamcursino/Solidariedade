using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Solidariedade.Application.Interfaces;
using Solidariedade.Domain.Entities.Donee;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solidariedade.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoneePersonController : ControllerBase
    {
        private readonly ILogger<DoneePersonController> _logger;

        private readonly IDoneePersonApp _doneePersonApp;

        public DoneePersonController(ILogger<DoneePersonController> logger, IDoneePersonApp doneePersonApp)
        {
            _logger = logger;
            _doneePersonApp = doneePersonApp;
        }


        // GET: api/<DoneePersonController>
        [HttpGet]
        public IEnumerable<DoneePerson> Get()
        {
            return _doneePersonApp.GetAllDonee();
        }

        // GET api/<DoneePersonController>/5
        [HttpGet("{id}")]
        public DoneePerson Get(string email)
        {
            return _doneePersonApp.GetDoneePersonByEmail(email);
        }

        // POST api/<DoneePersonController>
        [HttpPost]
        public void Post([FromBody] DoneePerson doneePerson)
        {
            _doneePersonApp.AddDoneePerson(doneePerson);
        }
    }
}
