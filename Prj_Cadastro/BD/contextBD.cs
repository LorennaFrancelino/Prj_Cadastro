using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Prj_Cadastro.BD
{
    public class contextBD : DbContext
    {
        public contextBD() : base("name=DBConnection")
        {
        }
        public System.Data.Entity.DbSet<Prj_Cadastro.Entities.Pessoa> Pessoas { get; set; }
    }
}
