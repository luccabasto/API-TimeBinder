using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using TimeBinder.Domain.Entities;
using TimeBinder.Domain.Interfaces;
using TimeBinder.Infrastructure.MongoDB.Contexts;

namespace TimeBinder.Infrastructure.MongoDB.Repositories
{
    public class TarefaRepository : ITarefaRepository
    {
        private readonly MongoDbContext _context;
        public TarefaRepository(MongoDbContext context) => _context = context;
        public async Task AddAsync(Tarefa tarefa) =>
            await _context.Tarefas.InsertOneAsync(tarefa);
        public async Task DeleteAsync(Guid id) =>
            await _context.Tarefas.DeleteOneAsync(x => x.Id == id);
        public async Task<List<Tarefa>> GetByToDoIdAsync(Guid toDoId) =>
            await _context.Tarefas.Find(x => x.ToDoId == toDoId).ToListAsync();
        public async Task<Tarefa?> GetByIdAsync(Guid id) =>
            await _context.Tarefas.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task UpdateAsync(Tarefa tarefa) =>
            await _context.Tarefas.ReplaceOneAsync(x => x.Id == tarefa.Id, tarefa);
    }
}
