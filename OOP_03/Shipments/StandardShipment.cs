using System;
using System.Collections.Generic;
using System.Text;
#nullable disable
namespace OOP_03.Shipments
{
    public class StandardShipment : Shipment
    {
        public StandardShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination) : base(trackingCode, description, weight, deliveryFee, destination) { }
        public override void PrintShipment()
        {
            base.PrintShipment();

        }
    }
}
