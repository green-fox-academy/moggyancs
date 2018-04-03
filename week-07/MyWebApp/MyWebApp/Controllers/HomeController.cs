using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string name)
        {
            var greeting = new Greeting(1, $"{name}");
            return View(greeting);
        }

    }
}
