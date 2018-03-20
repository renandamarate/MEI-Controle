using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class Telefone
    {
        [Key]
        public int TelefoneId { get; }
        public String Numero { get; set; }
        public String DDD { get; set; }
        public String CodigoPais { get; set; }
    }
}