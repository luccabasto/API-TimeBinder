using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeBinder.Domain.Enums;
using TimeBinder.Domain.Execptions;

namespace TimeBinder.Domain.Entities
{
    public class Tarefa
    {
        public Guid Id { get; set; }

        public Guid ToDoId { get; set; }
        public string Title { get; set; } = null;
        public string Description { get; set; } = null;

        /*public string Flag { get; set; } = null; */
        public TarefaProgressStatus Status { get; set; } = TarefaProgressStatus.NaoIniciado;
        public DateTime StartDate { get; set; } = DateTime.UtcNow;
        public DateTime FinishAt { get; set; }


        private Tarefa() { }

        public static Tarefa Criar(string title, string description, Guid toDoId)
        {
           if (toDoId == Guid.Empty)
                throw new RegraNegocioException("O ToDoId não pode ser vazio.");

           if (string.IsNullOrWhiteSpace(title))
                throw new RegraNegocioException("O título não pode ser vazio.");
           if (string.IsNullOrWhiteSpace(description))
                throw new RegraNegocioException("A descrição não pode ser vazia.");

            return new Tarefa
            {
                Id = Guid.NewGuid(),
                Title = title,
                Description = description,
                ToDoId = toDoId,
                Status = TarefaProgressStatus.NaoIniciado,
                StartDate = DateTime.UtcNow
            };
        }

        public void Iniciar(DateTime dateTime)
        {
            if (Status == Enums.TarefaProgressStatus.Concluido)
                throw new RegraNegocioException("Não é possível iniciar uma tarefa já concluída.");

            Status = TarefaProgressStatus.EmAndamento;
            StartDate = DateTime.UtcNow;
        }


        public void Pausar()
        {
            if (Status != TarefaProgressStatus.EmAndamento)
                throw new RegraNegocioException("Não é possível pausar uma tarefa que não está em andamento.");

            Status = TarefaProgressStatus.Pausado;
        }

        public void Finalizar()
        {
            if (Status == TarefaProgressStatus.NaoIniciado)
                throw new RegraNegocioException("Não é possível finalizar uma tarefa que não foi iniciada.");
            if (Status == TarefaProgressStatus.Concluido)
                throw new RegraNegocioException("A task já está finalizada.");

            Status = TarefaProgressStatus.Concluido;
            FinishAt = DateTime.UtcNow;
        }

        public void MarcarComoEmAndamento()
        {
            if (Status == TarefaProgressStatus.NaoIniciado)
                Status = TarefaProgressStatus.EmAndamento;
        }

     
        public void Reiniciar()
        {
            if (Status == TarefaProgressStatus.Concluido)
                throw new RegraNegocioException("Não é possível reiniciar uma tarefa já concluída.");
            Status = TarefaProgressStatus.EmAndamento;
            StartDate = DateTime.UtcNow;
            FinishAt = default;
        }
    }
}
