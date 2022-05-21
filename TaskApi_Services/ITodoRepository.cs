using MyTaskToday.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskApi_Services
{
    public interface ITodoRepository
    {
        public List<ToDo> AllTodos();
    }
}
