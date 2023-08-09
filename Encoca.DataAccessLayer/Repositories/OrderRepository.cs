using Encoca.DataAccessLayer.Context;
using Encoca.DataAccessLayer.Interfaces;
using Encoca.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encoca.DataAccessLayer.Repositories
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {

        public void AddOrder(Order order)
        {
            using var context = new CarrierDbContext();

            var carrierList = context.Configurations.Where(x => order.OrderDesi >= x.CarrierMinDesi && order.OrderDesi <= x.CarrierMaxDesi).ToList();

            if (carrierList.Count <= 0)
            {
                // Sipariş desisi değerine uyan bir kargo firması yoksa, en yakın kargo firmasını bulma işlemi.
                var closestCarrier = context.Configurations
                    .OrderBy(c => Math.Abs(order.OrderDesi - c.CarrierMaxDesi)).Include(x => x.Carrier)
                    .FirstOrDefault();

                if (closestCarrier != null)
                {
                    var plusDesiCost = closestCarrier.Carrier.CarrierPlusDesiCost;
                    //Gerekli matematiksel işlemin yapılması
                    order.OrderCarrierCost = closestCarrier.CarrierCost + (plusDesiCost * (order.OrderDesi - closestCarrier.CarrierMaxDesi));
                    order.CarrierId = closestCarrier.CarrierId;
                    order.OrderDate = DateTime.Now;
                    Insert(order);
                }
            }

            else
            {
                order.OrderCarrierCost = carrierList[0].CarrierCost;
                order.CarrierId = carrierList[0].CarrierId;
                order.OrderDate = DateTime.Now;

                Insert(order);
            }
        }
    }
}
