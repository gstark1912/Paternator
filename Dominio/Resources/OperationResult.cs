using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Resources
{
    public class OperationResult
    {
        public OperationResult()
        {
            this.Success = true;
        }

        public OperationResult(List<string> messages)
        {
            this.Success = false;
            Messages = messages;
        }

        public List<string> Messages { get; set; }
        public bool Success { get; set; }
    }
}
