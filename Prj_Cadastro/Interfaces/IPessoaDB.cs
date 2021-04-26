using Prj_Cadastro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prj_Cadastro.Interfaces
{
    public interface IPessoaDB
    {
        void addPessoa(Pessoa p);
        void removePessoa(Pessoa p);
        void updatePessoa(Pessoa p);
        List<Pessoa> listPessoas();
    }
}
