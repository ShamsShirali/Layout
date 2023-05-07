using Microsoft.AspNetCore.Mvc;

namespace Layout.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
