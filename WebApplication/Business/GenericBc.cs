using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Business
{
    public interface GenericBc<T> where T : class
    {
        bool Add(T item);
        bool Delete(T item);
        bool Update(T item);
        bool Validate(T item);
        List<T> Get();
        T Get(int id);
    }
}