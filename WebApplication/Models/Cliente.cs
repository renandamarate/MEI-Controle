using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class Cliente : PessoaFisica
    {
        public DateTime DataCadastro { get; set; }
        public DateTime DataModificacao { get; set; }
    }
}