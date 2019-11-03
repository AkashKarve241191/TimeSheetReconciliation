using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TimeSheetReconciliation.Web.Models;

namespace TimeSheetReconciliation.Web.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("api/employees")]
        public IActionResult Index()
        {
            var emp = new Employee
            {
                Name = "akash",
                Id = 1
            };
            return Ok(emp);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    public class Employee
    {
        public string Name { get; set; }

        public int Id { get; set; }
    }
}
