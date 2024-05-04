using Microsoft.AspNetCore.Mvc;

namespace FiuWebsite.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
