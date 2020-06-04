using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Solidariedade.Application.Interfaces;
using Solidariedade.Domain.Entities.Donee;
using System;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solidariedade.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestedProductController : ControllerBase
    {
        private readonly ILogger<RequestedProductController> _logger;

        private readonly IRequestedProductApp _requestedProductApp;

        public RequestedProductController(ILogger<RequestedProductController> logger, IRequestedProductApp requestedProductApp)
        {
            _logger = logger;
            _requestedProductApp = requestedProductApp;
        }

        // GET: api/<RequestedProductController>
        [HttpGet]
        public IEnumerable<RequestedProduct> Get()
        {
            return _requestedProductApp.GetAllRequestedProducts();
        }

        // GET: api/<RequestedProductController>
        [HttpGet("filter")]
        public IEnumerable<RequestedProduct> GetByState([FromQuery] String uf)
        {
            return _requestedProductApp.GetRequestedProductsByState(uf);
        }

        // GET api/<RequestedProductController>/5
        [HttpGet("{id}")]
        public RequestedProduct Get(Guid id)
        {
            return _requestedProductApp.GetRequestedProduct(id);
        }

        // POST api/<RequestedProductController>
        [HttpPost]
        public void Post([FromBody] RequestedProduct requestedProduct)
        {
            _requestedProductApp.AddRequestedProduct(requestedProduct);
        }
    }
}
