using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Guardians.Controllers
{
    public class GuardianController : Controller
    {
        [HttpGet("/groot")]
        public IActionResult Groot(string message)
        {
            if (message != null)
            {
                var groot = new Translator(message);
                return new JsonResult(groot);
            }
            else
            {
                var grooterror = new Errors("I am Groot!");
                return new BadRequestObjectResult(grooterror);
            }
        }

        [HttpGet("/yondu")]
        public IActionResult Yondu(double distance, double time)
        {
            var speed = new Arrow(distance, time);
            return new JsonResult(speed);
        }
    }
}
