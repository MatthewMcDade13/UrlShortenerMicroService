using Microsoft.AspNetCore.Mvc;

namespace UrlShortenerMicroService.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Http404()
        {
            return View();
        }
    }
}
