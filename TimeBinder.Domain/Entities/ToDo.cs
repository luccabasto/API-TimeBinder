using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeBinder.Domain.Enums;
using TimeBinder.Domain.Execptions;

namespace TimeBinder.Domain.Entity
{
   public class ToDo
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = null;
        public string Description { get; set; } = null;
        public string Flag { get; set; } = null;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime FinishAt { get; set; }
        public ToDoStatus Status { get; set; } = ToDoStatus.NaoIniciado;

        public List<Task> Tasks { get; set; } = new List<Task>();

        public void MarcarComoConcluido()
        {
            Status = ToDoStatus.Concluido;
            FinishAt = DateTime.UtcNow;
        }

        public void MarcarEmProgresso()
        {
            if (Status == ToDoStatus.NaoIniciado)
                Status = ToDoStatus.EmAndamento;
        }

        public void AdicionarTask(Task task)
        {
            if (task == null)
                throw new ArgumentNullException(nameof(task));
            if (Tasks.Any(t => t.Id == task.Id))
                throw new RegraNegocioException("Não é permitido adicionar uma task duplicada ao ToDo.");
            Tasks.Add(task);
        }
    }
}
