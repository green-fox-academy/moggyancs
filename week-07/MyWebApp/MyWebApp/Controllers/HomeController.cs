using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string name)
        {
            Greeting greeting = new Greeting(name);

            return View(greeting);
        }

    }
}
