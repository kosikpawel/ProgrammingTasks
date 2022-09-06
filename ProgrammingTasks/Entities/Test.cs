namespace ProgrammingTasks.Entities
{
    public class Test
    {
        public int Id { get; set; }
        public string Input { get; set; }
        public string ExpectedOutput { get; set; }
        public int TaskId { get; set; }
        public virtual Task Task { get; set; }
    }
}
