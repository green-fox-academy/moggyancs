using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyWebApp.Controllers
{
    [Route("api")]
    public class RESTController : Controller
    {
        [Route("greeting")]
        public IActionResult Index()
        {
            return new JsonResult(new Greeting(0, "Hello, sweetie"));
        }
    }
}
