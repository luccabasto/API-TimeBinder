using TimeBinder.Application.Interfaces;
using TimeBinder.Domain.Interfaces;
using TimeBinder.Infrastructure.MongoDB.Configurations;
using TimeBinder.Infrastructure.MongoDB.Contexts;
using TimeBinder.Infrastructure.MongoDB.Repositories;
using TimeBinder.Infrastructure.MongoDB.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Configure<MongoConfiguration>(
    builder.Configuration.GetSection("Mongo"));
builder.Services.AddSingleton<MongoDbContext>();
builder.Services.AddScoped<IToDoRepository, ToDoRepository>();
builder.Services.AddScoped<ITarefaRepository, TarefaRepository>();
builder.Services.AddScoped<IPomodoroRepository, PomodoroRepository>();

builder.Services.AddScoped<INotificationService, NotificationService>();
builder.Services.AddScoped<ITimeService, TimeService>();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
