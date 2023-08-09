using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encoca.DataAccessLayer.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        void Insert(T t);

        void Delete(int id);

        void Update(T t);

        List<T> GetList();

        T GetById(int id);
    }
}
