using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_03.Shipments
{
    public sealed class CompletedShipment  : Shipment
    {
        // we must make Chaining Constructor to prevent the error 
        // and that means we overload on parameterless constructor 
        // i know that every class has implict parameterless constructor
        public CompletedShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination) : base(trackingCode, description, weight, deliveryFee, destination) { }
    }
}
