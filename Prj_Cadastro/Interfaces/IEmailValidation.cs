﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prj_Cadastro.Interfaces
{
    public interface IEmailValidation
    {
        bool IsValid(string email);
    }
}
