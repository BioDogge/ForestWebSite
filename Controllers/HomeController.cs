using AutoMapper;
using ForestWebSite.Data;
using ForestWebSite.Dtos;
using ForestWebSite.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ForestWebSite.Controllers
{
	public class HomeController : Controller
	{
		private readonly ICustomerRepo _repository;
		private readonly IMapper _mapper;

		public HomeController(ICustomerRepo repo, IMapper mapper)
		{
			_repository = repo;
			_mapper = mapper;
		}

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult AddCustomer(CustomerCreateDto customerCreateDto)
		{
			if (ModelState.IsValid)
			{
				var customerModel = _mapper.Map<Customer>(customerCreateDto);
				_repository.CreateCustomer(customerModel);
				_repository.SaveChanges();
				TempData["success"] = "Your contact information have added. Wait our call (⁠ꈍ⁠ᴗ⁠ꈍ⁠)";
			}
			else
				TempData["error"] = "Something is wrong (⁠-⁠_⁠-⁠メ⁠)";

			return RedirectToAction("Index");
		}
	}
}