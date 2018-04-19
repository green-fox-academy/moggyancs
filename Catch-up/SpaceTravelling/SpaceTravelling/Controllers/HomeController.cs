using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaceTravelling.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpaceTravelling.Controllers
{
    public class HomeController : Controller
    {
        SpaceshipRepository spaceshipRepository;

        public HomeController(SpaceshipRepository spaceshipRepository)
        {
            this.spaceshipRepository = spaceshipRepository;
        }

        [HttpGet ("/")]
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpPost ("/movehere/{id}")]
        public IActionResult MoveHere([FromRoute] int id)
        {

            return View("Index");
        }
    }
}
