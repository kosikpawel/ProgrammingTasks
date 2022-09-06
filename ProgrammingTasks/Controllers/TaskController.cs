using Microsoft.AspNetCore.Mvc;
using ProgrammingTasks.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingTasks.Controllers
{
    [ApiController]
    [Route("api/task")]
    public class TaskController : ControllerBase
    {
        private readonly TaskDbContext _taskDbContext;
        public TaskController(TaskDbContext taskDbContext)
        {
            _taskDbContext = taskDbContext;
        }

        [HttpGet("allTasks")]
        public ActionResult<IEnumerable<Task>> GetAllTasks()
        {
            var tasks = _taskDbContext.Tasks.ToList();
            return Ok(tasks);
        }

        [HttpGet("getTask/{taskId}")]
        public ActionResult<Task> GetTask([FromRoute] int taskId)
        {
            var task =  _taskDbContext.Tasks.FirstOrDefault(t => t.Id == taskId);

            if(task == null)
            {
                return NotFound();
            }

            return Ok(task);
        }
    }
}
