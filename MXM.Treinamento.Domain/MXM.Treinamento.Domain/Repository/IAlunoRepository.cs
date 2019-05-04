using MXM.Treinamento.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MXM.Treinamento.Domain.Repository
{
    public interface IAlunoRepository : IRepository<Aluno>
    {
        IEnumerable<Aluno> ObterAlunos(String codigo, String nome, String cpf);
    }
}
