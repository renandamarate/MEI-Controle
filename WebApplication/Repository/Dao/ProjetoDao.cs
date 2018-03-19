using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication.Models;

namespace WebApplication.Repository.Dao
{
    public class ProjetoDao : GenericDao<Projeto>
    {
        public override Projeto Get(int id)
        {
            return Contexto.Set<Projeto>().Where(p => p.ProjetoId == id).FirstOrDefault();
        }
    }
}