using Microsoft.AspNetCore.Mvc;

namespace WebsiteTuThien.Controllers
{
    public class Admin : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
