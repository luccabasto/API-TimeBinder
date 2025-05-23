namespace TimeBinder.WebAPI.DTOs.Response
{
    public class TarefaResponse
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Flag { get; set; } = null!;
        public string Status { get; set; } = null!;
        public DateTime? StartDate { get; set; }
        public DateTime? FinishDate { get; set; }
    }
}
