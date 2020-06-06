using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solidariedade.Application.Interfaces;
using Solidariedade.Domain.ValueObjects;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solidariedade.API.Controllers
{
    [ApiVersion("1")]
    [Route("api/[controller]")]
    [ApiController]
    public class StateController : ControllerBase
    {
        private IStateApp _stateApp;

        public StateController(IStateApp stateApp)
        {
            _stateApp = stateApp;
        }

        // GET: api/<StateController>
        [HttpGet]
        public IEnumerable<State> Get()
        {
            return _stateApp.GetAllStates();
        }

    }
}
