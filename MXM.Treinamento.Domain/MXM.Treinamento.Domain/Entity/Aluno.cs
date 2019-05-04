using System;

namespace MXM.Treinamento.Domain.Entity
{
    /*Propriedades “virtual”: É necessário trabalhar com propriedades virtuais no NHibernate 
     * devido a forma como ele implementa o recurso de lazy-load (carga tardia). Ele precisa disso
     * para criar a classe de proxy que permite a utilização desse recurso.*/

    public class Aluno
    {
        public virtual Int32 Identificador { get; set; }
        public virtual String Nome { get; set; }
        public virtual String CPF { get; set; }
        public virtual DateTime? DataNascimento { get; set; }
        public virtual String Email { get; set; }
    }
}
