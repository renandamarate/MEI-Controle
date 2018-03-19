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
        private int EnderecoId { get; }
        private String Cep { get; set; }
        private String Rua { get; set; }
        private String Bairro { get; set; }
        private String Cidade { get; set; }
        private String Pais { get; set; }
        private String Complemento { get; set; }

    }
}