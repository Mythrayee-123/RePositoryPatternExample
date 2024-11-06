using Microsoft.AspNetCore.Mvc;
using RePositoryPatternExample.Models;
using RePositoryPatternExample.Repository;

namespace RePositoryPatternExample.Controllers
{
	public class EmployeesController : Controller
	{
		private readonly IEmployeeRepository _emprepo;
		public EmployeesController(IEmployeeRepository emprepo)
		{
			_emprepo = emprepo;
		}
		public IActionResult Index()
		
		{
			var empList = _emprepo.GetAllEmployees().ToList();
			return View(empList);
		}

		public ActionResult Create()   /// to just generted create page
		{
			return View();
		}
		[HttpPost]
		public ActionResult Create(Employee employee)
		{
			if (ModelState.IsValid)
			{
				_emprepo.AddEmployee(employee);
				return RedirectToAction("Index");
			}
			return View();
		}


	}
}
