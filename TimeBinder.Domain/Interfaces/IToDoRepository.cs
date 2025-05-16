using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeBinder.Domain.Entity;


namespace TimeBinder.Domain.Interfaces
{
    public interface IToDoRepository
    {
        Task<ToDo> GetByIdAsync(Guid id);
        Task<List<ToDo>> GetAllAsync();
        Task AddAsync(ToDo toDo);
        Task UpdateAsync(ToDo toDo);
        Task DeleteAsync(Guid id);
    }
}
