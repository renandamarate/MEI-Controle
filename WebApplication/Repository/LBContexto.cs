using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication.Models;

namespace WebApplication.Repository
{
    public class LBContexto : DbContext
    {
        public static LBContexto Create()
        {
            return new LBContexto();
        }

        public DbSet<Projeto> Projeto { get; set; }
    }
}