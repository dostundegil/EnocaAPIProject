using Encoca.EntityLayer.Entities;

namespace Encoca.API.Dtos.OrderDtos
{
    public class OrderViewModel
    {
        public int OrderId { get; set; }
        public int CarrierId { get; set; }
        public Carrier Carrier { get; set; }
        public int OrderDesi { get; set; }
        public DateTime OrderDate { get; set; }
        public Decimal OrderCarrierCost { get; set; }
    }
}
