using Microsoft.AspNetCore.Mvc;

namespace FiuWebsite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
