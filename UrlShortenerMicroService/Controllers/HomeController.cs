using Microsoft.AspNetCore.Mvc;

namespace UrlShortenerMicroService.Controllers
{
    public class HomeController : Controller
    {        
        public IActionResult Index()
        {
            return View();
        }
    }
}
