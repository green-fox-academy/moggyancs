using BankOfSimba.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BankOfSimba.Controllers
{
    [Route("simba")]
    public class HomeController : Controller
    {
        // GET: /<controller>/


        public IActionResult Index()
        {
            BankAccount simba = new BankAccount("Simba", "2000", "Lion");
            return View(simba);
        }
    }
}
