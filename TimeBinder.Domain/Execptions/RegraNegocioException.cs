using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeBinder.Domain.Execptions
{
   public class RegraNegocioException : Exception
    {
        public RegraNegocioException(string message) : base(message)
        {
        }
    }
}
