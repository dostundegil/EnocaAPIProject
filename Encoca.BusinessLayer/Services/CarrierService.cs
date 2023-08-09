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
    public class CarrierService : ICarrierService
    {
        private readonly ICarrierRepository _carrierRepository;

        public CarrierService(ICarrierRepository carrierRepository)
        {
            _carrierRepository = carrierRepository;
        }

        public void TAdd(Carrier t)
        {
            _carrierRepository.Insert(t);
        }

        public void TDelete(int id)
        {
            _carrierRepository.Delete(id);
        }

        public Carrier TGetById(int id)
        {
            return _carrierRepository.GetById(id);
        }

        public List<Carrier> TGetList()
        {
            return _carrierRepository.GetList();
        }

        public void TUpdate(Carrier t)
        {
            _carrierRepository.Update(t);
        }
    }
}
