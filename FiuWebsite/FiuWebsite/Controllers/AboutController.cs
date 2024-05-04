using Microsoft.AspNetCore.Mvc;

namespace FiuWebsite.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
