using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MXM.Treinamento.Domain.Entity
{
    public class Instrutor
    {
        public virtual Int32 Identificador { get; set; }
        public virtual String Nome { get; set; }
        public virtual String CPF { get; set; }
        public virtual DateTime? DataNascimento { get; set; }
        public virtual String Email { get; set; }
    }
}
