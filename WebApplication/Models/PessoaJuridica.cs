using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class PessoaJuridica : Pessoa
    {
        public String NomeFantasia { get; set; }
        public String CNPJ { get; set; }
        public String RazaoSocial { get; set; }
        public DateTime DataAbertura { get; set; }
        public String InscricaoEstadual { get; set; }

        public virtual ICollection<Orcamento> Orcamentos { get; set; }
    }
}