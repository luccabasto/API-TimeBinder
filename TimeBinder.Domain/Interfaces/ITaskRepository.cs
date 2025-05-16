using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeBinder.Domain.Interfaces
{
    public interface ITaskRepository
    {
        Task<Task> GetByIdAsync(Guid id);
        Task<List<Task>> GetByToDoIdAsync(Guid toDoId);
        Task AddAsync(Task task);
        Task UpdateAsync(Task task);
        Task DeleteAsync(Guid id);
    }
}
