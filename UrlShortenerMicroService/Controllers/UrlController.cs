using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UrlShortenerMicroService.Models;
using System.Text.RegularExpressions;

namespace UrlShortenerMicroService.Controllers
{
    public class UrlController : Controller
    {
        private IUrlRepository repo;
        private Regex regex = new Regex("https?://[A-Za-z]+[.][A-Za-z]+");
        private Random random = new Random();

        public UrlController(IUrlRepository repo)
        {
            this.repo = repo;
        }

        //GET /api/short/url(must be string)
        [HttpGet("api/short")]
        public async Task<IActionResult> ShortenUrl()
        {
            //Gets Query string and removes the leading '?' and trims leading and trailing whitespace
            string url = Request.QueryString.Value
                .Replace('?', ' ').Trim();

            if (url != null)
            {
                if (regex.IsMatch(url))
                {
                    Url newEntry = new Url { Name = url };

                        repo.AddUrl(newEntry);
                    
                    if (await repo.SaveChangesAsync())
                    {
                        return Json(new { OldUrl = url, NewUrl = $"http://localhost:49250/{newEntry.Id}" });
                    }
                    else
                    {
                        return Json(new { Error = "An error occured. Item was not saved to Database." });
                        
                    }
                    
                }
            }

            return Json(
                new {
                Error = "Url Format is incorrect, please use a real site.",
                ProperFormat = "?http(s)://website.com"});
        }

        // GET /5
        [HttpGet("{id:long}")]
        public void RedirectUser(long id)
        {
            var urlList = repo.GetAllUrls()
                .Where(model => model.Id == id).ToList();

            Response.Redirect(urlList[0].Name);
        }
    }
}
