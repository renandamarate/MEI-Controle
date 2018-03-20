using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class Projeto
    {
        [Key]
        public int ProjetoId { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataModificacao { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        public String Descricao { get; set; }
        public int Status { get; set; }
        public Decimal Gastos { get; set; }
        public Decimal CustoFinal { get; set; }
        public DateTime TotalHorasGatas { get; set; }

        [ForeignKey("Profissional")]
        public int ProfissionalId { get; set; }
        public virtual Profissional Profissional { get; set; }

        public virtual ICollection<Orcamento> Orcamentos { get; set; }
        public virtual ICollection<Lancamento> Lancamentos { get; set; }
        public virtual ICollection<Tarefa> Tarefas { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}