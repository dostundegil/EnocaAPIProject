using Encoca.EntityLayer.Entities;

namespace Encoca.API.Dtos.CarrierConfigurationDtos
{
    public class CreateCarrierConfigurationDto
    {
        public int CarrierId { get; set; }
        public int CarrierMaxDesi { get; set; }
        public int CarrierMinDesi { get; set; }
        public Decimal CarrierCost { get; set; }
    }
}
