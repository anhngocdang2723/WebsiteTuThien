using Microsoft.AspNetCore.Mvc;
using WebsiteTuThien.Data;

namespace WebsiteTuThien.Controllers
{
    public class UserDonation : Controller
    {
        private readonly WebsiteTuThienContext _context;

        public UserDonation(WebsiteTuThienContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            return View();
        }
    }
}
