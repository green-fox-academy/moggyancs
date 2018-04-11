using Microsoft.AspNetCore.Mvc;
using ToDoApp.Models;
using ToDoApp.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ToDoApp.Controllers
{
    [Route("/Todo")]
    public class ToDoController : Controller
    {
        IDoThingsRepo MyToDos;

        public ToDoController(IDoThingsRepo myToDos)
        {
            MyToDos = myToDos;
        }

        [Route("/")]
        [Route("/List")]
        [HttpGet]
        public IActionResult List()
        {

            return View(MyToDos.Read());
        }

        [Route("/Add")]
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [Route("/Create")]
        [HttpPost]
        public IActionResult Create(string Title, bool IsUrgent)
        {
            ToDo thing = new ToDo(Title, IsUrgent);
            MyToDos.Create(thing);
            return RedirectToAction("List");
        }
    }
}
