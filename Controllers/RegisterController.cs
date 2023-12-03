using Microsoft.AspNetCore.Mvc;
using WebsiteTuThien.Data;
using WebsiteTuThien.Models;

namespace WebsiteTuThien.Controllers
{
	public class RegisterController : Controller
	{
		private readonly WebsiteTuThienContext _context;

		public RegisterController(WebsiteTuThienContext context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
			//ViewBag.Tag = Tag();
			return View();
		}

		[HttpPost]

		public IActionResult Index(Account account)
		{
			if (account == null)
			{
				return NotFound();
			}
			var check = _context.Account.Where(m => m.AccountName == account.AccountName).FirstOrDefault();
			if (check != null)
			{
				return RedirectToAction("Index", "Register");
			}

			_context.Add(account);
			_context.SaveChanges();

			return RedirectToAction("Index", "Login");
		}
	}
}
