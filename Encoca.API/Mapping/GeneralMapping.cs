using AutoMapper;
using Encoca.API.Dtos.CarrierConfigurationDtos;
using Encoca.API.Dtos.CarrierDtos;
using Encoca.API.Dtos.OrderDtos;
using Encoca.EntityLayer.Entities;

namespace Encoca.API.Mapping
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
            CreateMap<Order,CreateOrderDto>().ReverseMap();
            CreateMap<Order,OrderViewModel>().ReverseMap();

            CreateMap<Carrier, CarrierViewModel>().ReverseMap();
            CreateMap<Carrier, CreateCarrierDto>().ReverseMap();
            CreateMap<Carrier, UpdateCarrierDto>().ReverseMap();

            CreateMap<CarrierConfiguration, CarrierConfigurationViewModel>().ReverseMap();
            CreateMap<CarrierConfiguration, CreateCarrierConfigurationDto>().ReverseMap();
            CreateMap<CarrierConfiguration, UpdateCarrierConfigurationDto>().ReverseMap();
        }
    }
}
