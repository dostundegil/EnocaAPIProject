using AutoMapper;
using Encoca.API.Dtos.OrderDtos;
using Encoca.BusinessLayer.Interfaces;
using Encoca.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Encoca.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly IMapper _mapper;
        private readonly ICarrierConfigurationService _carrierConfigurationService;

        public OrderController(IOrderService orderService, IMapper mapper, ICarrierConfigurationService carrierConfigurationService)
        {
            _orderService = orderService;
            _mapper = mapper;
            _carrierConfigurationService = carrierConfigurationService;
        }
        [HttpGet]
        public IActionResult ListOrder()
        {
            var value = _orderService.TGetList();
            return Ok(value);
        }

        [HttpPost]
        public IActionResult AddOrder(CreateOrderDto dto)
        {
            _orderService.TAddOrder(_mapper.Map<Order>(dto));
            return Ok("Sipariş Başarıyla Eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteOrder(int id)
        {
            _orderService.TDelete(id);
            return Ok($"{id} ID'li Sipariş Başarıyla Silindi");
        }
    }
}
