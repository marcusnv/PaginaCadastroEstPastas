using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MXM.Treinamento.Domain.Entity
{
    public class PreRequisitoCurso
    {
        public virtual Int32 Identificador { get; set; }
        public virtual String Descricao { get; set; }
        public virtual Curso Curso { get; set; }
    }
}
