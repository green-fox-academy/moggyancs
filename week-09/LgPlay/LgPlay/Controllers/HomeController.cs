using LgPlay.Models;
using Microsoft.AspNetCore.Mvc;

namespace LgPlay.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public IActionResult Index()
        {
            return File("Index.html", "text/html");
        }

        [HttpGet("/doubling")]
        public IActionResult Doubling(double? input)
        {
            if (input != null)
            {
                var db = new Doubler(input);
                return new JsonResult(db);
            }
            else
            {
                var doublerError = new ErrorMsg("an input");
                return new JsonResult(doublerError);
            }
        }

        [HttpGet("/greeter")]
        public IActionResult Greeter(string name, string title)
        {
            if (name == null)
            {
                var nameError = new ErrorMsg("a name");
                return new JsonResult(nameError);
            }
            else if (title == null)
            {
                var titleError = new ErrorMsg("a title");
                return new JsonResult(titleError);
            }
            else
            {
                var gr = new Greeter(name, title);
                return new JsonResult(gr);
            }
        }

        [HttpGet("/appenda/{appendable}")]
        public IActionResult AppendA([FromRoute] string appendable)
        {
            var app = new AppendA(appendable);
            return new JsonResult(app);
        }

        [HttpPost("/dountil/{what}")]
        public IActionResult DoUntil([FromRoute] string what, [FromBody] Number until)
        {

            if (until.Until == null)
            {
                var doUntilError = new ErrorMsg("a number");
                return new JsonResult(doUntilError);
            }

            if (what == "sum")
            {
                var sum = new DoUntil();
                sum.Result = sum.Sum((int)until.Until);
                return new JsonResult(sum);
            }
            else if (what == "factor")
            {
                var fact = new DoUntil();
                fact.Result = fact.Fact((int)until.Until);
                return new JsonResult(fact);
            }
            else
            {
                var doUntilError = new ErrorMsg("a number");
                return new JsonResult(doUntilError);
            }
        }

        [HttpPost("/arrays/{what}")]
        public IActionResult Arrays([FromRoute] string what, [FromBody] Numbers numbers)
        {
            if (what == "sum")
            {
                var sum = new ArrayMath();
                sum.Result = sum.ArraySum(numbers);
                return new JsonResult(sum);
            }
            return Ok();
        }

    }
}

