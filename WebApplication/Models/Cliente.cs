using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class Cliente : PessoaFisica
    {
        [Key]
        public int ClienteId { get; }
        public DateTime DataModificacao { get; set; }
    }
}