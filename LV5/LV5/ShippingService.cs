using System;
using System.Collections.Generic;
using System.Text;

namespace LV5
{
    class ShippingService
    {
        private double price { get; set; }

        public ShippingService(double price) { }
        
       
        public double CalculatePrice(IShipable pack)
        {
            return pack.Weight * price;
        }

    }
}
