using Solidariedade.Domain.Entities;
using Solidariedade.Domain.Entities.Donee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solidariedade.MVC.Models
{
    public class AddRequestViewModel
    {
        public RequestedProduct RequestedProduct { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
