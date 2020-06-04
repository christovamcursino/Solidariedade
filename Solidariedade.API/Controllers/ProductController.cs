using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Solidariedade.Application.Interfaces;
using Solidariedade.Domain.Entities;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solidariedade.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;

        private readonly IProductApp _productApp;

        public ProductController(ILogger<ProductController> logger, IProductApp productApp)
        {
            _logger = logger;
            _productApp = productApp;
        }



        // GET: api/<ProductController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _productApp.GetAllProducts();
        }

        // GET api/<ProductController>/5
        [HttpGet("filter")]
        public IEnumerable<Product> Get([FromQuery] string name)
        {
            return _productApp.GetProductsByName(name);
        }

        // POST api/<ProductController>
        [HttpPost]
        public void Post([FromBody] Product product)
        {
            _productApp.AddProduct(product);
        }
    }
}
