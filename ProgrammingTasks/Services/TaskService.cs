using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProgrammingTasks.Entities;
using ProgrammingTasks.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingTasks.Services
{
    public class TaskService : ITaskService
    {
        private readonly TaskDbContext _taskDbContext;
        private readonly IMapper _mapper;

        public TaskService(TaskDbContext taskDbContext, IMapper mapper)
        {
            _taskDbContext = taskDbContext;
            _mapper = mapper;
        }
        public IEnumerable<TaskDto> GetAllTasks()
        {
            var tasks = _taskDbContext.Tasks.Include(t => t.Tests).ToList();

            var tasksDtos = _mapper.Map<List<TaskDto>>(tasks);

            return tasksDtos;
        }

        public TaskDto GetTask(int taskId)
        {
            var task = _taskDbContext.Tasks.Include(t => t.Tests).FirstOrDefault(t => t.Id == taskId);

            if (task is null)
            {
                return null;
            }

            var taskDto = _mapper.Map<TaskDto>(task);

            return taskDto;
        }

        public int CreateTask(CreateTaskDto dto)
        {
            var task = _mapper.Map<Task>(dto);

            _taskDbContext.Tasks.Add(task);
            _taskDbContext.SaveChanges();

            return task.Id;
        }

        public bool DeleteTask(int id)
        {
            var task = _taskDbContext.Tasks.Include(t => t.Tests).FirstOrDefault(t => t.Id == id);

            if (task is null)
                return false;

            _taskDbContext.Tasks.Remove(task);
            _taskDbContext.SaveChanges();

            return true;
        }

        public bool ModifyTask(ModifyTaskDto dto, int id)
        {
            var task = _taskDbContext.Tasks.FirstOrDefault(t => t.Id == id);

            if (task is null)
                return false;

            task.Name = dto.Name;
            task.Description = dto.Description;

            _taskDbContext.SaveChanges();

            return true;
        }
    }
}
