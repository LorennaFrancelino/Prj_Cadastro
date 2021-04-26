using Prj_Cadastro.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prj_Cadastro.Entities
{
    public class Pessoa
    {
        private readonly IEmailValidation vEmail;
        private readonly ICpfValidation vCpf;

        public Pessoa(string nome, string sobrenome, DateTime dtNascimento, string email, string cpf, string celular, string ocupacao, DateTime datacadastro)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Email = nome;
            this.CPF = sobrenome;
            this.DtNascimento = dtNascimento;
            this.Celular = celular;
            this.Ocupacao = ocupacao;
            this.DataCadastro = datacadastro;
        }

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public string Celular { get; set; }
        public string Ocupacao { get; set; }

        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataCadastro { get; set; }

        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DtNascimento { get; set; }        

        public bool IsValid()
        {
            return vEmail.IsValid(Email) && vCpf.IsValid(CPF);
        }
    }
}
