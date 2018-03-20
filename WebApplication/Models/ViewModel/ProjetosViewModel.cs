using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models.ViewModel
{
    public class ProjetosViewModel
    {
        public List<ProjetoViewModel> Projetos { get; set; }
    }

    public class ProjetoViewModel
    {
        public int ProjetoId { get; set; }
        public List<TarefaViewModel> Tarefas { get; set; }
        public String Cliente { get; set; }
        public String Contato { get; set; }
        public decimal Entrada { get; set; }
        public decimal Saida { get; set; }
        public decimal Liquidez { get; set; }
        public decimal EntradaFutura { get; set; }
        public decimal SaidaFutura { get; set; }
        public decimal OrcamentoUtilizado { get; set; }
    }

    public class TarefaViewModel
    {
        public int TarefaId { get; set; }
        public String Tarefa { get; set; }
        public DateTime Data { get; set; }
    }
}