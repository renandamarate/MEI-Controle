using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class Pessoa
    {
        [Key]
        public int PessoaId { get; set; }

        public String Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public Telefone Contato { get; set; }
        public virtual List<Endereco> Enderecos { get; set; }
        public virtual List<Telefone> Telefones { get; set; }
        public virtual List<Cliente> Clientes { get; set; }

    }
}