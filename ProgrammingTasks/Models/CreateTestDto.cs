using System.ComponentModel.DataAnnotations;

namespace ProgrammingTasks.Models
{
    public class CreateTestDto
    {
        [Required]
        public string Input { get; set; }
        [Required]
        public string ExpectedOutput { get; set; }
    }
}
