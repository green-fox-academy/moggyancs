using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyWebApp.Controllers
{
    [Route("api")]
    public class RESTController : Controller
    {
        [Route("greeting")]
        public IActionResult Index(string name)
        {
            Greeting greetMe = new Greeting($"Good day, {name}.");
            return new JsonResult(greetMe);
        }
    }
}
