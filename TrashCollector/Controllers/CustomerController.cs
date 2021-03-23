using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrashCollector.Data;
using TrashCollector.Models;

namespace TrashCollector.Controllers
{
	[Authorize(Roles = "Customer")]
	public class CustomerController : Controller
	{
		private ApplicationDbContext _context;
		public CustomerController(ApplicationDbContext context)
		{
			_context = context;
		}
		// GET: CustomerController
		public ActionResult Index()
		{
			var customer = _context.Customers.ToList();
			return View(customer);
		}

		// GET: CustomerController/Details/5
		public ActionResult Details(int id)
		{
			var customer = _context.Customers.Find(id);
			return View(customer);
		}

		// GET: CustomerController/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: CustomerController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(Customer customers)
		{
			try
			{
				_context.Customers.Add(customers);
				_context.SaveChanges();
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: CustomerController/Edit/5
		public ActionResult Edit(int id)
		{
			var findid = _context.Customers.Find(id);
			return View(findid);
		}

		// POST: CustomerController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(int id, Customer customer)
		{
			try
			{
				_context.Customers.Update(customer);
				_context.SaveChanges();
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}
	

		// GET: CustomerController/Delete/5
		public ActionResult Delete(int id)
		{
			var deleteid = _context.Customers.Find(id);
			return View(deleteid);
		}

		// POST: CustomerController/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(int id, Customer customer)
		{
			try
			{
				_context.Customers.Remove(customer);
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
