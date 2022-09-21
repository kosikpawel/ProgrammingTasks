using ProgrammingTasks.Models;
using System.Collections.Generic;

namespace ProgrammingTasks.Services
{
    public interface ITaskService
    {
        int CreateTask(CreateTaskDto dto);
        bool DeleteTask(int id);
        IEnumerable<TaskDto> GetAllTasks();
        TaskDto GetTask(int taskId);
        bool ModifyTask(ModifyTaskDto dto, int id);
    }
}