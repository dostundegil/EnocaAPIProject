﻿namespace Encoca.API.Dtos.CarrierConfigurationDtos
{
    public class UpdateCarrierConfigurationDto
    {
        public int CarrierConfigurationId { get; set; }
        public int CarrierId { get; set; }
        public int CarrierMaxDesi { get; set; }
        public int CarrierMinDesi { get; set; }
        public Decimal CarrierCost { get; set; }
    }
}
