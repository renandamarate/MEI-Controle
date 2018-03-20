using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class Compromisso
    {
        [Key]
        public int CompromissoId { get; set; }
        public TimeSpan HoraInicial { get; set; }
        public TimeSpan HoraFinal { get; set; }
        public DateTime Data { get; set; }
        public String Descricao { get; set; }

        [ForeignKey("Profissional")]
        public int ProfissionalId { get; set; }
        public virtual Profissional Profissional { get; set; }
    }
}