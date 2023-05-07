using Microsoft.AspNetCore.Mvc;

namespace Layout.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
