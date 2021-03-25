using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrashCollector.Data;
using TrashCollector.Models;

namespace TrashCollector.Controllers
{
	[Authorize(Roles = "Employee")]
	public class EmployeeController : Controller
	{
		private ApplicationDbContext _context;
		public EmployeeController(ApplicationDbContext context)
		{
			_context = context;
		}
		// GET: EmployeeController
		public ActionResult Index()
		{
			//see all the customers in the employee who is logged in based on zip code
			var employee = _context.Employees.ToList();
			return View(employee);
		}

		// GET: EmployeeController/Details/5
		public ActionResult Details(int id)
		{
			var Employee = _context.Employees.Find(id);
			return View(id);
		}

		// GET: EmployeeController/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: EmployeeController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(Employee employee)
		{
			try
			{
				_context.Employees.Add(employee);
				_context.SaveChanges();

				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: EmployeeController/Edit/5
		public ActionResult Edit(int id)
		{
			var findid = _context.Employees.Find(id);
			return View(findid);
			//return View();
		}

		// POST: EmployeeController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(int id, Employee employee)
		{
			try
			{
				_context.Employees.Update(employee);
				_context.SaveChanges();
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: EmployeeController/Delete/5
		public ActionResult Delete(int id)
		{
			var deleteid = _context.Employees.Find(id);
			return View(deleteid);
			
		}

		// POST: EmployeeController/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(int id, Employee employee)
		{
			try
			{
				_context.Employees.Remove(employee);
				_context.SaveChanges();
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}

		}
		//public ActionResult Charge(int id)
		//{
		//	var chargeid = _context.Customers.Find(id);
		//	return View(chargeid);
		//}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Charge(int id, Customer customer)
		{
			try
			{
				customer.AccountBallance += 15;
				_context.SaveChanges();
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}
	}
}
