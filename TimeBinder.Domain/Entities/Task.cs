using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeBinder.Domain.Enums;
using TimeBinder.Domain.Execptions;

namespace TimeBinder.Domain.Entities
{
    public class Task
    {
        public Guid Id { get; set; }

        public Guid ToDoId { get; set; }
        public string Title { get; set; } = null;
        public string Description { get; set; } = null;

        /*public string Flag { get; set; } = null; */
        public TaskProgressStatus Status { get; set; } = TaskProgressStatus.NaoIniciado;
        public DateTime StartDate { get; set; } = DateTime.UtcNow;
        public DateTime FinishAt { get; set; }


        private Task() { }

        public static Task Create(string title, string description, Guid toDoId)
        {
           if (toDoId == Guid.Empty)
                throw new RegraNegocioException("O ToDoId não pode ser vazio.");

           if (string.IsNullOrWhiteSpace(title))
                throw new RegraNegocioException("O título não pode ser vazio.");
           if (string.IsNullOrWhiteSpace(description))
                throw new RegraNegocioException("A descrição não pode ser vazia.");

            return new Task
            {
                Id = Guid.NewGuid(),
                Title = title,
                Description = description,
                ToDoId = toDoId,
                Status = TaskProgressStatus.NaoIniciado,
                StartDate = DateTime.UtcNow
            };
        }

        public void Iniciar(DateTime dateTime)
        {
            if (Status == Enums.TaskProgressStatus.Concluido)
                throw new RegraNegocioException("Não é possível iniciar uma tarefa já concluída.");

            Status = TaskProgressStatus.EmAndamento;
            StartDate = DateTime.UtcNow;
        }


        public void Pausar()
        {
            if (Status != TaskProgressStatus.EmAndamento)
                throw new RegraNegocioException("Não é possível pausar uma tarefa que não está em andamento.");

            Status = TaskProgressStatus.Pausado;
        }

        public void Finalizar()
        {
            if (Status == TaskProgressStatus.NaoIniciado)
                throw new RegraNegocioException("Não é possível finalizar uma tarefa que não foi iniciada.");
            if (Status == TaskProgressStatus.Concluido)
                throw new RegraNegocioException("A task já está finalizada.");

            Status = TaskProgressStatus.Concluido;
            FinishAt = DateTime.UtcNow;
        }

        public void MarcarComoEmAndamento()
        {
            if (Status == TaskProgressStatus.NaoIniciado)
                Status = TaskProgressStatus.EmAndamento;
        }

     
        public void Reiniciar()
        {
            if (Status == TaskProgressStatus.Concluido)
                throw new RegraNegocioException("Não é possível reiniciar uma tarefa já concluída.");
            Status = TaskProgressStatus.EmAndamento;
            StartDate = DateTime.UtcNow;
            FinishAt = default;
        }
    }
}
