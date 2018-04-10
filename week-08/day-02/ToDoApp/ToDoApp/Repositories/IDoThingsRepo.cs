using System.Collections.Generic;
using ToDoApp.Models;

namespace ToDoApp.Repositories
{
    public interface IDoThingsRepo
    {
        void Create(ToDo thing);
        List<ToDo> Read();
        void Update(long id);
        void Delete(long id);
    }
}