using Microsoft.AspNetCore.Mvc;

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
