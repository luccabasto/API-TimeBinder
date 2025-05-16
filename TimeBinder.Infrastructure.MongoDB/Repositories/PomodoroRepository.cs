using MongoDB.Driver;
using TimeBinder.Domain.Entities;
using TimeBinder.Domain.Interfaces;
using TimeBinder.Infrastructure.MongoDB.Contexts;

namespace TimeBinder.Infrastructure.MongoDB.Repositories
{
    public class PomodoroRepository : IPomodoroRepository
    {
        private readonly MongoDbContext _context;
        public PomodoroRepository(MongoDbContext context) => _context = context;

        public async Task AddAsync(Pomodoro pomodoro) =>
            await _context.Pomodoros.InsertOneAsync(pomodoro);

        public async Task DeleteAsync(Guid id) =>
            await _context.Pomodoros.DeleteOneAsync(x => x.Id == id);

        public async Task<List<Pomodoro>> GetByTaskIdAsync(Guid taskId) =>
            await _context.Pomodoros.Find(x => x.TaskId == taskId).ToListAsync();

        public async Task<List<Pomodoro>> GetByToDoIdAsync(Guid toDoId) =>
            await _context.Pomodoros.Find(x => x.ToDoId == toDoId).ToListAsync();

        public async Task<Pomodoro?> GetByIdAsync(Guid id) =>
            await _context.Pomodoros.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task UpdateAsync(Pomodoro pomodoro) =>
            await _context.Pomodoros.ReplaceOneAsync(x => x.Id == pomodoro.Id, pomodoro);
    }
}
