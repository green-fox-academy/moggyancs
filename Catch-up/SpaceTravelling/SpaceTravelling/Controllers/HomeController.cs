using Microsoft.AspNetCore.Mvc;
using SpaceTravelling.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpaceTravelling.Controllers
{
    public class HomeController : Controller
    {
        ICrudSpaceX Space;

        public HomeController(ICrudSpaceX space)
        {
            Space = space;
        }

        [HttpGet("/")]
        public IActionResult Index()
        {
            return View(Space.GetAllPlanets());
        }
    }
}
