using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebsiteTuThien.Data;
using WebsiteTuThien.Models;
using WebsiteTuThien.Utilies;

namespace WebsiteTuThien.Controllers
{
	public class LoginController : Controller
	{
		private readonly WebsiteTuThienContext _context;

		public LoginController(WebsiteTuThienContext context)
		{
			_context = context;
		}
		[HttpGet]
		public IActionResult Index()
		{

			return View();
		}
		[HttpPost]
		public IActionResult Index(Account account)
		{
			if (account == null)
			{
				return NotFound();
			}

			var checkadmin = _context.Account.Where(m => (m.AccountName == account.AccountName) && (m.Password == account.Password)&&(m.Role=="Admin")).FirstOrDefault();
			var checkuser = _context.Account.Where(m => (m.AccountName == account.AccountName) && (m.Password == account.Password) && (m.Role == "User")).FirstOrDefault();
			var checkschool = _context.Account.Where(m => (m.AccountName == account.AccountName) && (m.Password == account.Password) && (m.Role == "School")).FirstOrDefault();

			if (checkadmin == null && checkuser == null && checkschool == null)
			{
				return RedirectToAction("Index", "Login");
			}
			else if (checkadmin != null || checkuser != null || checkschool != null)
			{
				return RedirectToAction("Index", "Home");
			}
			return RedirectToAction("Index", "Login");
		}
	}
}
