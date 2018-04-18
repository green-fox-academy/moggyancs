using Microsoft.AspNetCore.Mvc;
using MyReddit.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyReddit.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        ICrudReddit Reddit;

        public HomeController(ICrudReddit reddit)
        {
            Reddit = reddit;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
