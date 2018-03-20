using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        
    }
}