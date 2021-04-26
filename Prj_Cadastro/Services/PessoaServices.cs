using Prj_Cadastro.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prj_Cadastro.Entities
{
    public class PessoaServices : IPessoaServices
    {
        private readonly IPessoaDB _pessoaDB;

        public PessoaServices(IPessoaDB pessoaDB)
        {
            _pessoaDB = pessoaDB;
        }

        public string addPessoa(Pessoa p)
        {
            if (!p.IsValid())
                return "Dados enviados são inválidos!";

            _pessoaDB.addPessoa(p);

            return "Pessoa adicionada com sucesso";
        }

        public string removePessoa(Pessoa p)
        {
            _pessoaDB.removePessoa(p);

            return "Pessoa removida com sucesso";
        }

        public string updatePessoa(Pessoa p)
        {
            _pessoaDB.updatePessoa(p);

            return "Dados de pessoa atualizados com sucesso";
        }

        public List<Pessoa> listPessoas()
        {
            return _pessoaDB.listPessoas();
        }

    }
}
