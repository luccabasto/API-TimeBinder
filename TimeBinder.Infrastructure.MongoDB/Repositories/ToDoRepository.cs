using MongoDB.Driver;
using TimeBinder.Domain.Entities;
using TimeBinder.Domain.Interfaces;
using TimeBinder.Infrastructure.MongoDB.Contexts;

namespace TimeBinder.Infrastructure.MongoDB.Repositories
{
    public class ToDoRepository : IToDoRepository
    {
        private readonly MongoDbContext _context;
        public ToDoRepository(MongoDbContext context) => _context = context;

        public async Task AddAsync(ToDo todo) =>
            await _context.ToDos.InsertOneAsync(todo);

        public async Task DeleteAsync(Guid id) =>
            await _context.ToDos.DeleteOneAsync(x => x.Id == id);

        public async Task<List<ToDo>> GetAllAsync() =>
            await _context.ToDos.Find(_ => true).ToListAsync();

        public async Task<ToDo?> GetByIdAsync(Guid id) =>
            await _context.ToDos.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task UpdateAsync(ToDo todo) =>
            await _context.ToDos.ReplaceOneAsync(x => x.Id == todo.Id, todo);
    }
}
