using Anagram.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Anagram.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        IsAnagram AnagramChecker;

        public HomeController(IsAnagram anagramChecker)
        {
            AnagramChecker = anagramChecker;
        }

        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("/")]
        public IActionResult Checker()
        {
            return View();
        }


    }
}
