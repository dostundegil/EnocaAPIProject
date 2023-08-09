using AutoMapper;
using Encoca.API.Dtos.CarrierConfigurationDtos;
using Encoca.API.Dtos.CarrierDtos;
using Encoca.BusinessLayer.Interfaces;
using Encoca.BusinessLayer.Services;
using Encoca.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Encoca.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarrierConfigurationController : ControllerBase
    {
        private readonly ICarrierConfigurationService _carrierConfigurationService;
        private readonly IMapper _mapper;

        public CarrierConfigurationController(ICarrierConfigurationService carrierConfigurationService, IMapper mapper)
        {
            _carrierConfigurationService = carrierConfigurationService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ListCarrierConfigurations()
        {
            var values = _carrierConfigurationService.TGetList();
            var viewModel = _mapper.Map<List<CarrierConfigurationViewModel>>(values);
            return Ok(viewModel);
        }

        [HttpPost]
        public IActionResult AddCarrierConfiguration(CreateCarrierConfigurationDto dto)
        {
            _carrierConfigurationService.TAdd(_mapper.Map<CarrierConfiguration>(dto));
            return Ok("Kargo Firması Konfigürasyonu Başarıyla Eklendi.");
        }

        [HttpDelete]
        public IActionResult DeleteCarrierConfiguration(int id)
        {
            _carrierConfigurationService.TDelete(id);
            return Ok($"{id} ID'li Kargo Firması Konfigürasyonu Başarıyla Silindi.");
        }

        [HttpPut]
        public IActionResult UpdateCarrierConfiguration(UpdateCarrierConfigurationDto dto)
        {
            _carrierConfigurationService.TUpdate(_mapper.Map<CarrierConfiguration>(dto));
            return Ok("Kargo Firması Konfigürasyonu Başarıyla Güncellendi.");
        }
    }
}
