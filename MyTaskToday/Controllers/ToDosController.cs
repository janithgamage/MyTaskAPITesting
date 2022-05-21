using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using MyTaskToday.Services;
using TaskApi_Services;

namespace MyTaskToday.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class ToDosController : ControllerBase
    {
       // private ToDoService _toDoService;
        private ITodoRepository _toDoService; //After depndency injection

        public ToDosController(ITodoRepository todoRepository)
        {
           // _toDoService=new ToDoService();
            _toDoService= todoRepository;  //After depndency injection
        }

        [HttpGet]
        public IActionResult GetTodos()
        {

            var list = _toDoService. AllTodos();
            return Ok(list);
        
        }

        

    }


}
