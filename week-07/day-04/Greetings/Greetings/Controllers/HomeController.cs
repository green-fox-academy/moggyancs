using Greetings.Services;
using Microsoft.AspNetCore.Mvc;

namespace Greetings.Controllers
{
    public class HomeController : Controller
    {
        IGreetYou GreetingOnDemand;

        public HomeController(IGreetYou greetingOnDemand)
        {
            this.GreetingOnDemand = greetingOnDemand;
        }

        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("/")]
        public IActionResult Greeting(string visitor)
        {
            return RedirectToAction("greet", new { visitor });
        }

        [HttpGet]
        [Route("greet")]
        public IActionResult Greet(string visitor)
        {
            return View((object)GreetingOnDemand.GreetThee(visitor));
        }
    }
}