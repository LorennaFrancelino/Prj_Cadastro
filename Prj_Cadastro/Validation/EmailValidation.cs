using Prj_Cadastro.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prj_Cadastro.Entities
{
    public class EmailValidation : IEmailValidation
    {
        public bool IsValid(string email)
        {
            return email.Contains("@");
        }
    }
}
