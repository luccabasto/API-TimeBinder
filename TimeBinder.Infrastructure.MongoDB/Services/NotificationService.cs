using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeBinder.Application.Interfaces;

namespace TimeBinder.Infrastructure.MongoDB.Services
{
    public class NotificationService : INotificationService
    {
        public Task AlertaAsync(string message)
        {
            // TODO: integrar com e-mail, push, etc.
            return Task.CompletedTask;
        }
    }
}
