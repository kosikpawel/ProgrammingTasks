using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProgrammingTasks.Models
{
    public class CreateTaskDto
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public List<CreateTestDto> Tests { get; set; }
    }
}
