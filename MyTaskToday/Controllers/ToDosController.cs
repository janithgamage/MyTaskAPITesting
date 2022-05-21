using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyTaskToday.Models;
using MyTaskToday.Services;

namespace MyTaskToday.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class ToDosController : ControllerBase
    {
        private ToDoService _toDoService;

        public ToDosController()
        {
            _toDoService=new ToDoService();
        }

        [HttpGet]
        public IActionResult GetTodos()
        {

            var list = _toDoService. AllTodos();
            return Ok(list);
        
        }

        

    }


}
