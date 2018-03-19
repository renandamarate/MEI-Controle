using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication.Repository.Dao
{
    public abstract class GenericDao<T> where T : class
    {
        public LBContexto Contexto { get; set; }
        public GenericDao()
        {
            Contexto = LBContexto.Create();
        }
        
        public abstract T Get(int id);

        public void Add(T objeto)
        {
            Contexto.Set<T>().Add(objeto);
            try
            {
                Contexto.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        // raise a new exception nesting
                        // the current instance as InnerException
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                throw raise;
            }
            //Contexto.SaveChanges();
        }

        public void Delete(T objeto)
        {
            Contexto.Set<T>().Remove(objeto);
            Contexto.SaveChanges();
        }

        public void Update(T objeto)
        {
            Contexto.Entry(objeto).State = EntityState.Modified;
            Contexto.SaveChanges();
        }

        public List<T> Get()
        {
            return Contexto.Set<T>().ToList();
        }
    }
}