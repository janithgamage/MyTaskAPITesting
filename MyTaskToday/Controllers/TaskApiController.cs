using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyTaskToday.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class TaskApiController : ControllerBase
    {
        [HttpGet]
        public string[] Task()
        {
            string[] abc=new string[] { "task1", "task2", "task3", "task4" };

            return abc;


        }

       

        [HttpPost]
        public IActionResult NewTaske()
        {
            
            return Ok();

        }

        [HttpPut]
        public IActionResult UpdateTaske()
        {

            return Ok();

        }

        [HttpDelete]
        public IActionResult DeleteTaske()
        {

            return Ok();

        }

    }


}
