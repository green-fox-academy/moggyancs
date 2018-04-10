using Microsoft.AspNetCore.Mvc;
using ToDoApp.Models;
using ToDoApp.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ToDoApp.Controllers
{
    [Route("/todo")]
    public class ToDoController : Controller
    {
        IDoThingsRepo MyToDos;

        public ToDoController(IDoThingsRepo myToDos)
        {
            MyToDos = myToDos;
        }

        [Route("/")]
        [Route("/list")]
        [HttpGet]
        public IActionResult List()
        {

            return View(MyToDos.Read());
        }

        [Route("/add")]
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [Route("/create")]
        [HttpPost]
        public IActionResult Create(string Title, bool IsUrgent)
        {
            ToDo thing = new ToDo(Title, IsUrgent);
            MyToDos.Create(thing);
            return RedirectToAction("list");
        }
    }
}
