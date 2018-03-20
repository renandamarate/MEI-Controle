using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class Pessoa
    {
        [Key]
        public int PessoaId { get; set; }

        public String Nome { get; set; }
        public String Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public virtual ICollection<Endereco> Enderecos { get; set; }
        public virtual ICollection<Telefone> Telefones { get; set; }
        
    }
}