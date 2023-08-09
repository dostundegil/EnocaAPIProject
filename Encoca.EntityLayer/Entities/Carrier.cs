﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encoca.EntityLayer.Entities
{
    public class Carrier
    {
        public int CarrierId { get; set; }
        public string CarrierName { get; set; }
        public bool CarrierIsActive { get; set; }
        public int CarrierPlusDesiCost{ get; set; }
        public List<CarrierConfiguration> CarrierConfigurations { get; set; }
        public List<Order> Orders { get; set; }
    }
}
