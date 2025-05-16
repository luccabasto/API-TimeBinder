using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeBinder.Domain.Entities;

namespace TimeBinder.Domain.Interfaces
{
    public interface IPomodoroRepository
    {
        Task<Pomodoro> GetByIdAsync(Guid id);
        Task<List<Pomodoro>> GetByTaskIdAsync(Guid taskId);
        Task<List<Pomodoro>> GetByToDoIdAsync(Guid toDoId);
        Task AddAsync(Pomodoro pomodoro);
        Task UpdateAsync(Pomodoro pomodoro);
        Task DeleteAsync(Guid id);
    }
}
