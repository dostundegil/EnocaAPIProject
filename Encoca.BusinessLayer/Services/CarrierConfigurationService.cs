using Encoca.BusinessLayer.Interfaces;
using Encoca.DataAccessLayer.Interfaces;
using Encoca.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encoca.BusinessLayer.Services
{
    public class CarrierConfigurationService : ICarrierConfigurationService
    {
        private readonly ICarrierConfigurationRepository _carrierConfigurationRepository;

        public CarrierConfigurationService(ICarrierConfigurationRepository carrierConfigurationRepository)
        {
            _carrierConfigurationRepository = carrierConfigurationRepository;
        }

        public void TAdd(CarrierConfiguration t)
        {
            _carrierConfigurationRepository.Insert(t);
        }

        public void TDelete(int id)
        {
            _carrierConfigurationRepository.Delete(id);
        }

        public CarrierConfiguration TGetById(int id)
        {
            return _carrierConfigurationRepository.GetById(id);
        }

        public List<CarrierConfiguration> TGetList()
        {
            return _carrierConfigurationRepository.GetList();
        }

        public void TUpdate(CarrierConfiguration t)
        {
            _carrierConfigurationRepository.Update(t);
        }
    }
}
