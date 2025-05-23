namespace TimeBinder.WebAPI.DTOs.Request
{
    public class CreatePomodoroRequest
    {
        public string? Description { get; set; }
        public int FocusDuration { get; set; }
        public int BreakDuration { get; set; }
        public int TotalCycles { get; set; }
        public Guid? ToDoId { get; set; }
        public Guid? TaskId { get; set; }
    }
}
