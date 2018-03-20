using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class Endereco
    {
        [Key]
        public int EnderecoId { get; set; }
        public String Cep { get; set; }
        public String Rua { get; set; }
        public String Bairro { get; set; }
        public String Cidade { get; set; }
        public String Pais { get; set; }
        public String Complemento { get; set; }

    }
}