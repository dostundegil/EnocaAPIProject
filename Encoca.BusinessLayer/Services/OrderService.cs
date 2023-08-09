using Encoca.BusinessLayer.Interfaces;
using Encoca.DataAccessLayer.Interfaces;
using Encoca.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encoca.BusinessLayer.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public void TAdd(Order t)
        {
            _orderRepository.Insert(t);
        }

        public void TAddOrder(Order order)
        {
            _orderRepository.AddOrder(order);
        }

        public void TDelete(int id)
        {
            _orderRepository.Delete(id);
        }

        public Order TGetById(int id)
        {
            return _orderRepository.GetById(id);
        }

        public List<Order> TGetList()
        {
            return _orderRepository.GetList();
        }

        public void TUpdate(Order t)
        {
            _orderRepository.Update(t);
        }
    }
}
