using Prj_Cadastro.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prj_Cadastro.Entities
{
    public class CpfValidation : ICpfValidation
    {
        public bool IsValid(string cpf)
        {
            return cpf.Length == 11;
        }
    }
}
