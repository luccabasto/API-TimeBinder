using TimeBinder.Domain.Entities;
using TimeBinder.WebAPI.DTOs.Response;

namespace TimeBinder.WebAPI.Mappers
{
    public static class EntityToResponseMapper
    {
        public static ToDoResponse ToToDoResponse(ToDo todo) =>
            new ToDoResponse
            {
                Id = todo.Id,
                Title = todo.Title,
                Description = todo.Description,
                Status = todo.Status.ToString()
            };

        public static IEnumerable<ToDoResponse> ToToDoResponseList(IEnumerable<ToDo> todos) =>
            todos.Select(ToToDoResponse);

        public static TarefaResponse ToTaskResponse(Domain.Entities.Tarefa task) =>
            new TarefaResponse
            {
                Id = task.Id,
                Title = task.Title,
                Description = task.Description,
                Status = task.Status.ToString(),
                StartDate = task.StartDate,
                FinishDate = task.FinishAt
            };

        public static IEnumerable<TarefaResponse> ToTaskResponseList(IEnumerable<Domain.Entities.Tarefa> tasks) =>
            tasks.Select(ToTaskResponse);

        public static PomodoroResponse ToPomodoroResponse(Pomodoro pomo) =>
            new PomodoroResponse
            {
                Id = pomo.Id,
                Description = pomo.Description,
                FocusDuration = pomo.FocusDuration,
                BreakDuration = pomo.BreakDuration,
                TotalCycles = pomo.TotalCycles,
                CurrentCycle = pomo.CurrentCycle,
                Status = pomo.Status.ToString(),
                StartDate = pomo.StartDate,
                FinishDate = pomo.FinishDate
            };
    }
}
