using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class PessoaFisica : Pessoa
    {
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}