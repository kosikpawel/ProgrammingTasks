using ProgrammingTasks.Entities;
using System.Collections.Generic;

namespace ProgrammingTasks.Models
{
    public class TaskDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<TestDto> Tests { get; set; }
    }
}
