using System.ComponentModel.DataAnnotations;

namespace ProgrammingTasks.Models
{
    public class ModifyTaskDto
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
