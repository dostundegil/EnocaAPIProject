using Encoca.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Encoca.DataAccessLayer.Interfaces
{
    public interface IOrderRepository:IGenericRepository<Order>
    {
        public void AddOrder(Order order);
    }
}
