using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encoca.EntityLayer.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CarrierId { get; set; }
        public Carrier Carrier { get; set; }
        public int OrderDesi { get; set; }
        public DateTime OrderDate{ get; set; }
        public Decimal OrderCarrierCost{ get; set; }
    }
}
