
using TimeBinder.Application.Interfaces;

namespace TimeBinder.Infrastructure.MongoDB.Services
{
    public class TimeService : ITimeService
    {
        public DateTime HorarioNow() => DateTime.UtcNow;
    }
}
