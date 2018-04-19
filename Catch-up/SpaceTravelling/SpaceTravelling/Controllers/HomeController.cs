using Microsoft.AspNetCore.Mvc;
using SpaceTravelling.Repositories;
using SpaceTravelling.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpaceTravelling.Controllers
{
    public class HomeController : Controller
    {
        ITravelInSpace spaceshipRepository;
        SpaceTravelVM vm;

        public HomeController(ITravelInSpace spaceshipRepository)
        {
            this.spaceshipRepository = spaceshipRepository;
            vm = new SpaceTravelVM()
            {
                Spaceship = spaceshipRepository.GetSpaceship(),
                Planets = spaceshipRepository.GetAllPlanets()
            };
        }

        [HttpGet("/")]
        public IActionResult Index()
        {
            return View("Index", vm);
        }

        [HttpPost("/movehere/{id}")]
        public IActionResult MoveHere([FromRoute] int id)
        {
            spaceshipRepository.TravelToPlanet(id);
            return RedirectToAction("Index");
        }

        [HttpGet("toship/{id}")]
        public IActionResult MoveToShip([FromRoute] int id)
        {
            spaceshipRepository.MoveToShip(id);
            return RedirectToAction("Index");
        }

        [HttpGet("toplanet/{id}")]
        public IActionResult MoveToPlanet([FromRoute] int id)
        {
            spaceshipRepository.MoveToPlanet(id);
            return RedirectToAction("Index");
        }
    }
}
