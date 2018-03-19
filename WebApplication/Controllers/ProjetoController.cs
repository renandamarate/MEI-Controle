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
            return View(projetoBc.Get());
        }

        // GET: Projeto/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var find = id ?? default(int);
            Projeto projeto = projetoBc.Get(find);
            if (projeto == null)
                return HttpNotFound();

            return View(projeto);
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
