using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeBinder.Domain.Enums
{
    public enum TaskProgressStatus
    {
        NaoIniciado,
        EmAndamento,
        Pausado,
        Concluido,
       /* Interrompido, validar se faz sentido */
    }
}
