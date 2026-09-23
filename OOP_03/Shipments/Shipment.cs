using System;
using System.Collections.Generic;
using System.Text;
#nullable disable

namespace OOP_03.Shipments
{
        public class Shipment
        {
            private string _TrackingCode;
            public string TrackingCode
            {
                get
                { return _TrackingCode; }
            }
            private string _Description;
            public string Description
            {
                get { return _Description; }
                set
                {
                    if (!string.IsNullOrWhiteSpace(value))
                        _Description = value;
                }
            }
            private decimal _Weight;
            public decimal Weight
            {
                get { return _Weight; }
                set
                {
                    if (value > 0)
                        _Weight = value;
                }
            }
            private decimal _DeliveryFee;
            public decimal DeliveryFee
            {
                get { return _DeliveryFee; }
                private set
                {
                    if (value > 0)
                        _DeliveryFee = value;
                }

            }
            private DeliveryAddress _Destination;
            public DeliveryAddress Destination
            {
                get
                { return _Destination; }

                set
                { _Destination = value; }

            }
            // computed property
            public virtual decimal EstimatedCost
            {
                get
                {
                    return DeliveryFee + (Weight * 5);
                }
            }


            public Shipment(string trackingCode)
            {
                if (!string.IsNullOrWhiteSpace(trackingCode))
                    _TrackingCode = trackingCode;
                Description = "Unknown";
                Weight = 1;
                DeliveryFee = 50;
                Destination = new DeliveryAddress("Unknown", "Unknown", 0);
            }
            //------constructor overloading-----
            public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
            {
                if (!string.IsNullOrWhiteSpace(trackingCode))
                    _TrackingCode = trackingCode;
                Description = description;
                Weight = weight;
                DeliveryFee = deliveryFee;
                Destination = destination;
            }
            public void UpdateDeliveryFee(decimal newFee)
            {
                if (newFee > 0)
                    DeliveryFee = newFee;
            }
        #region Update Weight 
        // Update weight directly
        public void UpdateWeight(decimal newWeight)
        {
            if (newWeight > 0)
                Weight = newWeight;
        }

        //  Update weight after adding extra packing weight  (overloading)
        public void UpdateWeight(decimal newWeight, decimal packingWeight)
        {
            if (newWeight > 0 && packingWeight > 0)
                Weight = newWeight + packingWeight;
        }
        // overloading hear with the number of parameters 
        #endregion
        public virtual void PrintShipment()
            {
                Console.WriteLine("This Shipment struct include the Following : ");
                Console.WriteLine($"Tracking Code is => {_TrackingCode}");
                Console.WriteLine($"The Description is => {Description}");
                Console.WriteLine($"The Weight is = {Weight}");
                Console.WriteLine($"The DeliveryFee is => {DeliveryFee}");
                Console.WriteLine($"The Destination is => {Destination.GetFullAddress()}");
                Console.WriteLine($"The EstimateCost is => {EstimatedCost}");
            }
            

        }

}
