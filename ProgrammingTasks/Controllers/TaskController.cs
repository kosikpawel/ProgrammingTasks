using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProgrammingTasks.Entities;
using ProgrammingTasks.Models;
using ProgrammingTasks.Services;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingTasks.Controllers
{
    [ApiController]
    [Route("api/task")]
    public class TaskController : ControllerBase
    {
        private readonly ITaskService _taskService;

        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet("allTasks")]
        public ActionResult<IEnumerable<TaskDto>> GetAllTasks()
        {
            var tasksDtos = _taskService.GetAllTasks();

            return Ok(tasksDtos);
        }

        [HttpGet("getTask/{taskId}")]
        public ActionResult<TaskDto> GetTask([FromRoute] int taskId)
        {
            var task = _taskService.GetTask(taskId);

            return Ok(task);
        }

        [HttpPost]
        public ActionResult CreateTask([FromBody] CreateTaskDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var id = _taskService.CreateTask(dto);

            return Created($"/api/task/getTask/{id}", null);
        }

        [HttpDelete("deleteTask/{id}")]
        public ActionResult DeleteTask([FromRoute] int id)
        {
            var result = _taskService.DeleteTask(id);

            if (result == false)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpPut("modifyTask/{id}")]
        public ActionResult ModifyTask([FromBody] ModifyTaskDto dto, int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            bool result = _taskService.ModifyTask(dto, id);

            if (result == false)
                return NotFound();

            return Ok();
        }
    }
}
