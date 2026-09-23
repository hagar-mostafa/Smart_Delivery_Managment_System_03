using System;
using System.Collections.Generic;
using System.Text;
#nullable disable

namespace OOP_03
{
    public struct DeliveryAddress
    {
        private string City;
        private string Street;
        private int BuildingNumber;
        public DeliveryAddress(string City, string Street, int BuildingNumber)
        {
            this.City = City;
            this.Street = Street;
            this.BuildingNumber = BuildingNumber;
        }
        public string GetFullAddress()
        {
            return $"The address {City}, {Street}, {BuildingNumber}";
        }
    }
}
