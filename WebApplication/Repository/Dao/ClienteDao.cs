using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication.Models;

namespace WebApplication.Repository.Dao
{
    public class ClienteDao : GenericDao<Cliente>
    {
        public override Cliente Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}