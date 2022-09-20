using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProgrammingTasks.Entities;
using ProgrammingTasks.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingTasks.Controllers
{
    [ApiController]
    [Route("api/task")]
    public class TaskController : ControllerBase
    {
        private readonly TaskDbContext _taskDbContext;
        private readonly IMapper _mapper;
        public TaskController(TaskDbContext taskDbContext, IMapper mapper)
        {
            _taskDbContext = taskDbContext;
            _mapper = mapper;
        }

        [HttpGet("allTasks")]
        public ActionResult<IEnumerable<TaskDto>> GetAllTasks()
        {
            var tasks = _taskDbContext.Tasks.Include(t => t.Tests).ToList();

            var tasksDtos = _mapper.Map<List<TaskDto>>(tasks);

            return Ok(tasksDtos);
        }

        [HttpGet("getTask/{taskId}")]
        public ActionResult<TaskDto> GetTask([FromRoute] int taskId)
        {
            var task =  _taskDbContext.Tasks.Include(t => t.Tests).FirstOrDefault(t => t.Id == taskId);

            if (task == null)
            {
                return NotFound();
            }

            var taskDto = _mapper.Map<TaskDto>(task);

            return Ok(taskDto);
        }
    }
}
