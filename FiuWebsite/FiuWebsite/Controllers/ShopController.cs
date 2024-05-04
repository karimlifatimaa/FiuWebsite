using Microsoft.AspNetCore.Mvc;

namespace FiuWebsite.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
