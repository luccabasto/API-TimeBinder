using System;
using TimeBinder.Domain.Enums;
using TimeBinder.Domain.Execptions;

namespace TimeBinder.Domain.Entities
{
    public class Pomodoro
    {
        public Guid Id { get; private set; }
        public string? Description { get; private set; }

        public int FocusDuration { get; private set; }    // min
        public int BreakDuration { get; private set; }    // min
        public int TotalCycles { get; private set; }      // quantos ciclos o usuário quer fazer
        public int CurrentCycle { get; private set; } = 0;

        public PomodoroStatus Status { get; private set; } = PomodoroStatus.NaoIniciado;

        public DateTime? StartDate { get; private set; }
        public DateTime? FinishDate { get; private set; }

        public Guid? ToDoId { get; private set; }
        public Guid? TaskId { get; private set; }

        private Pomodoro() { }

        public static Pomodoro Create(string? description, int focusMinutes, int breakMinutes, int totalCycles, Guid? toDoId = null, Guid? taskId = null)
        {
            if (focusMinutes <= 0)
                throw new RegraNegocioException("A duração do foco deve ser maior que zero.");

            if (breakMinutes < 0)
                throw new RegraNegocioException("A duração da pausa não pode ser negativa.");

            if (totalCycles <= 0)
                throw new RegraNegocioException("O número de ciclos deve ser maior que zero.");

            return new Pomodoro
            {
                Id = Guid.NewGuid(),
                Description = description,
                FocusDuration = focusMinutes,
                BreakDuration = breakMinutes,
                TotalCycles = totalCycles,
                ToDoId = toDoId,
                TaskId = taskId
            };
        }

        public void Iniciar()
        {
            if (Status == PomodoroStatus.Finalizado)
                throw new RegraNegocioException("O Pomodoro já foi finalizado.");

            Status = PomodoroStatus.EmExecucao;
            StartDate = DateTime.UtcNow;
        }

        public void Pausar()
        {
            if (Status != PomodoroStatus.EmExecucao)
                throw new RegraNegocioException("O Pomodoro só pode ser pausado se estiver em execução.");

            Status = PomodoroStatus.Pausado;
        }

        public void Finalizar()
        {
            if (Status != PomodoroStatus.Pausado)
                throw new RegraNegocioException("O Pomodoro só pode ser retomado se estiver pausado.");

            Status = PomodoroStatus.EmExecucao;
        }

        public void FinalizarCycle()
        {
            if (Status != PomodoroStatus.EmExecucao && Status != PomodoroStatus.Pausado)
                throw new RegraNegocioException("O ciclo só pode ser finalizado se estiver em execução ou pausado.");

            CurrentCycle++;

            if (CurrentCycle >= TotalCycles)
            {
                Status = PomodoroStatus.Finalizado;
                FinishDate = DateTime.UtcNow;
            }
            else
            {
                Status = PomodoroStatus.NaoIniciado;
            }
        }

        public void Reiniciar()
        {
            CurrentCycle = 0;
            Status = PomodoroStatus.NaoIniciado;
            StartDate = null;
            FinishDate = null;
        }
    }
}
