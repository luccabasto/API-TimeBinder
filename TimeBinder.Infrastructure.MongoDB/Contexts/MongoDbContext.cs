using Microsoft.Extensions.Options;
using MongoDB.Driver;
using TimeBinder.Infrastructure.MongoDB.Configurations;
using TimeBinder.Domain.Entities;

namespace TimeBinder.Infrastructure.MongoDB.Contexts
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _database;

        public MongoDbContext(IOptions<MongoConfiguration> config)
        {
            var client = new MongoClient(config.Value.ConnectionString);
            _database = client.GetDatabase(config.Value.DatabaseName);
        }

        public IMongoCollection<ToDo> ToDos => _database.GetCollection<ToDo>("to-dos");
        public IMongoCollection<Tarefa> Tarefas => _database.GetCollection<Tarefa>("tarefas");
        public IMongoCollection<Pomodoro> Pomodoros => _database.GetCollection<Pomodoro>("pomodoros");
    }
}
