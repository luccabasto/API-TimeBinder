using TimeBinder.Domain.Entities;
using TimeBinder.WebAPI.DTOs.Request;

namespace TimeBinder.WebAPI.Mappers
{
    public static class DtoToEntityMapper
    {
        public static ToDo ToDomain(this CreateToDoRequest dto) =>
            new ToDo(dto.Title, dto.Description);

        public static Domain.Entities.Tarefa ToDomain(this CreateTarefaRequest dto, Guid toDoId) =>
            Domain.Entities.Tarefa.Criar(dto.Title, dto.Description, toDoId);

        public static Pomodoro ToDomain(this CreatePomodoroRequest dto) =>
            Pomodoro.Create(dto.Description, dto.FocusDuration, dto.BreakDuration, dto.TotalCycles, dto.ToDoId, dto.TaskId);
    }
}
