using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeBinder.Domain.Enums
{
    public enum TaskStatus
    {
        NaoIniciado,
        EmAndamento,
        Pausado,
       // Interrompido, validar se faz sentido
        Concluido,
    }
}
