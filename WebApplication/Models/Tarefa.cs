using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class Tarefa
    {
        [Key]
        public int TarefaId { get; set; }
        public String Titulo { get; set; }
        public String Descricao { get; set; }
        public int Status { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFinal { get; set; }
        public TimeSpan HoraEstimada { get; set; }
        public TimeSpan HoraGasta { get; set; }
        public String Situacao { get; set; }

        [ForeignKey("Projeto")]
        public int ProjetoId { get; set; }
        public virtual Projeto Projeto { get; set; }
    }
}