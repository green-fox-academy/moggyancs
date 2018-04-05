using Greetings.Services;
using Microsoft.AspNetCore.Mvc;

namespace Greetings.Controllers
{
    public class HomeController : Controller
    {
        IGreetYou greetingOnDemand;

        public HomeController(IGreetYou greetingOnDemand)
        {
            this.greetingOnDemand = greetingOnDemand;
        }

        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("greet")]
        public IActionResult Greet(string visitor)
        {
            return View((object)greetingOnDemand.GreetThee(visitor));
        }
    }
}