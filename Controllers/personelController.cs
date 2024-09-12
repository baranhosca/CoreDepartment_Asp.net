using CoreDepartment.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreDepartment.Controllers
{
	public class personelController : Controller
	{
		Context c = new Context();
		public IActionResult Index()
		{
			var values = c.personels.ToList();
			return View(values);
		}
	}
}
