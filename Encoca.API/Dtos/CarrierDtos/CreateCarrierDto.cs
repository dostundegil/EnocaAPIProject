namespace Encoca.API.Dtos.CarrierDtos
{
    public class CreateCarrierDto
    {
        public string CarrierName { get; set; }
        public bool CarrierIsActive { get; set; }
        public int CarrierPlusDesiCost { get; set; }
    }
}
