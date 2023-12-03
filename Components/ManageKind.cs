using Microsoft.AspNetCore.Mvc;
using WebsiteTuThien.Data;

namespace WebsiteTuThien.Components
{
    public class ManageKind:ViewComponent
    {
        private readonly WebsiteTuThienContext _context;

        public ManageKind(WebsiteTuThienContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            return View("Index", _context.Kind.ToList());
        }
    }
}
