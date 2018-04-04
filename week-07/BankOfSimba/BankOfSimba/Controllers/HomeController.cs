using BankOfSimba.Models;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BankOfSimba.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/


        [Route("summary")]
        public IActionResult Index()
        {
            BankAccounts accounts = new BankAccounts();

            return View(accounts);
        }
    }
}
