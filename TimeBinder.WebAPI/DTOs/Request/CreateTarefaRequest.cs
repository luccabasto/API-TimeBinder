namespace TimeBinder.WebAPI.DTOs.Request
{
    public class CreateTarefaRequest
    {
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;

        /* public string Flag { get; set; } = null!; */
    }
}
