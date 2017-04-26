using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UrlShortenerMicroService.Models;

namespace UrlShortenerMicroService.Controllers
{
    [Route("api/short")]
    public class UrlController : Controller
    {
        private UrlContext context;

        public UrlController(UrlContext context)
        {
            this.context = context;
        }


        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {

            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
    }
}
