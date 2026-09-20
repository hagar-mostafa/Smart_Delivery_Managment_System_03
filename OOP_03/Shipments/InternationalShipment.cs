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
        public InternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination , string destinationCountry, decimal customsFee) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            DestinationCountry = destinationCountry; 
            CustomsFee = customsFee;                 
        }
        public override void PrintShipment()
        {
            base.PrintShipment();
            Console.WriteLine($"The CustomsFee is => {CustomsFee}");
            Console.WriteLine($"The DestinationCountry is => {DestinationCountry}");
        }
        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine("=== Customs Report ===");
            Console.WriteLine($"Tracking Code      : {TrackingCode}");
            Console.WriteLine($"Description        : {Description}");
            Console.WriteLine($"Weight             : {Weight}");
            Console.WriteLine($"Destination Country: {DestinationCountry}");
            Console.WriteLine($"Customs Fee        : {CustomsFee}");
        }

    }
    public class PriorityInternationalShipment : InternationalShipment
    {
        public PriorityInternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination , string destinationCountry, decimal customsFee)
            : base(trackingCode, description, weight, deliveryFee, destination , destinationCountry , customsFee) { }

        public sealed override void GenerateCustomsReport()
        {
            base.GenerateCustomsReport(); 
            Console.WriteLine("Priority: EXPRESS CUSTOMS CLEARANCE");
        }
    }
}
