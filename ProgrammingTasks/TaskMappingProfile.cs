using AutoMapper;
using ProgrammingTasks.Entities;
using ProgrammingTasks.Models;

namespace ProgrammingTasks
{
    public class TaskMappingProfile : Profile
    {
        public TaskMappingProfile()
        {
            CreateMap<Task, TaskDto>();
            CreateMap<Test, TestDto>();
        }
    }
}
