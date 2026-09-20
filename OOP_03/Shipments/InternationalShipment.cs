using System;
using System.Collections.Generic;
using System.Text;
#nullable disable
namespace OOP_03.Shipments
{
    public class InternationalShipment : Shipment
    {
        private string _DestinationCountry;
        private decimal _CustomsFee;

        public string DestinationCountry
        {
            get
            {
                return _DestinationCountry;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _DestinationCountry = value;
            }
        }
        public decimal CustomsFee
        {
            get
            {
                return _CustomsFee;
            }
            set
            {
                if (_CustomsFee >= 0)
                    _CustomsFee = value;
            }
        }
        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5) + CustomsFee;
            }
        }
        public InternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            CustomsFee = _CustomsFee;
        }
       
    }
}
