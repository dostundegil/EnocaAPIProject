using Encoca.DataAccessLayer.Context;
using Encoca.DataAccessLayer.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encoca.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public void Delete(int id)
        {
            var context = new CarrierDbContext();
            var value = context.Set<T>().Find(id);
            context.Remove(value);
            context.SaveChanges();
        }

        public T GetById(int id)
        {
            var context = new CarrierDbContext();
            return context.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            var context = new CarrierDbContext();
            return context.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            var context = new CarrierDbContext();
            context.Add(t);
            context.SaveChanges();
        }

        public void Update(T t)
        {
            var context = new CarrierDbContext();
            context.Update(t);
            context.SaveChanges();
        }
    }
}
