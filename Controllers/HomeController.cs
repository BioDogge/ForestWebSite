using ForestWebSite.Data;
using ForestWebSite.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ForestWebSite.Controllers
{
	public class HomeController : Controller
	{
		private readonly ICustomerRepo _repository;

		public HomeController(ICustomerRepo repo)
		{
			_repository = repo;
		}

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult AddCustomer(Customer customer)
		{
			_repository.CreateCustomer(customer);
			_repository.SaveChanges();
			TempData["success"] = "Your contact information have added. Wait our call (⁠ꈍ⁠ᴗ⁠ꈍ⁠)";

			return RedirectToAction("Index");
		}
	}
}