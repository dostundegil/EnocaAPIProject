using Encoca.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encoca.BusinessLayer.Interfaces
{
    public interface IOrderService: IGenericService<Order>
    {
        public void TAddOrder(Order order);
    }
}
