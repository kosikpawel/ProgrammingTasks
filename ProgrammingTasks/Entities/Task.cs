using System.Collections.Generic;

namespace ProgrammingTasks.Entities
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual List<Test> Tests { get; set; }
    }
}
