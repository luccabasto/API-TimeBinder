using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeBinder.Domain.Entities;

namespace TimeBinder.Domain.Interfaces
{
    public interface ITarefaRepository
    {
        Task<Tarefa> GetByIdAsync(Guid id);
        Task<List<Tarefa>> GetByToDoIdAsync(Guid toDoId);
        Task AddAsync(Tarefa tarefa);
        Task UpdateAsync(Tarefa tarefa);
        Task DeleteAsync(Guid id);
    }
}
