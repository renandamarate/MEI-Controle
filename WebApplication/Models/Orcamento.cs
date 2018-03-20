using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class Orcamento
    {
        [Key]
        public int OrcamentoId { get; set; }
        public DateTime DataOrcamento { get; set; }
        public DateTime ValidadeOrcamento { get; set; }
        public decimal CustoOrcamento { get; set; }
        public decimal LucroEsperado { get; set; }
        public decimal ValorOrcamento { get; set; }
        public int Status { get; set; }
        public String Situacao { get; set; }

        [ForeignKey("Cliente")]
        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }

        [ForeignKey("PessoaJuridica")]
        public int PessoaJuridicaId { get; set; }
        public virtual PessoaJuridica PessoaJuridica { get; set; }

        [ForeignKey("Profissional")]
        public int ProfissionalId { get; set; }
        public virtual Profissional Profissional { get; set; }
    }
}