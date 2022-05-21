using MyTaskToday.Models;
using TaskApi_Services;

namespace MyTaskToday.Services
{
    public class ToDoService : ITodoRepository
    {

        public List<ToDo> AllTodos()
        {
            var mydo = new List<ToDo>();

            var todo1 = new ToDo
            {
                Id = 1,
                Title = "Get Book For School",
                Description = "Text",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = ToDoStatus.New

            };
            mydo.Add(todo1);


            var todo2 = new ToDo
            {
                Id = 2,
                Title = "Get Book For School",
                Description = "Text",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = ToDoStatus.Completed

            };
            mydo.Add(todo2);



            return mydo;

        }
    }
}
