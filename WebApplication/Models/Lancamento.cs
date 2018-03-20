using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class Lancamento
    {
        [Key]
        public int LancamentoId { get; set; }
        public DateTime Data { get; set; }
        public String Tipo { get; set; }
        public String Descricao { get; set; }
        public decimal Valor { get; set; }
        public int Parcelado { get; set; }
        public int TotalParcelas { get; set; }
    }
}