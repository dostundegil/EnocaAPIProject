using AutoMapper;
using Encoca.API.Dtos.CarrierDtos;
using Encoca.BusinessLayer.Interfaces;
using Encoca.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Encoca.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarrierController : ControllerBase
    {
        private readonly ICarrierService _carrierService;
        private readonly IMapper _mapper;

        public CarrierController(ICarrierService carrierService, IMapper mapper)
        {
            _carrierService = carrierService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ListCarriers()
        {
            var values = _carrierService.TGetList();
            var viewModel = _mapper.Map<List<CarrierViewModel>>(values);
            return Ok(viewModel);
        }

        [HttpPost]
        public IActionResult AddCarrier(CreateCarrierDto dto)
        {
            _carrierService.TAdd(_mapper.Map<Carrier>(dto));
            return Ok("Kargo Firması Başarıyla Eklendi.");
        }

        [HttpDelete]
        public IActionResult DeleteCarrier(int id)
        {
            _carrierService.TDelete(id);
            return Ok($"{id} ID'li Kargo Firması Başarıyla Silindi.");
        }

        [HttpPut]
        public IActionResult UpdateCarrier(UpdateCarrierDto dto)
        {
            _carrierService.TUpdate(_mapper.Map<Carrier>(dto));
            return Ok("Kargo Firması Başarıyla Güncellendi.");
        }
    }
}
