using Microsoft.AspNetCore.Mvc;
using CoreDepartment.Models;
using CoreDepartmant.Models;

namespace CoreDepartment.Controllers
{
	public class DepartController : Controller
	{
		Context c = new Context();
		public IActionResult Index()
		{
			var values = c.departments.ToList();
			return View(values);
		}
		[HttpGet]
		public IActionResult NewDepartment()
		{
			return View(); 
		}
		[HttpPost]
		public IActionResult NewDepartment(Department d)
		{
			c.departments.Add(d);
			c.SaveChanges();
			return RedirectToAction("Index");
		}
		public IActionResult DeleteDepartment(int id)
		{
			var dep=c.departments.Find(id);
			c.departments.Remove(dep);
			c.SaveChanges();
			return RedirectToAction("Index");
		}
		public IActionResult ReturnDepartment(int id)
		{
			var depart=c.departments.Find(id);
			return View("ReturnDepartment", depart);
		}
		public IActionResult UpdateDepartment(Department d)
		{
			var dep = c.departments.Find(d.ID);
			dep.departmentName = d.departmentName;
			c.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
