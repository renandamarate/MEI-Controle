using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;
using WebApplication.Repository.Dao;

namespace WebApplication.Business.BC
{
    public class ProjetoBc : GenericBc<Projeto>
    {
        ModelStateDictionary modelState;

        public ProjetoBc(ModelStateDictionary ms)
        {
            this.modelState = ms;
        }

        public ProjetoBc() { }

        public bool Add(Projeto item)
        {
            if (Validate(item))
            {
                item.DataCadastro = DateTime.Now;
                item.DataModificacao = DateTime.Now;
                new ProjetoDao().Add(item);
                return true;
            }
            return false;
        }

        public bool Delete(Projeto item)
        {
            new ProjetoDao().Delete(item);
            return true;
        }

        public bool Update(Projeto item)
        {
            if (Validate(item))
            {
                new ProjetoDao().Update(item);
                return true;
            }
            return false;
        }

        public bool Validate(Projeto item)
        {
            if (item.DataInicial == null)
                modelState.AddModelError("DataInicial", "Data Inicial Inválido");
            if (item.DataFinal == null)
                modelState.AddModelError("DataFinal", "Data Final Inválido");

            return modelState.IsValid;
        }


        public List<Projeto> Get()
        {
            return new ProjetoDao().Get().ToList();
        }

        public Projeto Get(int id)
        {
            return new ProjetoDao().Get(id);
        }

        public bool Remove(int id)
        {
            new ProjetoDao().Delete(Get(id)); 
            return true;
        }
    }
}