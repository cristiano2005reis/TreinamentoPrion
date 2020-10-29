using Backend.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace API.Controllers
{
    public class BaseController<T> : ApiController where T : class
    {
        internal GenericService<T> service;

        public BaseController()
        {
            service = new GenericService<T>();
        }

        public virtual void Add(T entity)
        {
            service.Add(entity);
        }

        public virtual void Update(T entity)
        {
            service.Update(entity);
        }

        public virtual void Delete(T entity)
        {
            service.Delete(entity);
        }

        public virtual T Find(int id)
        {
            return service.Find(id);
        }

        public virtual List<T> ListAll()
        {
            return service.ListAll();
        }
    }
}