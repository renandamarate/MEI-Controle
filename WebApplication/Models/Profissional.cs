using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class Profissional : PessoaFisica
    {
        public String AreaAtuacao { get; set; }
        public String Login { get; set; }
        public String Senha { get; set; }

        [ForeignKey("PessoaJuridica")]
        public int PessoaJuridicaId { get; set; }
        public virtual PessoaJuridica PessoaJuridica { get; set; }
        
        public virtual ICollection<Compromisso> Compromissos { get; set; }
        public virtual ICollection<Projeto> Projetos { get; set; }
        public virtual ICollection<Orcamento> Orcamentos { get; set; }
    }
}