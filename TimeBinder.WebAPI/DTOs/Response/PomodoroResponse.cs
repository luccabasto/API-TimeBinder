namespace TimeBinder.WebAPI.DTOs.Response
{
    public class PomodoroResponse
    {
        public Guid Id { get; set; }
        public string? Description { get; set; }
        public int FocusDuration { get; set; }
        public int BreakDuration { get; set; }
        public int TotalCycles { get; set; }
        public int CurrentCycle { get; set; }
        public string Status { get; set; } = null!;
        public DateTime? StartDate { get; set; }
        public DateTime? FinishDate { get; set; }
    }
}
