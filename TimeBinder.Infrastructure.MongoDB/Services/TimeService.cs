using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeBinder.Application.Interfaces;


namespace TimeBinder.Infrastructure.MongoDB.Services
{
    public class TimeService : ITimeService
    {
        public DateTime HoraNow() => DateTime.UtcNow;
    }
}
