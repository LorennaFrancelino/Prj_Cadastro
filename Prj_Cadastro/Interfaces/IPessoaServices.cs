using Prj_Cadastro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prj_Cadastro.Interfaces
{
    public interface IPessoaServices
    {
        string addPessoa(Pessoa p);
        string removePessoa(Pessoa p);
        string updatePessoa(Pessoa p);
        List<Pessoa> listPessoas();
    }
}
