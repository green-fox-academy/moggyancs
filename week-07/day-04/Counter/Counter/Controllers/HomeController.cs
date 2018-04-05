using Counter.Services;
using Microsoft.AspNetCore.Mvc;

namespace Counter.Controllers
{
    public class HomeController : Controller
    {
        IVisitorIncrement visitor;
        public HomeController(IVisitorIncrement _visitor)
        {
            visitor = _visitor;
        }

        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            return View(visitor.GetVisitors());
        }
    }
}