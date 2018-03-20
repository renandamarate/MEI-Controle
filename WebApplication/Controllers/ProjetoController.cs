using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication.Business.BC;
using WebApplication.Models;
using WebApplication.Models.ViewModel;
using WebApplication.Repository;
using WebApplication.Repository.Dao;

namespace WebApplication.Controllers
{
    public class ProjetoController : Controller
    {
        private ProjetoBc projetoBc = new ProjetoBc();

        // GET: Projeto
        public ActionResult Index()
        {
            //Criei uma viewModel para mostrar na Tela apenas o básico.
            //Demais telas precisam requisitar o objeto completo.
            //Método não funciona pois não foi tratado HTML
            ProjetosViewModel projetoModel = new ProjetosViewModel();
            
            foreach(var item in projetoBc.Get())
            {
                var cliente = item.Clientes.FirstOrDefault();
                var telefone = cliente.Telefones.FirstOrDefault();
                var model = new ProjetoViewModel
                {
                    Cliente = cliente.Nome,
                    Contato = String.Format("+{0} ({1}) {2}", telefone.CodigoPais, telefone.DDD, telefone.Numero),
                    ProjetoId = item.ProjetoId,
                    Entrada = item.Lancamentos.Where(p => p.Parcelado == 1 && p.Tipo == "Entrada").Sum(p => p.Valor),
                    Saida = item.Lancamentos.Where(p => p.Parcelado == 1 && p.Tipo == "Saida").Sum(p => p.Valor),
                    EntradaFutura = item.Lancamentos.Where(p => p.Parcelado != -1 && p.Tipo == "Entrada").Sum(p => p.Valor),
                    SaidaFutura = item.Lancamentos.Where(p => p.Parcelado != -1 && p.Tipo == "Saida").Sum(p => p.Valor),

                };
                model.Liquidez = model.Entrada - model.Saida;
                var N1 = item.Orcamentos.Sum(p => p.ValorOrcamento);
                var N2 = model.Saida;
                model.OrcamentoUtilizado = ((N1) * (N2) / 100 + N2); //Porcentagem
                foreach (var tarefa in item.Tarefas)
                    model.Tarefas.Add(new TarefaViewModel {
                                            Data = tarefa.DataFinal,
                                            Tarefa = tarefa.Titulo,
                                            TarefaId = tarefa.TarefaId});

                projetoModel.Projetos.Add(model);
            }

            return View(projetoModel);
        }
        
        // GET: Projeto/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Projeto projeto)
        {
            if (projetoBc.Add(projeto))
                return RedirectToAction("Index");
            
            return View(projeto);
        }

        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            projetoBc.Remove(id);
            return RedirectToAction("Index");
        }
    }
}
