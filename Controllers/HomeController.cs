using csWebAppMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace csWebAppMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Forms()
        {
            return View();
        }

        public IActionResult SumitInfo(Employee param)
        {  
            List<Employee> list = new List<Employee>();
            for(int i = 0; i < 10; i++)
            {
                list.Add(new Employee { fname = (param.fname + i.ToString() ), id = param.id + i });
            }
            return View("Table", list);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}