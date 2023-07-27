using Microsoft.AspNetCore.Mvc;

namespace Conreollers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}