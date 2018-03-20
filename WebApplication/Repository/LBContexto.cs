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
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Telefone> Telefone { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Profissional> Profissional { get; set; }
        public DbSet<Compromisso> Compromisso { get; set; }
        public DbSet<PessoaFisica> PessoaFisica { get; set; }
        public DbSet<PessoaJuridica> PessoaJuridica { get; set; }
    }
}