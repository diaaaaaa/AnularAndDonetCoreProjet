using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AnularAndDonetCoreProjet.Controllers
{
    [Route("api/[controller]")]
    public class ItemsController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Laptop", "Smart TV", "Smart Phone", "Tablet" };
        }

       
    }
}
