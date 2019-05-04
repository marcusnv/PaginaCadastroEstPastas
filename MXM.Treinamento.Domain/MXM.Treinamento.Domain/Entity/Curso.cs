using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MXM.Treinamento.Domain.Entity
{
    public class Curso
    {
        public virtual Int32 Identificador { get; set; }
        public virtual String Codigo { get; set; }
        public virtual String Descricao { get; set; }
        public virtual String Ativo { get; set; }

        public virtual IList<PreRequisitoCurso> PreRequisitos{ get; set; }
        public virtual IList<Instrutor> Instrutor { get; set; }
    }
}
