﻿namespace Encoca.API.Dtos.CarrierDtos
{
    public class UpdateCarrierDto
    {
        public int CarrierId { get; set; }
        public string CarrierName { get; set; }
        public bool CarrierIsActive { get; set; }
        public int CarrierPlusDesiCost { get; set; }
    }
}
