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
        private IUrlRepository repo;

        public UrlController(IUrlRepository repo)
        {
            this.repo = repo;
        }

        //GET /api/short/url(must be string)
        [HttpGet("{url:alpha}")]
        public string Get(string url)
        {
            return "string";
        }

        // GET api/short/5
        [HttpGet("{id:long}")]
        public string Get(long id)
        {
            return "number";
        }
    }
}
