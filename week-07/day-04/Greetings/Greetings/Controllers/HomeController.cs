using Greetings.Services;
using Greetings.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Greetings.Controllers
{
    public class HomeController : Controller
    {
        IGreetYou GreetingOnDemand;
        GreetVisitor greeter;

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
            greeter = new GreetVisitor(GreetingOnDemand, visitor);
            return RedirectToAction("greet");
        }

        [HttpGet]
        [Route("greet")]
        public IActionResult Greet()
        {
            return View((object)greeter.GetGreet()); //!! Greeter was null :(
        }
    }
}